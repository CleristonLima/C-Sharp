namespace Aula13.Heranca
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
            this.exemploButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Exemplo2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exemploButton
            // 
            this.exemploButton.Location = new System.Drawing.Point(32, 23);
            this.exemploButton.Name = "exemploButton";
            this.exemploButton.Size = new System.Drawing.Size(174, 37);
            this.exemploButton.TabIndex = 0;
            this.exemploButton.Text = "Exemplo Heranca";
            this.exemploButton.UseVisualStyleBackColor = true;
            this.exemploButton.Click += new System.EventHandler(this.exemploButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 199);
            this.listBox1.TabIndex = 1;
            // 
            // Exemplo2Button
            // 
            this.Exemplo2Button.Location = new System.Drawing.Point(237, 23);
            this.Exemplo2Button.Name = "Exemplo2Button";
            this.Exemplo2Button.Size = new System.Drawing.Size(155, 37);
            this.Exemplo2Button.TabIndex = 2;
            this.Exemplo2Button.Text = "Exemplo 2";
            this.Exemplo2Button.UseVisualStyleBackColor = true;
            this.Exemplo2Button.Click += new System.EventHandler(this.Exemplo2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 323);
            this.Controls.Add(this.Exemplo2Button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exemploButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exemploButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Exemplo2Button;
    }
}

