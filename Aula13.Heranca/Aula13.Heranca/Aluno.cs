using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13.Heranca
{
    // Colocando o :CadastroBase já declara que ele possui o nome e email da ouotra classe
    public class Aluno:CadastroBase
    {
        public string Matricula { get; set; }
    }
}
