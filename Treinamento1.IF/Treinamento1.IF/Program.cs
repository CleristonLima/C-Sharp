using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento1.IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int resultado; 

            Console.Write("Digite o numero para n1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o numero para n2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            resultado = n1 + n2;

            if (resultado >= 30)
            {
                Console.Write("O resultado é maior ou igual a 30, pois a soma dos valores foi: {0} ", resultado);

            }
            else
            {
                Console.Write("O resultado não é maior ou igual a 30, pois a soma deu: {0} ", resultado);
            }

            Console.ReadLine();
        }
    }
}
