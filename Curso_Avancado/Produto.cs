using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso_Avancado
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }//AutoPropreties
        private int _quantidade;

        //Construtor

        public Produto() { }
        public Produto(String nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }
        public Produto(String nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = 0;
        }
        //Versão Propietes
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length >= 1)
                {
                    _nome = value;
                }
            }

        }
        public int Quantidade
        {
            get { return _quantidade; }
        }

        
        /*Get e Set
      
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double GetPreco()
        {
            return _preco;
        }*/
        //Calcula o valor total no estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }
        //Realiza uma soma na quantidade de produtos.
        public void AdicionarProduto(int quantia)
        {
            _quantidade += quantia;
        }

        public void RetiraProduto(int quantia)
        {
            _quantidade -= quantia;
        }

        //Mostra a String final
        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
