using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07.Ativ01
{
    class Program
    {
        // Tabuada
        static void Main(string[] args)
        {
            int tabuada;
            int numero;
            int resultado;

            Console.Write("Digite o número para fazer a tabuada: ");
            tabuada = Convert.ToInt32(Console.ReadLine());

            for (numero = 1; numero<=10; numero++)
            {
                resultado = tabuada * numero;
                Console.WriteLine(" {0} * {1} = {2} ", tabuada, numero, resultado);
                
            }

            Console.Write("Fim!");
            Console.ReadLine();
        }
    }
}
