using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06.IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero entre 1 e 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Operadores: > (Maior que)   < (Menor que)
            // Operador:   || (ou)    && (e)

            if (n < 1 || n > 10)
            {
                Console.WriteLine("Numero errado!!!");
            }
            else
            {
                Console.WriteLine("Obrigado!!!");
            }



            Console.ReadLine();

        }
    }
}
