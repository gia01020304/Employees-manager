using final.DataObject;
using project.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class EditSalary : Form
    {
        private DataTable tbLuong = null;
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        public EditSalary()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lấy mức lương add vào cbbMlg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditSalary_Load(object sender, EventArgs e)
        {
            object ob;
            ketoan.GetSalary(out ob);
            if (ob != null)
            {
                tbLuong = (DataTable)ob;
                if (tbLuong.Rows.Count > 0)
                {
                    for (int i = 0; i < tbLuong.Rows.Count; i++)
                        cbbMlg.Items.Add(tbLuong.Rows[i]["Id"].ToString());
                }
                else MessageBox.Show("Mức lương trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi không lấy được mức lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbbMlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tbLuong.Rows.Count; i++)
                if (cbbMlg.SelectedItem.ToString() == tbLuong.Rows[i]["Id"].ToString())
                {
                    txtM.Text = tbLuong.Rows[i]["Money"].ToString();
                    txtM.ReadOnly = false;
                    break;
                }
        }
        /// <summary>
        ///  kiểm tra số tiền nhập có phù hợp với mức lương không
        /// </summary>
        /// <param name="l"></param> mức lương
        /// <param name="m"></param> số tiền
        /// <returns></returns>

        private int check(int l, int m)
        {
            for (int i = 0; i < tbLuong.Rows.Count; i++)
            {
                if (tbLuong.Rows[i]["Id"].ToString() == l + "")
                {
                    if (i - 1 >= 0)
                        if (Int32.Parse(tbLuong.Rows[i - 1]["Money"].ToString()) < m) return -1;
                    if (i + 1 < tbLuong.Rows.Count)
                        if (Int32.Parse(tbLuong.Rows[i + 1]["Money"].ToString()) > m) return 1;
                    break;
                }
            }
            return 0;
        }

        /// <summary>
        /// Sửa mức lương được nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            int res;
            LuongDTO l = new LuongDTO();
            if (Int32.TryParse(txtM.Text, out res) == true)
            {
                l.ID = Int32.Parse(cbbMlg.Text);
                l.Money = Int32.Parse(txtM.Text);
                int kt = check(l.ID, l.Money);
                if (kt == 0)
                {
                    int result = ketoan.EditSalary(l);
                    if (result >= 0)
                    {
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (kt == -1)
                {
                    MessageBox.Show("Mức lương " + l.ID + " phải nhỏ hơn mức " + (l.ID - 1), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Mức lương " + l.ID + " phải lớn hơn mức " + (l.ID + 1), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Số tiền không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
