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
using final.DataObject;

namespace final
{
    public partial class RAD : UserControl
    {
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        private RADEmp radNV;
        private AddRAD rad;
        public RAD()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Tạo bảng KTKL
        /// </summary>

        private void createtableKTKL()
        {
            object ob;
            ketoan.GetKTKL(out ob);
            if (ob != null)
            {
                dtgKTKL.DataSource = (DataTable)ob;
                if (dtgKTKL.Rows.Count - 1 > 0)
                    dtgKTKL.Columns["Tên KTKL"].Width = 200;
                else MessageBox.Show("Bảng KTKL trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi không lấy được bảng KTKL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Tạo bảng KTKL tất cả nhân viên
        /// </summary>
        private void createNVKTKL()
        {
            object ob;
            ketoan = new PhongKeToanBO();
            ketoan.GetKTKLNV1(out ob);
            if (ob != null)
            {
                dtgNVKTKL.DataSource = (DataTable)ob;
                if (dtgNVKTKL.Rows.Count - 1 > 0)
                {
                    for (int i = 0; i < dtgNVKTKL.Rows.Count - 1; i++)
                        dtgNVKTKL.Rows[i].Cells[1].Value = dtgNVKTKL.Rows[i].Cells[0].Value.ToString() + dtgNVKTKL.Rows[i].Cells[1].Value.ToString();
                    dtgNVKTKL.Columns[0].Visible = false;
                    dtgNVKTKL.Columns["Tên KTKL"].Width = 200;
                }
                else MessageBox.Show("Bảng KTKL-NV trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi không lấy được bảng KTKL-NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RAD_Load(object sender, EventArgs e)
        {
            Mypaint.dtgcolor(dtgKTKL);
            Mypaint.dtgcolor(dtgNVKTKL);
            createtableKTKL();
        }
        /// <summary>
        /// Tab==0:thêm KTKL
        /// Tab==1:thêm KTKL cho NV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btadd_Click(object sender, EventArgs e)
        {
            if (tabc.SelectedTab == tabc.TabPages[0])
            {
                rad = new AddRAD();
                rad.ShowDialog();
                createtableKTKL();
            }
            else
            {
                DataTable dtb = (DataTable)dtgKTKL.DataSource;
                radNV = new RADEmp(dtb);
                radNV.ShowDialog();
                createNVKTKL();
            }
        }
        /// <summary>
        /// Tạo bảng khi thay đổi tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabc.SelectedTab == tabc.TabPages[0])
            {
                btedit.Visible = true;
            }
            else
            {
                createNVKTKL();
                btedit.Visible = false;
            }
        }
        /// <summary>
        /// tab==0 xóa KTKL
        /// tab==1 xóa KTKL của nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btdel_Click(object sender, EventArgs e)
        {
            if (tabc.SelectedTab == tabc.TabPages[0])
            {
                DataGridViewRow row = dtgKTKL.CurrentRow;
                if (row != null)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = ketoan.XoaKTKL(row.Cells["ID KTKL"].Value.ToString());
                        if (result >= 0)
                        {
                            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            createtableKTKL();       
                        }
                        else MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else return;
            }
            else
            {
                DataGridViewRow row = dtgNVKTKL.CurrentRow;
                if (row != null)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int result = ketoan.XoaKTKLNV(row.Cells["Id"].Value.ToString(), row.Cells["ID KTKL"].Value.ToString());
                        if (result >= 0)
                        {
                            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            createNVKTKL();
                        }
                        else MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else return;
            }
        }
        /// <summary>
        /// Sửa KTKL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btedit_Click(object sender, EventArgs e)
        {
            KTKLDTO KT = new KTKLDTO();
            DataGridViewRow row = dtgKTKL.CurrentRow;
            if (row != null)
            {
                KT.ID = Int32.Parse(row.Cells["ID KTKL"].Value.ToString());
                KT.Money = Int32.Parse(row.Cells["Số tiền"].Value.ToString());
                KT.Name = row.Cells["Tên KTKL"].Value.ToString();
                KT.HT = row.Cells["Hình thức"].Value.ToString();
                rad = new AddRAD();
                rad.KTKL = KT;
                rad.ShowDialog();
                createtableKTKL();
            }
        }
    }
}
