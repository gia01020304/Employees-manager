namespace final
{
    partial class AccountUS
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
            this.txtday = new final.DayUS();
            this.txtSEX = new final.SexControlUS();
            this.txtPhone = new final.TextBoxUS();
            this.txtFN = new final.TextBoxUS();
            this.txtPW = new final.TextBoxUS();
            this.txtUN = new final.TextBoxUS();
            this.SuspendLayout();
            // 
            // txtday
            // 
            this.txtday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtday.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtday.LabelText = "Birth Day:";
            this.txtday.LabelWidth = 140;
            this.txtday.Location = new System.Drawing.Point(0, 200);
            this.txtday.Margin = new System.Windows.Forms.Padding(4);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(362, 29);
            this.txtday.TabIndex = 4;
            this.txtday.TextValue = "  /  /";
            this.txtday.WidthContainer = 362;
            this.txtday.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtSEX
            // 
            this.txtSEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEX.FontText = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEX.LabelText = "Sex";
            this.txtSEX.LabelWidth = 100;
            this.txtSEX.Location = new System.Drawing.Point(1, 158);
            this.txtSEX.Margin = new System.Windows.Forms.Padding(4);
            this.txtSEX.Name = "txtSEX";
            this.txtSEX.Size = new System.Drawing.Size(517, 29);
            this.txtSEX.TabIndex = 3;
            this.txtSEX.TextValue = "";
            this.txtSEX.WidthContainer = 517;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.LabelText = "Phone:";
            this.txtPhone.LabelWidth = 140;
            this.txtPhone.Location = new System.Drawing.Point(1, 250);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(64, 54, 64, 54);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Size = new System.Drawing.Size(362, 29);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhone.TextValue = "";
            this.txtPhone.WidthContainer = 362;
            this.txtPhone.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.LabelText = "Full Name:";
            this.txtFN.LabelWidth = 140;
            this.txtFN.Location = new System.Drawing.Point(1, 110);
            this.txtFN.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.txtFN.MaxLength = 200;
            this.txtFN.Name = "txtFN";
            this.txtFN.PasswordChar = '\0';
            this.txtFN.Size = new System.Drawing.Size(521, 29);
            this.txtFN.TabIndex = 2;
            this.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFN.TextValue = "";
            this.txtFN.WidthContainer = 521;
            this.txtFN.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.LabelText = "Pass Word:";
            this.txtPW.LabelWidth = 140;
            this.txtPW.Location = new System.Drawing.Point(1, 58);
            this.txtPW.Margin = new System.Windows.Forms.Padding(8);
            this.txtPW.MaxLength = 6;
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '\0';
            this.txtPW.Size = new System.Drawing.Size(521, 29);
            this.txtPW.TabIndex = 1;
            this.txtPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPW.TextValue = "";
            this.txtPW.WidthContainer = 521;
            this.txtPW.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtUN
            // 
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.LabelText = "User Name:";
            this.txtUN.LabelWidth = 140;
            this.txtUN.Location = new System.Drawing.Point(1, 4);
            this.txtUN.Margin = new System.Windows.Forms.Padding(4);
            this.txtUN.MaxLength = 50;
            this.txtUN.Name = "txtUN";
            this.txtUN.PasswordChar = '\0';
            this.txtUN.Size = new System.Drawing.Size(520, 29);
            this.txtUN.TabIndex = 0;
            this.txtUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUN.TextValue = "";
            this.txtUN.WidthContainer = 520;
            this.txtUN.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // AccountUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtSEX);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountUS";
            this.Size = new System.Drawing.Size(522, 309);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxUS txtUN;
        private TextBoxUS txtPW;
        private TextBoxUS txtFN;
        private TextBoxUS txtPhone;
        private SexControlUS txtSEX;
        private DayUS txtday;
    }
}
