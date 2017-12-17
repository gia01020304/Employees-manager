namespace final
{
    partial class StatusUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusUS));
            this.lbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.pninfo = new final.InfoCompanyUS();
            this.pnac = new final.AccountUS();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbInfo.Location = new System.Drawing.Point(12, 13);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(97, 33);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Administrator Info ";
            // 
            // pt1
            // 
            this.pt1.BackColor = System.Drawing.Color.Transparent;
            this.pt1.Image = ((System.Drawing.Image)(resources.GetObject("pt1.Image")));
            this.pt1.Location = new System.Drawing.Point(461, 43);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(57, 47);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 35;
            this.pt1.TabStop = false;
            this.pt1.Click += new System.EventHandler(this.pt1_Click);
            this.pt1.MouseLeave += new System.EventHandler(this.pt1_MouseLeave);
            this.pt1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(504, 412);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(114, 57);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pninfo
            // 
            this.pninfo.BackColor = System.Drawing.Color.Transparent;
            this.pninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pninfo.Location = new System.Drawing.Point(18, 119);
            this.pninfo.Margin = new System.Windows.Forms.Padding(4);
            this.pninfo.Name = "pninfo";
            this.pninfo.Size = new System.Drawing.Size(697, 405);
            this.pninfo.TabIndex = 36;
            this.pninfo.Load += new System.EventHandler(this.pninfo_Load);
            // 
            // pnac
            // 
            this.pnac.Admin = null;
            this.pnac.BackColor = System.Drawing.Color.Transparent;
            this.pnac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnac.ForeColor = System.Drawing.Color.DarkBlue;
            this.pnac.Location = new System.Drawing.Point(93, 134);
            this.pnac.Margin = new System.Windows.Forms.Padding(4);
            this.pnac.Name = "pnac";
            this.pnac.Size = new System.Drawing.Size(525, 299);
            this.pnac.TabIndex = 37;
            this.pnac.Visible = false;
            // 
            // StatusUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pninfo);
            this.Controls.Add(this.pnac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "StatusUS";
            this.Size = new System.Drawing.Size(719, 528);
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pt1;
        private InfoCompanyUS pninfo;
        private AccountUS pnac;
        private System.Windows.Forms.Button btnDone;
    }
}
