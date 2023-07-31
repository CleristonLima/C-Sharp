using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento3.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j1, j2;
            int resultado;

            Console.Write("Digite 1 para soma, 2 para subtrair, 3 para multiplicar e 4 para dividir: ");
            i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:

                    Console.Write("Digite o primeiro número: ");
                    j1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    j2 = Convert.ToInt32(Console.ReadLine());

                    resultado = j1 + j2;

                    Console.Write("O resultado de {0} + {1} = {2} ", j1, j2, resultado);
                    break;

                case 2:

                    Console.Write("Digite o primeiro número: ");
                    j1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    j2 = Convert.ToInt32(Console.ReadLine());

                    resultado = j1 - j2;

                    Console.Write("O resultado de {0} - {1} = {2} ", j1, j2, resultado);
                    break;

                case 3:

                    Console.Write("Digite o primeiro número: ");
                    j1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    j2 = Convert.ToInt32(Console.ReadLine());

                    resultado = j1 * j2;

                    Console.Write("O resultado de {0} X {1} = {2} ", j1, j2, resultado);
                    break;

                case 4:

                    Console.Write("Digite o primeiro número: ");
                    j1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    j2 = Convert.ToInt32(Console.ReadLine());

                    resultado = j1 / j2;

                    Console.Write("O resultado de {0} / {1} = {2} ", j1, j2, resultado);
                    break;

                default:

                    Console.Write("Não existe essa operação!!!");
                    break;
          }

          Console.ReadLine();

        }
    }
}
