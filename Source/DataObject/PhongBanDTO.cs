using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DataObject
{
    public class PhongBanDTO
    {

        private int maPhongBan;
        public int MaPhongBan
        {
            get { return maPhongBan; }
            set { maPhongBan = value; }
        }
        private string tenPhongBan;
        public string TenPhongBan
        {
            get { return tenPhongBan; }
            set { tenPhongBan = value; }
        }
        private string kyHieu;
        public string KyHieu
        {
            get { return kyHieu; }
            set { kyHieu = value; }
        }
        private List<ChucVuDTO> cV;
        public List<ChucVuDTO> CV
        {
            get { return cV; }
            set { cV = value; }
        }
    }
}
