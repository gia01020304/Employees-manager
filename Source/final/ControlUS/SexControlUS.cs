using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class SexControlUS : BaseControl
    {
        public SexControlUS()
        {
            InitializeComponent();
            BaseControls = panel1;
            
        }
      

        public string TextValue
        {
            get
            {
                foreach (RadioButton item in panel1.Controls)
                {
                    if (item.Checked)
                    {
                        return item.Text;
                    }
                }
                return "";
            }

            set
            {
                
                if (value != "")
                {
                    foreach (RadioButton item in panel1.Controls)
                    {
                        if (item.Text == value)
                        {
                            item.Checked = true;
                            OnPropertyChanged("TextValue");
                            break;
                        }
                    }
                }
            }
        }

        private void rbtn0_CheckedChanged(object sender, EventArgs e)
        {
            OnPropertyChanged("TextValue");
        }
    }
}
