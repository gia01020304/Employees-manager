namespace final
{
    partial class LuongCV
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
            this.cbbML = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbM = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbML
            // 
            this.cbbML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbML.FormattingEnabled = true;
            this.cbbML.Location = new System.Drawing.Point(115, 110);
            this.cbbML.Name = "cbbML";
            this.cbbML.Size = new System.Drawing.Size(77, 21);
            this.cbbML.TabIndex = 5;
            this.cbbML.Tag = "";
            this.cbbML.SelectedIndexChanged += new System.EventHandler(this.cbbML_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSave.Location = new System.Drawing.Point(195, 192);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(64, 26);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(36, 156);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(40, 13);
            this.lbM.TabIndex = 6;
            this.lbM.Text = "Số tiền";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(36, 118);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(57, 13);
            this.lbHT.TabIndex = 7;
            this.lbHT.Text = "Mức lương";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(36, 78);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(47, 13);
            this.lbN.TabIndex = 8;
            this.lbN.Text = "Chức vụ";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(115, 149);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(120, 20);
            this.txtM.TabIndex = 9;
            // 
            // cbbCV
            // 
            this.cbbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Location = new System.Drawing.Point(115, 70);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(161, 21);
            this.cbbCV.TabIndex = 11;
            this.cbbCV.Tag = "";
            this.cbbCV.SelectedIndexChanged += new System.EventHandler(this.cbbCV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phòng ban";
            // 
            // cbbPB
            // 
            this.cbbPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPB.FormattingEnabled = true;
            this.cbbPB.Items.AddRange(new object[] {
            "Quản lí",
            "Kế toán"});
            this.cbbPB.Location = new System.Drawing.Point(115, 24);
            this.cbbPB.Name = "cbbPB";
            this.cbbPB.Size = new System.Drawing.Size(120, 21);
            this.cbbPB.TabIndex = 11;
            this.cbbPB.Tag = "";
            this.cbbPB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LuongCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.cbbPB);
            this.Controls.Add(this.cbbCV);
            this.Controls.Add(this.cbbML);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.txtM);
            this.MaximizeBox = false;
            this.Name = "LuongCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lương cho chức vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbML;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPB;
    }
}