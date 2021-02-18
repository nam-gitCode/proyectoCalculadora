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
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
        }

        operacionesBasicas opBasicas = new operacionesBasicas();
        operacionesUnarias opUnarias = new operacionesUnarias();
        funcionesTrigonometricas opTrigonometricas = new funcionesTrigonometricas();

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "/";
        }

        private void btnNCien_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "*10^(";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "π";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "^(";
        }

        private void btnParentecisA_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "(";
        }

        private void btnParentecisB_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ")";
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "sin(";
        }

        private void btnSenoInverso_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "aSin(";
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "cos(";
        }

        private void btnCosenoInverso_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "aCos(";
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "tan(";
        }

        private void btnTangenteInversa_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "aTan(";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "√(";
        }

        private void btnLogaritmoNatural_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "ln(";
        }

        private void btnLogaritmoBase10_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "log10(";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "e^(";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "%";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Logica
            string operacion = txtPantalla.Text;
            char[] delimitador = {'*','/','-'};
            string[] valores = operacion.Split(delimitador);

            for(int i=0; i < valores.Length; i++)
            {
                lblPruebas.Text += valores[i] + "\n";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
        }

        
    }
}
