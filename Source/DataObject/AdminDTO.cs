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
