namespace EX08PAG73
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
            this.lstvetor1 = new System.Windows.Forms.ListBox();
            this.btngerarnumeros = new System.Windows.Forms.Button();
            this.lstvetor2 = new System.Windows.Forms.ListBox();
            this.lstsoma = new System.Windows.Forms.ListBox();
            this.lstsubtracao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstvetor1
            // 
            this.lstvetor1.FormattingEnabled = true;
            this.lstvetor1.Location = new System.Drawing.Point(28, 78);
            this.lstvetor1.MultiColumn = true;
            this.lstvetor1.Name = "lstvetor1";
            this.lstvetor1.Size = new System.Drawing.Size(288, 173);
            this.lstvetor1.TabIndex = 0;
            // 
            // btngerarnumeros
            // 
            this.btngerarnumeros.Location = new System.Drawing.Point(297, 12);
            this.btngerarnumeros.Name = "btngerarnumeros";
            this.btngerarnumeros.Size = new System.Drawing.Size(105, 47);
            this.btngerarnumeros.TabIndex = 1;
            this.btngerarnumeros.Text = "GERAR";
            this.btngerarnumeros.UseVisualStyleBackColor = true;
            this.btngerarnumeros.Click += new System.EventHandler(this.btngerarnumeros_Click);
            // 
            // lstvetor2
            // 
            this.lstvetor2.FormattingEnabled = true;
            this.lstvetor2.Location = new System.Drawing.Point(379, 78);
            this.lstvetor2.MultiColumn = true;
            this.lstvetor2.Name = "lstvetor2";
            this.lstvetor2.Size = new System.Drawing.Size(288, 173);
            this.lstvetor2.TabIndex = 2;
            // 
            // lstsoma
            // 
            this.lstsoma.FormattingEnabled = true;
            this.lstsoma.Location = new System.Drawing.Point(28, 265);
            this.lstsoma.MultiColumn = true;
            this.lstsoma.Name = "lstsoma";
            this.lstsoma.Size = new System.Drawing.Size(288, 173);
            this.lstsoma.TabIndex = 3;
            // 
            // lstsubtracao
            // 
            this.lstsubtracao.FormattingEnabled = true;
            this.lstsubtracao.Location = new System.Drawing.Point(379, 265);
            this.lstsubtracao.MultiColumn = true;
            this.lstsubtracao.Name = "lstsubtracao";
            this.lstsubtracao.Size = new System.Drawing.Size(288, 173);
            this.lstsubtracao.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstsubtracao);
            this.Controls.Add(this.lstsoma);
            this.Controls.Add(this.lstvetor2);
            this.Controls.Add(this.btngerarnumeros);
            this.Controls.Add(this.lstvetor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstvetor1;
        private System.Windows.Forms.Button btngerarnumeros;
        private System.Windows.Forms.ListBox lstvetor2;
        private System.Windows.Forms.ListBox lstsoma;
        private System.Windows.Forms.ListBox lstsubtracao;
    }
}

