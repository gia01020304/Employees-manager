using final.DataObject;
using project.DataObject;
using project.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BusinessObject
{
    public class PhongKeToanBO
    {
        /// <summary>
        /// Tính tổng lương của 1 phòng ban
        /// </summary>
        /// <param name="MaPb"></param>
        /// <returns></returns>
        public decimal TongLuong(int MaPb)
        {
            Providers provi = new Providers();
            object temp = provi.TongLuong(MaPb);
            if (temp != DBNull.Value)
            {
                return Convert.ToDecimal(temp);
            }
            return 0;
        }
        /// <summary>
        /// Bảng lương theo chức vụ
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="Par"></param>
        public void GetTablesaCV(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetTablesaCV();
            if (data.Tables.Count > 0)
            {
                data.Tables[0].TableName = "MucLuong";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }
        /// <summary>
        /// Nhân viên theo chức vụ và phòng ban
        /// </summary>
        /// <param name="DataSource"></param> 
        /// <param name="Par"></param>
        public void GetNhanVien(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetNhanVien2(Par);
            if (data.Tables.Count > 0)
            {
                data.Tables[0].TableName = "PhongBan";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }
        /// <summary>
        /// bảng KTKL của một nhân viên
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="Par"></param>
        public void GetKTKLNV(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetKTKLNV(Par);
            if (data.Tables.Count > 0)
            {
                data.Tables[0].TableName = "KTKL";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }
        /// <summary>
        /// Bảng lương
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="Par"></param>
        public void GetSalary(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetSalary();
            if (data.Tables.Count > 0)
            {
                data.Tables[0].TableName = "BangLuong";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }
        /// <summary>
        /// Sửa lương
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int EditSalary(LuongDTO l)
        {
            Providers provi = new Providers();
            return provi.EditSalary(l.Money, l.ID);
        }

        /// <summary>
        /// Thêm KTKL
        /// </summary>
        /// <param name="pp"></param>
        /// <returns></returns>
        public int ThemKTKL(KTKLDTO pp)
        {
            Providers provi = new Providers();
            return provi.ThemKTKL(pp.Name, pp.HT, pp.Money);
        }
        /// <summary>
        /// Bảng KTKL
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="Par"></param>
        public void GetKTKL(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetKTKL(Par);
            if (data.Tables.Count > 0)
            {
                data.Tables[0].TableName = "KTKL";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }

        /// <summary>
        /// Bảng KTKL của tất cả nhân viên
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="Par"></param>
        public void GetKTKLNV1(out object DataSource, params object[] Par)
        {
            Providers provi = new Providers();
            DataSet data = provi.GetKTKLNV1();
            if (data.Tables.Count > 0)
            {
                data.Tables[0].TableName = "NV-KTKL";
                DataSource = data.Tables[0];
            }
            else
            {
                DataSource = null;
            }
        }

        /// <summary>
        /// Sửa KTKL
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int EditKTKL(KTKLDTO l)
        {
            Providers provi = new Providers();
            return provi.EditKTKL(l.Name, l.HT, l.Money, l.ID);
        }

        /// <summary>
        ///  Xóa KTKL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int XoaKTKL(object id)
        {
            Providers provi = new Providers();
            return provi.XoaKTKL(id);
        }

        /// <summary>
        /// Xóa KTKL của một nhân viên
        /// </summary>
        /// <param name="id1"></param> ID Nhân viên
        /// <param name="id2"></param> ID KTKL
        /// <returns></returns>
        public int XoaKTKLNV(object id1, object id2)
        {
            Providers provi = new Providers();
            return provi.XoaKTKLNV(id1, id2);
        }

        /// <summary>
        /// Lấy bảng chức vụ theo phòng ban
        /// </summary>
        /// <param name="Cv"></param>
        /// <param name="Id"></param> Mã PB
        public void GetChucvuDTO(out List<ChucVuDTO> Cv, object Id)
        {
            Cv = new List<ChucVuDTO>();
            Providers provi = new Providers();
            SqlDataReader reader = provi.GetChucVuDTO(Id);
            if (reader != null)
            {
                while (reader.Read())
                {
                    ChucVuDTO dto = new ChucVuDTO();
                    dto.ID = Int32.Parse(reader["Id"].ToString());
                    dto.NameCV = reader["Name"].ToString();
                    Cv.Add(dto);
                }
                reader.Close();
            }
            else Cv = null;
        }

        /// <summary>
        /// Thêm KTKL của nhân viên
        /// </summary>
        /// <param name="kt"></param>
        /// <param name="pp"></param>
        /// <returns></returns>
        public int ThemNVKTKL(KTKLDTO kt, PeopleDTO pp)
        {
            Providers provi = new Providers();
            return provi.ThemNVKTKL(kt.ID, pp.ID, pp.KH);
        }
        /// <summary>
        /// Mã KTKL của một nhân viên
        /// </summary>
        /// <param name="Cv"></param>
        /// <param name="Id"></param>
        public void getIDKTKL(out List<KTKLDTO> KTKL, object Id)
        {
            KTKL = new List<KTKLDTO>();
            Providers provi = new Providers();
            SqlDataReader reader = provi.getIDKTKL(Id);
            if (reader != null)
            {
                while (reader.Read())
                {
                    KTKLDTO dto = new KTKLDTO();
                    dto.ID = Int32.Parse(reader["Id_KTKL"].ToString());
                    KTKL.Add(dto);
                }
                reader.Close();
            }
            else KTKL = null;
        }/// <summary>
        /// Sửa lương cho chức vụ
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int EditCVL(object id1, object id2)
        {
            Providers provi = new Providers();
            return provi.EditCVL(id1,id2);
        }
    }
}
