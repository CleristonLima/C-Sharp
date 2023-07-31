using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08.Ativ03.CalculoProdutoeQuantidade
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void resultadoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(valorTextBox.Text);
            int quantidade = Convert.ToInt32(quantidadeTextBox.Text);
            decimal resultado = valor * quantidade;

            resultadoLabel1.Text = Convert.ToString(resultado);
            
        }
    }
}
