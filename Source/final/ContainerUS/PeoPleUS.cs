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
using final.DataObject;

namespace final
{
    public partial class PeoPleUS : UserControl
    {
        private List<PhongBanDTO> lPB;
        private PeopleDTO nhanVien;
        private ThanNhanDTO thanNhan;
        private string stringThongBao;
        private bool visiblenew;
        private int? id_NQL;
        private string kh;
        Label lb = null;
        public PeoPleUS()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Khi có danh sách phòng ban gán dữ liệu vào datasource của comboBox
        /// </summary>
        public List<PhongBanDTO> LPB
        {
            get
            {
                return lPB;
            }
            set
            {
                lPB = value;
                if (lPB != null)
                {
                    cmbPB.DataSource = lPB;
                    cmbPB.DisplayMember = "tenPhongBan";
                    cmbPB.TextValue = nhanVien.MaPB.ToString();

                }
            }
        }
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


        public bool Visiblenew
        {
            get
            {
                return visiblenew;
            }

            set
            {
                visiblenew = value;
            }
        }

        public ThanNhanDTO ThanNhan
        {
            get
            {
                return thanNhan;
            }

            set
            {
                thanNhan = value;
            }
        }

        public int? Id_NQL
        {
            get
            {
                return id_NQL;
            }

            set
            {
                id_NQL = value;
            }
        }


        /// <summary>
        /// Binding giữa các thuộc tính cảu đối tượng nhân viên và các control
        /// </summary>
        public void BindingPeopleVsControl()
        {

            //Id nhân viên
            Binding data = new Binding("textvalue", nhanVien, "iD", true, DataSourceUpdateMode.OnPropertyChanged);
            txtID.DataBindings.Add(data);
            //kh
            data = new Binding("textvalue", nhanVien, "kH", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKH.DataBindings.Add(data);
            //First name
            data = new Binding("textvalue", nhanVien, "fName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFN.DataBindings.Add(data);
            //Last name
            data = new Binding("textvalue", nhanVien, "lName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLN.DataBindings.Add(data);
            //gioitinh
            data = new Binding("TextValue", nhanVien, "gioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            sCT.DataBindings.Add(data);
            //dob
            data = new Binding("textvalue", nhanVien, "dOB", true, DataSourceUpdateMode.OnPropertyChanged);
            mkDOB.DataBindings.Add(data);
            //hiren day
            data = new Binding("textvalue", nhanVien, "hD", true, DataSourceUpdateMode.OnPropertyChanged);
            mkHD.DataBindings.Add(data);
            //que quan
            data = new Binding("text", nhanVien, "queQuan", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbqq.DataBindings.Add(data);
            //mapb
            data = new Binding("TextValue", nhanVien, "maPB", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbPB.DataBindings.Add(data);
            //macv
            data = new Binding("TextValue", nhanVien, "MaCV", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbCV.DataBindings.Add(data);
            //IDManager
            data = new Binding("TextValue", nhanVien, "iDNQL", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDMA.DataBindings.Add(data);
            //khnql
            data = new Binding("textvalue", nhanVien, "kHNQL", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKHQL.DataBindings.Add(data);
        }
        /// <summary>
        /// khởi tạo 1 số thuộc tính khi tạo 1 nhân viên mới
        /// </summary>
        public void setup()
        {
            PeoPleBO nvbo = new PeoPleBO();
            nhanVien.ID = nvbo.GetIDNV() + 1;
            nhanVien.HD = DateTime.Now;
        }

        private void cmbPB_ValuaChanged(object sender, EventArgs e)
        {

            ComboBox cmb = sender as ComboBox;

            PeoPleBO bonv = new PeoPleBO();
            PhongBanDTO pb = cmb.SelectedValue as PhongBanDTO;
            if (string.Compare(StringThongBao, "Edit") == 0 && Visiblenew == false)
            {
                if (pb.MaPhongBan == nhanVien.MaPB)
                {
                    int temp = nhanVien.MaCV;
                    List<ChucVuDTO> cvnew = new List<ChucVuDTO>(pb.CV);
                    if (nhanVien.MaCV == 1 || nhanVien.MaCV == 4)
                    {
                        int t = cvnew.Count;
                        for (int i = cvnew.Count-1; i >=0; i--)
                        {
                            if (cvnew[i] is NhanVienDTO ||cvnew[i] is PhoPhongDTO)
                            {
                                cvnew.RemoveAt(i);
                            }
                        }
                        cmbPB.Enabled = false;
                        cmbCV.Enabled = false;
                    }
                    else
                    {
                        foreach (var item in cvnew)
                        {
                            if (item is TruongPhongDTO)
                            {
                                cvnew.Remove(item);
                                break;
                            }
                        }

                    }
                    cmbCV.DataSource = cvnew;
                    cmbCV.DisplayMember = "nameCV";
                    cmbCV.TextValue = temp.ToString();

                }

                return;
            }

            if (cmb.SelectedValue != null)
            {

                List<ChucVuDTO> cvnew = new List<ChucVuDTO>(pb.CV);
                Id_NQL = bonv.test(pb.MaPhongBan);
                nhanVien.IDNQL = id_NQL;
                nhanVien.MaPB = pb.MaPhongBan;
                nhanVien.KH = pb.KyHieu;
                if (Id_NQL != 0)
                {
                    foreach (var item in cvnew)
                    {
                        if (item is TruongPhongDTO)
                        {
                            cvnew.Remove(item);
                            break;
                        }
                    }
                    nhanVien.KHNQL = pb.KyHieu;
                }
                else
                {
                    for (int i = cvnew.Count - 1; i >= 0; i--)
                    {
                        if (cvnew[i] is NhanVienDTO || cvnew[i] is PhoPhongDTO)
                        {
                            cvnew.RemoveAt(i);
                        }
                    }

                    nhanVien.IDNQL = null;
                    nhanVien.KHNQL = null;
                }
                cmbCV.DataSource = cvnew;
                cmbCV.DisplayMember = "namecv";
            }

        }
        private void cmbCV_ValuaChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedValue != null)
            {
                ChucVuDTO cv = cmb.SelectedValue as ChucVuDTO;
                nhanVien.MaCV = cv.ID;
            }
        }

        private void txtLN_Leave(object sender, EventArgs e)
        {
         
            BaseControl bs = sender as BaseControl;
            if (lb!=null&&bs.Text=="")
            {
                bs.Focus();
                return;
            }
            KiemtraDuLieu(bs);
        }
        /// <summary>
        /// Kiểm tra xem text đã được điền chưa
        /// </summary>
        /// <param name="crtl">control hiện tại</param>
        public void KiemtraDuLieu(BaseControl crtl)
        {
            if ((crtl.Text == "" || crtl.Text == "  /  /")&&lb==null)
            {
                crtl.Focus();
                lb = new Label();
                lb.Text = "Value not null";
                lb.Location = new Point(crtl.LabelWidth + crtl.Left, crtl.Bottom);
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Visible = true;
                this.Controls.Add(lb);
            }
            else
            {
                if (lb != null)
                {

                    lb.Text = "";
                    lb = null;
                    this.Controls.Remove(lb);
                }
            }


        }

    }
}

