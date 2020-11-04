using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Avancado
{
    class ConversorMoeda
    {
        public static double IOF = 0.06;

        public static double Conversao(double cot, double qt)
        {
            double appIOF = (cot * qt) * IOF;
            return (cot * qt) + appIOF;
        }
    }
}
