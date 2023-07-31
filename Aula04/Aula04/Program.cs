using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis
            string nome;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            int dias = idade * 365;

            Console.WriteLine("Olá {0}, você ja viveu {1} dias.", nome, dias);   // É utilizado String de formatação
            Console.ReadLine();

        }
    }
}
