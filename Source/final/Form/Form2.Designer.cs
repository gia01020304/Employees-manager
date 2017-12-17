namespace final
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnMove = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lbtick = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.btClock = new System.Windows.Forms.Button();
            this.btAccou = new System.Windows.Forms.Button();
            this.btRAD = new System.Windows.Forms.Button();
            this.btHuman = new System.Windows.Forms.Button();
            this.btWage = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnFr = new System.Windows.Forms.Panel();
            this.ctmn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMenu.SuspendLayout();
            this.ctmn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMove
            // 
            this.pnMove.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMove.Location = new System.Drawing.Point(148, 3);
            this.pnMove.Name = "pnMove";
            this.pnMove.Size = new System.Drawing.Size(14, 41);
            this.pnMove.TabIndex = 5;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnMenu.Controls.Add(this.lbtick);
            this.pnMenu.Controls.Add(this.lbSecond);
            this.pnMenu.Controls.Add(this.lbMinutes);
            this.pnMenu.Controls.Add(this.lbHour);
            this.pnMenu.Controls.Add(this.btClock);
            this.pnMenu.Controls.Add(this.btAccou);
            this.pnMenu.Controls.Add(this.btRAD);
            this.pnMenu.Controls.Add(this.btHuman);
            this.pnMenu.Controls.Add(this.btWage);
            this.pnMenu.Controls.Add(this.btAdmin);
            this.pnMenu.Controls.Add(this.pnMove);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(157, 489);
            this.pnMenu.TabIndex = 4;
            // 
            // lbtick
            // 
            this.lbtick.AutoSize = true;
            this.lbtick.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtick.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbtick.Location = new System.Drawing.Point(66, 395);
            this.lbtick.Name = "lbtick";
            this.lbtick.Size = new System.Drawing.Size(18, 28);
            this.lbtick.TabIndex = 16;
            this.lbtick.Text = ":";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSecond.Location = new System.Drawing.Point(57, 426);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(38, 28);
            this.lbSecond.TabIndex = 17;
            this.lbSecond.Text = "00";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbMinutes.Location = new System.Drawing.Point(93, 395);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(38, 28);
            this.lbMinutes.TabIndex = 18;
            this.lbMinutes.Text = "00";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbHour.Location = new System.Drawing.Point(22, 395);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(38, 28);
            this.lbHour.TabIndex = 19;
            this.lbHour.Text = "00";
            // 
            // btClock
            // 
            this.btClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClock.Enabled = false;
            this.btClock.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btClock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btClock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClock.Location = new System.Drawing.Point(10, 382);
            this.btClock.Name = "btClock";
            this.btClock.Size = new System.Drawing.Size(137, 78);
            this.btClock.TabIndex = 15;
            this.btClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClock.UseVisualStyleBackColor = false;
            // 
            // btAccou
            // 
            this.btAccou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btAccou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAccou.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btAccou.FlatAppearance.BorderSize = 0;
            this.btAccou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccou.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAccou.Image = global::final.Properties.Resources.Webp_net_resizeimage__23_;
            this.btAccou.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccou.Location = new System.Drawing.Point(5, 121);
            this.btAccou.Name = "btAccou";
            this.btAccou.Size = new System.Drawing.Size(137, 68);
            this.btAccou.TabIndex = 14;
            this.btAccou.TabStop = false;
            this.btAccou.Text = "Phòng\r\n    Kế Toán";
            this.btAccou.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAccou.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAccou.UseCompatibleTextRendering = true;
            this.btAccou.UseVisualStyleBackColor = false;
            this.btAccou.Click += new System.EventHandler(this.btAccou_Click);
            // 
            // btRAD
            // 
            this.btRAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btRAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRAD.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btRAD.FlatAppearance.BorderSize = 0;
            this.btRAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRAD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btRAD.Image = global::final.Properties.Resources.Webp_net_resizeimage__21_;
            this.btRAD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRAD.Location = new System.Drawing.Point(2, 290);
            this.btRAD.Name = "btRAD";
            this.btRAD.Size = new System.Drawing.Size(145, 89);
            this.btRAD.TabIndex = 12;
            this.btRAD.TabStop = false;
            this.btRAD.Text = "Khen thưởng\r\nkỉ luật";
            this.btRAD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRAD.UseVisualStyleBackColor = false;
            this.btRAD.Click += new System.EventHandler(this.btRAD_Click);
            // 
            // btHuman
            // 
            this.btHuman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHuman.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btHuman.FlatAppearance.BorderSize = 0;
            this.btHuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuman.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btHuman.Image = global::final.Properties.Resources.Webp_net_resizeimage__24_;
            this.btHuman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuman.Location = new System.Drawing.Point(3, 47);
            this.btHuman.Name = "btHuman";
            this.btHuman.Size = new System.Drawing.Size(137, 68);
            this.btHuman.TabIndex = 11;
            this.btHuman.TabStop = false;
            this.btHuman.Text = "Phòng \r\n     Nhân Sự\r\n";
            this.btHuman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHuman.UseVisualStyleBackColor = false;
            this.btHuman.Click += new System.EventHandler(this.btHuman_Click);
            // 
            // btWage
            // 
            this.btWage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btWage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btWage.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btWage.FlatAppearance.BorderSize = 0;
            this.btWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btWage.Image = global::final.Properties.Resources.Webp_net_resizeimage__20_;
            this.btWage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btWage.Location = new System.Drawing.Point(2, 195);
            this.btWage.Name = "btWage";
            this.btWage.Size = new System.Drawing.Size(145, 89);
            this.btWage.TabIndex = 13;
            this.btWage.TabStop = false;
            this.btWage.Text = "Lương";
            this.btWage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btWage.UseVisualStyleBackColor = false;
            this.btWage.Click += new System.EventHandler(this.btWage_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdmin.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btAdmin.FlatAppearance.BorderSize = 0;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAdmin.Image = global::final.Properties.Resources.Webp_net_resizeimage__1_;
            this.btAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdmin.Location = new System.Drawing.Point(-3, 0);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(154, 41);
            this.btAdmin.TabIndex = 10;
            this.btAdmin.TabStop = false;
            this.btAdmin.Text = "Hello Admin";
            this.btAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdmin.UseVisualStyleBackColor = false;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnFr
            // 
            this.pnFr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnFr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFr.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pnFr.Location = new System.Drawing.Point(157, 0);
            this.pnFr.Name = "pnFr";
            this.pnFr.Size = new System.Drawing.Size(719, 489);
            this.pnFr.TabIndex = 6;
            this.pnFr.TabStop = true;
            // 
            // ctmn
            // 
            this.ctmn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ctmn.Name = "ctmn";
            this.ctmn.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 489);
            this.Controls.Add(this.pnFr);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ctmn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMove;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btAccou;
        private System.Windows.Forms.Button btRAD;
        private System.Windows.Forms.Button btHuman;
        private System.Windows.Forms.Button btWage;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbtick;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Button btClock;
        private System.Windows.Forms.Panel pnFr;
        private System.Windows.Forms.ContextMenuStrip ctmn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}