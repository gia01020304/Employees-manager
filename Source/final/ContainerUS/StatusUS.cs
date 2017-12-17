using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.DataObject;
using project.BusinessObject;
using final.Properties;

namespace final
{
    public partial class StatusUS : UserControl
    {
        private AdminDTO ad;
        private string temp;
        private int numberPQL;
        private int numberPKT;
        private decimal constsPQL;
        private decimal constsPKT;
        private decimal rates;
        public StatusUS()
        {
            InitializeComponent();
        }
        public AdminDTO Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
                pnac.Admin = ad;
                pnac.BindingAdmin();
            }
        }

        public string Temp
        {
            get
            {
                return temp;
            }

            set
            {
                temp = value;
            }
        }

        public int NumberPQL
        {
            get
            {
                return numberPQL;
            }

            set
            {
                numberPQL = value;

            }
        }

        public int NumberPKT
        {
            get
            {
                return numberPKT;
            }

            set
            {
                numberPKT = value;

            }
        }

        public decimal ConstsPQL
        {
            get
            {
                return constsPQL;
            }

            set
            {
                constsPQL = value;
            }
        }

        public decimal ConstsPKT
        {
            get
            {
                return constsPKT;
            }

            set
            {
                constsPKT = value;
            }
        }

        public decimal Rates
        {
            get
            {
                return rates;
            }

            set
            {
                rates = value;
            }
        }

        public void Pain()
        {
            pninfo.Pain(numberPQL, numberPKT,ConstsPQL,ConstsPKT,ad);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pt1.Image = Resources.edit2;
        }

        private void pt1_MouseLeave(object sender, EventArgs e)
        {
            pt1.Image = Resources.edit1;
        }

        private void pt1_Click(object sender, EventArgs e)
        {
            if (pnac.Visible==true)
            {
                pninfo.Visible = true;
                btnDone.Visible = false;
                pnac.Visible = false;
                return;
            }
            pninfo.Visible = false;
            pnac.Visible = true;
            btnDone.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            pninfo.Visible = true;
            pnac.Visible = false;
            btnDone.Visible = false;
            AdminBO adbo = new AdminBO();
            int kq = adbo.UpdateThongTin(ad);
            if (kq!=0)
            {
                MessageBox.Show("Success", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("fail", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pninfo_Load(object sender, EventArgs e)
        {

        }
    }
}
