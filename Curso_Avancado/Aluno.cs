using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Avancado
{
    class Aluno
    {
        public String Nome;
        public double n1, n2, n3;
        public double NotaFinal()
        {
            return n1 + n2 + n3;
        }

        public string Resultado()
        {
            if (NotaFinal() >= 60.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
                
            }

        }
        public double Recuperacao()
        {
            Double med = 60.0;
            return med-NotaFinal();
         
        }
    }
}
