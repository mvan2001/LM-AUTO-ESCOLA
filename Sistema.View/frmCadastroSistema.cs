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
using EncryptLogin;

namespace Sistema.View
{
    public partial class frmCadastroSistema : Form
    {
        CadastroSistemaEnt objtabela = new CadastroSistemaEnt();

        public frmCadastroSistema()
        {
            InitializeComponent();
        }

        private void btnNovoCadastroSistema_Click(object sender, EventArgs e) //Configurando botão Novo
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
                case "Novo": //Configurando função Novo
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Buscar": //Configurando função Buscar
                    try
                    {
                        objtabela.Usuario = txtUsuarioCadastroSistema.Text;
                        List<CadastroSistemaEnt> Lista = new List<CadastroSistemaEnt>();
                        Lista = new CadastroSistemaModel().Buscar(objtabela);
                        GridCadastroSistema.AutoGenerateColumns = false;
                        GridCadastroSistema.DataSource = Lista;
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Erro ao listar dados" + ex.Message);
                    }
                    break;

                case "Salvar": //Configurando função Salvar
                    try
                    {
                        objtabela.Usuario = txtUsuarioCadastroSistema.Text;
                        objtabela.Senha = txtSenhaCadastroSistema.Text;

                        if (txtUsuarioCadastroSistema.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtSenhaCadastroSistema.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        int x = CadastroSistemaModel.Inserir(objtabela);
                        if (x > 0)
                        {
                            this.Close();
                            MessageBox.Show(String.Format("Usuário {0} cadastrado com sucesso", txtUsuarioCadastroSistema.Text)); //Cadastrando usuário
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

                case "Excluir": //Configurando função Excluir
                    try
                    {
                        objtabela.Id = (txtIdCadastroSistema.Text);

                        int x = CadastroSistemaModel.Excluir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Usuário {0} excluído com sucesso", txtUsuarioCadastroSistema.Text)); //Excluindo usuário
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

                case "Editar": //Configurando função Editar
                    try
                    {
                        objtabela.Id = txtIdCadastroSistema.Text;
                        objtabela.Usuario = txtUsuarioCadastroSistema.Text;
                        objtabela.Senha = txtSenhaCadastroSistema.Text;

                        int x = CadastroSistemaModel.Editar(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Usuário {0} editado com sucesso", txtUsuarioCadastroSistema.Text)); //Editando usuário
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
            txtUsuarioCadastroSistema.Enabled = true;
            txtSenhaCadastroSistema.Enabled = true;
        }

        private void DesabilitarCampos() //Configurando função DesabilitarCampos
        {
            txtUsuarioCadastroSistema.Enabled = false;
            txtSenhaCadastroSistema.Enabled = false;
        }

        private void LimparCampos() //Configurando função LimparCampos
        {
            txtUsuarioCadastroSistema.Text = "";
            txtSenhaCadastroSistema.Text = "";
            txtIdCadastroSistema.Text = "";
        }

        private void btnSalvarCadastroSistema_Click(object sender, EventArgs e) //Configurando botão Salvar
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
        
           HashCode hc = new HashCode();
           Cadastrar cad = new Cadastrar(txtUsuarioCadastroSistema.Text, hc.PassHash(txtSenhaCadastroSistema.Text));
           MessageBox.Show(cad.mensagem);
        }

        private void btnExcluirCadastroSistema_Click(object sender, EventArgs e) //Configurando botão Excluir
        {
            if (txtIdCadastroSistema.Text == "") //Verificação de campos vazios
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

        private void btnEditarCadastroSistema_Click(object sender, EventArgs e) //Configurando botão Editar
        {
            if (txtIdCadastroSistema.Text == "") //Verificação de campos vazios
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
                List<CadastroSistemaEnt> Lista = new List<CadastroSistemaEnt>();
                Lista = new CadastroSistemaModel().Lista();
                GridCadastroSistema.AutoGenerateColumns = false;
                GridCadastroSistema.DataSource = Lista;
            }

            catch (Exception ex) //Caso ocorra erro
            {
                MessageBox.Show("Erro ao listar dados" + ex.Message);
            }
        }

        private void frmCadastroSistema_Load(object sender, EventArgs e)
        {
            ListarGrid(); //Configurando o load do frmCadastroSistema
        }

        private void GridCadastroSistema_CellClick(object sender, DataGridViewCellEventArgs e) //Configurando CellClick da GridCadastroSistema
        {
            txtIdCadastroSistema.Text = GridCadastroSistema.CurrentRow.Cells[0].Value.ToString();
            txtUsuarioCadastroSistema.Text = GridCadastroSistema.CurrentRow.Cells[1].Value.ToString();
            txtSenhaCadastroSistema.Text = GridCadastroSistema.CurrentRow.Cells[2].Value.ToString();
            HabilitarCampos();
        }

        private void btnVoltarCadastroSistema_Click(object sender, EventArgs e) //Configurando botão Voltar
        {
            this.Close();
        }

        private void btnBuscarCadastroSistema_Click(object sender, EventArgs e) //Configurando botão Buscar
        {
            opc = "Buscar";
            iniciarOpc();

            if (txtUsuarioCadastroSistema.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Digite um usuário");
                return;
            }

            if (GridCadastroSistema.RowCount == 0) //Verificação de cadastro de usuário
            {
                MessageBox.Show("Usuário não encontrado");
                ListarGrid();
            }
        }
    }
}