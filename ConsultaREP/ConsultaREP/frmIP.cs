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
    public partial class frmIP : Form
    {
        public frmIP()
        {
            InitializeComponent();
        }

        private void FrmIP_Load(object sender, EventArgs e)
        {
            picIPBig.Load(Form1.IP);
            AutoScroll = true;
        }
    }
}
