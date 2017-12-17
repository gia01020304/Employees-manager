  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DataObject
{
    public class PeopleDTO : INotifyPropertyChanged
    {
        private int iD;

        private string kH;
       
        private string fName;
       
        private string lName;
       
        private string gioiTinh;
       
        private DateTime dOB;
      
        private DateTime hD;
       
        private string queQuan;
        
        private int maCV;
       
        private int maPB;
       
        private object iDNQL;
       


        private object kHNQL;

        public string KH
        {
            get
            {
                return kH;
            }

            set
            {
                kH = value;
                OnPropertyChanged("KH");
            }
        }

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
                OnPropertyChanged("ID");
            }
        }

        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
                OnPropertyChanged("FName");
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
                OnPropertyChanged("LName");
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
                OnPropertyChanged("GioiTinh");
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
                OnPropertyChanged("DOB");
            }
        }

        public DateTime HD
        {
            get
            {
                return hD;
            }

            set
            {
                hD = value;
                OnPropertyChanged("HD");
            }
        }

        public string QueQuan
        {
            get
            {
                return queQuan;
            }

            set
            {
                queQuan = value;
                OnPropertyChanged("QueQuan");
            }
        }

        public int MaCV
        {
            get
            {
                return maCV;
            }

            set
            {
                maCV = value;
                OnPropertyChanged("MaCV");
            }
        }

        public int MaPB
        {
            get
            {
                return maPB;
            }

            set
            {
                maPB = value;
                OnPropertyChanged("MaPB");
            }
        }

        public object IDNQL
        {
            get
            {
                return iDNQL;
            }

            set
            {
                iDNQL = value;
                OnPropertyChanged("IDNQL");
            }
        }

        public object KHNQL
        {
            get
            {
                return kHNQL;
            }

            set
            {
                kHNQL = value;
                OnPropertyChanged("KHNQL");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual  void OnPropertyChanged(string newName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
    }
}
