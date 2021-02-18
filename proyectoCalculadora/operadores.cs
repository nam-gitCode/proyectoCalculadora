using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class operadores
    {
        private double operando1 = 0;
        private double operando2 = 0;
        private string operador = "";

        //getter & setter
        public double Operando1
        {
            get
            {
                return this.operando1;
            }
            set
            {
                this.operando1 = value;
            }
        }
        public double Operando2
        {
            get
            {
                return this.operando2;
            }
            set
            {
                this.operando2 = value;
            }
        }
        public string Operador
        {
            get
            {
                return this.operador;
            }
            set
            {
                this.operador = value;
            }
        }
    }
}
