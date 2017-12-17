using final.DataObject;
using project.BusinessObject;
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
    public partial class AddRAD : Form
    {
        private KTKLDTO ktkl;
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        /// <summary>
        ///KTKL được chọn để edit
        /// </summary>
        public KTKLDTO KTKL
        {
            get
            {
                return ktkl;
            }

            set
            {
                ktkl = value;
                txtM.Text = ktkl.Money + "";
                txtN.Text = ktkl.Name;
                cbbHT.Text = ktkl.HT;
            }
        }
        public AddRAD()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thêm nếu KTKL nếu biến KTKL== null 
        /// Edit khi KTKL!=null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "" || cbbHT.Text == "" || txtM.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KTKLDTO KT = new KTKLDTO();
            int tam;
            bool kq = Int32.TryParse(txtM.Text, out tam);
            if (kq == true)
            {
                KT.Money = tam;
                KT.Name = txtN.Text;
                KT.HT = cbbHT.Text;
                int result;
                if (ktkl == null) result = ketoan.ThemKTKL(KT);
                else
                {
                    KT.ID = ktkl.ID;
                    result = ketoan.EditKTKL(KT);
                }
                if (result >= 0)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Số tiền không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
