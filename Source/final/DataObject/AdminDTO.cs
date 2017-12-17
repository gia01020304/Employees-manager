using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DataObject
{
    public class AdminDTO:INotifyPropertyChanged
    {
        private string userName;
    
        private string passWord;
 
        private string nameAdmin;
        private int phoneNumber;
        private DateTime dOB;
        private string sex;
        private decimal rate;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
                OnPropertyChanged("PassWord");
            }
        }

        public string NameAdmin
        {
            get
            {
                return nameAdmin;
            }

            set
            {
                nameAdmin = value;
                OnPropertyChanged("NameAdmin");
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

        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
                OnPropertyChanged("Sex");
            }
        }

        public decimal Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
                OnPropertyChanged("Rate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }



    }
}
