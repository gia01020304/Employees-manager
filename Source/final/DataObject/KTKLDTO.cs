using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.DataObject
{
    public class KTKLDTO
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private int money;
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string ht;
        public string HT
        {
            get { return ht; }
            set { ht = value; }
        }
    }
}
