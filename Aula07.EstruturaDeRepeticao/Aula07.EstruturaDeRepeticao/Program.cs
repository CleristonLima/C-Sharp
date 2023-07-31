using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07.EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variação do While para verificar embaixo   ---- do

            string senha = "123";
            string senhaInformada = string.Empty;

            do
            {
                Console.Write("Digite a senha: ");
                senhaInformada = Console.ReadLine();

                if(senhaInformada != senha)
                {
                    Console.WriteLine("Senha Incorreta");
                }

            } while (senhaInformada != senha);

            Console.WriteLine("Fim!");


            // Para saber quantas vezes vai repetir

            /* int x = 1;
             while(x <= 10)
             {
                 Console.WriteLine(x);
                 x++;

             }*/


            // while (condição){ }
            // Operadores ! (não)  == igual     != diferente
            /*  string senha = "123";
              string senhaInformada = string.Empty;

              while(senha!= senhaInformada)
              {
                  Console.Write("Digite a senha: ");
                  senhaInformada = Console.ReadLine();

              }
              Console.WriteLine("Fim!");*/



            // for (inicia; condição; incremento) {}
            // Operador ++

            /*for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                
            }*/
            Console.ReadLine();
        }
    }
}
