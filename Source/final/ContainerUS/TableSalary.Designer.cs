namespace final
{
    partial class TableSalary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgSalary = new System.Windows.Forms.DataGridView();
            this.btedit = new System.Windows.Forms.Button();
            this.lbBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.cbbPB = new System.Windows.Forms.ComboBox();
            this.cbbIDP = new System.Windows.Forms.ComboBox();
            this.lbCV = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.lbPB = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lnNV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgS)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalary)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabc);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.lbBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 331);
            this.panel1.TabIndex = 48;
            // 
            // tabc
            // 
            this.tabc.Controls.Add(this.tabPage1);
            this.tabc.Controls.Add(this.tabPage2);
            this.tabc.Location = new System.Drawing.Point(23, 39);
            this.tabc.Name = "tabc";
            this.tabc.SelectedIndex = 0;
            this.tabc.Size = new System.Drawing.Size(693, 225);
            this.tabc.TabIndex = 55;
       
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgS);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bảng mức lương";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgS
            // 
            this.dtgS.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgS.Location = new System.Drawing.Point(3, 3);
            this.dtgS.Name = "dtgS";
            this.dtgS.ReadOnly = true;
            this.dtgS.Size = new System.Drawing.Size(679, 181);
            this.dtgS.TabIndex = 6;
            this.dtgS.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Mức lương";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Money";
            this.Column2.HeaderText = "Số tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgSalary);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bảng lương theo chức vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgSalary
            // 
            this.dtgSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSalary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSalary.Location = new System.Drawing.Point(3, 3);
            this.dtgSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSalary.Name = "dtgSalary";
            this.dtgSalary.ReadOnly = true;
            this.dtgSalary.Size = new System.Drawing.Size(679, 181);
            this.dtgSalary.TabIndex = 53;
            this.dtgSalary.TabStop = false;
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btedit.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.Color.Navy;
            this.btedit.Image = global::final.Properties.Resources.Webp_net_resizeimage__27_;
            this.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedit.Location = new System.Drawing.Point(597, 271);
            this.btedit.Margin = new System.Windows.Forms.Padding(4);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(87, 39);
            this.btedit.TabIndex = 0;
            this.btedit.Tag = "";
            this.btedit.Text = "Sửa";
            this.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // lbBL
            // 
            this.lbBL.AutoSize = true;
            this.lbBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbBL.Location = new System.Drawing.Point(2, 7);
            this.lbBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBL.Name = "lbBL";
            this.lbBL.Size = new System.Drawing.Size(135, 29);
            this.lbBL.TabIndex = 51;
            this.lbBL.Text = "Bảng lương";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbCV);
            this.panel2.Controls.Add(this.cbbPB);
            this.panel2.Controls.Add(this.cbbIDP);
            this.panel2.Controls.Add(this.lbCV);
            this.panel2.Controls.Add(this.txtFN);
            this.panel2.Controls.Add(this.lbPB);
            this.panel2.Controls.Add(this.lbFname);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.lnNV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 161);
            this.panel2.TabIndex = 49;
            // 
            // cbbCV
            // 
            this.cbbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Location = new System.Drawing.Point(462, 57);
            this.cbbCV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(199, 26);
            this.cbbCV.TabIndex = 2;
            this.cbbCV.Tag = "";
            this.cbbCV.SelectedIndexChanged += new System.EventHandler(this.cbbCV_SelectedIndexChanged);
            // 
            // cbbPB
            // 
            this.cbbPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPB.FormattingEnabled = true;
            this.cbbPB.Items.AddRange(new object[] {
            "Quản lí",
            "Kế toán"});
            this.cbbPB.Location = new System.Drawing.Point(148, 57);
            this.cbbPB.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPB.Name = "cbbPB";
            this.cbbPB.Size = new System.Drawing.Size(150, 26);
            this.cbbPB.TabIndex = 1;
            this.cbbPB.Tag = "";
            this.cbbPB.SelectedIndexChanged += new System.EventHandler(this.cbbPB_SelectedIndexChanged);
            // 
            // cbbIDP
            // 
            this.cbbIDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDP.FormattingEnabled = true;
            this.cbbIDP.Location = new System.Drawing.Point(148, 115);
            this.cbbIDP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbIDP.Name = "cbbIDP";
            this.cbbIDP.Size = new System.Drawing.Size(150, 26);
            this.cbbIDP.TabIndex = 3;
            this.cbbIDP.Tag = "";
            this.cbbIDP.SelectedIndexChanged += new System.EventHandler(this.cbbIDP_SelectedIndexChanged);
            // 
            // lbCV
            // 
            this.lbCV.AutoSize = true;
            this.lbCV.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCV.Location = new System.Drawing.Point(338, 59);
            this.lbCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCV.Name = "lbCV";
            this.lbCV.Size = new System.Drawing.Size(53, 15);
            this.lbCV.TabIndex = 61;
            this.lbCV.Text = "Chức vụ";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(462, 116);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.Size = new System.Drawing.Size(148, 24);
            this.txtFN.TabIndex = 4;
            this.txtFN.Tag = "";
            // 
            // lbPB
            // 
            this.lbPB.AutoSize = true;
            this.lbPB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPB.Location = new System.Drawing.Point(24, 59);
            this.lbPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPB.Name = "lbPB";
            this.lbPB.Size = new System.Drawing.Size(67, 15);
            this.lbPB.TabIndex = 61;
            this.lbPB.Text = "Phòng ban";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.Location = new System.Drawing.Point(338, 119);
            this.lbFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(61, 15);
            this.lbFname.TabIndex = 62;
            this.lbFname.Text = "Họ và tên";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(50, 123);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 15);
            this.lbID.TabIndex = 58;
            this.lbID.Text = "ID";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSave.Location = new System.Drawing.Point(627, 124);
            this.btSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(96, 36);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Xuất";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // lnNV
            // 
            this.lnNV.AutoSize = true;
            this.lnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnNV.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lnNV.Location = new System.Drawing.Point(18, 7);
            this.lnNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnNV.Name = "lnNV";
            this.lnNV.Size = new System.Drawing.Size(124, 29);
            this.lnNV.TabIndex = 56;
            this.lnNV.Text = "Nhân Viên";
            // 
            // TableSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableSalary";
            this.Size = new System.Drawing.Size(719, 489);
            this.Load += new System.EventHandler(this.TableSalary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalary)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbIDP;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label lbPB;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lnNV;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.ComboBox cbbPB;
        private System.Windows.Forms.Label lbCV;
        private System.Windows.Forms.TabControl tabc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgSalary;
        private System.Windows.Forms.DataGridView dtgS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
