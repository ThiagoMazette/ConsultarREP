namespace ConsultaREP
{
    partial class frmImagem
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
            this.picImagemBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagemBig
            // 
            this.picImagemBig.Location = new System.Drawing.Point(0, 0);
            this.picImagemBig.Name = "picImagemBig";
            this.picImagemBig.Size = new System.Drawing.Size(904, 518);
            this.picImagemBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagemBig.TabIndex = 0;
            this.picImagemBig.TabStop = false;
            // 
            // frmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 518);
            this.Controls.Add(this.picImagemBig);
            this.Name = "frmImagem";
            this.Text = "Imagem";
            this.Load += new System.EventHandler(this.FrmImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagemBig;
    }
}