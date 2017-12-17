using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BusinessObject;
using project.DataObject;
using final.DataObject;

namespace final
{
    public partial class TableSalary : UserControl
    {
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        private DataTable tbNV = null;
        private LuongDTO luongNV;
        public TableSalary()
        {
            InitializeComponent();
        }

        private void TableSalary_Load(object sender, EventArgs e)
        {
            createtablesalary1();
            createtablesalary();
        }
        /// <summary>
        /// Tạo bảng lương theo chức vụ
        /// </summary>
        private void createtablesalary()
        {
            object ob = null;
            ketoan.GetTablesaCV(out ob);
            if (ob != null)
            {
                dtgSalary.DataSource = (DataTable)ob;
                if (dtgSalary.Rows.Count - 1 > 0)
                {
                    dtgSalary.Columns[0].Visible = false;
                    Mypaint.dtgcolor(dtgSalary);
                }
                else MessageBox.Show("Bảng lương trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lỗi không lấy được bảng lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// bảng lương theo mức lương
        /// </summary>
        private void createtablesalary1()
        {
            object ob = null;
            ketoan.GetSalary(out ob);
            if (ob != null)
            {
                dtgS.DataSource = (DataTable)ob;
                if (dtgS.Rows.Count - 1 > 0)
                {
                    Mypaint.dtgcolor(dtgS);
                }
                else MessageBox.Show("Bảng lương trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lỗi không lấy được bảng lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Event: lấy chức vụ theo phòng ban được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;
            if (cbbPB.SelectedItem.ToString() == "Quản lí")
                id = "123";
            else id = "456";
            cbbCV.Items.Clear();
            cbbIDP.Items.Clear();
            txtFN.Text = "";
            for (int i = 0; i < dtgSalary.Rows.Count - 1; i++)
            {
                if (dtgSalary.Rows[i].Cells["Id_PB"].Value.ToString() == id)
                    cbbCV.Items.Add(dtgSalary.Rows[i].Cells["Chức vụ"].Value);
            }
        }

        /// <summary>
        /// Event: Lấy nhân viên theo chức vụ được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            object ob = new object();
            cbbIDP.Items.Clear();
            txtFN.Text = "";
            luongNV = new LuongDTO();
            for (int i = 0; i < dtgSalary.Rows.Count - 1; i++)
            {
                if (dtgSalary.Rows[i].Cells["Chức vụ"].Value.ToString() == cbbCV.Text)
                {
                    ketoan.GetNhanVien(out ob, dtgSalary.Rows[i].Cells["Id_PB"].Value
                        , dtgSalary.Rows[i].Cells["ID Chức vụ"].Value);
                    luongNV.ID = Int32.Parse(dtgSalary.Rows[i].Cells["Mức lương"].Value.ToString());
                    luongNV.Money = Int32.Parse(dtgSalary.Rows[i].Cells["Số tiền"].Value.ToString());
                    break;
                }

            }
            if (ob != null)
            {
                tbNV = (DataTable)ob;
                if (tbNV.Rows.Count > 0)
                {
                    for (int i = 0; i < tbNV.Rows.Count; i++)
                        cbbIDP.Items.Add(tbNV.Rows[i]["Id"].ToString() + tbNV.Rows[i]["Kh"].ToString());
                }
                else MessageBox.Show("Không có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi không lấy được nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Set tên theo ID chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbIDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tbNV.Rows.Count; i++)
            {
                if (tbNV.Rows[i]["Id"].ToString() == cbbIDP.Text.Substring(0, cbbIDP.Text.Length - 3))
                {
                    txtFN.Text = tbNV.Rows[i]["FName"].ToString() + " " + tbNV.Rows[i]["LName"].ToString();
                    break;
                }

            }
        }
        /// <summary>
        /// Xuất bảng lương nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click_1(object sender, EventArgs e)
        {
            if (txtFN.Text != "")
            {
                PeopleDTO nv = new PeopleDTO();
                Salary sl = null;
                for (int i = 0; i < tbNV.Rows.Count; i++)
                {
                    if (tbNV.Rows[i]["Id"].ToString() == cbbIDP.Text.Substring(0, cbbIDP.Text.Length - 3))
                    {
                        nv.ID = Int32.Parse(tbNV.Rows[i]["Id"].ToString());
                        nv.KH = tbNV.Rows[i]["Kh"].ToString();
                        nv.FName = tbNV.Rows[i]["FName"].ToString();
                        nv.LName = tbNV.Rows[i]["LName"].ToString();
                        nv.MaCV = Int32.Parse(tbNV.Rows[i]["Id"].ToString());
                        sl = new Salary(nv);
                        sl.CV = cbbCV.Text;
                        sl.Luong = luongNV;
                        break;
                    }
                }
                sl.ShowDialog();
            }
            else MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Sửa bảng lương
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btedit_Click(object sender, EventArgs e)
        {
            if (tabc.SelectedTab == tabc.TabPages[0])
            {
                EditSalary ed = new EditSalary();
                ed.ShowDialog();
                createtablesalary1();
            }
            else
            {
                DataTable dtb = (DataTable)dtgS.DataSource;
                LuongCV l = new LuongCV(dtb);
                l.ShowDialog();
                createtablesalary();
            }
        }
    }
}
