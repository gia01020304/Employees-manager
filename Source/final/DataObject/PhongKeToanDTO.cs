using final.DataObject;
using project.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DataObject
{
    public class PhongKeToanDTO : PhongBanDTO
    {
        public PhongKeToanDTO()
        {
            MaPhongBan = 456;
        }
    }
}

