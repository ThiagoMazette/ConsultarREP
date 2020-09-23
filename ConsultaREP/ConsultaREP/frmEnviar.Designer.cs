namespace ConsultaREP
{
    partial class frmEnviar
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
            this.picEnviarReceberBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnviarReceberBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picEnviarReceberBig
            // 
            this.picEnviarReceberBig.Location = new System.Drawing.Point(0, 0);
            this.picEnviarReceberBig.Name = "picEnviarReceberBig";
            this.picEnviarReceberBig.Size = new System.Drawing.Size(100, 50);
            this.picEnviarReceberBig.TabIndex = 0;
            this.picEnviarReceberBig.TabStop = false;
            // 
            // frmEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picEnviarReceberBig);
            this.Name = "frmEnviar";
            this.Text = "frmEnviar";
            this.Load += new System.EventHandler(this.FrmEnviar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEnviarReceberBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picEnviarReceberBig;
    }
}