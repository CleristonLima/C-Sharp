using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento6.Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um array com 10 elementos

            int[] elemento = new int [10]; // esse trecho (new int [10]) define o tamanho do elemento;
            int numero;

            elemento[0] = 10;
            elemento[1] = 15;
            elemento[2] = 20;
            elemento[3] = 25;
            elemento[4] = 30;
            elemento[5] = 35;
            elemento[6] = 40;
            elemento[7] = 45;
            elemento[8] = 50;
            elemento[9] = 55;

            // Para ordenar ao contrario

            // Array.Reverse(elemento);

             foreach (int e in elemento)
             {
                 Console.WriteLine("Esse array é do elemento {0}", e);

             }

            Console.Write("Digite o número para identificar sua posição: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int posicao = Array.IndexOf(elemento, numero);

            if (posicao == -1)
            {
                Console.Write("Não exite esse elemento!!");               
            }
            else
            {
                Console.Write("O elemento {0} esta na posição: {1}", elemento[posicao], posicao);
                
            }

            Console.ReadLine();

        }
    }
}
