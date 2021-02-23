using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class funcionesTrigonometricas : operadores
    {
        public double seno(double n1)
        {
            n1 = n1 * (Math.PI / 180);
            return Math.Sin(n1);
        }

        public double coseno(double n1)
        {
            n1 = n1 * (Math.PI / 180);
            return Math.Cos(n1);
        }

        public double tangente(double n1)
        {
            n1 = n1 * (Math.PI / 180);
            return Math.Tan(n1);
        }

        public double senoInverso(double n1)
        {
            n1 = Math.Asin(n1);
            return n1*(180/Math.PI);
        }

        public double cosenoInverso(double n1)
        {
            n1 = Math.Acos(n1);
            return n1 * (180 / Math.PI);
        }

        public double tangenteInversa(double n1)
        {
            n1 = Math.Atan(n1);
            return n1 * (180 / Math.PI);
        }
    }
}
