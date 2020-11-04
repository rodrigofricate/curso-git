using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_Avancado
{
    class Banco
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Deposito { get; private set; }
        //Construtor
        public Banco()
        {

        }
        public Banco(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
            Deposito = 0.0;
        }
        
        public Banco(string nome, int conta, double deposito) : this(nome, conta)
        {
            Deposito = deposito;
        }

        //metodos
        public string MostrarConta()
        {
            return "Conta: " + Conta + ", Titular: " + Nome + ", Saldo: $" + Deposito.ToString("F2", CultureInfo.InvariantCulture);
        }

        public double AddDeposito(double quantia)
        {
            return Deposito += quantia;
        }

        public double Saque(double quantia)
        {
            
           return Deposito -= (quantia + 5.0);
           
        }
        //override
        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + Nome + ", Saldo: $" + Deposito;
        }
    }
}
