using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula12.ManipulacaoDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classe Environment - Ela define a onde vai ficar gravado o arquivo na pasta

            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "teste.txt";

            // é necessário declarar no Using System.IO para gravar no (Path)
            string path = Path.Combine(pasta, arquivo);

            // Para escrever no arquivo
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("Escrevendo no arquivo de texto....");
            writer.WriteLine("Meu nome é Cleriston");
            writer.Close();

            // Para ler o arquivo
            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                Console.WriteLine(linha);
            }

            Console.ReadLine();
           
        }
    }
}
