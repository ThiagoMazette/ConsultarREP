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
    public partial class frmPen : Form
    {
        public frmPen()
        {
            InitializeComponent();
        }

        private void FrmPen_Load(object sender, EventArgs e)
        {
            picPenBig.Load(Form1.Pen);
            AutoScroll = true;
        }
    }
}
