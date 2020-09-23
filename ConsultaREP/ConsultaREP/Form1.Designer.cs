namespace ConsultaREP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCadBio = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picIP = new System.Windows.Forms.PictureBox();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picPen = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picEnviarReceber = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadBio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPen)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnviarReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.Location = new System.Drawing.Point(6, 19);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(441, 283);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 13;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.PicImagem_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(85, 70);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(164, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fabricante:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(85, 42);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(383, 20);
            this.txtFabricante.TabIndex = 2;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(85, 14);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(164, 20);
            this.txtProcurar.TabIndex = 1;
            this.txtProcurar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtProcurar_KeyUp);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(12, 12);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(60, 23);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(296, 14);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.ReadOnly = true;
            this.txtCNPJ.Size = new System.Drawing.Size(174, 20);
            this.txtCNPJ.TabIndex = 3;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(294, 68);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(174, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo:";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(6, 308);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(87, 308);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 19;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(85, 98);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(164, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "SenhaMenu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCadBio);
            this.groupBox1.Location = new System.Drawing.Point(476, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 142);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Biometria";
            // 
            // picCadBio
            // 
            this.picCadBio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCadBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCadBio.Location = new System.Drawing.Point(3, 16);
            this.picCadBio.Name = "picCadBio";
            this.picCadBio.Size = new System.Drawing.Size(156, 123);
            this.picCadBio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadBio.TabIndex = 0;
            this.picCadBio.TabStop = false;
            this.picCadBio.Click += new System.EventHandler(this.PicCadBio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picImagem);
            this.groupBox2.Controls.Add(this.btnAnterior);
            this.groupBox2.Controls.Add(this.btnProximo);
            this.groupBox2.Location = new System.Drawing.Point(15, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 341);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto Equipamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picIP);
            this.groupBox3.Location = new System.Drawing.Point(812, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 142);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mudar IP";
            // 
            // picIP
            // 
            this.picIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIP.Location = new System.Drawing.Point(3, 16);
            this.picIP.Name = "picIP";
            this.picIP.Size = new System.Drawing.Size(156, 123);
            this.picIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIP.TabIndex = 0;
            this.picIP.TabStop = false;
            this.picIP.Click += new System.EventHandler(this.PicIP_Click);
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(6, 19);
            this.txtOutros.Multiline = true;
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.ReadOnly = true;
            this.txtOutros.Size = new System.Drawing.Size(230, 199);
            this.txtOutros.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Web:";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(85, 126);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.ReadOnly = true;
            this.txtWeb.Size = new System.Drawing.Size(383, 20);
            this.txtWeb.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picPen);
            this.groupBox4.Location = new System.Drawing.Point(644, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 142);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puxar PenDrive";
            // 
            // picPen
            // 
            this.picPen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPen.Location = new System.Drawing.Point(3, 16);
            this.picPen.Name = "picPen";
            this.picPen.Size = new System.Drawing.Size(156, 123);
            this.picPen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPen.TabIndex = 0;
            this.picPen.TabStop = false;
            this.picPen.Click += new System.EventHandler(this.PicPen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtOutros);
            this.groupBox5.Location = new System.Drawing.Point(474, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 227);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Outros";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picEnviarReceber);
            this.groupBox6.Location = new System.Drawing.Point(812, 171);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(162, 142);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tela Enviar/Receber";
            // 
            // picEnviarReceber
            // 
            this.picEnviarReceber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnviarReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEnviarReceber.Location = new System.Drawing.Point(3, 16);
            this.picEnviarReceber.Name = "picEnviarReceber";
            this.picEnviarReceber.Size = new System.Drawing.Size(156, 123);
            this.picEnviarReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnviarReceber.TabIndex = 0;
            this.picEnviarReceber.TabStop = false;
            this.picEnviarReceber.Click += new System.EventHandler(this.PicEnviarReceber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 505);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.btnProcurar);
            this.Name = "Form1";
            this.Text = "Consulta REP´s **Demonstração*  -  Thiago Mazette";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCadBio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPen)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEnviarReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox picImagem;
        public System.Windows.Forms.Button btnAnterior;
        public System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox picCadBio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picPen;
        public System.Windows.Forms.PictureBox picIP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.PictureBox picEnviarReceber;
    }
}

