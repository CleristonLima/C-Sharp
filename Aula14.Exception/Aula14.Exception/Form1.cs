using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula14.Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valorCompra = Convert.ToDecimal(ValorTextBox.Text);
                if (valorCompra <0 )
                {
                    throw new ApplicationException("Não é permitido número negativos");
                }
                if (valorCompra > 9000)
                {
                    throw new ApplicationException("O valor maximo é de 9000 reais");
                }
                valorCompraLabel.Text = valorCompra.ToString("c");
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(OverflowException)
            {
                MessageBox.Show("Numero digito é muito grande");
            }
            catch(FormatException)
            {
                MessageBox.Show("Valor da compra invalido");
            }
        }
    }
}
