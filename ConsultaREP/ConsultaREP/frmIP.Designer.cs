namespace ConsultaREP
{
    partial class frmIP
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
            this.picIPBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIPBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picIPBig
            // 
            this.picIPBig.Location = new System.Drawing.Point(0, 0);
            this.picIPBig.Name = "picIPBig";
            this.picIPBig.Size = new System.Drawing.Size(100, 50);
            this.picIPBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIPBig.TabIndex = 0;
            this.picIPBig.TabStop = false;
            // 
            // frmIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 524);
            this.Controls.Add(this.picIPBig);
            this.Name = "frmIP";
            this.Text = "IP";
            this.Load += new System.EventHandler(this.FrmIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIPBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIPBig;
    }
}