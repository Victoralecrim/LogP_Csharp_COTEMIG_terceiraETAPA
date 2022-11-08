namespace EX09PAG73
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
            this.btngerarnumeros = new System.Windows.Forms.Button();
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.lblmaiornumero = new System.Windows.Forms.Label();
            this.lblmenornumero = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngerarnumeros
            // 
            this.btngerarnumeros.Location = new System.Drawing.Point(293, 32);
            this.btngerarnumeros.Name = "btngerarnumeros";
            this.btngerarnumeros.Size = new System.Drawing.Size(123, 48);
            this.btngerarnumeros.TabIndex = 0;
            this.btngerarnumeros.Text = "GERAR";
            this.btngerarnumeros.UseVisualStyleBackColor = true;
            this.btngerarnumeros.Click += new System.EventHandler(this.btngerarnumeros_Click);
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.Location = new System.Drawing.Point(209, 98);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.Size = new System.Drawing.Size(288, 186);
            this.lstnumeros.TabIndex = 1;
            // 
            // lblmaiornumero
            // 
            this.lblmaiornumero.AutoSize = true;
            this.lblmaiornumero.Location = new System.Drawing.Point(215, 326);
            this.lblmaiornumero.Name = "lblmaiornumero";
            this.lblmaiornumero.Size = new System.Drawing.Size(10, 13);
            this.lblmaiornumero.TabIndex = 2;
            this.lblmaiornumero.Text = ".";
            // 
            // lblmenornumero
            // 
            this.lblmenornumero.AutoSize = true;
            this.lblmenornumero.Location = new System.Drawing.Point(215, 361);
            this.lblmenornumero.Name = "lblmenornumero";
            this.lblmenornumero.Size = new System.Drawing.Size(10, 13);
            this.lblmenornumero.TabIndex = 3;
            this.lblmenornumero.Text = ".";
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Location = new System.Drawing.Point(444, 326);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(10, 13);
            this.lblmedia.TabIndex = 4;
            this.lblmedia.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lblmenornumero);
            this.Controls.Add(this.lblmaiornumero);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.btngerarnumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngerarnumeros;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Label lblmaiornumero;
        private System.Windows.Forms.Label lblmenornumero;
        private System.Windows.Forms.Label lblmedia;
    }
}

