using final;
using project.DataObject;
using project.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.BusinessObject
{
    class PhongQuanLyBO
    {
        public void GetNhanVien(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetNhanVien(Par);
            if (data.Tables[0].Rows.Count > 0)
            {
                data.Tables[0].TableName = "PhongBan";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }
        public int ThemNhanVien(PeopleDTO pp)
        {
            Providers provi = new Providers();
            return provi.ThemNhanVien(pp.KH, pp.FName, pp.LName, pp.GioiTinh, pp.DOB, pp.HD, pp.QueQuan, pp.MaPB, pp.IDNQL, pp.KHNQL, pp.MaCV);
        }

        public int TimKiem(DataGridView Dtgv, string Ctk)
        {
            Providers provi = new Providers();
            Ctk = string.Format("%{0}%", Ctk);
            DataSet data = provi.TimKiem(Ctk);
            if (data.Tables[0].Rows.Count > 0)
            {
                data.Tables[0].TableName = "TimKiem";
                Dtgv.DataSource = data.Tables[0];
                return 1;
            }
            return 0;
        }

        public void GetNhanVienDTO(out PeopleDTO Nv, object Id)
        {
            Nv = new PeopleDTO();
            Providers provi = new Providers();
            SqlDataReader reader = provi.GetNhanVienDTO(Id);
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

        public int ThemThanNhan(DataTable dtb, int iD, string kH)
        {
            Providers provi = new Providers();
            return provi.ThemThanNhan(iD, kH, dtb.Rows[0][0], dtb.Rows[0][1], dtb.Rows[0][2]);
        }

        public int UpdateDataSet(DataSet ds, int id)
        {
            Providers provi = new Providers();
            return provi.UpdateDataSet(ds,ds.Tables[0].TableName,id );
        }

        public void GetThanNhan(DataGridView dtgv, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetThanNhan(Par);
            data.Tables[0].TableName = "ThanNhan";
            dtgv.DataSource = data.Tables[0];
        }

        public int XoaNhanVien(object id)
        {
            Providers provi = new Providers();
            return provi.XoaNhanVien(id);
        }

        public int EditNhanVien(PeopleDTO pp)
        {
            Providers provi = new Providers();
            return provi.EditNhanVien(pp.KH, pp.FName, pp.LName, pp.GioiTinh, pp.DOB, pp.HD, pp.QueQuan, pp.MaPB, pp.IDNQL, pp.KHNQL, pp.MaCV, pp.ID);
        }
    }
}
