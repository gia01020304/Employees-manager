namespace final.BusinessObject
{
    partial class ThanNhanUS
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanNhanUS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pt2 = new System.Windows.Forms.PictureBox();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txtns = new final.DayUS();
            this.txtqh = new final.TextBoxUS();
            this.txthvt = new final.TextBoxUS();
            this.panel1.SuspendLayout();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn2);
            this.panel1.Controls.Add(this.pt2);
            this.panel1.Controls.Add(this.pt1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 227);
            this.panel1.TabIndex = 1;
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.txtns);
            this.pn2.Controls.Add(this.txtqh);
            this.pn2.Controls.Add(this.txthvt);
            this.pn2.Location = new System.Drawing.Point(37, 13);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(371, 151);
            this.pn2.TabIndex = 6;
            // 
            // pt2
            // 
            this.pt2.Image = ((System.Drawing.Image)(resources.GetObject("pt2.Image")));
            this.pt2.Location = new System.Drawing.Point(275, 170);
            this.pt2.Name = "pt2";
            this.pt2.Size = new System.Drawing.Size(40, 40);
            this.pt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pt2.TabIndex = 2;
            this.pt2.TabStop = false;
            this.pt2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pt2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pt2.MouseHover += new System.EventHandler(this.pt2_MouseHover);
            // 
            // pt1
            // 
            this.pt1.Image = ((System.Drawing.Image)(resources.GetObject("pt1.Image")));
            this.pt1.Location = new System.Drawing.Point(136, 170);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(40, 40);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pt1.TabIndex = 2;
            this.pt1.TabStop = false;
            this.pt1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pt1.MouseLeave += new System.EventHandler(this.pt1_MouseLeave);
            this.pt1.MouseHover += new System.EventHandler(this.pt1_MouseHover);
            // 
            // dtgv
            // 
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeight = 25;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.Size = new System.Drawing.Size(409, 194);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // txtns
            // 
            this.txtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtns.FontText = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtns.LabelText = "Ngày Sinh";
            this.txtns.LabelWidth = 100;
            this.txtns.Location = new System.Drawing.Point(16, 102);
            this.txtns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(239, 29);
            this.txtns.TabIndex = 2;
            this.txtns.TextValue = "  /  /";
            this.txtns.WidthContainer = 239;
            // 
            // txtqh
            // 
            this.txtqh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqh.FontText = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqh.LabelText = "Quan Hệ";
            this.txtqh.LabelWidth = 100;
            this.txtqh.Location = new System.Drawing.Point(16, 58);
            this.txtqh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtqh.MaxLength = 32767;
            this.txtqh.Name = "txtqh";
            this.txtqh.PasswordChar = '\0';
            this.txtqh.Size = new System.Drawing.Size(306, 36);
            this.txtqh.TabIndex = 1;
            this.txtqh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtqh.TextValue = "";
            this.txtqh.WidthContainer = 306;
            // 
            // txthvt
            // 
            this.txthvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthvt.FontText = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthvt.LabelText = "Họ và tên:";
            this.txthvt.LabelWidth = 100;
            this.txthvt.Location = new System.Drawing.Point(16, 17);
            this.txthvt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthvt.MaxLength = 32767;
            this.txthvt.Name = "txthvt";
            this.txthvt.PasswordChar = '\0';
            this.txthvt.Size = new System.Drawing.Size(306, 33);
            this.txthvt.TabIndex = 0;
            this.txthvt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txthvt.TextValue = "";
            this.txthvt.WidthContainer = 306;
            // 
            // ThanNhanUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv);
            this.Name = "ThanNhanUS";
            this.Size = new System.Drawing.Size(409, 421);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pt1;
        private System.Windows.Forms.PictureBox pt2;
        private DayUS txtns;
        private TextBoxUS txtqh;
        private TextBoxUS txthvt;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.DataGridView dtgv;
    }
}
