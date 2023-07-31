using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ06.Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valorCompra;
           // int numeroParcelas;
            decimal valorParcela;

            Console.Write("Digite o valor da compra: ");
            valorCompra = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Valor a vista: {0:c} ", valorCompra);

            if (valorCompra >= 1000 && valorCompra <= 1499)
            {
                valorParcela = valorCompra / 3;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 3, valorParcela);

            }
            else if (valorCompra >= 1500 && valorCompra <= 1999)
            {
                valorParcela = valorCompra / 4;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 4, valorParcela);

            }

            else if (valorCompra >= 2000 && valorCompra <= 2499)
            {
                valorParcela = valorCompra / 5;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 5, valorParcela);
            }

            else if (valorCompra >= 2500 && valorCompra <= 2999)
            {
                valorParcela = valorCompra / 6;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 6, valorParcela);
            }
            else if (valorCompra >= 3000 && valorCompra <= 3499)
            {
                valorParcela = valorCompra / 7;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 7, valorParcela);
  
            }
            else if (valorCompra >= 3500 && valorCompra <= 3999)
            {
                valorParcela = valorCompra / 8;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 8, valorParcela);

            }
            else if (valorCompra >= 4000 && valorCompra <= 4499)
            {
                valorParcela = valorCompra / 9;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 9, valorParcela);

            }
            else if (valorCompra >= 4500)
            {
                valorParcela = valorCompra / 10;
                Console.Write("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c} ", 10, valorParcela);

            }

            Console.ReadLine();
        }
    }
}
