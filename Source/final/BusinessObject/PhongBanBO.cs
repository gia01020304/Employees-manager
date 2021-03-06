﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.DataObject;
using System.Data.SqlClient;
using project.Provider;
using System.Windows.Forms;

namespace project.BusinessObject
{
    class PhongBanBO
    {
        /// <summary>
        /// Lấy dữ liệu Phòng Ban và danh sách Chức Vụ dưới DB
        /// </summary>
        /// <param name="PB">Phòng Ban cần lấy</param>
        /// <param name="Par">Tham số truyền vào</param>
        /// <returns>true --lấy được dữ liệu/false ngược lại</returns>
        public bool GetPhongBan(PhongBanDTO PB, params object[]Par)
        {
            Providers provi=new Providers();
            SqlDataReader reader = provi.GetPhongBan(Par);
            if (reader==null)
            {
                return false;
            }
            if (reader.Read())
            {
                PB.TenPhongBan = reader["NamePB"].ToString();
                PB.KyHieu = reader["KyHieu"].ToString();
                do
                {
                    int tam = int.Parse(reader["idcv"].ToString());
                    ChucVuDTO cvnew=null;
                    switch (tam)
                    {
                        case 1:
                            case 4:
                            cvnew = new TruongPhongDTO();
                            cvnew.ID = tam;
                            cvnew.NameCV = reader["Name"].ToString();
                            break;
                        case 2:
                        case 5:
                            cvnew = new PhoPhongDTO();
                            cvnew.ID = tam;
                            cvnew.NameCV = reader["Name"].ToString();
                            break;
                        case 3:
                        case 6:
                            cvnew = new NhanVienDTO();
                            cvnew.ID = tam;
                            cvnew.NameCV = reader["Name"].ToString();
                            break;
                   
                    }
                    PB.CV.Add(cvnew);
                } while (reader.Read());
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
    }
}
