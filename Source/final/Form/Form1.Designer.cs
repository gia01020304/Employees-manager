namespace final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pt3 = new System.Windows.Forms.PictureBox();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.pt4 = new System.Windows.Forms.PictureBox();
            this.ptDN = new System.Windows.Forms.PictureBox();
            this.dangNhapUS1 = new final.DangNhapUS();
            ((System.ComponentModel.ISupportInitialize)(this.pt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDN)).BeginInit();
            this.SuspendLayout();
            // 
            // pt3
            // 
            this.pt3.BackColor = System.Drawing.Color.Transparent;
            this.pt3.Image = ((System.Drawing.Image)(resources.GetObject("pt3.Image")));
            this.pt3.Location = new System.Drawing.Point(418, 2);
            this.pt3.Name = "pt3";
            this.pt3.Size = new System.Drawing.Size(44, 40);
            this.pt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt3.TabIndex = 0;
            this.pt3.TabStop = false;
            this.pt3.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pt3.MouseLeave += new System.EventHandler(this.pt3_MouseLeave);
            this.pt3.MouseHover += new System.EventHandler(this.pt3_MouseHover);
            // 
            // pt1
            // 
            this.pt1.BackColor = System.Drawing.Color.Transparent;
            this.pt1.Image = ((System.Drawing.Image)(resources.GetObject("pt1.Image")));
            this.pt1.Location = new System.Drawing.Point(1, 2);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(167, 40);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 1;
            this.pt1.TabStop = false;
            this.pt1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pt1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pt1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // pt4
            // 
            this.pt4.BackColor = System.Drawing.Color.Transparent;
            this.pt4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pt4.Image = ((System.Drawing.Image)(resources.GetObject("pt4.Image")));
            this.pt4.Location = new System.Drawing.Point(1, 53);
            this.pt4.Name = "pt4";
            this.pt4.Size = new System.Drawing.Size(123, 133);
            this.pt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt4.TabIndex = 4;
            this.pt4.TabStop = false;
            this.pt4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pt4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pt4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // ptDN
            // 
            this.ptDN.BackColor = System.Drawing.Color.Transparent;
            this.ptDN.Image = ((System.Drawing.Image)(resources.GetObject("ptDN.Image")));
            this.ptDN.Location = new System.Drawing.Point(323, 166);
            this.ptDN.Name = "ptDN";
            this.ptDN.Size = new System.Drawing.Size(94, 55);
            this.ptDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDN.TabIndex = 6;
            this.ptDN.TabStop = false;
            this.ptDN.Click += new System.EventHandler(this.ptDN_Click);
            this.ptDN.MouseLeave += new System.EventHandler(this.ptDN_MouseLeave);
            this.ptDN.MouseHover += new System.EventHandler(this.ptDN_MouseHover);
            // 
            // dangNhapUS1
            // 
            this.dangNhapUS1.Ad = null;
            this.dangNhapUS1.BackColor = System.Drawing.Color.Transparent;
            this.dangNhapUS1.Location = new System.Drawing.Point(130, 53);
            this.dangNhapUS1.Name = "dangNhapUS1";
            this.dangNhapUS1.Size = new System.Drawing.Size(301, 109);
            this.dangNhapUS1.TabIndex = 1;
            this.dangNhapUS1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.dangNhapUS1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.dangNhapUS1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final.Properties.Resources.background_dandau_01_min;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 223);
            this.Controls.Add(this.ptDN);
            this.Controls.Add(this.pt4);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.pt3);
            this.Controls.Add(this.dangNhapUS1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pt3;
        private System.Windows.Forms.PictureBox pt1;
        private System.Windows.Forms.PictureBox pt4;
        private DangNhapUS dangNhapUS1;
        private System.Windows.Forms.PictureBox ptDN;
    }
}

