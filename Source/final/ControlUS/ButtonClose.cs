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
    public partial class ButtonClose : UserControl
    {
        public ButtonClose()
        {
            InitializeComponent();
        }
        public event EventHandler Click
        {
            add
            {
                pt.Click += value;
            }
            remove
            {
                pt.Click -= value;
            }
        }
    }
}
