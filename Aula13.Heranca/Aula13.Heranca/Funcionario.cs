using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13.Heranca
{
    public class Funcionario:CadastroBase
    {
        public string Cargo { get; set; }

        public decimal salario { get; set; }
    }
}
