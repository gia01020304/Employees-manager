using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.DataObject
{
    public class ThanNhanDTO
    {
        private int id_NV;
        private string kh_NV;
        private string quanHe;
        private string name;
        private DateTime dOB;

        public int Id_NV
        {
            get
            {
                return id_NV;
            }

            set
            {
                id_NV = value;
            }
        }

        public string Kh_NV
        {
            get
            {
                return kh_NV;
            }

            set
            {
                kh_NV = value;
            }
        }

        public string QuanHe
        {
            get
            {
                return quanHe;
            }

            set
            {
                quanHe = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dOB;
            }

            set
            {
                dOB = value;
            }
        }
    }
}
