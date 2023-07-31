using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Ativ01
{
    class Program
    {
        // Realizando a multiplicação de dois valores
        static void Main(string[] args)
        {
            // Obter os Valores
            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            // Multiplicar

            decimal resultado = quantidade * valor;

            // Exibir

            Console.WriteLine("Total da compra:{0:c}", resultado);
            Console.ReadLine();
        }
    }
}
