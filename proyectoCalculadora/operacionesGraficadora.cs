using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class operacionesGraficadora:operadores
    {
        operacionesBasicas opBasicas = new operacionesBasicas();
        operacionesUnarias opUnarias = new operacionesUnarias();
        public double encontrarPiAtras(List<string> operacion,int posicion)
        {
            if (operacion[posicion - 1] == "π")
            {
                Operando1 = Math.PI;
            }
            else
            {
                Operando1 = double.Parse(operacion[posicion - 1]);
            }
            return Operando1;
        }

        public double encontrarPiDelante(List<string> operacion, int posicion)
        {
            if (operacion[posicion + 1] == "π")
            {
                Operando2 = Math.PI;
            }
            else
            {
                Operando2 = double.Parse(operacion[posicion + 1]);
            }
            return Operando2;
        }

        public string calcular(List<string> operacion)
        {

            int x = 0;
            double tmpResultado = 0;
            int jerarquia = 0;
            int posicion = 0;

            while (operacion.Count > 1)
            {
                for (int i = 0; i < operacion.Count; i++)
                {
                    if (operacion[i] == "+" || operacion[i] == "-" || operacion[i] == "*" || operacion[i] == "/" || operacion[i] == "^" || operacion[i] == "√")
                    {
                        if (operacion[i] == "+")
                        {
                            x = 2;
                            if (x > jerarquia)
                            {
                                posicion = i;
                                jerarquia = x;
                            }
                        }
                        else if (operacion[i] == "-")
                        {
                            x = 2;
                            if (x > jerarquia)
                            {
                                posicion = i;
                                jerarquia = x;
                            }
                        }
                        else if (operacion[i] == "*")
                        {
                            x = 4;
                            if (x > jerarquia)
                            {
                                posicion = i;
                                jerarquia = x;
                            }
                        }
                        else if (operacion[i] == "/")
                        {
                            x = 4;
                            if (x > jerarquia)
                            {
                                posicion = i;
                                jerarquia = x;
                            }
                        }
                        else if (operacion[i] == "√")
                        {
                            x = 6;
                            if (x > jerarquia)
                            {
                                posicion = i;
                                jerarquia = x;
                            }
                        }
                        else if (operacion[i] == "^")
                        {
                            x = 6;
                            if (x > jerarquia)
                            {
                                posicion = i;
                                jerarquia = x;
                            }
                        }
                    }
                }

                if (jerarquia == 4)
                {
                    if (operacion[posicion] == "*")
                    {
                        encontrarPiAtras(operacion,posicion);
                        encontrarPiDelante(operacion,posicion);
                        tmpResultado = opBasicas.multiplicar(Operando1,Operando2);
                        operacion[posicion - 1] = tmpResultado.ToString();
                        operacion.RemoveAt(posicion);
                        operacion.RemoveAt(posicion);
                    }
                    else if (operacion[posicion] == "/")
                    {
                        encontrarPiAtras(operacion, posicion);
                        encontrarPiDelante(operacion, posicion);
                        tmpResultado = opBasicas.dividir(Operando1, Operando2);
                        operacion[posicion - 1] = tmpResultado.ToString();
                        operacion.RemoveAt(posicion);
                        operacion.RemoveAt(posicion);
                    }
                }
                else if (jerarquia == 2)
                {
                    if (operacion[posicion] == "+")
                    {
                        encontrarPiAtras(operacion, posicion);
                        encontrarPiDelante(operacion, posicion);
                        tmpResultado = opBasicas.sumar(Operando1, Operando2);
                        operacion[posicion - 1] = tmpResultado.ToString();
                        operacion.RemoveAt(posicion);
                        operacion.RemoveAt(posicion);
                    }
                    else if (operacion[posicion] == "-")
                    {
                        encontrarPiAtras(operacion, posicion);
                        encontrarPiDelante(operacion, posicion);
                        tmpResultado = opBasicas.restar(Operando1, Operando2);
                        operacion[posicion - 1] = tmpResultado.ToString();
                        operacion.RemoveAt(posicion);
                        operacion.RemoveAt(posicion);
                    }
                }
                else if (jerarquia == 6)
                {
                    if (operacion[posicion] == "^")
                    {
                        encontrarPiAtras(operacion, posicion);
                        encontrarPiDelante(operacion, posicion+1);
                        tmpResultado = opUnarias.Potencia(Operando1,Operando2);
                        operacion[posicion - 1] = tmpResultado.ToString();
                        if (operacion[posicion + 3] == ")")
                        {
                            operacion.RemoveAt(posicion);
                            operacion.RemoveAt(posicion);
                            operacion.RemoveAt(posicion);
                            operacion.RemoveAt(posicion);
                        }
                        else
                        {
                            //operacion.Remove(operacion[posicion]); -> Por si hay mas operaciones en la potencia.
                        }
                    }
                    else if (operacion[posicion] == "√")
                    {
                        Operando1 = double.Parse(operacion[posicion + 2]);
                        tmpResultado = opUnarias.Raiz(Operando1);
                        operacion[posicion] = tmpResultado.ToString();
                        if (operacion[posicion + 3] == ")")
                        {
                            operacion.RemoveAt(posicion+1);
                            operacion.RemoveAt(posicion+1);
                            operacion.RemoveAt(posicion+1);
                        }
                        else
                        {
                            //operacion.Remove(operacion[posicion]); -> Por si hay mas operaciones en la raiz.
                        }
                    }
                }

                jerarquia = 0;
            }

            return operacion[0];
        }
    }
}
