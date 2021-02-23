using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class operacionesBasicas : operadores
    {
        public double sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
