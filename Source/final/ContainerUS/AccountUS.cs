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

namespace final
{
    public partial class AccountUS : UserControl
    {
        public AccountUS()
        {
            InitializeComponent();
        }
        private AdminDTO admin;
        Label lb = null;

        public AdminDTO Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }
        /// <summary>
        /// Binding Dữ liệu giữa AdminDTO và các Control
        /// </summary>
        public void BindingAdmin()
        {
            Binding data = new Binding("textvalue", admin, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUN.DataBindings.Add(data);
            data = new Binding("textvalue", admin, "PassWord", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPW.DataBindings.Add(data);
            data = new Binding("textvalue", admin, "DOB", true, DataSourceUpdateMode.OnPropertyChanged);
            txtday.DataBindings.Add(data);
            data = new Binding("textvalue", admin, "PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add(data);
            data = new Binding("textvalue", admin, "Sex", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSEX.DataBindings.Add(data);
            data = new Binding("textvalue", admin, "NameAdmin", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFN.DataBindings.Add(data);
        }
        /// <summary>
        /// Khi rời khỏi textBox nhập dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Leave(object sender, EventArgs e)
        {
            BaseControl bs = sender as BaseControl;
            KiemtraDuLieu(bs);
        }
        /// <summary>
        /// Kiểm tra xem text đã được điền chưa
        /// </summary>
        /// <param name="crtl">control hiện tại</param>
        public void KiemtraDuLieu(BaseControl crtl)
        {
            if (crtl.Text==""||crtl.Text== "  /  /")
            {
                crtl.Focus();
                lb = new Label();
                lb.Text = "Value not null";
                lb.Location = new Point(crtl.LabelWidth+10, crtl.Bottom);
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Visible = true;
                this.Controls.Add(lb);
            }
            else
            {
                if (lb!=null)
                {
                 
                    lb.Text = "";
                    lb = null;
                    this.Controls.Remove(lb);
                }
            }

            
        }

    }
}
