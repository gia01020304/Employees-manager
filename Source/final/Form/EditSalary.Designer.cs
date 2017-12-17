namespace final
{
    partial class EditSalary
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
            this.lbMlg = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.cbbMlg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbMlg
            // 
            this.lbMlg.AutoSize = true;
            this.lbMlg.Location = new System.Drawing.Point(26, 27);
            this.lbMlg.Name = "lbMlg";
            this.lbMlg.Size = new System.Drawing.Size(57, 13);
            this.lbMlg.TabIndex = 0;
            this.lbMlg.Text = "Mức lương";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(26, 74);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(40, 13);
            this.lbM.TabIndex = 5;
            this.lbM.Text = "Số tiền";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(107, 67);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(91, 20);
            this.txtM.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSave.Location = new System.Drawing.Point(145, 99);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(64, 26);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbbMlg
            // 
            this.cbbMlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMlg.FormattingEnabled = true;
            this.cbbMlg.Location = new System.Drawing.Point(107, 19);
            this.cbbMlg.Name = "cbbMlg";
            this.cbbMlg.Size = new System.Drawing.Size(62, 21);
            this.cbbMlg.TabIndex = 0;
            this.cbbMlg.Tag = "";
            this.cbbMlg.SelectedIndexChanged += new System.EventHandler(this.cbbMlg_SelectedIndexChanged);
            // 
            // EditSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 137);
            this.Controls.Add(this.cbbMlg);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lbMlg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa lương";
            this.Load += new System.EventHandler(this.EditSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMlg;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbbMlg;
    }
}