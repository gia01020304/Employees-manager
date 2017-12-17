using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public class Mypaint
    {
        public static void dtgcolor(DataGridView dtg)
        {
            dtg.EnableHeadersVisualStyles = false;
            dtg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
