using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10.ProgOrientadaAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto da classe Calculo
            // Criando uma instancia da classe Calculos

            Calculos calc = new Calculos();
            
            int total = calc.Somar (5, 5, 30);
            int resto = calc.Subtrair (10, 4);

            Console.WriteLine("Total: {0}", total);
            Console.WriteLine("Resto: {0}", resto);

            Produto prod = new Produto();
            prod.Nome = "Blusa";
            prod.Preço = -50;

            Console.WriteLine("Nome: {0}", prod.Nome);
            Console.WriteLine("Preço: {0:c}", prod.Preço);
            

            Console.ReadLine();

        }
    }
}
