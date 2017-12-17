using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using project.BusinessObject;
using System.Threading;
using project.DataObject;
using final.Properties;

namespace final
{
    public partial class PhongBanUS : UserControl
    {
        public PhongBanUS()
        {
            InitializeComponent();
            re = new Regex(@"\d");
        }
        private List<PhongBanDTO> listPhongBan;
        private PhongBanDTO phongBanHienTai;
        private int soTrang;
        private int soRowHienThi = 14;
        private int trangHienTai = 1;
        private int soRow;
        private int firstRow, lastRow;
        private int maPB;
        private int row;
        private int column;
        public Regex re = null;
        private List<ChucVuDTO> CV;



        public int MaPB
        {
            get
            {
                return maPB;
            }

            set
            {
                maPB = value;

            }
        }
        /// <summary>
        /// lấy danh sách các chức vụ của phòng ban hiện tại đổ vào combobox chức vụ
        /// </summary>
        public PhongBanDTO PhongBanHienTai
        {
            get
            {
                return phongBanHienTai;
            }

            set
            {
                phongBanHienTai = value;
                if (phongBanHienTai != null)
                {
                    maPB = phongBanHienTai.MaPhongBan;
                    CV = new List<ChucVuDTO>(phongBanHienTai.CV);
                    ChucVuDTO cvnuew = new ChucVuDTO() { NameCV = "", ID = -1 };
                    CV.Add(cvnuew);
                    cmbcv.DataSource = CV;
                    cmbcv.SelectedIndex = cmbcv.Items.Count - 1;
                    cmbcv.DisplayMember = "namecv";
                    cmbcv.ValueMember = "id";
                    if (maPB != 0)
                    {
                        PhongQuanLyBO qlbo = new PhongQuanLyBO();
                        soRow = qlbo.DemRecord(maPB);
                    }
                }
            }
        }

        public List<PhongBanDTO> ListPhongBan
        {
            get
            {
                return listPhongBan;
            }

            set
            {
                listPhongBan = value;
            }
        }
        /// <summary>
        /// Khi double CLick vào 1 cell có các trường hợp xảy ra
        /// Nếu ở bảng nhân viên thì có thể xem thông tin nhân viên và nhân thân của nhân viên đó và không thể chỉnh sửa
        /// Nếu ở bảng Danh sách nhân viên bị xóa thì có thể lựa chọn khôi phục dữ liệu hoặc không
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            column = e.ColumnIndex;
            row = e.RowIndex;
            if (string.Compare(((DataTable)dtgv.DataSource).TableName, "Remove") == 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc là muốn khôi phục?", "Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Khôi phục
                    PhongQuanLyBO qlbo = new PhongQuanLyBO();
                    qlbo.FillFinish += Bo_FillFainal1;
                    object id = dtgv.Rows[e.RowIndex].Cells["Mã Nhân Viên"].Value;
                    int kq = qlbo.RestoreNhanVien(id);
                    if (kq>0)
                    {
                        MessageBox.Show("Restore thành công", "Restore");
                        qlbo.LoadRemove(dtgv);
                    }
                    else
                    {
                        MessageBox.Show("Restore thất bại", "Restore");
                    }
                }
            }

        }
        private void pt4_Click(object sender, EventArgs e)
        {
            txttrang2.Text = lbltrang.Text.Substring(3);
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            txttrang2.Text = txtTrang.Text;
        }

        private void pt1_Click(object sender, EventArgs e)
        {

            txttrang2.Text = 1.ToString();
        }

        private void pt2_Click(object sender, EventArgs e)
        {
            if (txtTrang.Text != "")
                txttrang2.Text = (int.Parse(txtTrang.Text) - 1).ToString();
        }

        private void pt3_Click(object sender, EventArgs e)
        {
            if (txtTrang.Text != "")
            {
                txttrang2.Text = (int.Parse(txtTrang.Text) + 1).ToString();
            }

        }
        /// <summary>
        /// Even số trang thay đổi tiến hành lấy dữ liệu đổ datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txttrang2_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            ptLoad.Image = Resources.Double_Ring__2_;

            if (soTrang == 0)
            {
                ptLoad.Image = Resources.icons8_empty_set_48;

            }
            if (t == null || t.Text == "")
            {
                
                return;
            }
            Match m = re.Match(t.Text);
            if (!m.Success || int.Parse(t.Text) > soTrang|| int.Parse(t.Text) <= 0)
            {
                t.Focus();
                t.Text = "1";
                return;
            }
            trangHienTai = int.Parse(t.Text);
            firstRow = soRowHienThi * (trangHienTai - 1); //Dong dau
            lastRow = soRowHienThi * (trangHienTai);//Dong cuoi cua 1 trang duoc chon. 
            txtTrang.Text = trangHienTai.ToString();
            dtgvcolor();
            PhongQuanLyBO bo = new PhongQuanLyBO();
            bo.FillFinish += Bo_FillFainal1;
            object tuples = new Tuple<DataGridView, int, int, int>(dtgv, firstRow, soRowHienThi, MaPB);
            LoadNhanVien(bo, tuples);

        }
        /// <summary>
        /// Phân luồng cho việc Load nhân viên
        /// </summary>
        /// <param name="bo"></param>
        /// <param name="tuples"></param>
        public void LoadNhanVien(PhongQuanLyBO bo, object tuples)
        {
            Thread newThread = new Thread(bo.GetNhanVienPT);
            newThread.Start(tuples);
            newThread.Join();
        }
        /// <summary>
        /// Hàm ủy thác cho sự kiện thông báo lấy được dữ liệu hoặc không
        /// </summary>
        /// <param name="kt"></param>
        private void Bo_FillFainal1(bool kt)
        {
            if (kt == true)
            {
                ptLoad.Image = Resources.icons8_ok_48;
            }
            else
            {
                ptLoad.Image = Resources.icons8_empty_set_48;

                dtgv.DataSource = null;
            }

        }
        /// <summary>
        /// Vẽ lên datagridview
        /// </summary>
        private void dtgvcolor()
        {
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            TextBox a = sender as TextBox;
            if ((a.Text != "" && a.Text != "Thông tin"))
            {
                btnFind.Enabled = true;
            }
            else
            {
                btnFind.Enabled = false;
            }
        }
        private void cmbcv_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb.Text != "")
            {
                btnFind.Enabled = true;
            }
            else
            {
                btnFind.Enabled = false;
            }
        }
        private void btFind_Click(object sender, EventArgs e)
        {

            if (txtFind.Text != "Thông tin" || cmbcv.Text != "")
            {
                dtgv.DataSource = null;
                pntrang.Visible = false;
                ptLoad.Image = Resources.Double_Ring__2_;
                PhongQuanLyBO bo = new PhongQuanLyBO();
                int mcv = int.Parse(cmbcv.SelectedValue.ToString());
                bo.FillFinish += Bo_FillFainal1;
                dtgvcolor();
                string par = string.Format("{0}%", txtFind.Text);
                object boxing = new Tuple<DataGridView, int, int, string>(dtgv, MaPB, mcv, par);
                bo.FillFinish += Bo_FillFainal1;
                LoadTimKiem(bo, boxing);
            }

        }
        public void LoadTimKiem(PhongQuanLyBO bo, object tuples)
        {
            Thread newThrea = new Thread(bo.TimKiem);
            newThrea.Start(tuples);
            newThrea.Join();
        }
        /// <summary>
        /// Khi xóa nhân viên các trường hợp có thể xảy ra:
        /// Nếu là trưởng phòng thì chỉ có thể chỉnh sữa lại các thuộc tình
        /// Nếu . phải trưởng phòng thì xóa trực tiếp trong DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDel_Click(object sender, EventArgs e)
        {
            if (dtgv.DataSource == null || row == -1|| dtgv.Rows[row].Cells["Mã Nhân Viên"].Value==null)
            {
                return;
            }
            PeoPleBO nvbo = new PeoPleBO();
            int idtp = nvbo.test(MaPB);
            int id = int.Parse(dtgv.Rows[row].Cells["Mã Nhân Viên"].Value.ToString());
            DialogResult result;
            if (id == idtp)
            {
                result = MessageBox.Show("Không thể xóa trưởng phong\n Bạn có muốn thay đổi trưởng phòng", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PeopleDTO nv;
                    PhongQuanLyBO bo = new PhongQuanLyBO();
                    bo.GetNhanVienDTO(out nv, id);
                    bo.XoaThanNhan(id);
                    if (nv.ID != 0)
                    {
                        nv.FName = "";
                        nv.LName = "";
                        nv.DOB = new DateTime();
                        nv.HD = new DateTime();
                        nv.GioiTinh = "";
                        nv.QueQuan = "";
                        Form4 f4 = new Form4(true);
                        f4.TranslationPeople(nv, listPhongBan, "Edit", false);
                        f4.ShowDialog();
                        txttrang2.Text = null;
                        txttrang2.Text = txtTrang.Text;
                    }

                }
                return;
            }
            result = MessageBox.Show("Bạn có thực sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PhongQuanLyBO qlbo = new PhongQuanLyBO();
                //Lưu vào DB temp
                qlbo.SaveTemp(id);
                //Tiến hành xóa

                int kq = qlbo.XoaThanNhan(id);
                kq = qlbo.XoaNVKTKL(id);
                kq = qlbo.XoaNhanVien(id);

                if (kq != -1)
                {
                    MessageBox.Show("Xóa thành công", "Xóa");
                    row--;
                    txttrang2.Text = null;
                    txttrang2.Text = txtTrang.Text;
                }
                else
                    MessageBox.Show("Thất bại", "Xóa");
            }
        }
        private void btEd_Click(object sender, EventArgs e)
        {
            if (dtgv.DataSource == null || row == -1)
            {
                return;
            }
            object id = dtgv.Rows[row].Cells["Mã Nhân Viên"].Value;
            PeopleDTO nv;
            PhongQuanLyBO bo = new PhongQuanLyBO();
            bo.GetNhanVienDTO(out nv, id);
            if (nv.ID != 0)
            {
                Form4 f4 = new Form4(true);
                f4.TranslationPeople(nv, listPhongBan, "Edit", false);
                f4.ShowDialog();
                txttrang2.Text = null;
                txttrang2.Text = txtTrang.Text;
            }
        }
        /// <summary>
        /// Dựa vào số lượng nhân viên tính được có bao nhiêu trang dựa vào số dòng muốn hiển thì
        /// </summary>
        public void PhanTrang()
        {
            txttrang2.Text = null;
            dtgv.DataSource = null;
            if (soRow % soRowHienThi != 0)
            {
                soTrang = soRow / soRowHienThi + 1;
            }
            else
                soTrang = soRow / soRowHienThi;
            lbltrang.Text = " / " + soTrang.ToString();
            txttrang2.Text = 1.ToString();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {

            PeopleDTO people = new PeopleDTO();
            Form4 f4 = new Form4(true);
            
            f4.TranslationPeople(people, listPhongBan, "Add", true);
            f4.ShowDialog();
            txttrang2.Text = null;
            txttrang2.Text = txtTrang.Text;
            if (txtTrang.Text=="")
            {
                soTrang = 1;
                txttrang2.Text = 1.ToString();
            }



        }
        private void tbFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.Text == "Thông tin" && txtFind.ForeColor != Color.Black)
            {
                txtFind.Text = "";
                txtFind.ForeColor = Color.Black;
            }
        }

        private void pt3_MouseHover(object sender, EventArgs e)
        {
            pt3.Image = Resources.R50;
        }

        private void pt3_MouseLeave(object sender, EventArgs e)
        {
            pt3.Image = Resources.R40;
        }

        private void pt1_MouseHover(object sender, EventArgs e)
        {
            pt1.Image = Resources.First50;
        }

        private void pt1_MouseLeave(object sender, EventArgs e)
        {
            pt1.Image = Resources.First40;
        }

        private void pt2_MouseHover(object sender, EventArgs e)
        {
            pt2.Image = Resources.L50;
        }

        private void pt2_MouseLeave(object sender, EventArgs e)
        {
            pt2.Image = Resources.L40;
        }

        private void pt4_MouseLeave(object sender, EventArgs e)
        {
            pt4.Image = Resources.End40;
        }


        private void pt4_MouseHover(object sender, EventArgs e)
        {
            pt4.Image = Resources.End50;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ptRac.Image = Resources.icons8_waste_35;
        }

        private void ptRac_MouseHover(object sender, EventArgs e)
        {
            ptRac.Image = Resources.icons8_waste_filled_35;
        }

        private void ptRac_Click(object sender, EventArgs e)
        {
            dtgv.DataSource = null;
            pntrang.Visible = false;
            pnChucNang.Visible = false;
            pnTimKiem.Visible = false;
            PhongQuanLyBO qlbo = new PhongQuanLyBO();
            qlbo.FillFinish += Bo_FillFainal1;
            qlbo.LoadRemove(dtgv);
        }

        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            if (dtgv.DataSource == null || row == -1)
            {
                return;
            }
            if (string.Compare(dtgv.Name, "Remove") == 0)
            {
                return;
            }
            object id = dtgv.Rows[row].Cells["Mã Nhân Viên"].Value;
            PeopleDTO nv;
            PhongQuanLyBO bo = new PhongQuanLyBO();
            bo.GetNhanVienDTO(out nv, id);
            if (nv.ID != 0)
            {
                Form4 f4 = new Form4(false);
                f4.TranslationPeople(nv, listPhongBan, "Edit", false);
                f4.ShowDialog();
            }

        }

        private void tbFind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFind.Text))
            {
                txtFind.Text = "Thông tin";
                txtFind.ForeColor = Color.Silver;
            }
        }
    }
}
