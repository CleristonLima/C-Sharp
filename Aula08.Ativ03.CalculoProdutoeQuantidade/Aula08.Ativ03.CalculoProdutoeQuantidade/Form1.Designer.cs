namespace Aula08.Ativ03.CalculoProdutoeQuantidade
{
    partial class Caixa
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
            this.valorLabel = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.resultadoLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorLabel.Location = new System.Drawing.Point(12, 25);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.valorLabel.Size = new System.Drawing.Size(234, 26);
            this.valorLabel.TabIndex = 0;
            this.valorLabel.Text = "Digite o valor do produto:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(253, 30);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(147, 20);
            this.valorTextBox.TabIndex = 1;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLabel.Location = new System.Drawing.Point(12, 86);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(119, 26);
            this.quantidadeLabel.TabIndex = 2;
            this.quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(148, 91);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 3;
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(185, 138);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(146, 33);
            this.calcularButton.TabIndex = 4;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(17, 200);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 26);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total:";
            // 
            // resultadoLabel1
            // 
            this.resultadoLabel1.AutoSize = true;
            this.resultadoLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel1.Location = new System.Drawing.Point(108, 200);
            this.resultadoLabel1.Name = "resultadoLabel1";
            this.resultadoLabel1.Size = new System.Drawing.Size(23, 26);
            this.resultadoLabel1.TabIndex = 6;
            this.resultadoLabel1.Text = "0";
            this.resultadoLabel1.Click += new System.EventHandler(this.resultadoLabel1_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 266);
            this.Controls.Add(this.resultadoLabel1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.valorLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label resultadoLabel1;
    }
}

