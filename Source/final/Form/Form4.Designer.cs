namespace final
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            final.DataObject.ThanNhanDTO thanNhanDTO1 = new final.DataObject.ThanNhanDTO();
            this.btRela = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnMove = new System.Windows.Forms.Panel();
            this.pnFr = new System.Windows.Forms.Panel();
            this.tnus1 = new final.BusinessObject.ThanNhanUS();
            this.ppus = new final.PeoPleUS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt2 = new System.Windows.Forms.PictureBox();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.pnFr.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRela
            // 
            this.btRela.FlatAppearance.BorderSize = 0;
            this.btRela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRela.Image = ((System.Drawing.Image)(resources.GetObject("btRela.Image")));
            this.btRela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRela.Location = new System.Drawing.Point(6, 232);
            this.btRela.Name = "btRela";
            this.btRela.Size = new System.Drawing.Size(108, 135);
            this.btRela.TabIndex = 0;
            this.btRela.TabStop = false;
            this.btRela.Text = "Thông tin thân nhân";
            this.btRela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRela.UseVisualStyleBackColor = true;
            this.btRela.Click += new System.EventHandler(this.pt2_Click);
            // 
            // btInfo
            // 
            this.btInfo.FlatAppearance.BorderSize = 0;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.Image = ((System.Drawing.Image)(resources.GetObject("btInfo.Image")));
            this.btInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btInfo.Location = new System.Drawing.Point(3, 58);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(108, 135);
            this.btInfo.TabIndex = 0;
            this.btInfo.TabStop = false;
            this.btInfo.Text = "Thông tin cá nhân";
            this.btInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.pt1_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnMenu.Controls.Add(this.pnMove);
            this.pnMenu.Controls.Add(this.btRela);
            this.pnMenu.Controls.Add(this.btInfo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(114, 487);
            this.pnMenu.TabIndex = 1;
            // 
            // pnMove
            // 
            this.pnMove.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnMove.Location = new System.Drawing.Point(107, 58);
            this.pnMove.Name = "pnMove";
            this.pnMove.Size = new System.Drawing.Size(7, 135);
            this.pnMove.TabIndex = 5;
            // 
            // pnFr
            // 
            this.pnFr.Controls.Add(this.tnus1);
            this.pnFr.Controls.Add(this.ppus);
            this.pnFr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFr.Location = new System.Drawing.Point(114, 0);
            this.pnFr.Name = "pnFr";
            this.pnFr.Size = new System.Drawing.Size(408, 487);
            this.pnFr.TabIndex = 2;
            // 
            // tnus1
            // 
             this.tnus1.DataSource = null;
             this.tnus1.Dock = System.Windows.Forms.DockStyle.Fill;
             this.tnus1.Location = new System.Drawing.Point(0, 0);
            this.tnus1.Name = "tnus1";
            this.tnus1.Row = -1;
            this.tnus1.Size = new System.Drawing.Size(1, 487);
            this.tnus1.TabIndex = 1;
            this.tnus1.Temp = null;
            thanNhanDTO1.DOB = new System.DateTime(((long)(0)));
            thanNhanDTO1.Id_NV = 0;
            thanNhanDTO1.Kh_NV = null;
            thanNhanDTO1.Name = null;
            thanNhanDTO1.QuanHe = null;
            this.tnus1.ThanNhan = thanNhanDTO1;
            this.tnus1.Visible = false;
            // 
            // ppus
            // 
            this.ppus.Dock = System.Windows.Forms.DockStyle.Right;
            this.ppus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppus.Id_NQL = null;
            this.ppus.Location = new System.Drawing.Point(1, 0);
            this.ppus.LPB = null;
            this.ppus.Name = "ppus";
            this.ppus.NhanVien = null;
            this.ppus.Size = new System.Drawing.Size(407, 487);
            this.ppus.StringThongBao = null;
            this.ppus.TabIndex = 0;
            this.ppus.ThanNhan = null;
            this.ppus.Visiblenew = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pt2);
            this.panel1.Controls.Add(this.pt1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(114, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 60);
            this.panel1.TabIndex = 3;
            // 
            // pt2
            // 
            this.pt2.Image = ((System.Drawing.Image)(resources.GetObject("pt2.Image")));
            this.pt2.Location = new System.Drawing.Point(327, 13);
            this.pt2.Name = "pt2";
            this.pt2.Size = new System.Drawing.Size(81, 47);
            this.pt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt2.TabIndex = 3;
            this.pt2.TabStop = false;
            this.pt2.Click += new System.EventHandler(this.pt2_Click);
            // 
            // pt1
            // 
            this.pt1.Image = ((System.Drawing.Image)(resources.GetObject("pt1.Image")));
            this.pt1.Location = new System.Drawing.Point(4, 13);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(73, 44);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 3;
            this.pt1.TabStop = false;
            this.pt1.Visible = false;
            this.pt1.Click += new System.EventHandler(this.pt1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(312, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 56);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnFr);
            this.Controls.Add(this.pnMenu);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnFr.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRela;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnMove;
        private System.Windows.Forms.Panel pnFr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private PeoPleUS ppus;
        private System.Windows.Forms.PictureBox pt2;
        private System.Windows.Forms.PictureBox pt1;
        private BusinessObject.ThanNhanUS tnus1;
    }
}