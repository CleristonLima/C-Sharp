using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula16.CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Metodo para exibir a mensagem da Conexão

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Classes

            // SQL Server

            // SqlConnection
                // ConnectionString
                // Open()
                // Close()

            // SqlCommand - Propriedades
                // Connection
                // CommandText
                // ExecuteReader()
                // ExecuteNonQuery()
                // ExecuteScalar()

            // SqlDataReader
                // Read()

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";
            cn.Open();
            Mensagem("Conexão Aberta");

            cn.Close();
            Mensagem("Conexao Fechada");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT Nome From Cliente";

            cn.Open();

            // Vai realizar a Leitura

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);
            }

            reader.Close();
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cliente(Id, Nome, Email, Telefone) values (@Id, @Nome, @Email, @Telefone)";

            // Parametros
            cmd.Parameters.AddWithValue("@Id", 20);
            cmd.Parameters.AddWithValue("@Nome", "Jose da Silva Xavier");
            cmd.Parameters.AddWithValue("@Email", "Jose.silva@gmail.com");
            cmd.Parameters.AddWithValue("@Telefone", "555-7878");

            cn.Open();
            Mensagem("Conexão Aberta");

            // Irá trazer o total de registors afetados
            int total=cmd.ExecuteNonQuery();
            Mensagem("Registro Incluido");


            cn.Close();
            Mensagem("Conexão Fechada");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Cliente SET Nome = @Nome Where Id = @Id";

            // Parametros
            cmd.Parameters.AddWithValue("@Id", 20);
            cmd.Parameters.AddWithValue("@Nome", "Pedro da Silva Xavier");


            cn.Open();
            Mensagem("Conexão Aberta");

            // Irá trazer o total de registors afetados
            int total = cmd.ExecuteNonQuery();
            Mensagem("Registro Alterado com Sucesso");

            cn.Close();
            Mensagem("Conexão Fechada");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Cliente WHERE Id = @Id";

            // Parametros
            cmd.Parameters.AddWithValue("@Id", 20);

            cn.Open();
            Mensagem("Conexão Aberta");

            // Irá trazer o total de registors afetados
            int total = cmd.ExecuteNonQuery();
            Mensagem("Registro excluido com Sucesso");

            cn.Close();
            Mensagem("Conexão Fechada");
        }
    }
}
