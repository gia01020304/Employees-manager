namespace final
{
    partial class RAD
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
            this.pnTB = new System.Windows.Forms.Panel();
            this.tabc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgKTKL = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgNVKTKL = new System.Windows.Forms.DataGridView();
            this.lbBL = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.pnTB.SuspendLayout();
            this.tabc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKTKL)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNVKTKL)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTB
            // 
            this.pnTB.Controls.Add(this.tabc);
            this.pnTB.Controls.Add(this.lbBL);
            this.pnTB.Controls.Add(this.btadd);
            this.pnTB.Controls.Add(this.btedit);
            this.pnTB.Controls.Add(this.btdel);
            this.pnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTB.Location = new System.Drawing.Point(4, 4);
            this.pnTB.Margin = new System.Windows.Forms.Padding(4);
            this.pnTB.Name = "pnTB";
            this.pnTB.Size = new System.Drawing.Size(719, 489);
            this.pnTB.TabIndex = 0;
            // 
            // tabc
            // 
            this.tabc.Controls.Add(this.tabPage1);
            this.tabc.Controls.Add(this.tabPage2);
            this.tabc.Location = new System.Drawing.Point(9, 71);
            this.tabc.Margin = new System.Windows.Forms.Padding(4);
            this.tabc.Name = "tabc";
            this.tabc.SelectedIndex = 0;
            this.tabc.Size = new System.Drawing.Size(679, 278);
            this.tabc.TabIndex = 17;
            this.tabc.SelectedIndexChanged += new System.EventHandler(this.tabc_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgKTKL);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(671, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KTKL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgKTKL
            // 
            this.dtgKTKL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKTKL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgKTKL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKTKL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKTKL.Location = new System.Drawing.Point(4, 4);
            this.dtgKTKL.Margin = new System.Windows.Forms.Padding(4);
            this.dtgKTKL.Name = "dtgKTKL";
            this.dtgKTKL.ReadOnly = true;
            this.dtgKTKL.Size = new System.Drawing.Size(663, 239);
            this.dtgKTKL.TabIndex = 16;
            this.dtgKTKL.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgNVKTKL);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(671, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách KLKT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgNVKTKL
            // 
            this.dtgNVKTKL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgNVKTKL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNVKTKL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNVKTKL.Location = new System.Drawing.Point(4, 4);
            this.dtgNVKTKL.Margin = new System.Windows.Forms.Padding(4);
            this.dtgNVKTKL.Name = "dtgNVKTKL";
            this.dtgNVKTKL.ReadOnly = true;
            this.dtgNVKTKL.Size = new System.Drawing.Size(663, 239);
            this.dtgNVKTKL.TabIndex = 16;
            this.dtgNVKTKL.TabStop = false;
            // 
            // lbBL
            // 
            this.lbBL.AutoSize = true;
            this.lbBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbBL.Location = new System.Drawing.Point(4, 10);
            this.lbBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBL.Name = "lbBL";
            this.lbBL.Size = new System.Drawing.Size(136, 29);
            this.lbBL.TabIndex = 16;
            this.lbBL.Text = "Bảng KTKL";
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btadd.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.Navy;
            this.btadd.Image = global::final.Properties.Resources.Webp_net_resizeimage__30_;
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(346, 391);
            this.btadd.Margin = new System.Windows.Forms.Padding(4);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(118, 39);
            this.btadd.TabIndex = 18;
            this.btadd.Tag = "";
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
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
            this.btedit.Location = new System.Drawing.Point(473, 391);
            this.btedit.Margin = new System.Windows.Forms.Padding(4);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(100, 39);
            this.btedit.TabIndex = 19;
            this.btedit.Tag = "";
            this.btedit.Text = "Sửa";
            this.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btdel
            // 
            this.btdel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btdel.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btdel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btdel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.ForeColor = System.Drawing.Color.Navy;
            this.btdel.Image = global::final.Properties.Resources.Webp_net_resizeimage__26_;
            this.btdel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdel.Location = new System.Drawing.Point(586, 391);
            this.btdel.Margin = new System.Windows.Forms.Padding(4);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(98, 39);
            this.btdel.TabIndex = 20;
            this.btdel.Tag = "";
            this.btdel.Text = "Xóa";
            this.btdel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdel.UseVisualStyleBackColor = false;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // RAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RAD";
            this.Size = new System.Drawing.Size(719, 489);
            this.Load += new System.EventHandler(this.RAD_Load);
            this.pnTB.ResumeLayout(false);
            this.pnTB.PerformLayout();
            this.tabc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKTKL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNVKTKL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTB;
        private System.Windows.Forms.Label lbBL;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.TabControl tabc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgKTKL;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgNVKTKL;
    }
}
