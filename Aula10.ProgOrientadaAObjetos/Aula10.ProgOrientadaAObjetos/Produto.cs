using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10.ProgOrientadaAObjetos
{
    public class Produto
    {
        // Campos (fields)
        private string nome;
        private decimal preço;


        // Quando faz isso, ele cria um campo automaticamente private e ja faz um get e set, sem ver o que acontece 
        public string Fornecedor { get; set; }
        
        // Propriedades

            public decimal Preço
        {
            get
            {
                return preço;
            }
            set
            {
                if (value >= 0)
                {
                    preço = value;
                }
                else
                {
                    preço = 0;
                }
            }
        }
        public string Nome
        {
            get {
                return nome;
            }

            set {
                // value é uma palavra reservada
                if (value.Length < 3)
                {
                    nome = "Errrrroooooouuuuuu....";
                }
                else
                {
                    nome = value;

                }
            }

        }
    }
}
