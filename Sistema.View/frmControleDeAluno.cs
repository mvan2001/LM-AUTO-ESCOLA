using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Model;
using Sistema.Entidades;

namespace Sistema.View
{
    public partial class frmControleDeAluno : Form
    {
        ControleDeAlunoEnt objtabela = new ControleDeAlunoEnt();

        public frmControleDeAluno()
        {
            InitializeComponent();
        }

        private void btnNovoControleDeAluno_Click(object sender, EventArgs e) //Configurando botão novo
        {
            opc = "Novo";
            iniciarOpc();
            ListarGrid();
        }

        private string opc = ""; //Declarando opc

        private void iniciarOpc() //Declarando iniciarOpc
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Buscar":
                    try
                    {
                        objtabela.Nome = txtNomeControleDeAluno.Text;
                        List<ControleDeAlunoEnt> Lista = new List<ControleDeAlunoEnt>();
                        Lista = new ControleDeAlunoModel().Buscar(objtabela);
                        GridControleDeAluno.AutoGenerateColumns = false;
                        GridControleDeAluno.DataSource = Lista;
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Erro ao listar dados" + ex.Message);
                    }

                    break;

                case "Salvar": //Configurando botão salvar
                    try
                    {
                        objtabela.Nome = txtNomeControleDeAluno.Text;
                        objtabela.Frequencia = txtFrequenciaControleDeAluno.Text;
                        objtabela.Pagamento = txtPagamentoControleDeAluno.Text;

                        if (txtNomeControleDeAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtFrequenciaControleDeAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtPagamentoControleDeAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        int x = ControleDeAlunoModel.Inserir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Dados do aluno {0} salvo com sucesso", txtNomeControleDeAluno.Text)); //Salvando aluno
                        }

                        else
                        {
                            MessageBox.Show("Dado não inserido!");
                        }
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Ocorreu um erro" + ex.Message);
                        throw;
                    }
                    DesabilitarCampos();
                    LimparCampos();
                    break;

                case "Excluir": //Configurando botão excluir
                    try
                    {
                        objtabela.Id = (txtIdControleDeAluno.Text);

                        int x = ControleDeAlunoModel.Excluir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Dados do aluno {0} excluído com sucesso", txtNomeControleDeAluno.Text)); //Excluindo aluno
                        }

                        else
                        {
                            MessageBox.Show("Não excluído!");
                        }
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir. Error" + ex.Message);
                        throw;
                    }
                    break;

                case "Editar": //Configurando botão editar
                    try
                    {
                        objtabela.Id = txtIdControleDeAluno.Text;
                        objtabela.Nome = txtNomeControleDeAluno.Text;
                        objtabela.Frequencia = txtFrequenciaControleDeAluno.Text;
                        objtabela.Pagamento = txtPagamentoControleDeAluno.Text;

                        int x = ControleDeAlunoModel.Editar(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Dados do aluno {0} editado com sucesso", txtNomeControleDeAluno.Text)); //Editando aluno
                        }

                        else
                        {
                            MessageBox.Show("Dado não atualizado!");
                        }
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Ocorreu um erro ao editar" + ex.Message);
                        throw;
                    }

                    break;
                    default:
                    break;
            }
        }

        private void HabilitarCampos() //Configurando função HabilitarCampos
        {
            txtNomeControleDeAluno.Enabled = true;
            txtFrequenciaControleDeAluno.Enabled = true;
            txtPagamentoControleDeAluno.Enabled = true;
        }

        private void DesabilitarCampos() //Configurando função DesabilitarCampos
        {
            txtNomeControleDeAluno.Enabled = false;
            txtFrequenciaControleDeAluno.Enabled = false;
            txtPagamentoControleDeAluno.Enabled = false;
        }

        private void LimparCampos() //Configurando função LimparCampos
        {
            txtNomeControleDeAluno.Text = "";
            txtFrequenciaControleDeAluno.Text = "";
            txtPagamentoControleDeAluno.Text = "";
            txtIdControleDeAluno.Text = "";
        }

        private void btnSalvarControleDeAluno_Click(object sender, EventArgs e) //Configurando botão salvar
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
        }

        private void btnExcluirControleDeAluno_Click(object sender, EventArgs e) //Configurando botão excluir
        {
            if (txtIdControleDeAluno.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Selecione um registro");
                return;
            }
            opc = "Excluir";
            iniciarOpc();
            ListarGrid();
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnEditarControleDeAluno_Click(object sender, EventArgs e) //Configurando botão de editar
        {

            if (txtIdControleDeAluno.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            opc = "Editar";
            iniciarOpc();
            ListarGrid();
            DesabilitarCampos();
            LimparCampos();
        }

        private void ListarGrid()
        {
            try
            {
                List<ControleDeAlunoEnt> Lista = new List<ControleDeAlunoEnt>();
                Lista = new ControleDeAlunoModel().Lista();
                GridControleDeAluno.AutoGenerateColumns = false;
                GridControleDeAluno.DataSource = Lista;
            }

            catch (Exception ex) //Caso ocorra erro
            {
                MessageBox.Show("Erro ao listar dados" + ex.Message);
            }
        }

        private void frmControleDeAluno_Load(object sender, EventArgs e) //Configurando o load do frmAluno
        {
            ListarGrid();
        }

        private void GridControleDeAluno_CellClick(object sender, DataGridViewCellEventArgs e) //Configurando CellClick da GridControleDeAluno
        {
            txtIdControleDeAluno.Text = GridControleDeAluno.CurrentRow.Cells[0].Value.ToString();
            txtNomeControleDeAluno.Text = GridControleDeAluno.CurrentRow.Cells[1].Value.ToString();
            txtFrequenciaControleDeAluno.Text = GridControleDeAluno.CurrentRow.Cells[2].Value.ToString();
            txtPagamentoControleDeAluno.Text = GridControleDeAluno.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }

        private void btnVoltarControleDeAluno_Click(object sender, EventArgs e) //Configurando botão voltar
        {
            this.Close();
        }

        private void txtNomeControleDeAluno_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) //Configurando keypress para dígito de apenas letras
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrequenciaControleDeAluno_KeyPress(object sender, KeyPressEventArgs e) //Configurando keypress para dígito de apenas números
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnBuscarControleDeAluno_Click(object sender, EventArgs e) //Configurando botão buscar
        {
            opc = "Buscar";
            iniciarOpc();

            if (txtNomeControleDeAluno.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Digite um nome");
                return;
            }

            if (GridControleDeAluno.RowCount == 0) //Verificação de cadastro de aluno
            {
                MessageBox.Show("Aluno não encontrado");
                ListarGrid();
            }
        }
    }
}
