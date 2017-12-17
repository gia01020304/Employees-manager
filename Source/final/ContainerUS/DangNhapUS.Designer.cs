namespace final
{
    partial class DangNhapUS
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
            this.pt2 = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.txtName = new final.TextBoxUS();
            this.txtMK = new final.TextBoxUS();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pt2
            // 
            this.pt2.AutoSize = true;
            this.pt2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt2.Location = new System.Drawing.Point(53, 0);
            this.pt2.Name = "pt2";
            this.pt2.Size = new System.Drawing.Size(204, 24);
            this.pt2.TabIndex = 7;
            this.pt2.Text = "Đăng Nhập Hệ Thống";
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.txtName);
            this.pn1.Controls.Add(this.txtMK);
            this.pn1.Location = new System.Drawing.Point(6, 37);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(346, 94);
            this.pn1.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtName.LabelText = "User Name:";
            this.txtName.LabelWidth = 113;
            this.txtName.Location = new System.Drawing.Point(14, 3);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Size = new System.Drawing.Size(268, 32);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextValue = "ADMIN";
            this.txtName.WidthContainer = 268;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMK.LabelText = "Pass Word:";
            this.txtMK.LabelWidth = 112;
            this.txtMK.Location = new System.Drawing.Point(14, 41);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.MaxLength = 6;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '\0';
            this.txtMK.Size = new System.Drawing.Size(268, 32);
            this.txtMK.TabIndex = 1;
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMK.TextValue = "1";
            this.txtMK.WidthContainer = 268;
            // 
            // DangNhapUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pt2);
            this.Controls.Add(this.pn1);
            this.Name = "DangNhapUS";
            this.Size = new System.Drawing.Size(308, 133);
            this.pn1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pt2;
        private System.Windows.Forms.Panel pn1;
        private TextBoxUS txtName;
        private TextBoxUS txtMK;
    }
}
