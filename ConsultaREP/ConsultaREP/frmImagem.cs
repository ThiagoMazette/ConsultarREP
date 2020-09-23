using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsultaREP
{
    public partial class frmImagem : Form
    {
        public frmImagem()
        {
            InitializeComponent();
        }

        private void FrmImagem_Load(object sender, EventArgs e)
        {
            picImagemBig.Load(Form1.pic);
            AutoScroll = true;
        }
    }
}
