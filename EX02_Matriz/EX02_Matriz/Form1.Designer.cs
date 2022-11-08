namespace EX02_Matriz
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
            this.btngerar = new System.Windows.Forms.Button();
            this.lblnumeros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngerar
            // 
            this.btngerar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btngerar.Location = new System.Drawing.Point(232, 12);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(279, 67);
            this.btngerar.TabIndex = 0;
            this.btngerar.Text = "Gerar Dados";
            this.btngerar.UseVisualStyleBackColor = false;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // lblnumeros
            // 
            this.lblnumeros.Location = new System.Drawing.Point(337, 152);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(376, 157);
            this.lblnumeros.TabIndex = 1;
            this.lblnumeros.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valores armazenados na matriz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnumeros);
            this.Controls.Add(this.btngerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.Label label1;
    }
}

