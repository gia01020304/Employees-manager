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
    public partial class Salary : Form
    {
      
        private PhongKeToanBO ketoan = new PhongKeToanBO();
        private string cv;
        private LuongDTO luong;
        private PeopleDTO nv;

        public string CV
        {
            get
            {
                return cv;
            }

            set
            {
                cv = value;
                txtCV.Text = CV;
            }
        }

        public LuongDTO Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
                txtsa.Text = luong.ID + "";
            }
        }
        public Salary(PeopleDTO nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        /// <summary>
        /// Input thông tin nhân viên được chọn
        /// </summary>
        private void InputInfo()
        {
            txtid.Text = nv.ID + nv.KH;
            txtname.Text = nv.FName + " " + nv.LName;
            if (nv.KH == "PQL") txtPB.Text = "Quản lí";
            else txtPB.Text = "Kế Toán";
        }

        /// <summary>
        /// Tạo bảng lương
        /// </summary>

        private void createTableSalary()
        {
            dtgS.Columns[0].DataPropertyName = "Mục";
            dtgS.Columns[1].DataPropertyName = "Hình thức";
            dtgS.Columns[2].DataPropertyName = "Số tiền";
            object ob;
            ketoan.GetKTKLNV(out ob, nv.ID, nv.KH);
            int sum = luong.Money;
            if (ob != null)
            {
                DataTable tbKTKL = (DataTable)ob;
                if (tbKTKL.Rows.Count > 0)
                {
                    for (int i = 0; i < tbKTKL.Rows.Count; i++)
                    {
                        if (tbKTKL.Rows[i][1].ToString() == "Phạt")
                            sum -= Int32.Parse(tbKTKL.Rows[i][2].ToString());
                        else sum += Int32.Parse(tbKTKL.Rows[i][2].ToString());
                    }
                }
                var row = tbKTKL.Rows.Add();
                row[0] = "Lương cơ bản";
                row[1] = "Mức " + txtsa.Text;
                row[2] = luong.Money + "";
                row = tbKTKL.Rows.Add();
                row[0] = "";
                row[1] = "Tổng tiền";
                row[2] = sum + "";
                dtgS.DataSource = tbKTKL;
            }
            else MessageBox.Show("Lỗi không thể tính lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Salary_Load(object sender, EventArgs e)
        {
            InputInfo();
            createTableSalary();
            Mypaint.dtgcolor(dtgS);
        }
    }
}
