using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DB
{
    // Helper   - Classe para acesso a dados
    public static class DB
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpresaDB;Integrated Security=True;";
            }
        }
    }
}
