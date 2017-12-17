using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using project.DataObject;

namespace final
{
    public partial class ComboBoxUS : BaseControl
    {
        public ComboBoxUS()
        {
            InitializeComponent();
            BaseControls = new ComboBox();
            BaseControls.TextChanged += BaseControls_TextChanged;
            ((ComboBox)BaseControls).DataSourceChanged += ComboBoxUS_DataSourceChanged;
        }

        private void ComboBoxUS_DataSourceChanged(object sender, EventArgs e)
        {
            OnPropertyChanged("DataSource");
        }

        private void BaseControls_TextChanged(object sender, EventArgs e)
        {
            OnPropertyChanged("TextValue");
        }

        public object SelectedValue
        {
            get
            {
                return ((ComboBox)BaseControls).SelectedValue;
            }

            set
            {
                ((ComboBox)BaseControls).SelectedValue = value;
                OnPropertyChanged("SelectedValue");
            }
        }

        public object DataSource
        {
            get
            {
                return ((ComboBox)BaseControls).DataSource;
            }

            set
            {

                ((ComboBox)BaseControls).DataSource = value;
                OnPropertyChanged("DataSource");
            }
        }

        public string DisplayMember
        {
            get
            {
                return ((ComboBox)BaseControls).DisplayMember;
            }

            set
            {
                ((ComboBox)BaseControls).DisplayMember = value;
            }
        }

        public string ValueMember
        {
            get
            {
                return ((ComboBox)BaseControls).ValueMember;
            }

            set
            {
                ((ComboBox)BaseControls).ValueMember = value;
            }
        }

        public int SelectedIndex
        {
            get
            {
                return ((ComboBox)BaseControls).SelectedIndex;
            }

            set
            {
                ((ComboBox)BaseControls).SelectedIndex = value;
            }
        }

        public new event EventHandler ValuaChanged
        {
            add { ((ComboBox)BaseControls).SelectedValueChanged += value; }
            remove { ((ComboBox)BaseControls).SelectedValueChanged -= value; }
        }
        public new event EventHandler DataSourceChanged
        {
            add { ((ComboBox)BaseControls).DataSourceChanged += value; }
            remove { ((ComboBox)BaseControls).DataSourceChanged -= value; }
        }
        public int FindStringExact(string s)
        {
            return ((ComboBox)BaseControls).FindStringExact(s);
        }
        public new bool Enabled
        {
            get
            {
                return ((ComboBox)BaseControls).Enabled;
            }

            set
            {
                ((ComboBox)BaseControls).Enabled = value;
            }
        }

        public string TextValue
        {
            get
            {
                if (SelectedValue is PhongBanDTO)
                {
                    PhongBanDTO pb = SelectedValue as PhongBanDTO;
                    return pb.MaPhongBan.ToString();
                }
                if (SelectedValue is ChucVuDTO)
                {
                    ChucVuDTO cv = SelectedValue as ChucVuDTO;
                    return cv.ID.ToString();
                }
                return "";
            }

            set
            {

                string a = null;
                if (DataSource is List<PhongBanDTO> && value != "")
                {

                    List<PhongBanDTO> pb = DataSource as List<PhongBanDTO>;
                    foreach (PhongBanDTO item in pb)
                    {
                        if (item.MaPhongBan == int.Parse(value))
                        {
                            a = item.TenPhongBan;
                            break;
                        }
                    }
                }
                if (DataSource is List<ChucVuDTO> && value != "")
                {
                    List<ChucVuDTO> cv = DataSource as List<ChucVuDTO>;
                    foreach (ChucVuDTO item in cv)
                    {
                        if (item.ID == int.Parse(value))
                        {
                            a = item.NameCV;
                            break;
                        }
                    }
                }

                ((ComboBox)BaseControls).SelectedIndex = ((ComboBox)BaseControls).FindStringExact(a);
                OnPropertyChanged("TextValue");
            }
        }

    }
}
