using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class operacionesBasicas : operadores
    {
        public double sumar()
        {
            return this.Operando1 + Operando2;
        }

        public double restar()
        {
            return this.Operando1 - this.Operando2;
        }

        public double multiplicar()
        {
            return this.Operando1 * this.Operando2;
        }

        public double dividir()
        {
            return this.Operando1 / this.Operando2;
        }
    }
}
