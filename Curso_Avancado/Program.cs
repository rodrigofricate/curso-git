using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Curso_Avancado
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int negativo = 0;
            double[,] matriz = new double[N, N];

            for (int Linha = 0; Linha < N; Linha++)
            {
                string[] add = Console.ReadLine().Split(' ');
                for (int Coluna = 0; Coluna < N; Coluna++)
                {
                    
                    matriz[Linha, Coluna] = double.Parse(add[Coluna]);
                   
                    if (matriz[Linha, Coluna] < 0)
                    {
                        negativo += 1;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal principal:");
                    for (int Linha=0; Linha<N; Linha++)
            {
                for(int Coluna=0; Coluna<N; Coluna++)
                {
                    if (Linha == Coluna)
                    {
                        Console.Write(matriz[Linha,Coluna]+", ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negativos: "+negativo);


        }//Main




    }//Class


}//Name Espace




