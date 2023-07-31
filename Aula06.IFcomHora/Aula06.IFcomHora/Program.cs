using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06.IFcomHora
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = DateTime.Now.Hour;
            if (hora > 17)
            {
                Console.WriteLine("Boa Noite!!");

            }
            else if (hora > 11)
            {
                Console.WriteLine("Boa Tarde!!");
            }
            else
            {
                Console.WriteLine("Bom dia!!");

            }

            Console.ReadLine();
        }
    }
}
