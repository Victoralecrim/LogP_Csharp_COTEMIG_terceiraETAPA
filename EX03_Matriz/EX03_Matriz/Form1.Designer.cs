namespace EX03_Matriz
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbldados = new System.Windows.Forms.Label();
            this.lblvet = new System.Windows.Forms.Label();
            this.lbltotaldados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "GERAR DADOS ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldados
            // 
            this.lbldados.AutoSize = true;
            this.lbldados.Location = new System.Drawing.Point(322, 120);
            this.lbldados.Name = "lbldados";
            this.lbldados.Size = new System.Drawing.Size(0, 13);
            this.lbldados.TabIndex = 1;
            // 
            // lblvet
            // 
            this.lblvet.AutoSize = true;
            this.lblvet.Location = new System.Drawing.Point(269, 236);
            this.lblvet.Name = "lblvet";
            this.lblvet.Size = new System.Drawing.Size(223, 13);
            this.lblvet.TabIndex = 2;
            this.lblvet.Text = "O total da soma das colunas dessa matriz é:   ";
            // 
            // lbltotaldados
            // 
            this.lbltotaldados.AutoSize = true;
            this.lbltotaldados.Location = new System.Drawing.Point(296, 185);
            this.lbltotaldados.Name = "lbltotaldados";
            this.lbltotaldados.Size = new System.Drawing.Size(160, 13);
            this.lbltotaldados.TabIndex = 3;
            this.lbltotaldados.Text = "O total da soma dessa matriz é:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotaldados);
            this.Controls.Add(this.lblvet);
            this.Controls.Add(this.lbldados);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldados;
        private System.Windows.Forms.Label lblvet;
        private System.Windows.Forms.Label lbltotaldados;
    }
}

