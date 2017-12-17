using final.Properties;
using project.BusinessObject;
using project.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// bắt even ấn phím enter từ bàn phím
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ptDN_Click(this, new EventArgs());
                return true; 
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        int x, y;
        bool co;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            co = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            co = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (co == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }


        private void pt3_MouseHover(object sender, EventArgs e)
        {
            pt3.Image = Resources.Close3a;
        }

        private void pt3_MouseLeave(object sender, EventArgs e)
        {
            pt3.Image = Resources.Close3b;
        }

        private void ptDN_MouseHover(object sender, EventArgs e)
        {
            ptDN.Image = Resources.lg4;
        }

        private void ptDN_MouseLeave(object sender, EventArgs e)
        {
            ptDN.Image = Resources.login2;
        }
        /// <summary>
        /// tiến hành đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptDN_Click(object sender, EventArgs e)
        {
            AdminDTO ad = new AdminDTO();
            AdminBO adbo = new AdminBO();
            dangNhapUS1.Ad = ad;
            bool kq = dangNhapUS1.LoadAD();
            if (kq == true)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Ad = ad;
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!\nVui lòng kiểm tra lại kết nối, tên tài khoản và mật khẩu\nMọi thắc mắc vui lòng liên hệ noidea@gmail.com", "Lổi");
            }
        }

       
    }
}
