using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento4.Comando.de.Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            decimal valor;
            int quantidade;
            decimal total;

            Console.Write("Digite o valor do produto: ");
            valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            for (i=1; i==1; i++)
            {
               if (quantidade <= 10)
                {
                    total = valor * quantidade;
                    Console.WriteLine("O valor total é de: {0:C} ", total);
                }
               else
                {
                    Console.WriteLine("A quantidade só pode ser contada até 10 unidade");
                }
            }

            Console.ReadLine();
        }

    }
}
