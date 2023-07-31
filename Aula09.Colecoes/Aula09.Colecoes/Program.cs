using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09.Colecoes
{
    class Program
    {
        // Coleçoes
        static void Main(string[] args)
        {
            // List  <Lista>
            // Queue <Fila>
            // Stack <Pilha>
            // Dictionary <Dicionario>

            Dictionary<string, string> dados = new Dictionary<string, string>();

            dados.Add("Nome", "Joao Pereira");
            dados.Add("RG", "45.327.908-3");
            dados.Add("Telefone", "(11) 3467-9078");

            Console.WriteLine(dados["Nome"]);
            Console.WriteLine(dados["RG"]);
            Console.WriteLine(dados["Telefone"]);

            // Exemplo de Pilha FILO - First In Last Ou

           /* Stack<string> pilha = new Stack<string>();
            pilha.Push("Processo 1");
            pilha.Push("Processo 2");

            while(pilha.Count > 0 )
            {
                string item = pilha.Pop();
                Console.WriteLine(item);

            }*/

            // Exemplo de Fila  FIFO - First in First Out

           /* Queue<string> fila = new Queue<string>();
            fila.Enqueue("Processo 1");
            fila.Enqueue("Processo 2");
            fila.Enqueue("Processo 3");

            while (fila.Count > 0)
            {
                string item = fila.Dequeue();
                Console.WriteLine(item);
            }*/

            // Generics

           /* List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Rio de Janeiro");

            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(50);

            foreach(string c in cidades)
            {
                Console.WriteLine(c);
            }

            foreach (int  n in numeros)
            {
                Console.WriteLine(n);
            }*/

            /*    Coleções
            ArrayList lista = new ArrayList();
            lista.Add("São Paulo");
            lista.Add("Rio de Janeiro");
            lista.Add("Belo Horizonte");

            string cidade = Convert.ToString(lista[1]);

            foreach(string cid in lista)
            {
                Console.WriteLine(cid);
            }

            lista.Remove("Belo Horizonte");
            lista.Insert(0, "Madrid");
            Console.WriteLine("-----");

            foreach (string cid in lista)
            {
                Console.WriteLine(cid);
            }

            int tamanho = lista.Count;

            Console.WriteLine("Tamanho: {0}", tamanho);*/

            Console.ReadLine();
        }
    }
}
