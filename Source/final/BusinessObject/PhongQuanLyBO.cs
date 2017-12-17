using final;
using final.Properties;
using project.DataObject;
using project.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.BusinessObject
{

    public class PhongQuanLyBO
    {

        public delegate void Fill(bool kt);
        public event Fill FillFinish;
        /// <summary>
        /// Lấy dữ liệu từ DB Đổ vào Dataset và Tiến hành phân luồn cho việc đổ dữ liệu vào datagridview
        /// </summary>
        /// <param name="Tuples">các tham số truyền vào được nén vào object</param>
        public void GetNhanVienPT(object Tuples)
        {
            Tuple<DataGridView, int, int, int> temp = Tuples as Tuple<DataGridView, int, int, int>;
            Providers provi = new Providers();
            DataSet data = provi.GetNhanVienPT(temp.Item2, temp.Item3, "NhanVien", temp.Item4);
            if (data==null)
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return;
            }
            object boxing = new Tuple<DataGridView, DataSet>(temp.Item1, data);
            Thread newThrea = new Thread(FillDataToGridView);
            newThrea.Start(boxing);
        }
        /// <summary>
        /// Luồn đổ  dữ liệu vào datagridview
        /// </summary>
        /// <param name="Tuples">các tham số được boxing vào object</param>

        public void FillDataToGridView(object Tuples)
        {
            bool kt = false;
            Tuple<DataGridView, DataSet> temp = Tuples as Tuple<DataGridView, DataSet>;
            if ((temp.Item1.Parent).InvokeRequired)
            {
                temp.Item1.Parent.Invoke(new MethodInvoker(() => { FillDataToGridView(Tuples); }));
            }
            else
            {
                if ((temp.Item2) == null)
                {
                    return;
                }
                if ((temp.Item2).Tables[0].Rows.Count > 0)
                {

                    temp.Item2.Tables[0].TableName = "NhanVien";
                    temp.Item1.DataSource = temp.Item2.Tables[0];
                    kt = true;

                }
                if (FillFinish != null)
                {
                    FillFinish(kt);
                }
            }

        }
        /// <summary>
        /// Thêm nhân viên 
        /// </summary>
        /// <param name="pp">đối tượng Nhân viên DTO</param>
        /// <returns></returns>
        public int ThemNhanVien(PeopleDTO pp)
        {
            Providers provi = new Providers();
            int kq= provi.ThemNhanVien(pp.KH, pp.FName, pp.LName, pp.GioiTinh, pp.DOB, pp.HD, pp.QueQuan, pp.MaPB, pp.IDNQL, pp.KHNQL, pp.MaCV);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Tìm kiếm thông tin
        /// </summary>
        /// <param name="Tuples">Dữ liệu tiềm kiếm được boxing</param>
        public void TimKiem(object Tuples)
        {
            Tuple<DataGridView, int, int, string> temp = Tuples as Tuple<DataGridView, int, int, string>;
            Providers provi = new Providers();
            int model = (temp.Item3 == -1) ? 1 : (temp.Item4 == "Thông tin%" ? 2 : 3);
            DataSet data = provi.TimKiem(model, temp.Item2, temp.Item3, temp.Item4);
            if (data == null)
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return;
            }
            object boxing = new Tuple<DataGridView, DataSet>(temp.Item1, data);
            Thread newThrea = new Thread(FillDataToGridView);
            newThrea.Start(boxing);
        }
        /// <summary>
        /// Khôi phục nhân viên đã xóa
        /// </summary>
        /// <param name="id">mã nhân viên</param>
        /// <returns></returns>
        public int RestoreNhanVien(object id)
        {
            Providers provi = new Providers();
            int kq= provi.RestoreNhanVien(id, id);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Lấy 1 đối nhân viên dto để xử lý
        /// </summary>
        /// <param name="Nv">instan dùng để lưu nhân viên lấy đc</param>
        /// <param name="Id">mã nhân viên</param>
        public void GetNhanVienDTO(out PeopleDTO Nv, object Id)
        {
            Nv = new PeopleDTO();
            Providers provi = new Providers();
            SqlDataReader reader = provi.GetNhanVienDTO(Id);
            if (reader==null)
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return;
            }
            if (reader.Read())
            {
                Nv.ID = int.Parse(reader["Id"].ToString());
                Nv.FName = reader["Fname"].ToString();
                Nv.LName = reader["LName"].ToString();
                Nv.GioiTinh = reader["GioiTinh"].ToString();
                Nv.KH = reader["Kh"].ToString();
                Nv.DOB = DateTime.Parse(reader["DOB"].ToString());
                Nv.HD = DateTime.Parse(reader["HireDay"].ToString());
                Nv.QueQuan = reader["QueQuan"].ToString();
                Nv.MaPB = int.Parse(reader["Id_PB"].ToString());
                Nv.MaCV = int.Parse(reader["Id_CV"].ToString());
                if (reader["Id_NQL"] != DBNull.Value)
                {
                    Nv.IDNQL = int.Parse(reader["Id_NQL"].ToString());
                }
                if (reader["Kh_NQL"] != DBNull.Value)
                {
                    Nv.KHNQL = reader["Kh_NQL"].ToString();
                }

            }
            reader.Close();
        }
        /// <summary>
        /// Lưu Thân nhân xuống DB
        /// </summary>
        /// <param name="dtb">table chứa các dòng dữ liệu của thân nhân</param>
        /// <param name="iD">Id của nhân viên</param>
        /// <param name="kH">Kh của nhân viên</param>
        /// <returns></returns>
        public int ThemThanNhan(DataTable dtb, int iD, string kH)
        {
            Providers provi = new Providers();
            int kq = 1;
            for (int i = 0; dtb.Rows.Count > i; i++)
            {
                kq = provi.ThemThanNhan(iD, kH, dtb.Rows[i][0], dtb.Rows[i][1], dtb.Rows[i][2]);
                if (kq<=0)
                {
                    MessageBox.Show("Xữ lý lổi", "Error");
                    return -1;
                }
            }

            return kq;
        }
        /// <summary>
        /// update dữ liệu được lưu trong dataset xuông DB
        /// </summary>
        /// <param name="ds">DAtaset chứa dữ liệu</param>
        /// <param name="id">Id nhân viên</param>
        /// <returns></returns>

        public int UpdateDataSet(DataSet ds, int id)
        {
            Providers provi = new Providers();
            int kq= provi.UpdateDataSet(ds, ds.Tables[0].TableName, id);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xữ lý lổi", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Lấy danh sách thân nhân của nhân viên 
        /// Nếu 0 có lấy bản trống
        /// </summary>
        /// <param name="dtgv">DatagridView chứa dữ liệu</param>
        /// <param name="Par">các tham số truyền vào</param>
        public void GetThanNhan(DataGridView dtgv, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetThanNhan(Par);
            if (data==null)
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return;
            }
            data.Tables[0].TableName = "ThanNhan";
            dtgv.DataSource = data.Tables[0];
        }
        /// <summary>
        /// Xóa nhân viên dựa vào mã nhân viên
        /// </summary>
        /// <param name="id">Mã nhân viên</param>
        /// <returns></returns>
        public int XoaNhanVien(object id)
        {
            Providers provi = new Providers();
            int kq= provi.XoaNhanVien(id);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Update dữ liệu của đối tượng sau khi được chỉnh sửa
        /// </summary>
        /// <param name="pp">đối tượng đã được chỉnh sữa</param>
        /// <returns></returns>
        public int EditNhanVien(PeopleDTO pp)
        {
            Providers provi = new Providers();
            int kq= provi.EditNhanVien(pp.KH, pp.FName, pp.LName, pp.GioiTinh, pp.DOB, pp.HD, pp.QueQuan, pp.MaPB, pp.IDNQL, pp.KHNQL, pp.MaCV, pp.ID);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Xóa thân nhân để tiến hành xóa nhân viên
        /// </summary>
        /// <param name="id">id nhân viên</param>
        /// <returns></returns>
        public int XoaThanNhan(object id)
        {
            Providers provi = new Providers();
            int kq= provi.XoaThanNhan(id);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Đếm số lượng nhân viên trong phòng ban
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public int DemRecord(params object[] Par)
        {
            Providers provi = new Providers();
            int kq= provi.DemRecord(Par);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Lấy dữ liệu danh sách nhân viên đã xóa trong vòng 31 ngày tính từ ngày hiện tại
        /// </summary>
        /// <param name="Dtgv">DatagridView chứa dữ liệu</param>
        public void LoadRemove(DataGridView Dtgv)
        {
            Dtgv.DataSource = null;
            Dtgv.Columns.Clear();
            Providers provi = new Providers();
            DataSet data = provi.LoadRemove();
            if (data==null)
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return;
            }
            if (data.Tables[0].Rows.Count > 0)
            {
                data.Tables[0].TableName = "Remove";
                Dtgv.DataSource = data.Tables[0];
                DataGridViewImageColumn colum = new DataGridViewImageColumn();
                colum.Image = Resources.icons8_restore_30;
                colum.Name = "KhoiPhuc";
                colum.HeaderText = "Trạng Thái";
                Dtgv.Columns.Add(colum);
                Dtgv.AllowUserToAddRows = false;
                if (FillFinish != null)
                {
                    FillFinish(true);
                }
            }
            else
            {
                FillFinish(false);
            }
        }
        /// <summary>
        /// xóa bảng nv ktkl
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int XoaNVKTKL(int id)
        {
            Providers provi = new Providers();
            int kq = provi.XoaKTKLNV2(id);
            if (kq >= 0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return -1;
            }
        }

        /// <summary>
        /// Khi xóa nhân viên lưu nhân viên vào bảng tạm
        /// </summary>
        /// <param name="Id">mã nhân viên</param>
        public void SaveTemp(int Id)
        {
            Providers provi = new Providers();
            int kq=provi.SaveTemp(Id);
            if (kq<=0)
            {
                MessageBox.Show("Xử lý lổi", "Error");
                return;
            }
        }
    }
}
