namespace Aula14.Exception
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
            this.ValorLabel = new System.Windows.Forms.Label();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.valorCompraLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValorLabel
            // 
            this.ValorLabel.AutoSize = true;
            this.ValorLabel.Location = new System.Drawing.Point(27, 25);
            this.ValorLabel.Name = "ValorLabel";
            this.ValorLabel.Size = new System.Drawing.Size(88, 13);
            this.ValorLabel.TabIndex = 0;
            this.ValorLabel.Text = "Valor da Compra:";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(122, 17);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(124, 20);
            this.ValorTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(269, 17);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(111, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // valorCompraLabel
            // 
            this.valorCompraLabel.AutoSize = true;
            this.valorCompraLabel.Location = new System.Drawing.Point(30, 79);
            this.valorCompraLabel.Name = "valorCompraLabel";
            this.valorCompraLabel.Size = new System.Drawing.Size(0, 13);
            this.valorCompraLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.valorCompraLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.ValorLabel);
            this.Name = "Form1";
            this.Text = "Valor da Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValorLabel;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label valorCompraLabel;
    }
}

