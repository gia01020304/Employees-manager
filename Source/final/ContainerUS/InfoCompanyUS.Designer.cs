namespace final
{
    partial class InfoCompanyUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoCompanyUS));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnCost = new System.Windows.Forms.Panel();
            this.pnedit = new System.Windows.Forms.Panel();
            this.lblKT = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.ptEdit = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblrate = new final.LabelUS();
            this.lblpkt = new final.LabelUS();
            this.lblpql = new final.LabelUS();
            this.lblcosts = new final.LabelUS();
            this.pnCost.SuspendLayout();
            this.pnedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCost
            // 
            this.pnCost.Controls.Add(this.pnedit);
            this.pnCost.Controls.Add(this.ptEdit);
            this.pnCost.Controls.Add(this.lblrate);
            this.pnCost.Controls.Add(this.lblpkt);
            this.pnCost.Controls.Add(this.lblpql);
            this.pnCost.Controls.Add(this.lblcosts);
            this.pnCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCost.Location = new System.Drawing.Point(449, 3);
            this.pnCost.Name = "pnCost";
            this.pnCost.Size = new System.Drawing.Size(246, 268);
            this.pnCost.TabIndex = 38;
            // 
            // pnedit
            // 
            this.pnedit.Controls.Add(this.lblKT);
            this.pnedit.Controls.Add(this.btnOK);
            this.pnedit.Controls.Add(this.txtrate);
            this.pnedit.Location = new System.Drawing.Point(3, 195);
            this.pnedit.Name = "pnedit";
            this.pnedit.Size = new System.Drawing.Size(242, 66);
            this.pnedit.TabIndex = 3;
            this.pnedit.Visible = false;
            // 
            // lblKT
            // 
            this.lblKT.AutoSize = true;
            this.lblKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKT.Location = new System.Drawing.Point(13, 39);
            this.lblKT.Name = "lblKT";
            this.lblKT.Size = new System.Drawing.Size(18, 16);
            this.lblKT.TabIndex = 2;
            this.lblKT.Text = "kt";
            this.lblKT.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(187, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(39, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(9, 6);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(137, 24);
            this.txtrate.TabIndex = 0;
            this.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ptEdit
            // 
            this.ptEdit.Image = ((System.Drawing.Image)(resources.GetObject("ptEdit.Image")));
            this.ptEdit.Location = new System.Drawing.Point(187, 149);
            this.ptEdit.Name = "ptEdit";
            this.ptEdit.Size = new System.Drawing.Size(39, 37);
            this.ptEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptEdit.TabIndex = 2;
            this.ptEdit.TabStop = false;
            this.ptEdit.Click += new System.EventHandler(this.ptEdit_Click);
            this.ptEdit.MouseLeave += new System.EventHandler(this.ptEdit_MouseLeave);
            this.ptEdit.MouseHover += new System.EventHandler(this.ptEdit_MouseHover);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MediumBlue;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(-11, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 2;
            series1.LabelBorderWidth = 5;
            series1.LabelForeColor = System.Drawing.Color.Crimson;
            series1.Name = "Number";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Maroon;
            series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(454, 387);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.MediumBlue;
            title1.Name = "Title1";
            title1.Text = "Number of employess";
            this.chart1.Titles.Add(title1);
            // 
            // lblrate
            // 
            this.lblrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.FontText = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.LabelText = "Rate:";
            this.lblrate.LabelWidth = 52;
            this.lblrate.Location = new System.Drawing.Point(6, 162);
            this.lblrate.Margin = new System.Windows.Forms.Padding(6);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(158, 24);
            this.lblrate.TabIndex = 1;
            this.lblrate.WidthContainer = 158;
            // 
            // lblpkt
            // 
            this.lblpkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpkt.FontText = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpkt.LabelText = "PKT:";
            this.lblpkt.LabelWidth = 60;
            this.lblpkt.Location = new System.Drawing.Point(9, 115);
            this.lblpkt.Margin = new System.Windows.Forms.Padding(4);
            this.lblpkt.Name = "lblpkt";
            this.lblpkt.Size = new System.Drawing.Size(238, 24);
            this.lblpkt.TabIndex = 0;
            this.lblpkt.WidthContainer = 238;
            // 
            // lblpql
            // 
            this.lblpql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpql.FontText = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpql.LabelText = "PQL:";
            this.lblpql.LabelWidth = 60;
            this.lblpql.Location = new System.Drawing.Point(6, 61);
            this.lblpql.Margin = new System.Windows.Forms.Padding(4);
            this.lblpql.Name = "lblpql";
            this.lblpql.Size = new System.Drawing.Size(238, 26);
            this.lblpql.TabIndex = 0;
            this.lblpql.WidthContainer = 238;
            // 
            // lblcosts
            // 
            this.lblcosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosts.FontText = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosts.LabelText = "Costs";
            this.lblcosts.LabelWidth = 80;
            this.lblcosts.Location = new System.Drawing.Point(89, 13);
            this.lblcosts.Margin = new System.Windows.Forms.Padding(4);
            this.lblcosts.Name = "lblcosts";
            this.lblcosts.Size = new System.Drawing.Size(75, 27);
            this.lblcosts.TabIndex = 0;
            this.lblcosts.WidthContainer = 75;
            // 
            // InfoCompanyUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnCost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoCompanyUS";
            this.Size = new System.Drawing.Size(703, 429);
            this.pnCost.ResumeLayout(false);
            this.pnedit.ResumeLayout(false);
            this.pnedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnCost;
        private LabelUS lblpkt;
        private LabelUS lblpql;
        private LabelUS lblcosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox ptEdit;
        private LabelUS lblrate;
        private System.Windows.Forms.Panel pnedit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label lblKT;
    }
}
