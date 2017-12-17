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

    public partial class TextBoxUS : BaseControl
    {

        public TextBoxUS()
        {
            InitializeComponent();
            BaseControls = new TextBox();
            BaseControls.TextChanged += BaseControls_TextChanged;
        }



        public int MaxLength
        {
            get
            {
                return ((TextBox)BaseControls).MaxLength;
            }
            set
            {
                ((TextBox)BaseControls).MaxLength = value;
            }
        }

        private void BaseControls_TextChanged(object sender, EventArgs e)
        {
            OnPropertyChanged("TextValue");
        }
        private string textValue;
        public string TextValue
        {
            get
            {
      
                return ((TextBox)BaseControls).Text;
            }
            set
            {
                ((TextBox)BaseControls).Text = value;
 
                OnPropertyChanged("TextValue");


            }
        }



        public new bool Enabled
        {
            get
            {
                return ((TextBox)BaseControls).Enabled;
            }

            set
            {
                ((TextBox)BaseControls).Enabled = value;

            }
        }

        public char PasswordChar
        {
            get
            {
                return ((TextBox)BaseControls).PasswordChar;
            }

            set
            {
                ((TextBox)BaseControls).PasswordChar = value;
            }
        }

        public HorizontalAlignment TextAlign
        {
            get
            {
                return ((TextBox)BaseControls).TextAlign;
            }

            set
            {
                ((TextBox)BaseControls).TextAlign = value;
            }
        }
    }
}
