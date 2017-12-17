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
        public bool GetAdmin(AdminDTO ad, params object[] par)
        {
            Providers provi = new Providers();
            SqlDataReader reader = provi.GetAdmin(par);
            if (reader.Read())
            {
                ad.UserName = reader["UserName"].ToString();
                ad.PassWord = reader["PassWord"].ToString();
                ad.NameAdmin = reader["FullName"].ToString();
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
        public  bool KiemTra(params object[] par)
        {
            Providers provi = new Providers();
            if (provi.KiemTra(par) == 0)
            {
                return true;
            }
            return false;
               

        }
        public  int LuuThongTin(params object[] par)
        {
            Providers provi = new Providers();
            int kq = provi.LuuThongTin(par);
            return kq;
           
        }

        public int UpdateThongTin(params object[] par)
        {
            Providers provi = new Providers();
            return provi.UpdateThongTin(par);
        }
    }
}
