using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Avancado
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
