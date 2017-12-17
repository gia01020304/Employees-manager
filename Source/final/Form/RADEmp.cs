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
    public partial class RADEmp : Form
    {
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        private List<ChucVuDTO> list = null;
        private object NV;
        private DataTable dtbKTKL; //các KTKL
        public RADEmp(DataTable dtb)
        {
            this.dtbKTKL = dtb;
            InitializeComponent();
        }
        /// <summary>
        /// Set Chức vụ theo PB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            cbbCV.Items.Clear();
            cbbKTKL.Items.Clear();
            if (cbbPB.Text == "Quản lí") id = 123;
            else id = 456;
            cbbID.Items.Clear();
            txtN.Text = "";
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
        /// Set ID theo Chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbID.Items.Clear();
            cbbKTKL.Items.Clear();
            txtN.Text = "";
            int id;
            if (cbbPB.Text == "Quản lí") id = 123;
            else id = 456;
            for (int i = 0; i < list.Count; i++)
                if (cbbCV.SelectedItem.ToString() == list[i].NameCV)
                {
                    ketoan.GetNhanVien(out NV, id, list[i].ID);
                    if (NV != null)
                    {
                        DataTable dtb = (DataTable)NV;
                        if (dtb.Rows.Count > 0)
                        {
                            for (int j = 0; j < dtb.Rows.Count; j++)
                                cbbID.Items.Add(dtb.Rows[j]["Id"].ToString() + dtb.Rows[j]["Kh"].ToString());
                        }
                        else MessageBox.Show("Không có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else MessageBox.Show("Lỗi không lấy được nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        /// <summary>
        /// Set tên theo ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<KTKLDTO> KTKL;
            cbbKTKL.Items.Clear();
            txtN.Text = "";
            DataTable dtb = (DataTable)NV;
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                if (cbbID.Text.Substring(0, cbbID.Text.Length - 3) == dtb.Rows[i]["Id"].ToString())
                {
                    txtN.Text = dtb.Rows[i]["FName"].ToString() + " " + dtb.Rows[i]["LName"].ToString();
                    break;
                }
            }
            ketoan.getIDKTKL(out KTKL, cbbID.Text.Substring(0, cbbID.Text.Length - 3));
            // kiểm tra các KTKL đã có
            if (KTKL != null)
            {
                for (int i = 0; i < dtbKTKL.Rows.Count; i++)
                {
                    int j;
                    for (j = 0; j < KTKL.Count; j++)
                    {
                        if (KTKL[j].ID == Int32.Parse(dtbKTKL.Rows[i]["ID KTKL"].ToString()))
                            break;
                    }
                    if (j == KTKL.Count) cbbKTKL.Items.Add(dtbKTKL.Rows[i]["ID KTKL"]);
                }
            }
            else MessageBox.Show("Lỗi không lấy được ID KTKL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Set Tên KTKL theo ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbKTKL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKLKT.Text = "";
            for (int i = 0; i < dtbKTKL.Rows.Count; i++)
            {
                if (cbbKTKL.SelectedItem.ToString() == dtbKTKL.Rows[i]["ID KTKL"].ToString())
                {
                    txtKLKT.Text = dtbKTKL.Rows[i]["Tên KTKL"].ToString();
                    break;
                }
            }
        }
        /// <summary>
        /// Lưu KTKL cho nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtN.Text != "" && txtKLKT.Text != "")
            {
                PeopleDTO pp = new PeopleDTO();
                KTKLDTO kt = new KTKLDTO();
                kt.ID = Int32.Parse(cbbKTKL.Text);
                pp.ID = Int32.Parse(cbbID.Text.Substring(0, cbbID.Text.Length - 3));
                pp.KH = cbbID.Text.Substring(cbbID.Text.Length - 3);
                int result = ketoan.ThemNVKTKL(kt, pp);
                if (result > 0)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}