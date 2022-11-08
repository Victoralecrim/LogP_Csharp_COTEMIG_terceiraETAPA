namespace EX05PÁG73
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
            this.LSTNUMEROS = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstzeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LSTNUMEROS
            // 
            this.LSTNUMEROS.FormattingEnabled = true;
            this.LSTNUMEROS.Location = new System.Drawing.Point(12, 68);
            this.LSTNUMEROS.Name = "LSTNUMEROS";
            this.LSTNUMEROS.Size = new System.Drawing.Size(274, 264);
            this.LSTNUMEROS.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(71, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "GERAR NUMEROS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Onde estão os zeros:";
            // 
            // lstzeros
            // 
            this.lstzeros.FormattingEnabled = true;
            this.lstzeros.Location = new System.Drawing.Point(329, 70);
            this.lstzeros.Name = "lstzeros";
            this.lstzeros.Size = new System.Drawing.Size(274, 264);
            this.lstzeros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstzeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LSTNUMEROS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSTNUMEROS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstzeros;
    }
}

