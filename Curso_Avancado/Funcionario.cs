using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Avancado
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;

        public double SalarioLiquido()
        {
            return salario - imposto;
        }
        public void AumentarSalario(double valor)
        {
            salario +=  valor/100*salario;
        }
        public override string ToString()
        {
            return "Funcionário: " + nome + ", $" + SalarioLiquido();
        }
    }
}
