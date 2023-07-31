using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.TiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");

            string nome = "Jose";

            // Numeros Inteiros
            short quantidade = 100;             //Int16
            int numero = 20;                    //Int32
            long numerogrande = 3200000;        //Int64

            // Os principais
            byte item = 20;                     // Tamanho de 0 a 255 e serve para armazenar bytes, arquivos.
            double comissao = 32.45456723;      // O double tem número grande.
            decimal valor = 1000;               // Decimal serve para valores unitarios.

            // Tipos de data

            DateTime data = DateTime.Now;                           // Traz a data e hora atual.
            DateTime dataExemplo = new DateTime(2050, 10, 29);      // Traz a data especifica e pode colocar hora minuto e segundo.

            // Formatar a data

            Console.WriteLine("{0:d}", dataExemplo);
            Console.WriteLine("{0:D}", dataExemplo);
            Console.WriteLine("{0:ddd}", dataExemplo);
            Console.WriteLine("{0:dddd}", dataExemplo);

            // Formato Moeda
            Console.WriteLine("{0:c}", valor);                          
            Console.ReadLine();
        }
    }
}
