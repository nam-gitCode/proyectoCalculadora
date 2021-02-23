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
        operadores simbolos = new operadores();
        lectorCalculadora ltCalcu = new lectorCalculadora();
        operacionesCalculadora opCalculadora = new operacionesCalculadora();

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
            simbolos.Operador = "suma";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "-";
            simbolos.Operador = "resta";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "*";
            simbolos.Operador = "multi";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "/";
            simbolos.Operador = "div";
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
            txtPantalla.Text += "e";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "%";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string baseOp = txtPantalla.Text;
            txtOperacion.Enabled = true;
            txtOperacion.Text = baseOp;
            txtOperacion.Enabled = false;
            List<string> operacionBase = ltCalcu.cadenaOperacion(baseOp);

            txtPantalla.Text = Math.Round(double.Parse(opCalculadora.calcular(operacionBase)),9).ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPantalla.Text))
            {

            }
            else
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            txtOperacion.Enabled = true;
            txtOperacion.Text = "";
            txtOperacion.Enabled = false;
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            frmGraficadora formGrafica = new frmGraficadora();
            formGrafica.Show();
            MessageBox.Show("Instrucciones:\n   *La variable introducida siempre debe ser x\n   *Cerrar siempre los paréntesis abiertos\n   *Acompañar siempre a la variable x de su operador: \n       No Permitido: 2x\n       Permitido: 2*x \n  *No se grafican funciones con más de 1 variable");
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "!";
        }

        private void txtPantalla_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    string baseOp = txtPantalla.Text;
                    txtOperacion.Enabled = true;
                    txtOperacion.Text = baseOp;
                    txtOperacion.Enabled = false;
                    List<string> operacionBase = ltCalcu.cadenaOperacion(baseOp);

                    txtPantalla.Text = Math.Round(double.Parse(opCalculadora.calcular(operacionBase)), 9).ToString();
                    break;
                case Keys.Back:
                    if(string.IsNullOrEmpty(txtPantalla.Text))
                    {

                    }
                    else
                    {
                        txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
                        txtPantalla.SelectionStart = txtPantalla.Text.Length;
                    }
                    break;
            }
        }

        private void btnCorcheteA_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "[";
        }

        private void btnCorcheteC_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "]";
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Integrantes:\n    Kevin Estuardo Secay Estrada - 2000083\n    Esdras Alejandro Salazar Carranza - 2000158\n    Magdiel David López González - 2000171\n    Sergio Noel Perez Quiroa-2000154\n\nInstrucciones:\n *Para ingresar operaciones anidadas utilizar [\n       Ejemplo: 2+[3*4-2+[81/√(3)]]\n *Cerrar el parentesis en las operaciones como raiz, potencia, sen, etc.");
        }
    }
}
