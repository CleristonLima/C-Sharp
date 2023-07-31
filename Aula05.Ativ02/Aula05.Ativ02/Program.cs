using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Ativ02
{
    class Program
    {
        // Fazendo o calculo de parcelas
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da compra: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas: ");
            int parcela = Convert.ToInt32(Console.ReadLine());

            decimal total = valor / parcela;

            Console.WriteLine("O valor total por parcela é de {0:c}, em {1} parcelas.", total, parcela);
            Console.ReadLine();
        }
    }
}
