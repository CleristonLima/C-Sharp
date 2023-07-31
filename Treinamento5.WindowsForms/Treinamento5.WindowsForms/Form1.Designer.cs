namespace Treinamento5.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeLabel = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.CPFLabel = new System.Windows.Forms.Label();
            this.CPFTextBox = new System.Windows.Forms.TextBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.NLabel = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComplementoTextBox = new System.Windows.Forms.TextBox();
            this.SexoLabel = new System.Windows.Forms.Label();
            this.MasculinoRadioButton = new System.Windows.Forms.RadioButton();
            this.FemininoRadioButton = new System.Windows.Forms.RadioButton();
            this.CEPTextBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CidadeLabel = new System.Windows.Forms.Label();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            this.EstadoTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.Location = new System.Drawing.Point(25, 22);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(55, 20);
            this.NomeLabel.TabIndex = 0;
            this.NomeLabel.Text = "Nome:";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(87, 21);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(287, 20);
            this.NomeTextBox.TabIndex = 1;
            // 
            // CPFLabel
            // 
            this.CPFLabel.AutoSize = true;
            this.CPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFLabel.Location = new System.Drawing.Point(25, 71);
            this.CPFLabel.Name = "CPFLabel";
            this.CPFLabel.Size = new System.Drawing.Size(44, 20);
            this.CPFLabel.TabIndex = 2;
            this.CPFLabel.Text = "CPF:";
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.Location = new System.Drawing.Point(87, 71);
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(287, 20);
            this.CPFTextBox.TabIndex = 3;
            this.CPFTextBox.TextChanged += new System.EventHandler(this.CPFTextBox_TextChanged);
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLabel.Location = new System.Drawing.Point(26, 117);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(42, 20);
            this.EndLabel.TabIndex = 4;
            this.EndLabel.Text = "End:";
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(87, 114);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(287, 20);
            this.EndTextBox.TabIndex = 5;
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLabel.Location = new System.Drawing.Point(425, 114);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(26, 20);
            this.NLabel.TabIndex = 6;
            this.NLabel.Text = "Nº";
            this.NLabel.Click += new System.EventHandler(this.NLabel_Click);
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(457, 114);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(105, 20);
            this.NTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Complemento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComplementoTextBox
            // 
            this.ComplementoTextBox.Location = new System.Drawing.Point(145, 160);
            this.ComplementoTextBox.Name = "ComplementoTextBox";
            this.ComplementoTextBox.Size = new System.Drawing.Size(229, 20);
            this.ComplementoTextBox.TabIndex = 9;
            // 
            // SexoLabel
            // 
            this.SexoLabel.AutoSize = true;
            this.SexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoLabel.Location = new System.Drawing.Point(425, 21);
            this.SexoLabel.Name = "SexoLabel";
            this.SexoLabel.Size = new System.Drawing.Size(49, 20);
            this.SexoLabel.TabIndex = 10;
            this.SexoLabel.Text = "Sexo:";
            // 
            // MasculinoRadioButton
            // 
            this.MasculinoRadioButton.AutoSize = true;
            this.MasculinoRadioButton.Location = new System.Drawing.Point(480, 22);
            this.MasculinoRadioButton.Name = "MasculinoRadioButton";
            this.MasculinoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.MasculinoRadioButton.TabIndex = 11;
            this.MasculinoRadioButton.TabStop = true;
            this.MasculinoRadioButton.Text = "Masculino";
            this.MasculinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemininoRadioButton
            // 
            this.FemininoRadioButton.AutoSize = true;
            this.FemininoRadioButton.Location = new System.Drawing.Point(480, 60);
            this.FemininoRadioButton.Name = "FemininoRadioButton";
            this.FemininoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.FemininoRadioButton.TabIndex = 12;
            this.FemininoRadioButton.TabStop = true;
            this.FemininoRadioButton.Text = "Feminino";
            this.FemininoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CEPTextBox
            // 
            this.CEPTextBox.AutoSize = true;
            this.CEPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPTextBox.Location = new System.Drawing.Point(26, 203);
            this.CEPTextBox.Name = "CEPTextBox";
            this.CEPTextBox.Size = new System.Drawing.Size(45, 20);
            this.CEPTextBox.TabIndex = 13;
            this.CEPTextBox.Text = "CEP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 14;
            // 
            // CidadeLabel
            // 
            this.CidadeLabel.AutoSize = true;
            this.CidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CidadeLabel.Location = new System.Drawing.Point(25, 242);
            this.CidadeLabel.Name = "CidadeLabel";
            this.CidadeLabel.Size = new System.Drawing.Size(63, 20);
            this.CidadeLabel.TabIndex = 15;
            this.CidadeLabel.Text = "Cidade:";
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.Location = new System.Drawing.Point(95, 241);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(279, 20);
            this.CidadeTextBox.TabIndex = 16;
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoLabel.Location = new System.Drawing.Point(26, 284);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(64, 20);
            this.EstadoLabel.TabIndex = 17;
            this.EstadoLabel.Text = "Estado:";
            // 
            // SalvarButton
            // 
            this.SalvarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarButton.Location = new System.Drawing.Point(126, 365);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(102, 43);
            this.SalvarButton.TabIndex = 19;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // SairButton
            // 
            this.SairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairButton.Location = new System.Drawing.Point(349, 365);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(102, 43);
            this.SairButton.TabIndex = 20;
            this.SairButton.Text = "Sair";
            this.SairButton.UseVisualStyleBackColor = true;
            this.SairButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // EstadoTextBox
            // 
            this.EstadoTextBox.Location = new System.Drawing.Point(97, 283);
            this.EstadoTextBox.Name = "EstadoTextBox";
            this.EstadoTextBox.Size = new System.Drawing.Size(65, 20);
            this.EstadoTextBox.TabIndex = 21;
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(164, 321);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(82, 20);
            this.ResultadoLabel.TabIndex = 23;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 451);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.EstadoTextBox);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.EstadoLabel);
            this.Controls.Add(this.CidadeTextBox);
            this.Controls.Add(this.CidadeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CEPTextBox);
            this.Controls.Add(this.FemininoRadioButton);
            this.Controls.Add(this.MasculinoRadioButton);
            this.Controls.Add(this.SexoLabel);
            this.Controls.Add(this.ComplementoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.CPFTextBox);
            this.Controls.Add(this.CPFLabel);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.NomeLabel);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label CPFLabel;
        private System.Windows.Forms.TextBox CPFTextBox;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ComplementoTextBox;
        private System.Windows.Forms.Label SexoLabel;
        private System.Windows.Forms.RadioButton MasculinoRadioButton;
        private System.Windows.Forms.RadioButton FemininoRadioButton;
        private System.Windows.Forms.Label CEPTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CidadeLabel;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.TextBox EstadoTextBox;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}

