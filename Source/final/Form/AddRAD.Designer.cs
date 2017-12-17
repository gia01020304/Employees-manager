namespace final
{
    partial class AddRAD
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.lbN = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lbM = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.cbbHT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(101, 14);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(161, 20);
            this.txtN.TabIndex = 0;
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(18, 21);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(56, 13);
            this.lbN.TabIndex = 1;
            this.lbN.Text = "Tên KTKL";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(22, 60);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(53, 13);
            this.lbHT.TabIndex = 1;
            this.lbHT.Text = "Hình thức";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(101, 91);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(120, 20);
            this.txtM.TabIndex = 2;
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(22, 98);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(40, 13);
            this.lbM.TabIndex = 1;
            this.lbM.Text = "Số tiền";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSave.Location = new System.Drawing.Point(198, 132);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(64, 26);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbbHT
            // 
            this.cbbHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHT.FormattingEnabled = true;
            this.cbbHT.Items.AddRange(new object[] {
            "Thưởng",
            "Phạt"});
            this.cbbHT.Location = new System.Drawing.Point(101, 52);
            this.cbbHT.Name = "cbbHT";
            this.cbbHT.Size = new System.Drawing.Size(77, 21);
            this.cbbHT.TabIndex = 1;
            this.cbbHT.Tag = "";
            // 
            // AddRAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 171);
            this.Controls.Add(this.cbbHT);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.MaximizeBox = false;
            this.Name = "AddRAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KTKL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbbHT;
    }
}