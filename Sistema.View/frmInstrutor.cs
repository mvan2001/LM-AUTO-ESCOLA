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
    public partial class frmInstrutor : Form
    {

        InstrutorEnt objtabela = new InstrutorEnt();

        public frmInstrutor()
        {
            InitializeComponent();
        }

        private void btnNovoInstrutor_Click(object sender, EventArgs e) //Configurando botão novo
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

                case "Buscar": //Configurando função buscar
                    try
                    {
                        objtabela.Nome = txtNomeInstrutor.Text;
                        List<InstrutorEnt> Lista = new List<InstrutorEnt>();
                        Lista = new InstrutorModel().Buscar(objtabela);
                        GridInstrutor.AutoGenerateColumns = false;
                        GridInstrutor.DataSource = Lista;
                    }

                    catch (Exception ex) //Caso ocorra errro
                    {
                        MessageBox.Show("Erro ao listar dados" + ex.Message);
                    }

                    break;

                case "Salvar": //Configurando função salvar
                    try
                    {
                        objtabela.Nome = txtNomeInstrutor.Text;
                        objtabela.Cpf = txtCpfInstrutor.Text;
                        objtabela.Rg = txtRgInstrutor.Text;
                        objtabela.Telefone = txtTelefoneInstrutor.Text;

                        if (txtNomeInstrutor.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtCpfInstrutor.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtRgInstrutor.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtTelefoneInstrutor.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        int x = InstrutorModel.Inserir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Instrutor {0} salvo com sucesso", txtNomeInstrutor.Text)); //Cadastrando instrutor
                        }

                        else
                        {
                            MessageBox.Show("Dado não inserido!");
                        }
                    }

                    catch (Exception ex) //Caso ocorra errro
                    {
                        MessageBox.Show("Ocorreu um erro" + ex.Message);
                        throw;
                    }
                    DesabilitarCampos();
                    LimparCampos();
                    break;

                case "Excluir":
                    try
                    {
                        objtabela.Id = (txtIdInstrutor.Text);

                        int x = InstrutorModel.Excluir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Instrutor {0} excluído com sucesso", txtNomeInstrutor.Text)); //Excluindo instrutor
                        }

                        else
                        {
                            MessageBox.Show("Não excluído!");
                        }
                    }

                    catch (Exception ex) //Caso ocorra errro
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir. Error" + ex.Message);
                        throw;
                    }
                    break;

                case "Editar": //Configurando função novo
                    try
                    {
                        objtabela.Id = txtIdInstrutor.Text;
                        objtabela.Nome = txtNomeInstrutor.Text;
                        objtabela.Cpf = txtCpfInstrutor.Text;
                        objtabela.Rg = txtRgInstrutor.Text;
                        objtabela.Telefone = txtTelefoneInstrutor.Text;

                        int x = InstrutorModel.Editar(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Instrutor {0} editado com sucesso", txtNomeInstrutor.Text)); //Editando instrutor
                        }

                        else
                        {
                            MessageBox.Show("Dado não atualizado!");
                        }
                    }

                    catch (Exception ex) //Caso ocorra errro
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
            txtNomeInstrutor.Enabled = true;
            txtCpfInstrutor.Enabled = true;
            txtRgInstrutor.Enabled = true;
            txtTelefoneInstrutor.Enabled = true;
        }

        private void DesabilitarCampos() //Configurando função DesabilitarCampos
        {
            txtNomeInstrutor.Enabled = false;
            txtCpfInstrutor.Enabled = false;
            txtRgInstrutor.Enabled = false;
            txtTelefoneInstrutor.Enabled = false;
        }

        private void LimparCampos() //Configurando função LimparCampos
        {
            txtNomeInstrutor.Text = "";
            txtCpfInstrutor.Text = "";
            txtRgInstrutor.Text = "";
            txtTelefoneInstrutor.Text = "";
            txtIdInstrutor.Text = "";
        }

        private void btnSalvarInstrutor_Click(object sender, EventArgs e) //Configurando botão salvar
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
        }

        private void btnExcluirInstrutor_Click(object sender, EventArgs e) //Configurando botão excluir
        {
            if (txtIdInstrutor.Text == "") //Verificação de campos vazios
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

        private void btnEditarInstrutor_Click(object sender, EventArgs e) //Configurando botão editar
        {
            if (txtIdInstrutor.Text == "") //Verificação de campos vazios
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
                List<InstrutorEnt> Lista = new List<InstrutorEnt>();
                Lista = new InstrutorModel().Lista();
                GridInstrutor.AutoGenerateColumns = false;
                GridInstrutor.DataSource = Lista;
            }

            catch (Exception ex) //Caso ocorra errro
            {
                MessageBox.Show("Erro ao listar dados" + ex.Message);
            }
        }

        private void frmInstrutor_Load(object sender, EventArgs e) //Configurando o load do frmInstrutor
        {
            ListarGrid();
        }

        private void GridInstrutor_CellClick(object sender, DataGridViewCellEventArgs e) //Configurando CellClick da GridInstrutor
        {
            txtIdInstrutor.Text = GridInstrutor.CurrentRow.Cells[0].Value.ToString();
            txtNomeInstrutor.Text = GridInstrutor.CurrentRow.Cells[1].Value.ToString();
            txtCpfInstrutor.Text = GridInstrutor.CurrentRow.Cells[2].Value.ToString();
            txtRgInstrutor.Text = GridInstrutor.CurrentRow.Cells[3].Value.ToString();
            txtTelefoneInstrutor.Text = GridInstrutor.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
        }

        private void btnVoltarInstrutor_Click(object sender, EventArgs e) //Configurando botão de voltar
        {
            this.Close();
        }

        private void txtNomeInstrutor_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) //Configurando keypress para dígito de apenas letras
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarInstrutor_Click(object sender, EventArgs e) //Configurando botão buscar
        {
            opc = "Buscar";
            iniciarOpc();

            if (txtNomeInstrutor.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Digite um nome");
                return;
            }

            if (GridInstrutor.RowCount == 0) //Verificação de cadastro de instrutor
            {
                MessageBox.Show("Instrutor não encontrado");
                ListarGrid();
            }
        }
    }

}
