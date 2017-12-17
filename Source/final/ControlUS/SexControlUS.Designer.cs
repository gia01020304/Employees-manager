namespace final
{
    partial class SexControlUS
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
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnnu = new System.Windows.Forms.RadioButton();
            this.rbtn0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(3, -2);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(48, 17);
            this.rbtnNam.TabIndex = 0;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Male";
            this.rbtnNam.UseVisualStyleBackColor = true;
            this.rbtnNam.CheckedChanged += new System.EventHandler(this.rbtn0_CheckedChanged);
            // 
            // rbtnnu
            // 
            this.rbtnnu.AutoSize = true;
            this.rbtnnu.Location = new System.Drawing.Point(71, -2);
            this.rbtnnu.Name = "rbtnnu";
            this.rbtnnu.Size = new System.Drawing.Size(59, 17);
            this.rbtnnu.TabIndex = 1;
            this.rbtnnu.TabStop = true;
            this.rbtnnu.Text = "Female";
            this.rbtnnu.UseVisualStyleBackColor = true;
            this.rbtnnu.CheckedChanged += new System.EventHandler(this.rbtn0_CheckedChanged);
            // 
            // rbtn0
            // 
            this.rbtn0.AutoSize = true;
            this.rbtn0.Location = new System.Drawing.Point(147, -2);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.Size = new System.Drawing.Size(71, 17);
            this.rbtn0.TabIndex = 2;
            this.rbtn0.TabStop = true;
            this.rbtn0.Text = "Unknown";
            this.rbtn0.UseVisualStyleBackColor = true;
            this.rbtn0.CheckedChanged += new System.EventHandler(this.rbtn0_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnnu);
            this.panel1.Controls.Add(this.rbtnNam);
            this.panel1.Controls.Add(this.rbtn0);
            this.panel1.Location = new System.Drawing.Point(55, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 23);
            this.panel1.TabIndex = 1;
            // 
            // SexControlUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SexControlUS";
            this.Size = new System.Drawing.Size(276, 66);
            this.WidthContainer = 276;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton rbtnnu;
        private System.Windows.Forms.RadioButton rbtn0;
        private System.Windows.Forms.Panel panel1;
    }
}
