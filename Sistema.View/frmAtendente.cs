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
    public partial class frmAtendente : Form
    {
        AtendenteEnt objtabela = new AtendenteEnt();

        public frmAtendente()
        {
            InitializeComponent();
        }

        private void btnNovoAtendente_Click(object sender, EventArgs e) //Configurando botão novo
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
                        objtabela.Nome = txtNomeAtendente.Text;
                        List<AtendenteEnt> Lista = new List<AtendenteEnt>();
                        Lista = new AtendenteModel().Buscar(objtabela);
                        GridAtendente.AutoGenerateColumns = false;
                        GridAtendente.DataSource = Lista;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar dados" + ex.Message);
                    }

                    break;

                case "Salvar": //Configurando função salvar
                    try
                    {
                        objtabela.Nome = txtNomeAtendente.Text;
                        objtabela.Cpf = txtCpfAtendente.Text;
                        objtabela.Rg = txtRgAtendente.Text;
                        objtabela.Telefone = txtTelefoneAtendente.Text;

                        if (txtNomeAtendente.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtCpfAtendente.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtRgAtendente.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtTelefoneAtendente.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        int x = AtendenteModel.Inserir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Atendente {0} salvo com sucesso", txtNomeAtendente.Text)); //Cadastrando atendente
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

                case "Excluir":
                    try
                    {
                        objtabela.Id = (txtIdAtendente.Text);

                        int x = AtendenteModel.Excluir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Atendente {0} excluído com sucesso", txtNomeAtendente.Text)); //Excluindo atendente
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
                        objtabela.Id = txtIdAtendente.Text;
                        objtabela.Nome = txtNomeAtendente.Text;
                        objtabela.Cpf = txtCpfAtendente.Text;
                        objtabela.Rg = txtRgAtendente.Text;
                        objtabela.Telefone = txtTelefoneAtendente.Text;

                        int x = AtendenteModel.Editar(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Atendente {0} editado com sucesso", txtNomeAtendente.Text)); //Editando atendente
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
            txtNomeAtendente.Enabled = true;
            txtCpfAtendente.Enabled = true;
            txtRgAtendente.Enabled = true;
            txtTelefoneAtendente.Enabled = true;
        }

        private void DesabilitarCampos() //Configurando função DesabilitarCampos
        {
            txtNomeAtendente.Enabled = false;
            txtCpfAtendente.Enabled = false;
            txtRgAtendente.Enabled = false;
            txtTelefoneAtendente.Enabled = false;
        }

        private void LimparCampos() //Configurando função LimparCampos
        {
            txtNomeAtendente.Text = "";
            txtCpfAtendente.Text = "";
            txtRgAtendente.Text = "";
            txtTelefoneAtendente.Text = "";
            txtIdAtendente.Text = "";
        }

        private void btnSalvarAtendente_Click(object sender, EventArgs e) //Configurando botão salvar
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
        }

        private void btnExcluirAtendente_Click(object sender, EventArgs e) //Configurando botão excluir
        {
            if (txtIdAtendente.Text == "") //Verificação de campos vazios
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

        private void btnEditarAtendente_Click(object sender, EventArgs e) //Configurando botão editar
        {
            if (txtIdAtendente.Text == "") //Verificação de campos vazios
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
                List<AtendenteEnt> Lista = new List<AtendenteEnt>();
                Lista = new AtendenteModel().Lista();
                GridAtendente.AutoGenerateColumns = false;
                GridAtendente.DataSource = Lista;
            }

            catch (Exception ex) //Caso ocorra erro ao listar grid
            {
                MessageBox.Show("Erro ao listar dados" + ex.Message);
            }
        }

        private void frmAtendente_Load(object sender, EventArgs e) //Configurando o load do frmAtendente
        {
            ListarGrid();
        }

        private void GridAtendente_CellClick(object sender, DataGridViewCellEventArgs e) //Configurando CellClick da GridAtendente
        {
            txtIdAtendente.Text = GridAtendente.CurrentRow.Cells[0].Value.ToString();
            txtNomeAtendente.Text = GridAtendente.CurrentRow.Cells[1].Value.ToString();
            txtCpfAtendente.Text = GridAtendente.CurrentRow.Cells[2].Value.ToString();
            txtRgAtendente.Text = GridAtendente.CurrentRow.Cells[3].Value.ToString();
            txtTelefoneAtendente.Text = GridAtendente.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
        }

        private void btnVoltarAtendente_Click(object sender, EventArgs e) //Configurando botão de voltar
        {
            this.Close();
        }

        private void txtNomeAtendente_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) //Configurando keypress para dígito de apenas letras
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarAtendente_Click(object sender, EventArgs e) //Configurando botão buscar
        {
            opc = "Buscar";
            iniciarOpc();

            if (txtNomeAtendente.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Digite um nome");
                return;
            }

            if (GridAtendente.RowCount == 0) //Verificação de cadastro de atendente
            {
                MessageBox.Show("Atendente não encontrado");
                ListarGrid();
            }
        }

    }

}