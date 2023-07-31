using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento5.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CPFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(NomeTextBox.Text);
            string CPF = Convert.ToString(CPFTextBox.Text);
            string End = Convert.ToString(EndTextBox.Text);
            int n = Convert.ToInt32(NTextBox.Text);
            string complemento = Convert.ToString(ComplementoTextBox.Text);
            string CEP = Convert.ToString(CEPTextBox.Text);
            string Estado = Convert.ToString(EstadoTextBox.Text);
            bool sexoM = Convert.ToBoolean(MasculinoRadioButton.Bottom);
            bool sexoF = Convert.ToBoolean(FemininoRadioButton.Bottom);

            ResultadoLabel.Text = "Cadastrado com Sucesso!!!";           
                                                      
        }

        private void EstadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
