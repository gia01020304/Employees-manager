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
    public partial class DayUS : BaseControl, INotifyPropertyChanged
    {
        public DayUS()
        {
            InitializeComponent();
            BaseControls = new MaskedTextBox();
            ((MaskedTextBox)BaseControls).Mask = "00/00/0000";
            ((MaskedTextBox)BaseControls).Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((MaskedTextBox)BaseControls).TextAlign = HorizontalAlignment.Right;
            BaseControls.TextChanged += BaseControls_TextChanged;
        }

        private void BaseControls_TextChanged(object sender, EventArgs e)
        {
            OnPropertyChanged("TextValue");
        }
        
        public string TextValue
        {
            get
            {
                return ((MaskedTextBox)BaseControls).Text;
            }

            set
            {
                ((MaskedTextBox)BaseControls).Text = value;
                OnPropertyChanged("TextValue");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
