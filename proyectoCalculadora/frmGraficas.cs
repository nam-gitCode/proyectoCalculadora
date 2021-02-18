using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoCalculadora
{
    public partial class frmGraficas : Form
    {
        public frmGraficas()
        {
            InitializeComponent();
        }

        private void btnGraf1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 40; j++)
                chart1.Series["F1"].Points.AddXY(j, j * j);
        }
    }
}
