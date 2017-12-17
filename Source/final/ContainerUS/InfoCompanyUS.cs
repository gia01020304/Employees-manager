using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.Properties;
using project.BusinessObject;
using project.DataObject;

namespace final
{
    public partial class InfoCompanyUS : UserControl
    {

        public InfoCompanyUS()
        {
            InitializeComponent();
        }
        private AdminDTO ad;
        private decimal costPQL;
        private decimal costPKT;

        /// <summary>
        /// Vẽ đồ thị
        /// </summary>
        public void Pain(int NumberPQL,int NumberPKT,decimal CostsPQL,decimal CostsPKT,AdminDTO admin)
        {
            ad = admin;
            costPKT = CostsPKT;
            costPQL = CostsPQL;
            this.chart1.Series["Number"].Points.AddXY("PQL", NumberPQL);
            this.chart1.Series["Number"].Points.AddXY("PKT", NumberPKT);
            lblpql.Text =string.Format("{0:0,0}$",(CostsPQL/ ad.Rate));
            lblpkt.Text = string.Format("{0:0,0}$", (CostsPKT / ad.Rate));
            lblrate.Text= string.Format("{0:0,0}vnd/$", ad.Rate);

        }

        private void ptEdit_MouseHover(object sender, EventArgs e)
        {
            ptEdit.Image = Resources._2;
        }

        private void ptEdit_MouseLeave(object sender, EventArgs e)
        {
            ptEdit.Image = Resources._1;
        }

        private void ptEdit_Click(object sender, EventArgs e)
        {
            pnedit.Visible = true;
        }
        /// <summary>
        /// Khi thay đổi giá trị rate tiến hành kiểm tra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int a=0;
            bool kt = Int32.TryParse(txtrate.Text, out a);
            if (a<20000)
            {
                lblKT.Text = "Value not null and value >= 20000vnd";
                lblKT.ForeColor = Color.Red;
                txtrate.Focus();
                lblKT.Visible = true;
            }
            else
            {
                if (lblKT.Visible==true)
                {
                    lblKT.Visible = false;
                }
                ad.Rate = a;
                AdminBO adbo = new AdminBO();
                int kq= adbo.UpdateThongTin(ad);
                if (kq>0)
                {
                    lblpql.Text = string.Format("{0:0,0}$", (costPQL / ad.Rate));
                    lblpkt.Text = string.Format("{0:0,0}$", (costPKT / ad.Rate));
                    lblrate.Text = string.Format("{0:0,0}vnd/$", ad.Rate);
                    pnedit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Không thực hiện được", "Error");
                }
                
            }
            
        }
    }
}
