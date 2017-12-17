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

namespace final
{
    public partial class DangNhapUS : UserControl
    {
        private AdminDTO ad;
        public DangNhapUS()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            txtMK.PasswordChar = '*';
            
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
            }
        }
        /// <summary>
        /// Lấy dữ liệu ADmin dưới DB
        /// </summary>
        /// <returns></returns>
        public bool LoadAD()
        {
            AdminBO bo = new AdminBO();
            return bo.GetAdmin(ad, txtName.TextValue, txtMK.TextValue);
        }
    }
}
