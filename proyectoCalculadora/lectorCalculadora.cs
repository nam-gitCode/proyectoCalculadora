using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class lectorCalculadora
    {
        public List<string> cadenaOperacion (string baseOp)
        {
            List<string> cadena = new List<string>() { };
            List<string> cadenaFinal = new List<string>() { };

            string x = "";
            int contador = 0;
            string operador = "";
            string nuevoNumero = "";
            string fTrigonometricas = "";
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
                    else if (cadena[c] == "s" || cadena[c] == "i" || cadena[c] == "n" || cadena[c] == "c" || cadena[c] == "o" || cadena[c] == "t" || cadena[c] == "a" || cadena[c] == "S" || cadena[c] == "C" || cadena[c] == "T")
                    {
                        fTrigonometricas += cadena[c];
                    }
                    else if (cadena[c] != "+" || cadena[c] != "-" || cadena[c] != "*" || cadena[c] != "/" || cadena[c] != "^" || cadena[c] != "√" || cadena[c] != "(" || cadena[c] != ")" || cadena[c] != "s" || cadena[c] != "i" || cadena[c] != "n")
                    {
                        nuevoNumero += cadena[c];
                    }
                }

                if (fTrigonometricas != "")
                {
                    cadenaFinal.Add(fTrigonometricas);
                }
                cadenaFinal.Add(nuevoNumero);
                cadenaFinal.Add(operador);

                cadena.RemoveRange(0, contador);
                contador = 0;
                fTrigonometricas = "";
                nuevoNumero = "";
            }

            if(cadenaFinal[cadenaFinal.Count -1] == "+" || cadenaFinal[cadenaFinal.Count - 1] == "-" || cadenaFinal[cadenaFinal.Count - 1] == "*" || cadenaFinal[cadenaFinal.Count - 1] == "/")
            {
                cadenaFinal.RemoveAt(cadenaFinal.Count - 1);
            }
            else
            {

            }

            for (int i = 0; i < cadenaFinal.Count; i++)
            {
                cadenaFinal.Remove("");
            }

            return cadenaFinal;

        }
    }
}
