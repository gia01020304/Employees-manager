using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.DataObject;
using project.BusinessObject;
using final.Properties;

namespace final.BusinessObject
{
    public partial class ThanNhanUS : UserControl
    {
        public ThanNhanUS()
        {
            InitializeComponent();
            thanNhan = new ThanNhanDTO();
            dtgvcolor();

        }
        private int row=-1;
        private ThanNhanDTO thanNhan;
        private object dataSource;
        private string temp;
        private int id_NV=0;
        private string kh_NV=null;
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
        public object DataSource
        {
            get
            {
                return dataSource;
            }

            set
            {
                dataSource = value;
                if (dataSource != null)
                {
                    dtgv.DataSource = value;
                }
            }
        }

        public int Id_NV
        {
            get
            {
                return id_NV;
            }

            set
            {
                id_NV = value;
                if (id_NV != 0)
                {
                    GetThanNhan();
                }

            }
        }

        public string Kh_NV
        {
            get
            {
                return kh_NV;
            }

            set
            {
                kh_NV = value;
            }
        }

        public string Temp
        {
            get
            {
                return temp;
            }

            set
            {
                temp = value;
            }
        }

        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }

        public void GetThanNhan()
        {
            PhongQuanLyBO bo = new PhongQuanLyBO();
            if (string.Compare(temp, "Edit") == 0)
            {
                bo.GetThanNhan(dtgv, id_NV);
            }
            else
            {
                bo.GetThanNhan(dtgv, 0);
            }
            this.dtgv.AllowUserToAddRows = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txthvt.Text=="")
            {
                return;
            }
            if (row != -1)
            {
                Replace();
                row = -1;
            }
            else
                AddARow(dtgv.DataSource as DataTable);

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dtgv.Rows.RemoveAt(dtgv.Rows.Count - 1);
        }
        private void Replace()
        {
            dtgv.Rows[row].Cells[2].Value = thanNhan.Name;
            dtgv.Rows[row].Cells[3].Value = thanNhan.QuanHe;
            dtgv.Rows[row].Cells[4].Value = thanNhan.DOB;
            Reset();

        }
        public void Reset()
        {
            txtns.TextValue = new DateTime().ToShortDateString();
            foreach (BaseControl item in pn2.Controls)
            {
                item.Text = null;
            }
        }
        private void AddARow(DataTable table)
        {

            DataRow newRow = table.NewRow();
            newRow[0] = id_NV;
            newRow[1] = kh_NV;
            newRow[2] = thanNhan.Name;
            newRow[3] = thanNhan.QuanHe;
            newRow[4] = thanNhan.DOB;
            table.Rows.Add(newRow);
            Reset();
 
        }
        public void BinDing()
        {
            Binding data = new Binding("textvalue", thanNhan, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txthvt.DataBindings.Add(data);
            data = new Binding("textvalue", thanNhan, "DOB", true, DataSourceUpdateMode.OnPropertyChanged);
            txtns.DataBindings.Add(data);
            data = new Binding("textvalue", thanNhan, "QuanHe", true, DataSourceUpdateMode.OnPropertyChanged);
            txtqh.DataBindings.Add(data);

        }
  
        public int SaveThanNhan(int id, string kh)
        {
            PhongQuanLyBO bo = new PhongQuanLyBO();
            DataSet ds = ((DataTable)dtgv.DataSource).DataSet;
            return bo.UpdateDataSet(ds, id);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pt2.Image = Resources._40;
        }

        private void pt2_MouseHover(object sender, EventArgs e)
        {
            pt2.Image = Resources._50;
        }

        private void pt1_MouseLeave(object sender, EventArgs e)
        {
            pt1.Image = Resources.icons8_add_user_group_woman_man_40;
        }

        private void pt1_MouseHover(object sender, EventArgs e)
        {
            pt1.Image = Resources.icons8_add_user_group_woman_man_50;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            thanNhan.Name = dtgv.Rows[row].Cells[2].Value.ToString();
            thanNhan.QuanHe = dtgv.Rows[row].Cells[3].Value.ToString();
            thanNhan.DOB =DateTime.Parse( dtgv.Rows[row].Cells[4].Value.ToString());
         
        }
        private void dtgvcolor()
        {
            dtgv.Columns.Add(CreaterDataGridviewColumn("IdNV", "ID"));
            dtgv.Columns.Add(CreaterDataGridviewColumn("KhNV", "KH"));
            dtgv.Columns.Add(CreaterDataGridviewColumn("QuanHe", "Quan Hệ"));
            dtgv.Columns.Add(CreaterDataGridviewColumn("NameTN", "Name"));
            dtgv.Columns.Add(CreaterDataGridviewColumn("DOB", "DOB"));
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private DataGridViewTextBoxColumn CreaterDataGridviewColumn(string Name,string UIName)
        {
            DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
            colum.Name = Name;
            colum.HeaderText = UIName;
            colum.DataPropertyName = Name;
            return colum;
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
