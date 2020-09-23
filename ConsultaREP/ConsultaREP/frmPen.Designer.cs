namespace ConsultaREP
{
    partial class frmPen
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
            this.picPenBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPenBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picPenBig
            // 
            this.picPenBig.Location = new System.Drawing.Point(0, 0);
            this.picPenBig.Name = "picPenBig";
            this.picPenBig.Size = new System.Drawing.Size(304, 147);
            this.picPenBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPenBig.TabIndex = 0;
            this.picPenBig.TabStop = false;
            // 
            // frmPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 496);
            this.Controls.Add(this.picPenBig);
            this.Name = "frmPen";
            this.Text = "PenDrive";
            this.Load += new System.EventHandler(this.FrmPen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPenBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPenBig;
    }
}