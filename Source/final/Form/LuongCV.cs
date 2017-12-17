using final.DataObject;
using project.BusinessObject;
using project.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class LuongCV : Form
    {
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        private List<ChucVuDTO> list;
        private DataTable dtb;

        public LuongCV(DataTable dtb)
        {
            this.dtb = dtb;
            InitializeComponent();
        }

        /// <summary>
        /// chọn phòng ban để lấy chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCV.Items.Clear();
            txtM.Text = "";
            cbbML.Items.Clear();
            int id;
            if (cbbPB.Text == "Quản lí") id = 123;
            else id = 456;
            ketoan = new PhongKeToanBO();
            ketoan.GetChucvuDTO(out list, id);
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                    cbbCV.Items.Add(list[i].NameCV);
            }
            else MessageBox.Show("Lỗi không lấy được chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Set lương phù hợp với từng chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbML.Items.Clear();
            txtM.Text = "";
            if(cbbCV.SelectedIndex==0)
            {
                cbbML.Items.Add(dtb.Rows[0][0]);
                cbbML.Items.Add(dtb.Rows[1][0]);
            }
            else if(cbbCV.SelectedIndex == 1)
            {
                cbbML.Items.Add(dtb.Rows[2][0]);
                cbbML.Items.Add(dtb.Rows[3][0]);
            }
            else
            {
                cbbML.Items.Add(dtb.Rows[4][0]);
                cbbML.Items.Add(dtb.Rows[5][0]);
            }
        }

        private void cbbML_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtM.Text = "";
            txtM.Text = dtb.Rows[Int32.Parse(cbbML.Text)-1][1].ToString();
        }
        /// <summary>
        /// Thay đổi mức lương của chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            int res;
            if (Int32.TryParse(txtM.Text, out res) == true)
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.NameCV = cbbCV.Text;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].NameCV == cv.NameCV)
                    {
                        cv.ID = list[i].ID;
                        break;
                    }
                }
                int result=ketoan.EditCVL(Int32.Parse(cbbML.Text), cv.ID);
                if (result >= 0)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Số tiền không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
