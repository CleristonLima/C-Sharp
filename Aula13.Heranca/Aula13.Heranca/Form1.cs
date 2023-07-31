using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula13.Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exemploButton_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.Matricula = "2001";
            a.nome = "Romarinho Alves de souza";
            a.email = "Romarinho@hotmail.com";

            Funcionario f = new Funcionario();
            f.nome = "Maria jose";
            f.email = "Maria@gmail.com";
            f.Cargo = "Faxineira";
            f.salario = 1250;

            listBox1.Items.Add(a.Matricula);
            listBox1.Items.Add(a.nome);
            listBox1.Items.Add(a.email);
            listBox1.Items.Add("----------------------------");
            listBox1.Items.Add(f.nome);
            listBox1.Items.Add(f.email);
            listBox1.Items.Add(f.Cargo);
            listBox1.Items.Add(f.salario);

        }

        private void EnviarEmail(CadastroBase dados)
        {
            // Enviando Email.....
            string mensagem = string.Format("Enviando email para {0}", dados.nome);
            listBox1.Items.Add(mensagem);
        }

        private void Exemplo2Button_Click(object sender, EventArgs e)
        {
            CadastroBase a = new Aluno();
            a.nome = "Jessica";
            CadastroBase b = new Funcionario();
            b.nome = "Pedro";

            EnviarEmail(a);
            EnviarEmail(b);
        }
    }
}
