using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Atividade01
{
    //Classe
    class Program
    {
        // Metodo Principal
        static void Main(string[] args)
        {
            //Somar dois números

            int n1, n2, resultado;

            // Obtendo os valores

            Console.Write("Digite o número 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            // Processar

            resultado = n1 + n2;

            // Exibir

            Console.WriteLine("A soma de {0} + {1} = {2} .", n1, n2, resultado);
            Console.ReadLine();

        }
    }
}
