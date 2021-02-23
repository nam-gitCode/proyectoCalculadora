using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class lectorCalculadora
    {
        operacionesCalculadora opCalculadora = new operacionesCalculadora();
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
            bool verificarCorchete = true;
            int corcheteRango = 0;
            int contadorPosicion = 0;
            int contadorPosicion2 = 0;

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
                    else if (cadena[c] == "%")
                    {
                        operador = "%";
                        break;
                    }
                    else if (cadena[c] == "!")
                    {
                        operador = "!";
                        break;
                    }
                    else if (cadena[c] == "[")
                    {
                        operador = "[";
                        break;
                    }
                    else if (cadena[c] == "]")
                    {
                        operador = "]";
                        break;
                    }
                    else if (cadena[c] == "s" || cadena[c] == "i" || cadena[c] == "n" || cadena[c] == "c" || cadena[c] == "o" || cadena[c] == "t" || cadena[c] == "a" || cadena[c] == "S" || cadena[c] == "C" || cadena[c] == "T" || cadena[c] == "l"|| cadena[c]=="g")
                    {
                        fTrigonometricas += cadena[c];
                    }
                    else if (cadena[c] != "+" || cadena[c] != "-" || cadena[c] != "*" || cadena[c] != "/" || cadena[c] != "^" || cadena[c] != "√" || cadena[c] != "(" || cadena[c] != ")" || cadena[c] != "s" || cadena[c] != "i" || cadena[c] != "n")
                    {
                        if (cadena[c] == "1" || cadena[c] == "0")
                        {
                            if(cadena[c] == "1" && fTrigonometricas == "log")
                            {
                                fTrigonometricas += cadena[c];
                            }
                            else if(cadena[c] == "0" && fTrigonometricas == "log1")
                            {
                                fTrigonometricas += cadena[c];
                            }
                            else
                            {
                                nuevoNumero += cadena[c];
                            }
                        }
                        else
                        {
                            nuevoNumero += cadena[c];
                        }
                        
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
            // Inicio Anidados

            while(verificarCorchete == true)
            {
                verificarCorchete = false;
                for (int i = 0; i < cadenaFinal.Count; i++)
                {
                    if (cadenaFinal[i] == "[")
                    {
                        contadorPosicion = i;
                        contadorPosicion2 = i;
                        corcheteRango = corcheteRango + 1;
                    }
                }

                List<string> tmpCadenaCorchete = new List<string>() { };

                for (int i = contadorPosicion; i < cadenaFinal.Count; i++)
                {
                    if (cadenaFinal[contadorPosicion] != "]")
                    {
                        string datoCor = cadenaFinal[contadorPosicion];
                        contadorPosicion = contadorPosicion + 1;
                        tmpCadenaCorchete.Add(datoCor);
                    }
                    else
                    {
                        break;
                    }
                }
                tmpCadenaCorchete.RemoveAt(0);
                cadenaFinal[contadorPosicion2] = opCalculadora.calcular(tmpCadenaCorchete);
                cadenaFinal.RemoveRange(contadorPosicion2 + 1, contadorPosicion - contadorPosicion2);

                for (int i = 0; i < cadenaFinal.Count; i++)
                {
                    if (cadenaFinal[i] == "[")
                    {
                        verificarCorchete = true;
                    }
                }
            }

            // Final Pruebas
            return cadenaFinal;

        }
    }
}
