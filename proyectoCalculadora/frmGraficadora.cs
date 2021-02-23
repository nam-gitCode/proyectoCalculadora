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
    public partial class frmGraficadora : Form
    {
        public frmGraficadora()
        {
            InitializeComponent();
        }

        operacionesGraficadora opG = new operacionesGraficadora();

        private void frmGraficadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarGraf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {

            string baseOp = txtFuncion.Text;
            List<string> cadena = new List<string>() { };
            List<string> cadenaFinal = new List<string>() { };

            string x = "";
            int contador = 0;
            string operador = "";
            string nuevoNumero = "";
            char[] conversion;

            conversion = baseOp.ToCharArray();

            for (int i = 0; i < conversion.Length; i++)
            {
                x = conversion[i].ToString();
                cadena.Add(x);
            }

            while (cadena.Count > 0)
            {
                for (int c = 0; c < cadena.Count; c++)
                {
                    contador = contador + 1;
                    if (cadena[c] == "+")
                    {
                        operador = "+";
                        break;
                    }
                    else if (cadena[c] == "-")
                    {
                        operador = "-";
                        break;
                    }
                    else if (cadena[c] == "*")
                    {
                        operador = "*";
                        break;
                    }
                    else if (cadena[c] == "/")
                    {
                        operador = "/";
                        break;
                    }
                    else if (cadena[c] == "^")
                    {
                        operador = "^";
                        break;
                    }
                    else if (cadena[c] == "√")
                    {
                        operador = "√";
                        break;
                    }
                    else if (cadena[c] == "(")
                    {
                        operador = "(";
                        break;
                    }
                    else if (cadena[c] == ")")
                    {
                        operador = ")";
                        break;
                    }
                    else if (cadena[c] != "+" || cadena[c] != "-" || cadena[c] != "*" || cadena[c] != "/" || cadena[c] != "^" || cadena[c] != "√" || cadena[c] != "(" || cadena[c] != ")")
                    {
                        nuevoNumero += cadena[c];
                    }
                }

                cadenaFinal.Add(nuevoNumero);
                cadenaFinal.Add(operador);

                cadena.RemoveRange(0, contador);
                contador = 0;
                nuevoNumero = "";
            }

            cadenaFinal.RemoveAt(cadenaFinal.Count - 1);

            for(int i = 0; i < cadenaFinal.Count; i++)
            {
                cadenaFinal.Remove("");
            }

            List<string> funcion = cadenaFinal;
            
            List<string> tmpLista = new List<string>() { };
            int ejeX = -2;

            for(int ejeY = 0; ejeY < 5; ejeY++)
            {
                for (int i = 0; i < funcion.Count; i++)
                {
                    if (funcion[i] == "x")
                    {
                        tmpLista.Add(ejeX.ToString());
                    }
                    else
                    {
                        tmpLista.Add(funcion[i]);
                    }
                }
                chrGrafica.Series["f(x)"].Points.AddXY(Convert.ToDouble(ejeX),double.Parse(opG.calcular(tmpLista)));
                tmpLista.Clear();
                ejeX = ejeX + 1;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chrGrafica.Series["f(x)"].Points.Clear();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            txtFuncion.Text += "^";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtFuncion.Text += "π";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            txtFuncion.Text += "√";
        }
    }
}
