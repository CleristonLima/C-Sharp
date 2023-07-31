using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Ativ02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Divisão

            int n1, n2, quociente;

            Console.Write("Digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            quociente = n1 / n2;

            Console.WriteLine("A divisão de {0} e {1} é: {2}. ", n1, n2, quociente);
            Console.ReadLine();

        }
    }
}
