using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Olá");
            // int X = 10;
            // Console.Write(X);


            // Para trazer o dia de hoje

            DayOfWeek dia = DateTime.Now.DayOfWeek;
            Console.WriteLine(dia);
            Console.WriteLine((int)dia);

            Console.ReadLine();

        }
    }
}
