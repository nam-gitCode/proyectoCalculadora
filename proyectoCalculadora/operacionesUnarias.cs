using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class operacionesUnarias : operadores
    {
        public double potencia = 0;


        public double Potencia()
        {
            return Math.Pow(this.Operando1,potencia);

        }

        public double Raiz()
        {
            return Math.Sqrt(this.Operando1);

        }

        public double LogN()
        {
            return Math.Log(this.Operando1);
        }

        public double Log10()
        {
            return Math.Log10(this.Operando1);
        }
    }
}
