using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se colocar o String.Empty ele vai passar valor vazio ou colocando "".

            int hora = DateTime.Now.Hour;
            string mensagem = string.Empty;
            switch (hora)
            {
                case 10:
                case 15:
                    mensagem = "Hora do intervalo";
                    break;

                case 12:
                    mensagem = "Hora do almoço";
                    break;
                    
                default:
                    mensagem = "";
                    break;
            }
                       
            Console.ReadLine();
        }
    }
}
