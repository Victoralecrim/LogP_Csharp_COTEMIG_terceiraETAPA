using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void LimparDados()
        {
            txtID.Clear();
            txtNomeAluno.Clear();
            txtIdade.Clear();
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            rdb1ano.Checked = false;
            rdb2ano.Checked = false;
            rdb3ano.Checked = false;
            cmbTurma.SelectedIndex = -1;
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        Conexao objBD = new Conexao();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeAluno = txtNomeAluno.Text;
            int idadeAluno = Convert.ToInt32(txtIdade.Text);
            char turmaAluno = char.Parse(cmbTurma.Text);
            string unidadeAluno = rdbBarroca.Checked ? "Barroca" : rdbFloresta.Checked ? "Floresta" : "";
            int serieAluno = rdb1ano.Checked ? 1 : rdb2ano.Checked ? 2 : rdb3ano.Checked ? 3 : 0;


            string inserir = $"INSERT INTO tbl_Aluno VALUES(null, '{nomeAluno}', '{idadeAluno}', '{unidadeAluno}', '{serieAluno}', '{turmaAluno}');";
            MessageBox.Show(inserir);
            objBD.ExecutarComando(inserir);
        }
    }
}
