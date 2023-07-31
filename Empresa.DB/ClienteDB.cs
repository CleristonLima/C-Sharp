using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;

namespace Empresa.DB
{
    public class ClienteDB
    {
        public void Incluir(Cliente cliente)
        {
            // Codigo para incluir o cliente

            string sql = @"INSERT INTO Cliente(Id, Nome, Email, Telefone) values (@Id, @Nome, @Email, @Telefone)";
            var cn = new SqlConnection(DB.Conexao);
            var cmd = new SqlCommand(sql, cn);
            
            // Parametros
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();
            
            // Irá trazer o total de registors afetados
            cmd.ExecuteNonQuery();

            cn.Close();     

        }
        public void Alterar(Cliente cliente)
        {
            // Codigo para incluir o cliente

            string sql = @"UPDATE Cliente SET Nome=@Nome, Telefone=@Telefone, Email=@Email WHERE Id=@Id ";
            var cn = new SqlConnection(DB.Conexao);
            var cmd = new SqlCommand(sql, cn);

            // Parametros
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();

            // Irá trazer o total de registors afetados
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        public void Excluir(int Id)
        {
            // Codigo para incluir o cliente

            string sql = @"DELETE Cliente WHERE Id=@Id";
            var cn = new SqlConnection(DB.Conexao);
            var cmd = new SqlCommand(sql, cn);

            // Parametros
            cmd.Parameters.AddWithValue("@Id", Id);
            cn.Open();

            // Irá trazer o total de registors afetados
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        // Para trazer a consulta por ID no ASP.NET - MVC
        public Cliente ObterPorId(int id)
        {
            string sql = "SELECT Id, Nome, Email, Telefone From Cliente where Id=@id";
            var cn = new SqlConnection(DB.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", id);

            Cliente cliente = null;

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

            }
            reader.Close();
            cn.Close();
            return cliente;
        }

        public List<Cliente> Listar()
        {

            string sql = "SELECT Id, Nome, Email, Telefone From Cliente";
            var cn = new SqlConnection(DB.Conexao);
            var cmd = new SqlCommand(sql, cn);

            List<Cliente> lista = new List<Cliente>();          

            cn.Open();

            // Vai realizar a Leitura

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                lista.Add(cliente);

            }
            reader.Close();
            cn.Close();
            return lista;
        }
    }
}
