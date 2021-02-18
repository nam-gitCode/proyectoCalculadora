using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class funcionesTrigonometricas : operadores
    {
        public double seno()
        {
            return Math.Sin(this.Operando1);
        }

        public double coseno()
        {
            return Math.Cos(this.Operando1);
        }

        public double tangente()
        {
            return Math.Tan(this.Operando1);
        }

        public double senoInverso()
        {
            return Math.Asin(this.Operando1);
        }

        public double cosenoInverso()
        {
            return Math.Acos(this.Operando1);
        }

        public double tangenteInversa()
        {
            return Math.Atan(this.Operando1);
        }
    }
}
