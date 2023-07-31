using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // para não repetir o Impostos impostos, pode utilizar o var, por exemplo:
            // var impostos = new Impostos();

            var impostos = new Impostos(0.10m);
            var impostos1 = new Impostos();

            // Com o metodo estatico, pode chamar diretamente da classe e não cria o (new)
            decimal valorISS = impostos.CalcularISS("SP", 500);
            decimal valorIssIndividual = impostos.CalcularISS("SP", 500, true);

            Console.WriteLine("O valor do ISS em São Paulo: {0:c}", valorISS);
            Console.WriteLine("O valor do ISS em São Paulo para empresa individual: {0:c}", valorIssIndividual);

            Console.ReadLine();


        }
    }
}
