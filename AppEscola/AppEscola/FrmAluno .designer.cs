namespace AppEscola
{
    partial class FrmAluno
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.pnlDadosPessoais = new System.Windows.Forms.Panel();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.pnlDadosEscolares = new System.Windows.Forms.Panel();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.grpSerie = new System.Windows.Forms.GroupBox();
            this.rdb3ano = new System.Windows.Forms.RadioButton();
            this.rdb2ano = new System.Windows.Forms.RadioButton();
            this.rdb1ano = new System.Windows.Forms.RadioButton();
            this.grpUnidade = new System.Windows.Forms.GroupBox();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlDadosPessoais.SuspendLayout();
            this.pnlDadosEscolares.SuspendLayout();
            this.grpSerie.SuspendLayout();
            this.grpUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(175, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do aluno:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(9, 50);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(52, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(272, 12);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(271, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(52, 47);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // pnlDadosPessoais
            // 
            this.pnlDadosPessoais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDadosPessoais.Controls.Add(this.btnLimparDados);
            this.pnlDadosPessoais.Controls.Add(this.txtID);
            this.pnlDadosPessoais.Controls.Add(this.txtIdade);
            this.pnlDadosPessoais.Controls.Add(this.lblID);
            this.pnlDadosPessoais.Controls.Add(this.txtNomeAluno);
            this.pnlDadosPessoais.Controls.Add(this.lblNome);
            this.pnlDadosPessoais.Controls.Add(this.lblIdade);
            this.pnlDadosPessoais.Location = new System.Drawing.Point(10, 11);
            this.pnlDadosPessoais.Name = "pnlDadosPessoais";
            this.pnlDadosPessoais.Size = new System.Drawing.Size(550, 83);
            this.pnlDadosPessoais.TabIndex = 6;
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDados.Location = new System.Drawing.Point(414, 38);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(129, 37);
            this.btnLimparDados.TabIndex = 3;
            this.btnLimparDados.Text = "LIMPAR dados";
            this.btnLimparDados.UseVisualStyleBackColor = false;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // pnlDadosEscolares
            // 
            this.pnlDadosEscolares.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDadosEscolares.Controls.Add(this.cmbTurma);
            this.pnlDadosEscolares.Controls.Add(this.lblTurma);
            this.pnlDadosEscolares.Controls.Add(this.grpSerie);
            this.pnlDadosEscolares.Controls.Add(this.grpUnidade);
            this.pnlDadosEscolares.Location = new System.Drawing.Point(12, 111);
            this.pnlDadosEscolares.Name = "pnlDadosEscolares";
            this.pnlDadosEscolares.Size = new System.Drawing.Size(547, 82);
            this.pnlDadosEscolares.TabIndex = 7;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "2A",
            "2B",
            "2C",
            "2D"});
            this.cmbTurma.Location = new System.Drawing.Point(421, 37);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(99, 21);
            this.cmbTurma.TabIndex = 8;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(373, 39);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "Turma:";
            // 
            // grpSerie
            // 
            this.grpSerie.Controls.Add(this.rdb3ano);
            this.grpSerie.Controls.Add(this.rdb2ano);
            this.grpSerie.Controls.Add(this.rdb1ano);
            this.grpSerie.Location = new System.Drawing.Point(202, 15);
            this.grpSerie.Name = "grpSerie";
            this.grpSerie.Size = new System.Drawing.Size(153, 52);
            this.grpSerie.TabIndex = 4;
            this.grpSerie.TabStop = false;
            this.grpSerie.Text = "Série";
            // 
            // rdb3ano
            // 
            this.rdb3ano.AutoSize = true;
            this.rdb3ano.Location = new System.Drawing.Point(101, 22);
            this.rdb3ano.Name = "rdb3ano";
            this.rdb3ano.Size = new System.Drawing.Size(35, 17);
            this.rdb3ano.TabIndex = 7;
            this.rdb3ano.TabStop = true;
            this.rdb3ano.Text = "3º";
            this.rdb3ano.UseVisualStyleBackColor = true;
            // 
            // rdb2ano
            // 
            this.rdb2ano.AutoSize = true;
            this.rdb2ano.Location = new System.Drawing.Point(60, 22);
            this.rdb2ano.Name = "rdb2ano";
            this.rdb2ano.Size = new System.Drawing.Size(35, 17);
            this.rdb2ano.TabIndex = 6;
            this.rdb2ano.TabStop = true;
            this.rdb2ano.Text = "2º";
            this.rdb2ano.UseVisualStyleBackColor = true;
            // 
            // rdb1ano
            // 
            this.rdb1ano.AutoSize = true;
            this.rdb1ano.Location = new System.Drawing.Point(19, 22);
            this.rdb1ano.Name = "rdb1ano";
            this.rdb1ano.Size = new System.Drawing.Size(35, 17);
            this.rdb1ano.TabIndex = 5;
            this.rdb1ano.TabStop = true;
            this.rdb1ano.Text = "1º";
            this.rdb1ano.UseVisualStyleBackColor = true;
            // 
            // grpUnidade
            // 
            this.grpUnidade.Controls.Add(this.rdbFloresta);
            this.grpUnidade.Controls.Add(this.rdbBarroca);
            this.grpUnidade.Location = new System.Drawing.Point(3, 13);
            this.grpUnidade.Name = "grpUnidade";
            this.grpUnidade.Size = new System.Drawing.Size(171, 52);
            this.grpUnidade.TabIndex = 3;
            this.grpUnidade.TabStop = false;
            this.grpUnidade.Text = "Unidade";
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(97, 22);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(62, 17);
            this.rdbFloresta.TabIndex = 4;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(19, 22);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(62, 17);
            this.rdbBarroca.TabIndex = 3;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.Location = new System.Drawing.Point(10, 210);
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.Size = new System.Drawing.Size(554, 150);
            this.dtgAlunos.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(10, 373);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 37);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(124, 373);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 37);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(235, 373);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 37);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(348, 373);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 37);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(459, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 37);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR ";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 418);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtgAlunos);
            this.Controls.Add(this.pnlDadosEscolares);
            this.Controls.Add(this.pnlDadosPessoais);
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação C# e BD";
            this.pnlDadosPessoais.ResumeLayout(false);
            this.pnlDadosPessoais.PerformLayout();
            this.pnlDadosEscolares.ResumeLayout(false);
            this.pnlDadosEscolares.PerformLayout();
            this.grpSerie.ResumeLayout(false);
            this.grpSerie.PerformLayout();
            this.grpUnidade.ResumeLayout(false);
            this.grpUnidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Panel pnlDadosPessoais;
        private System.Windows.Forms.Panel pnlDadosEscolares;
        private System.Windows.Forms.GroupBox grpUnidade;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.GroupBox grpSerie;
        private System.Windows.Forms.RadioButton rdb2ano;
        private System.Windows.Forms.RadioButton rdb1ano;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.RadioButton rdb3ano;
        private System.Windows.Forms.DataGridView dtgAlunos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimparDados;
    }
}

