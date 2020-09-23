namespace ConsultaREP
{
    partial class frmBio
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
            this.picBioBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBioBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picBioBig
            // 
            this.picBioBig.Location = new System.Drawing.Point(0, 0);
            this.picBioBig.Name = "picBioBig";
            this.picBioBig.Size = new System.Drawing.Size(188, 107);
            this.picBioBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBioBig.TabIndex = 0;
            this.picBioBig.TabStop = false;
            // 
            // frmBio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBioBig);
            this.Name = "frmBio";
            this.Text = "Biometria";
            this.Load += new System.EventHandler(this.FrmBio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBioBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBioBig;
    }
}