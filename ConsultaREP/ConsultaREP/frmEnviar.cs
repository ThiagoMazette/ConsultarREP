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
    public partial class frmEnviar : Form
    {
        public frmEnviar()
        {
            InitializeComponent();
        }

        private void FrmEnviar_Load(object sender, EventArgs e)
        {
            picEnviarReceberBig.Load(Form1.Enviar);
            AutoScroll = true;
        }
    }
}
