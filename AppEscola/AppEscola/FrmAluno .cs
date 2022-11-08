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

        private void limparDados()
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
           limparDados();
        }

        Conexao objBD = new Conexao();

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string   nomeAluno = txtNomeAluno.Text;
            int   idadeAluno   = int.Parse(txtIdade.Text);
            string   unidadeAluno   = rdbBarroca.Checked ? "Barroca" : rdbFloresta.Checked ? "Floresta" : "";
            int   serieAluno  = rdb1ano.Checked ? 1 :rdb2ano.Checked ? -1 :rdb3ano.Checked ? 3 : 0;
            char   turmaAluno   = char.Parse(cmbTurma.Text);

            //if(rdbBarroca.Checked){
            //    unidadeAluno = "Barroca";
            // }

            //else if(rdbFloresta.Checked)
            //{
            //  unidadeAluno = "floresta";


            // }
            // else
            // {
            //   unidadeAluno = "";
            //}

            string inserir = $"INSERT INTO tbl_aluno Values(null,'{nomeAluno}', '{idadeAluno}', '{unidadeAluno}' , '{serieAluno}' , '{turmaAluno}');";
            MessageBox.Show(inserir);
            objBD.ExecutarComando(inserir);
            limparDados();
            MessageBox.Show("Os dados foram cadastrdos com sucesso");
        }

        private void ExibirDados()
        {
            string query = "Select * From tbl_aluno order by nome;";

           dtgAlunos.DataSource = objBD.ExecutarConsulta(query);
        }

        private void dtgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text=dtgAlunos.Rows[e.RowIndex].Cells["id"].Value.ToString();

            txtNomeAluno.Text=dtgAlunos.Rows[e.RowIndex].Cells["nome"].Value.ToString();

            txtIdade.Text = dtgAlunos.Rows[e.RowIndex].Cells["idade"].Value.ToString();

            cmbTurma.Text= dtgAlunos.Rows[e.RowIndex].Cells["turma"].Value.ToString();

            string unidadeAluno = dtgAlunos.Rows[e.RowIndex].Cells["unidade"].Value.ToString();

            string serie = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString();

            if (unidadeAluno == "Floresta")
                //Verifica a unidade
            {
                rdbFloresta.Checked = true;
            }
            else if (unidadeAluno == "Barroca")
                //Verifica a unidade
            {
                rdbBarroca.Checked = true;
            }


            if(serie == "1")
            {
                rdb1ano.Checked = true;
            }
            else if(serie == "2")
            {
                rdb2ano.Checked = true;
            }

            else if(serie == "3")
                {
                rdb3ano.Checked = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtID.Text !=String.Empty)
            //Verifica se "id" é nulo
            {

                string nomeAluno = txtNomeAluno.Text;
                int idadeAluno = int.Parse(txtIdade.Text);
                string unidadeAluno = rdbBarroca.Checked ? "Barroca" : rdbFloresta.Checked ? "Floresta" : "";
                int serieAluno = rdb1ano.Checked ? 1 : rdb2ano.Checked ? -1 : rdb3ano.Checked ? 3 : 0;
                char turmaAluno = char.Parse(cmbTurma.Text);


                string alterar = $@"UPDATE tbl_aluno SET nome = '{ nomeAluno}', idade = '{idadeAluno}', turma ='{turmaAluno}, unidade='{unidadeAluno}' , serie ='{serieAluno}' WHERE id = '{idadeAluno}';";
                                                        
            }
        }
    }
}
