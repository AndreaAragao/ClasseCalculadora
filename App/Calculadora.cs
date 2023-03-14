using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos09.App
{
    internal class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculadora(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public double Soma()
        {
            return Numero1 + Numero2;
        }
        public double Subtracao()
        {
            return Numero1 - Numero2;

        }
        public double Multiplicacao()
        {
            return Numero1 * Numero2;

        }
        public double Divisao()
        {
            return Numero1 / Numero2;

        }
    }
}
