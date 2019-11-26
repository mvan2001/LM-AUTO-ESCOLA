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
    public partial class frmAluno : Form
    {
        AlunoEnt objtabela = new AlunoEnt();

        public frmAluno()
        {
            InitializeComponent();
        }

        private void btnNovoAluno_Click(object sender, EventArgs e) //Configurando botão novo
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
                case "Novo": //Configurando função novo
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Buscar": //Configurando função Buscar
                    try
                    {
                        objtabela.Nome = txtNomeAluno.Text;
                        List<AlunoEnt> Lista = new List<AlunoEnt>();
                        Lista = new AlunoModel().Buscar(objtabela);
                        GridAluno.AutoGenerateColumns = false;
                        GridAluno.DataSource = Lista;
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Erro ao listar dados" + ex.Message);
                    }

                    break;

                case "Salvar": //Configurando função salvar
                    try
                    {
                        objtabela.Nome = txtNomeAluno.Text;
                        objtabela.Cpf = txtCpfAluno.Text;
                        objtabela.Rg = txtRgAluno.Text;
                        objtabela.Telefone = txtTelefoneAluno.Text;
                        objtabela.Categoriacnh = txtCategoriacnhAluno.Text;
                        objtabela.Horariodeaula = txtHorarioDeAulaAluno.Text;

                        if (txtNomeAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtCpfAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtRgAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtTelefoneAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtCategoriacnhAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtHorarioDeAulaAluno.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        int x = AlunoModel.Inserir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Aluno {0} salvo com sucesso", txtNomeAluno.Text)); //Cadastrando aluno
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

                case "Excluir": //Configurando função excluir
                    try
                    {
                        objtabela.Id = (txtIdAluno.Text);

                        int x = AlunoModel.Excluir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Aluno {0} excluído com sucesso", txtNomeAluno.Text)); //Excluindo aluno
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

                case "Editar":
                    try
                    {
                        objtabela.Id = txtIdAluno.Text;
                        objtabela.Nome = txtNomeAluno.Text;
                        objtabela.Cpf = txtCpfAluno.Text;
                        objtabela.Rg = txtRgAluno.Text;
                        objtabela.Telefone = txtTelefoneAluno.Text;
                        objtabela.Categoriacnh = txtCategoriacnhAluno.Text;
                        objtabela.Horariodeaula = txtHorarioDeAulaAluno.Text;

                        int x = AlunoModel.Editar(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Aluno {0} editado com sucesso", txtNomeAluno.Text)); //Editando aluno
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
            txtNomeAluno.Enabled = true;
            txtCpfAluno.Enabled = true;
            txtRgAluno.Enabled = true;
            txtTelefoneAluno.Enabled = true;
            txtCategoriacnhAluno.Enabled = true;
            txtHorarioDeAulaAluno.Enabled = true;
        }

        private void DesabilitarCampos() //Configurando função DesabilitarCampos
        {
            txtNomeAluno.Enabled = false;
            txtCpfAluno.Enabled = false;
            txtRgAluno.Enabled = false;
            txtTelefoneAluno.Enabled = false;
            txtCategoriacnhAluno.Enabled = false;
            txtHorarioDeAulaAluno.Enabled = false;
        }

        private void LimparCampos() //Configurando função LimparCampos
        {
            txtNomeAluno.Text = "";
            txtCpfAluno.Text = "";
            txtRgAluno.Text = "";
            txtTelefoneAluno.Text = "";
            txtCategoriacnhAluno.Text = "";
            txtHorarioDeAulaAluno.Text = "";
            txtIdAluno.Text = "";
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e) //Configurando botão de salvar
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e) //Configurando botão de excluir
        {

            if (txtIdAluno.Text == "") //Verificação de campos vazios
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

        private void btnEditarAluno_Click(object sender, EventArgs e) //Configurando botão de editar
        {
            if (txtIdAluno.Text == "") //Verificação de campos vazios
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
                List<AlunoEnt> Lista = new List<AlunoEnt>();
                Lista = new AlunoModel().Lista();
                GridAluno.AutoGenerateColumns = false;
                GridAluno.DataSource = Lista;
            }

            catch (Exception ex) //Caso ocorra erro ao listar grid
            {
                MessageBox.Show("Erro ao listar dados" + ex.Message);
            }
        }

        private void frmAluno_Load(object sender, EventArgs e) //Configurando o load do frmAluno
        {
            ListarGrid();
        }

        private void GridAluno_CellClick(object sender, DataGridViewCellEventArgs e) //Configurando CellClick da GridAluno
        {
            txtIdAluno.Text = GridAluno.CurrentRow.Cells[0].Value.ToString();
            txtNomeAluno.Text = GridAluno.CurrentRow.Cells[1].Value.ToString();
            txtCpfAluno.Text = GridAluno.CurrentRow.Cells[2].Value.ToString();
            txtRgAluno.Text = GridAluno.CurrentRow.Cells[3].Value.ToString();
            txtTelefoneAluno.Text = GridAluno.CurrentRow.Cells[4].Value.ToString();
            txtCategoriacnhAluno.Text = GridAluno.CurrentRow.Cells[5].Value.ToString();
            txtHorarioDeAulaAluno.Text = GridAluno.CurrentRow.Cells[6].Value.ToString();
            HabilitarCampos();
        }

        private void btnVoltarAluno_Click(object sender, EventArgs e) //Configurando botão de voltar
        {
            this.Close();
        }

        private void txtNomeAluno_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) //Configurando keypress para dígito de apenas letras
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e) //Configurando botão de busca
        {
            opc = "Buscar";
            iniciarOpc();

            if (txtNomeAluno.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Digite um nome");
                return;
            }

            if (GridAluno.RowCount == 0) //Verificação de cadastro de aluno
            {
                MessageBox.Show("Aluno não encontrado");
                ListarGrid();
            }
        }
    }
}