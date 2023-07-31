using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento2.IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j1;
            int j2;
            decimal resultado;

            Console.Write("Digite 1 para somar, 2 para subtrair, 3 para multiplicar e 4 para dividir: ");
            i = Convert.ToInt32(Console.ReadLine());


            if (i == 1)
            {
                Console.Write("Você escolheu somar, por favor digite o primeiro número: ");
                j1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Por favor digite o segundo numero: ");
                j2 = Convert.ToInt32(Console.ReadLine());

                resultado = j1 + j2;

                Console.Write("O resultado da soma é: {0} + {1} = {2}", j1, j2, resultado);

            }
            else if (i == 2 )
            {
                Console.Write("Você escolheu subtrair, por favor digite o primeiro numero: ");
                j1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Por favor digite o segundo número: ");
                j2 = Convert.ToInt32(Console.ReadLine());

                resultado = j1 - j2;

                Console.Write("O resultado da subtração é: {0} - {1} = {2}", j1, j2, resultado);

            }
            else if (i == 3)
            {
                Console.Write("Você escolheu multiplicar, por favor digite o primeiro numero: ");
                j1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Por favor digite o segundo número: ");
                j2 = Convert.ToInt32(Console.ReadLine());

                resultado = j1 * j2;

                Console.Write("O resultado da multiplicação é: {0} X {1} = {2}", j1, j2, resultado);

            }
            else if (i == 4)
            {
                Console.Write("Você escolheu dividir, por favor digite o primeiro numero: ");
                j1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Por favor digite o segundo número: ");
                j2 = Convert.ToInt32(Console.ReadLine());

                resultado = j1 / j2;

                Console.Write("O resultado da divisão é: {0} / {1} = {2}", j1, j2, resultado);
            }
            else
            {
                Console.Write("Nenhuma das opçoes foi escolhida!!!");
            }

            Console.ReadLine();
        }
    }
}
