using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.DataObject
{
    public class ThanNhanDTO:INotifyPropertyChanged
    {
        private int id_NV;
        private string kh_NV;
        private string quanHe;
        private string name;
        private DateTime? dOB;

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }

        public int Id_NV
        {
            get
            {
                return id_NV;
            }

            set
            {
                id_NV = value;
                OnPropertyChanged("Id_NV");
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
                OnPropertyChanged("Kh_NV");
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
                OnPropertyChanged("QuanHe");
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
                OnPropertyChanged("Name");
            }
        }



        public DateTime? DOB
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
    }
}
