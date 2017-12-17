namespace final
{
    partial class ButtonClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonClose));
            this.pt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).BeginInit();
            this.SuspendLayout();
            // 
            // pt
            // 
            this.pt.Image = ((System.Drawing.Image)(resources.GetObject("pt.Image")));
            this.pt.Location = new System.Drawing.Point(2, 2);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(41, 43);
            this.pt.TabIndex = 0;
            this.pt.TabStop = false;
            // 
            // ButtonClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pt);
            this.Name = "ButtonClose";
            this.Size = new System.Drawing.Size(45, 49);
            ((System.ComponentModel.ISupportInitialize)(this.pt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pt;
    }
}
