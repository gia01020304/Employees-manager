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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace final
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Lấy dữ liệu sẵn danh sách phòng ban và danh sách chức vụ của phòng ban đó
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            PhongBanBO bo = new PhongBanBO();
            PB = new List<PhongBanDTO>();
            qL = new PhongQuanLyDTO();
            qL.CV = new List<ChucVuDTO>();
            kT = new PhongKeToanDTO();
            KT.CV = new List<ChucVuDTO>();
            bo.GetPhongBan(qL, qL.MaPhongBan);
            bo.GetPhongBan(kT, kT.MaPhongBan);
            pB.Add(qL);
            pB.Add(kT);
        }
        private AdminDTO ad;
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

        private PhongQuanLyDTO qL;
        public PhongQuanLyDTO QL
        {
            get { return qL; }
            set { qL = value; }
        }
        private PhongKeToanDTO kT;
        public PhongKeToanDTO KT
        {
            get { return kT; }
            set { kT = value; }
        }
        private List<PhongBanDTO> pB;
        public List<PhongBanDTO> PB
        {
            get { return pB; }
            set { pB = value; }
        }
        private List<ChucVuDTO> CV;


        //
        private StatusUS status = null;
        private PhongBanUS pbus = null;
        private RAD rad = null;
        private TableSalary tbs = null;

        
        /// <summary>
        /// Khi Form hiện lên sẽ ở giao diện status admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            createTime();
            UserSetting();
            pnMove.Top = btAdmin.Top;
            pnMove.Height = btAdmin.Height;
        }

        /// <summary>
        /// Xóa hết các User cOntrol mà panel đang chứa
        /// </summary>
        public void RemovePanel()
        {
            pnFr.Controls.Clear();
            status = null;
            pbus = null;
            tbs = null;
            rad = null;
        }
        /// <summary>
        /// Khởi Tạo Status Admin
        /// </summary>
        private void UserSetting()
        {
            RemovePanel();
            status = new StatusUS();
            status.Ad = ad;
            status.Temp = ad.UserName;
            TransNumber();
            status.Pain();
            status.Visible = true;
            this.pnFr.Controls.Add(status);
            pnMove.Top = btAdmin.Top;
            pnMove.Height = btAdmin.Height;
        }
        /// <summary>
        /// Khởi tạo giao diện Phòng ban
        /// </summary>
        /// <param name="btnClick">Phòng ban được click</param>
        private void UserPhongBan(Control btnClick)
        {
            RemovePanel();
            pbus = new PhongBanUS();
            this.pnFr.Controls.Add(pbus);
            pnMove.Top = btnClick.Top;
            pnMove.Height = btnClick.Height;
        }
        /// <summary>
        /// Khởi tạo  lương
        /// </summary>
        private void UserSalary()
        {
            RemovePanel();
            tbs = new TableSalary();
            this.pnFr.Controls.Add(tbs);
            pnMove.Top = btWage.Top;
            pnMove.Height = btWage.Height;
        }
        /// <summary>
        /// Khởi tạo khen thưởng kỹ luật
        /// </summary>
        private void UserRAD()
        {
            RemovePanel();
            rad = new RAD();
            this.pnFr.Controls.Add(rad);
            pnMove.Top = btRAD.Top;
            pnMove.Height = btRAD.Height;
        }

        /// <summary>
        /// Even Click Admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdmin_Click_1(object sender, EventArgs e)
        {
            UserSetting();
        }

        /// <summary>
        /// Even Click Phòng Quản Lý
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btHuman_Click(object sender, EventArgs e)
        {

            UserPhongBan(btHuman);
            General(QL);
        }
        /// <summary>
        /// Sử dụng chung cho 2 phòng ban : phòng quản lý và phòng kế toán
        /// </summary>
        /// <param name="PhongBan"></param>
        private void General(PhongBanDTO PhongBan)
        {
            pbus.ListPhongBan = pB;
            pbus.PhongBanHienTai = PhongBan;
            pbus.PhanTrang();
        }
        /// <summary>
        /// Even Click Phòng kế toán
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAccou_Click(object sender, EventArgs e)
        {
            UserPhongBan(btAccou);
            General(KT);
        }
        /// <summary>
        /// Even Click Lương
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btWage_Click(object sender, EventArgs e)
        {
            RemovePanel();
            UserSalary();


        }
        /// <summary>
        /// Click khen thưởng kĩ ulậ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRAD_Click(object sender, EventArgs e)
        {
            RemovePanel();
            UserRAD();

        }
        /// <summary>
        /// Khởi tạo đồng hồ
        /// </summary>
        private void createTime()
        {
            DateTime date = DateTime.Now;
            if (date.Hour >= 10) lbHour.Text = date.Hour.ToString();
            else lbHour.Text = "0" + date.Hour.ToString();
            if (date.Minute >= 10) lbMinutes.Text = date.Minute.ToString();
            else lbMinutes.Text = "0" + date.Minute.ToString();
            if (date.Second >= 10) lbSecond.Text = date.Second.ToString();
            else lbSecond.Text = "0" + date.Second.ToString();
            timer1.Start();
        }

        /// <summary>
        /// Truyền số lượng nhân viên và tiền định phí của từng phòng ban vào User acc
        /// 
        /// </summary>
        public void TransNumber()
        {
            PhongQuanLyBO qlbo = new PhongQuanLyBO();
            PhongKeToanBO ktbo = new PhongKeToanBO();
            status.NumberPQL = qlbo.DemRecord(qL.MaPhongBan);
            status.NumberPKT = qlbo.DemRecord(kT.MaPhongBan);
            status.ConstsPQL = ktbo.TongLuong(qL.MaPhongBan);
            status.ConstsPKT = ktbo.TongLuong(kT.MaPhongBan);
            

        }
        /// <summary>
        /// Even đồng hồ chạy
        /// </summary>
        /// <param name="sender">timer</param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbHour.Text);
            int b = Int32.Parse(lbMinutes.Text);
            int c = Int32.Parse(lbSecond.Text);
            c++;
            if (c > 59)
            {
                c = 0;
                b++;
            }
            if (b > 59)
            {
                b = 0;
                a++;
            }
            if (c < 10) lbSecond.Text = "0" + c;
            else lbSecond.Text = "" + c;
            if (a < 10) lbHour.Text = "0" + a;
            else lbHour.Text = "" + a;
            if (b < 10) lbMinutes.Text = "0" + b;
            else lbMinutes.Text = "" + b;
        }

        private void buttonClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
