using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ06
{
    class Program
    {
        // Criado regra de pagamento com a estrutura de decisão
        static void Main(string[] args)
        {

            // Formas de pagamento
            // Se o valor da compra for maior que 1000 reais pode parcelar em 3x
            // Senão somente a vista

            decimal valorCompra;
            int numeroParcelas = 3;
            decimal valorParcela;
            decimal valorMinimoParcelar = 1000;

            Console.Write("Digite o valor da compra: ");
            valorCompra = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Valor a vista: {0:c} ", valorCompra);

            if(valorCompra >= valorMinimoParcelar)
            {
                valorParcela = valorCompra / numeroParcelas;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", numeroParcelas, valorParcela);

            }

            Console.ReadLine();
        }
    }
}
