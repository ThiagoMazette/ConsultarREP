using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConsultaREP
{
    public partial class Form1 : Form
    {
        public static string pic, pic1, pic2, Bio, Pen, IP, Enviar;
        public Form1()
        {
            InitializeComponent();
        }
        void Zerar()
        {
            pic    = null;
            pic1   = null;
            pic2   = null;
            Bio    = null;
            Pen    = null;
            IP     = null;
            Enviar = null;
        }
        void Limpar()
        {
            Zerar();
            txtFabricante.Text = "";
            txtModelo.Text = "";
            txtTipo.Text = "";
            txtCNPJ.Text = "";
            txtSenha.Text = "";
            txtWeb.Text = "";
            txtOutros.Text = "";
            picImagem.Image = null;
            picCadBio.Image = null;
            picPen.Image = null;
            picIP.Image = null;
            picEnviarReceber.Image = null;
        }

        void TrixDescricao()
        {
            txtSenha.Text = "Não";
            txtWeb.Text = "Não";
            txtOutros.Text = "*NÃO Comunica por pendrive \r\n" +
                             "*Reset relogio desliga, liga com 4,5,6 apertado \r\n" +
                             "*Teste memoria (apaga), religa com 1,2,3 \r\n" +
                             "*Enviar programacao do relogio atraves do programa da Trix 7,8,9, remoto" +
                             "*Funciona on line, tem programa proprio";

            IP = "./Imagens/Trix/TrixIP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Trix/TrixBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Trix/TrixPen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            Enviar = "./Imagens/Trix/TrixEnviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
        }
        void EnterplakDescricao()
        {
            txtSenha.Text = "CPF ou 000";
            txtWeb.Text = "Não";
            txtOutros.Text = "*Não envia empresa no enviar/receber \r\n" +
                             "*V1 Não envia pen drive, Cadastro feito por teclado de pc \r\n " +
                             "*V2 envia pendrive";
            Enviar = "./Imagens/Enterplak/EnterplakEnviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
        }
        void Orion6Descricao()
        {
            txtSenha.Text = "43690";
            txtWeb.Text = "Não tem, mudar ip somente via software";
            txtOutros.Text = "*Reset, desligar, ligar segurando 5 por 3s, soltar, senha tec 43690" +
                             "\r\n Alterar para comunicacao TCP: Menu, (senha), 2, 2, 3";
            Enviar = "./Imagens/Henry/Orion6Enviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
        }
        void PrismaSF() // R02 R04
        {
            txtSenha.Text = "121314";
            txtWeb.Text = "Usuario: rep |Senha: 121314";
            txtOutros.Text = "";

            Bio = "./Imagens/Henry/PrismaSFBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Henry/PrismaSFPen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            IP = "./Imagens/Henry/PrismaSFIP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(Pen);
            }
            Enviar = "./Imagens/Henry/PrismaSFEnviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
            pic1 = "./Imagens/Henry/PrismaSFFrente.jpg";
            pic2 = "./Imagens/Henry/PrismaSFTras.jpg";
            if (File.Exists(pic1) && File.Exists(pic2))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void PrismaL() //antigo letras
        {
            txtSenha.Text = "121314";
            txtWeb.Text = "Usuario: prisma |Senha: em branco";
            txtOutros.Text = "";
            IP = "./Imagens/Henry/PrismaLIP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Henry/PrismaLCadBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Henry/PrismaLPen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            Enviar = "./Imagens/Henry/PrismaLEnviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
            pic1 = "./Imagens/Henry/PrismaLFrente.jpg";
            pic2 = "./Imagens/Henry/PrismaLTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void Orion6BioBarras()
        {
            Orion6Descricao();
            IP = "./Imagens/Henry/Orion6IP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Henry/Orion6CadBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Henry/Orion6Pen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            Enviar = "./Imagens/Henry/Orion6Enviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
            pic1 = "./Imagens/Henry/Orion6BioBarrasFrente.jpg";
            pic2 = "./Imagens/Henry/Orion6BioBarrasTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void Orion6BioProx()
        {
            Orion6Descricao();
            IP = "./Imagens/Henry/Orion6IP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Henry/Orion6CadBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Henry/Orion6Pen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            pic1 = "./Imagens/Henry/Orion6BioProxFrente.jpg";
            pic2 = "./Imagens/Henry/Orion6BioProxTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void Orion6Barras()
        {
            Orion6Descricao();
            IP = "./Imagens/Henry/Orion6IP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Henry/Orion6CadBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Henry/Orion6Pen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            pic1 = "./Imagens/Henry/Orion6BarrasFrente.jpg";
            pic2 = "./Imagens/Henry/Orion6BarrasTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void Orion6Prox()
        {
            Orion6Descricao();
            IP = "./Imagens/Henry/Orion6IP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Henry/Orion6CadBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Henry/Orion6Pen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            pic1 = "./Imagens/Henry/Orion6ProxFrente.jpg";
            pic2 = "./Imagens/Henry/Orion6ProxTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void RWImagens()
        {
            IP = "./Imagens/RW/RWIP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/RW/RWBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/RW/RWPen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            Enviar = "./Imagens/RW/RWEnviar.jpg";
            if (File.Exists(Enviar))
            {
                picEnviarReceber.Load(Enviar);
            }
            pic1 = "./Imagens/RW/RWFrente.jpg";
            pic2 = "./Imagens/RW/RWTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void RW1()
        {
            txtSenha.Text = "000";
            txtWeb.Text = "Não";
            txtOutros.Text = "*Não envia pen drive, Cadastro feito por teclado de pc";
            RWImagens();
        }
        void EnterplakBioProx()
        {
            EnterplakDescricao();
            IP = "./Imagens/Enterplak/EnterplakIP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Enterplak/EnterplakBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Enterplak/EnterplakPen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            pic1 = "./Imagens/Enterplak/EnterplakBioProxFrente.jpg";
            pic2 = "./Imagens/Enterplak/EnterplakBioProxTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void EnterplakProx()
        {
            EnterplakDescricao();
            IP = "./Imagens/Enterplak/EnterplakIP.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/Enterplak/EnterplakBio.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/Enterplak/EnterplakPen.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            pic1 = "./Imagens/Enterplak/EnterplakProxFrente.jpg";
            pic2 = "./Imagens/Enterplak/EnterplakProxTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void EnterplakBioBarrasProx()
        {
            EnterplakDescricao();
            IP = "./Imagens/.jpg";
            if (File.Exists(IP))
            {
                picIP.Load(IP);
            }
            Bio = "./Imagens/.jpg";
            if (File.Exists(Bio))
            {
                picCadBio.Load(Bio);
            }
            Pen = "./Imagens/.jpg";
            if (File.Exists(Pen))
            {
                picPen.Load(Pen);
            }
            pic1 = "./Imagens/RW/RWFrente.jpg";
            pic2 = "./Imagens/RW/RWTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void TrixBioBarras()
        {
            TrixDescricao();
            pic1 = "./Imagens/Trix/TrixBioBarrasFrente.jpg";
            pic2 = "./Imagens/Trix/TrixBioBarrasTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        void TrixBioProx()
        {
            TrixDescricao();
            pic1 = "./Imagens/Trix/TrixBioProxFrente.jpg";
            pic2 = "./Imagens/Trix/TrixBioProxTras.jpg";
            if (File.Exists(pic1) && (File.Exists(pic2)))
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
         
       
        void Procurar()
        {
            Limpar();
            if (txtProcurar.TextLength > 4)
            {
                string Fab = txtProcurar.Text.Substring(0, 5);
                if (Fab == "00001") // dentro fabricante RW
                {
                    txtFabricante.Text = "RW Tecnologia Indústria e Comércio Ltda";
                    txtCNPJ.Text = "04.231.268/0001-95";

                    if (txtProcurar.TextLength > 9) //dentro modelo
                    {
                        string Mod = txtProcurar.Text.Substring(5, 5);
                        if (Mod == "00001")
                        {
                            txtModelo.Text = "POINTLINE 1510 - CARD";
                            txtTipo.Text = "Proximidade, Teclado";
                        }
                        else if (Mod == "00045")
                        {
                            txtModelo.Text = "POINTLINE 1510 BIO PROX";
                            txtTipo.Text = "Biometria, Proximidade, Teclado";
                        }
                        else if (Mod == "00068")
                        {
                            txtModelo.Text = "POINTLINE 1510 DUOCARD BIO";
                            txtTipo.Text = "Biometria, Código de Barras, Proximidade, Teclado";
                        }
                        else if (Mod == "00069")
                        {
                            txtModelo.Text = "POINTLINE 1510 DUOCARD";
                            txtTipo.Text = "Código de Barras, Proximidade, Teclado";
                        }
                    }
                } //rw
                else if (Fab == "00002")
                {
                    txtFabricante.Text = "Trix Tecnologia LTDA (TRIX)";
                    txtCNPJ.Text = "54.481.502/0001-00";

                    if (txtProcurar.TextLength > 9) //dentro modelo
                    {
                        string Mod = txtProcurar.Text.Substring(5, 5);
                        if (Mod == "00002")
                        {
                            txtModelo.Text = "X REP-520 BB300";
                            txtTipo.Text = "Biometria, Código de Barras, Teclado";
                            TrixBioBarras();
                        }
                        else if (Mod == "00004")
                        {
                            txtModelo.Text = "X REP-520 BP11";
                            txtTipo.Text = "Biometria, Proximidade, Teclado";
                            TrixBioProx();
                        }
                        else if (Mod == "00010")
                        {
                            txtModelo.Text = "XREP-520 BP";
                            txtTipo.Text = "Biometria, Proximidade, Teclado";
                            TrixBioProx();
                        }
                        else if (Mod == "00055")
                        {
                            txtModelo.Text = "XREP-520 P";
                        }
                    }
                } // Trix
                else if (Fab == "00004") // henry
                {
                    txtFabricante.Text = "Henry Equipamentos Eletrônicos e Sistemas Ltda. (A casa do Equipamento)";
                    txtCNPJ.Text = "01.245.055/0001-24";

                    if (txtProcurar.TextLength > 9) //dentro modelo
                    {
                        string Mod = txtProcurar.Text.Substring(5, 5);
                        if (Mod == "00005")
                        {
                            txtModelo.Text = "ORION 6A";
                            txtTipo.Text = "Biometria, Proximidade, Teclado";
                            Orion6BioProx();
                        }
                        else if (Mod == "00007")
                        {
                            txtModelo.Text = "ORION 6C";
                            txtTipo.Text = "Código de Barras, Teclado";
                            Orion6Barras();
                        }
                        else if (Mod == "00008")
                        {
                            txtModelo.Text = "ORION 6B";
                            txtTipo.Text = "Biometria, Código de Barras, Teclado";
                            Orion6BioBarras();
                        }
                        else if (Mod == "00009")
                        {
                            txtModelo.Text = "ORION 6D";
                            txtTipo.Text = "Proximidade, Teclado";
                            Orion6Prox();
                        }
                        else if (Mod == "00161")
                        {
                            txtModelo.Text = "PRISMA E";
                            txtTipo.Text = "Biometria, Código de Barras, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00162")
                        {
                            txtModelo.Text = "PRISMA G";
                            txtTipo.Text = "Proximidade, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00163")
                        {
                            txtModelo.Text = "PRISMA H";
                            txtTipo.Text = "Código de Barras, Proximidade, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00164")
                        {
                            txtModelo.Text = "PRISMA I";
                            txtTipo.Text = "Proximidade, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00165")
                        {
                            txtModelo.Text = "PRISMA J";
                            txtTipo.Text = "Biometria, Proximidade, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00171")
                        {
                            txtModelo.Text = "PRISMA F";
                            txtTipo.Text = "Biometria, Proximidade, Código de Barras, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00202")
                        {
                            txtModelo.Text = "PRISMA K";
                            txtTipo.Text = "Biometria, Teclado";
                            PrismaL();
                        }
                        else if (Mod == "00204")
                        {
                            txtModelo.Text = "SUPER FÁCIL R01";
                            txtTipo.Text = "Biometria, Código de Barras, Proximidade, Teclado";
                            PrismaSF();
                        }
                        else if (Mod == "00190")
                        {
                            txtModelo.Text = "SUPER FÁCIL R02";
                            txtTipo.Text = "Biometria, Proximidade, Teclado";
                            PrismaSF();
                        }
                        else if (Mod == "00206")
                        {
                            txtModelo.Text = "SUPER FÁCIL R03";
                            txtTipo.Text = "Código de Barras, Proximidade, Teclado";
                            PrismaSF();
                        }
                        else if (Mod == "00205")
                        {
                            txtModelo.Text = "SUPER FÁCIL R04";
                            txtTipo.Text = "Biometria, Teclado";
                            PrismaSF();
                        }

                        else if (Mod == "00217")
                        {
                            txtModelo.Text = "COMPACTO R01";
                            txtTipo.Text = "Proximidade, Teclado";
                        }
                        else if (Mod == "00250")
                        {
                            txtModelo.Text = "HEXA A";
                            txtTipo.Text = "Biometria, código de barras, sensor de proximidade e leitor mifare";
                        }
                        else if (Mod == "00251")
                        {
                            txtModelo.Text = "HEXA B";
                            txtTipo.Text = "Biometria, Proximidade";
                        }
                        else if (Mod == "00252")
                        {
                            txtModelo.Text = "HEXA C";
                            txtTipo.Text = "Biometria, Código de Barras";
                        }
                        else if (Mod == "00253")
                        {
                            txtModelo.Text = "HEXA D";
                            txtTipo.Text = "Biometria, leitor mifare";
                        }
                        else if (Mod == "00254")
                        {
                            txtModelo.Text = "HEXA E";
                            txtTipo.Text = "Código de barras, Proximidade";
                        }
                        else if (Mod == "00384")
                        {
                            txtModelo.Text = "COMPACTO S A";
                            txtTipo.Text = "Biometria, Sensor de proximidade (RFID) e Leitor mifare";
                        }
                        else if (Mod == "00385")
                        {
                            txtModelo.Text = "COMPACTO S B";
                            txtTipo.Text = "Biometria";
                        }
                    }
                } // Henry
                else if (Fab == "00008") // Proveu
                {
                    txtFabricante.Text = "Proveu Indústria Eletrônica Ltda";
                    txtCNPJ.Text = "07.020.193/0001-91";

                    if (txtProcurar.TextLength > 9) //dentro modelo
                    {
                        string Mod = txtProcurar.Text.Substring(5, 5);
                        if (Mod == "00391")
                        {
                            txtModelo.Text = "Kurumim REP3 BIO";
                            txtTipo.Text = "Teclado e biometria";
                        }
                        else if (Mod == "00007")
                        {
                            txtModelo.Text = "ORION 6C";
                            txtTipo.Text = "Código de Barras, Teclado";
                            Orion6Barras();
                        }
                    }
                } // Proveu
                else if (Fab == "00043")
                {
                    txtFabricante.Text = "Enterplak Produtos eletrônicos LTDA (RW TECH)";
                    txtCNPJ.Text = "07.013.491/0001-54";

                    if (txtProcurar.TextLength > 9) //dentro modelo
                    {
                        string Mod = txtProcurar.Text.Substring(5, 5);
                        if (Mod == "00401")
                        {
                            txtModelo.Text = "IPOINTLINE BIOPROX-C";
                            txtTipo.Text = "Proximidade (RFID) e biometria";
                            EnterplakBioProx();
                        }
                        else if (Mod == "00399")
                        {
                            txtModelo.Text = "IPOINTLINE PROX-S";
                            txtTipo.Text = "Proximidade (RFID)";
                            EnterplakProx();
                        }
                        else if (Mod == "00400")
                        {
                            txtModelo.Text = "IPOINTLINE BIOPROX-S";
                            txtTipo.Text = "Proximidade (RFID) e biometria";
                            EnterplakBioProx();
                        }
                        else if (Mod == "00402")
                        {
                            txtModelo.Text = "IPOINTLINE BIOPROX-BS";
                            txtTipo.Text = "Proximidade (RFID), biometria e codigo de barras";
                            EnterplakBioBarrasProx();
                        }
                        else if (Mod == "00403")
                        {
                            txtModelo.Text = "IPOINTLINE BIOPROX-BC";
                            txtTipo.Text = "Proximidade (RFID), biometria e codigo de barras";
                            EnterplakBioBarrasProx();
                        }
                        else if (Mod == "00404")
                        {
                            txtModelo.Text = "IPOINTLINE BIOPROX-MBC";
                            txtTipo.Text = "Proximidade (mifare), biometria e codigo de barras";
                            EnterplakBioBarrasProx();
                        }
                        else if (Mod == "00497")
                        {
                            txtModelo.Text = "IPOINTLINE PROX-C";
                            txtTipo.Text = "Identificação por RFID e teclado, e Impressora com cutter";
                            EnterplakProx();
                        }

                    }

                } // Enterplak RW

            }  // > 4
            else
            {
                MessageBox.Show("Digite pelo menos 5 numeros !", "Digitos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } // > 4
        }
        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            Procurar();
        }
        private void TxtProcurar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProcurar.TextLength > 4)
            {
                Procurar();
            }
        }
        private void PicIP_Click(object sender, EventArgs e)
        {
            if (File.Exists(IP))
            {
                frmIP _frmIP = new frmIP();
                _frmIP.ShowDialog();
            }
        }

        private void PicEnviarReceber_Click(object sender, EventArgs e)
        {
            if (File.Exists(Enviar))
            {
                frmEnviar _frmEnviar = new frmEnviar();
                _frmEnviar.ShowDialog();
            }
        }

        private void PicPen_Click(object sender, EventArgs e)
        {
            if (File.Exists(Pen))
            {
                frmPen _frmBio = new frmPen();
                _frmBio.ShowDialog();
            }
        }
        private void PicCadBio_Click(object sender, EventArgs e)
        {
            if (File.Exists(Bio))
            {
                frmBio _frmBio = new frmBio();
                _frmBio.ShowDialog();
            }
        }
        private void PicImagem_Click(object sender, EventArgs e)
        {
            if (File.Exists(pic))
            {
                frmImagem _frmImagem = new frmImagem();
                _frmImagem.ShowDialog();
            }
        }
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (pic != null)
            {
                pic = pic1;
                picImagem.Load(pic);
            }
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (pic != null)
            {
                pic = pic2;
                picImagem.Load(pic);
            }
        }

    }
}
