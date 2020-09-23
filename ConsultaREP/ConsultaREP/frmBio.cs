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
    public partial class frmBio : Form
    {
        public frmBio()
        {
            InitializeComponent();
        }

        private void FrmBio_Load(object sender, EventArgs e)
        {
            picBioBig.Load(Form1.Bio);
            AutoScroll = true;
        }
    }
}
