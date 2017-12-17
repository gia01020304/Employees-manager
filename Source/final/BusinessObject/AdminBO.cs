using project.DataObject;
using project.Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.BusinessObject
{
    class AdminBO
    {
        /// <summary>
        /// Lấy dữ liệu ADMIN dưới DB
        /// </summary>
        /// <param name="ad">instan ADMINDTO</param>
        /// <param name="par"></param>
        /// <returns>true--Lấy được/false ngược lại</returns>
        public bool GetAdmin(AdminDTO ad, params object[] par)
        {
            Providers provi = new Providers();
            SqlDataReader reader = provi.GetAdmin(par);
            if (reader==null)
            {
                return false;
            }
            if (reader.Read())
            {
                ad.UserName = reader["UserName"].ToString();
                ad.PassWord = reader["PassWord"].ToString();
                ad.NameAdmin = reader["FullName"].ToString();
                ad.DOB =DateTime.Parse( reader["DOB"].ToString());
                ad.PhoneNumber =int.Parse( reader["PhoneNumber"].ToString());
                ad.Sex = reader["Sex"].ToString();
                ad.Rate =Convert.ToDecimal( reader["Rate"]);
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        /// <summary>
        /// Update dữ liệu AdminDTO sau khi chỉnh sửa
        /// </summary>
        /// <param name="Admin">đối tượng DTO</param>
        /// <returns></returns>
        public int UpdateThongTin(AdminDTO Admin)
        {
            Providers provi = new Providers();
            int kq= provi.UpdateThongTin(Admin.UserName,Admin.PassWord,Admin.NameAdmin,Admin.DOB,Admin.PhoneNumber,Admin.Sex,Admin.Rate,Admin.UserName);
            if (kq>=0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Xử lý thất bại", "Error");
                return 0;
            }
        }
    }
}
