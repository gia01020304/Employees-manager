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
  
    public partial class BaseControl : UserControl,INotifyPropertyChanged
    {
        public BaseControl()
        {
            InitializeComponent();
          
           
        }
        public System.Drawing.Font FontText
        {
            get
            {
                return BaseControls.Font;
            }
            set
            {
                BaseControls.Font = value;
            }
        }
        private Control baseControls;

        public string LabelText
        {
            get
            {
                return lbl.Text;
            }

            set
            {
                lbl.Text = value;
                if (baseControls != null)
                {
                    baseControls.Location = new Point(lbl.Right + 5, lbl.Location.Y);
                    baseControls.Width = this.WidthContainer - baseControls.Left;
                }
            }
        }
        public override string Text
        {
            get
            {
                return BaseControls.Text;
            }

            set
            {
                BaseControls.Text = value;
                OnPropertyChanged("Text");
            }
        }

        public int LabelWidth
        {
            get
            {
                return lbl.Width;
            }

            set
            {
                lbl.Width = value;
                if (baseControls != null)
                {
                    baseControls.Location = new Point(lbl.Right + 5, lbl.Location.Y);
                    baseControls.Width = this.WidthContainer - baseControls.Left;
                }
            }

        }


        public Control BaseControls
        {
            get
            {
                return baseControls;
            }

            set
            {
                baseControls = value;
                if (baseControls != null)
                {
                    baseControls.Location = new Point(lbl.Right + 5, lbl.Location.Y);
                    baseControls.Width = this.WidthContainer- baseControls.Left;
                    this.Controls.Add(baseControls);
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
        public int WidthContainer
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
                if (baseControls != null)
                {
                    baseControls.Location = new Point(lbl.Right + 5, lbl.Location.Y);
                    baseControls.Width = WidthContainer - baseControls.Left;
                }
            }
        }

       
    }
}
