using final.DataObject;
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
    public partial class Form4 : Form
    {
        private int temp;
        private object dataSource;

        private PeopleDTO nhanVien;

        public PeopleDTO NhanVien
        {
            get
            {
                return nhanVien;
            }

            set
            {
                nhanVien = value;
            }
        }

        public string StringThongBao
        {
            get
            {
                return stringThongBao;
            }

            set
            {
                stringThongBao = value;
            }
        }

        public int Temp
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

        public object DataSource
        {
            get
            {
                return dataSource;
            }

            set
            {
                dataSource = value;
            }
        }

        private string stringThongBao;
        /// <summary>
        /// khi Form Load cho binding giữa nhân viên và control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
        {
           
            if (string.Compare(StringThongBao,"Edit")!=0)
            {
                ppus.setup();
            }
            ppus.BindingPeopleVsControl();
            ppus.Visible = true;
            

        }
        /// <summary>
        /// Vì form sử dụng chung cho nhiều mục đích nên có những mục cần cho phép ẩn hoặc hiện
        /// </summary>
        /// <param name="access"></param>
        public Form4(bool access)
        {
            InitializeComponent();

            ppus.Enabled = access;
            tnus1.Enabled = access;
            btnSave.Enabled = access;
        }
        /// <summary>
        ///Truyền dữ liệu vào User peple và User thannhan 
        /// </summary>
        /// <param name="people">Đối tượng people được đưa vào</param>
        /// <param name="pb">danh sách phòng ban</param>
        /// <param name="thongbao">xử lý được chọn</param>
        /// <param name="changed">cờ để kiểm tra có gán các giá trị mặt định cho nhan vien hay không</param>
        public void TranslationPeople(PeopleDTO people, List<PhongBanDTO> pb, string thongbao, bool changed)
        {
            this.Text = thongbao;
            StringThongBao = thongbao;
            ppus.StringThongBao = thongbao;
            ppus.Visiblenew = changed;
            nhanVien = people;
            ppus.NhanVien = nhanVien;
            ppus.LPB = pb;
            tnus1.Temp = stringThongBao;
            tnus1.BinDing();
        }





        private void btSave_Click(object sender, EventArgs e)
        {

            PhongQuanLyBO bo = new PhongQuanLyBO();

            ///Lưu Nhân Viên

            int kq;
            if (string.Compare(StringThongBao, "Edit") == 0)
            {
                kq = bo.EditNhanVien(nhanVien);
            }
            else
            {
                kq = bo.ThemNhanVien(nhanVien);
            }
            ///Lưu Thân Nhân
            tnus1.SaveThanNhan(nhanVien.ID, nhanVien.KH);
            if (kq > 0)
            {
                MessageBox.Show(StringThongBao + " thành công", StringThongBao + " Nhân Viên");
                this.Close();
            }
            else
                MessageBox.Show("Thất Bại", "Error");
        }

        private void btRela_Click(object sender, EventArgs e)
        {
            pnMove.Top = btRela.Top;
        }



        private void pt2_Click(object sender, EventArgs e)
        {
            pt2.Visible = false;
            btnSave.Visible = true;
            pt1.Visible = true;
            pnMove.Top = btRela.Top;
            ppus.Visible = false;
            tnus1.Id_NV = nhanVien.ID;
            tnus1.Kh_NV = nhanVien.KH;
            tnus1.Visible = true;
        }

        private void pt1_Click(object sender, EventArgs e)
        {
            pt2.Visible = true;
            btnSave.Visible = false;
            pt1.Visible = false;
            ppus.Visible = true;
            pnMove.Top = btInfo.Top;
            tnus1.Visible = false;
        }


    }
}
