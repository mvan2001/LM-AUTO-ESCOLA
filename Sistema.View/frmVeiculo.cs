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
    public partial class frmVeiculo : Form
    {

        VeiculoEnt objtabela = new VeiculoEnt();

        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e) //Configurando botão novo
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
                        objtabela.Placa = txtPlacaVeiculo.Text;
                        List<VeiculoEnt> Lista = new List<VeiculoEnt>();
                        Lista = new VeiculoModel().Buscar(objtabela);
                        GridVeiculo.AutoGenerateColumns = false;
                        GridVeiculo.DataSource = Lista;
                    }

                    catch (Exception ex) //Caso ocorra erro
                    {
                        MessageBox.Show("Erro ao listar dados" + ex.Message);
                    }

                    break;

                case "Salvar": //Configurando função Salvar
                    try
                    {
                        objtabela.Chassi = txtChassiVeiculo.Text;
                        objtabela.Placa = txtPlacaVeiculo.Text;
                        objtabela.Modelo = txtModeloVeiculo.Text;
                        objtabela.Cor = txtCorVeiculo.Text;

                        if (txtChassiVeiculo.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtPlacaVeiculo.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtModeloVeiculo.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        if (txtCorVeiculo.Text == "") //Verificação de campos vazios
                        {
                            MessageBox.Show("Preencha todos os dados!");
                            return;
                        }

                        int x = VeiculoModel.Inserir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Veículo {0} salvo com sucesso", txtModeloVeiculo.Text)); //Cadastrando instrutor
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
                        objtabela.Id = (txtIdVeiculo.Text);

                        int x = VeiculoModel.Excluir(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Veículo {0} excluído com sucesso", txtModeloVeiculo.Text)); //Excluindo instrutor
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
                        objtabela.Id = txtIdVeiculo.Text;
                        objtabela.Chassi = txtChassiVeiculo.Text;
                        objtabela.Placa = txtPlacaVeiculo.Text;
                        objtabela.Modelo = txtModeloVeiculo.Text;
                        objtabela.Cor = txtCorVeiculo.Text;

                        int x = VeiculoModel.Editar(objtabela);
                        if (x > 0)
                        {
                            MessageBox.Show(String.Format("Veículo {0} editado com sucesso", txtModeloVeiculo.Text)); //Editando instrutor
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
            txtChassiVeiculo.Enabled = true;
            txtPlacaVeiculo.Enabled = true;
            txtModeloVeiculo.Enabled = true;
            txtCorVeiculo.Enabled = true;
        }

        private void DesabilitarCampos() //Configurando função DesabilitarCampos
        {
            txtChassiVeiculo.Enabled = false;
            txtPlacaVeiculo.Enabled = false;
            txtModeloVeiculo.Enabled = false;
            txtCorVeiculo.Enabled = false;
        }

        private void LimparCampos() //Configurando função LimparCampos
        {
            txtChassiVeiculo.Text = "";
            txtPlacaVeiculo.Text = "";
            txtModeloVeiculo.Text = "";
            txtCorVeiculo.Text = "";
            txtIdVeiculo.Text = "";
        }

        private void btnSalvarVeiculo_Click(object sender, EventArgs e) //Configurando botão salvar
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e) //Configurando botão excluir
        {
            if (txtIdVeiculo.Text == "") //Verificação de campos vazios
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

        private void btnEditarVeiculo_Click(object sender, EventArgs e) //Configurando botão editar
        {
            if (txtIdVeiculo.Text == "") //Verificação de campos vazios
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
                List<VeiculoEnt> Lista = new List<VeiculoEnt>();
                Lista = new VeiculoModel().Lista();
                GridVeiculo.AutoGenerateColumns = false;
                GridVeiculo.DataSource = Lista;
            }

            catch (Exception ex) //Caso ocorra erro
            {
                MessageBox.Show("Erro ao listar dados" + ex.Message);
            }
        }

        private void frmVeiculo_Load(object sender, EventArgs e) //Configurando o load do frmVeiculo
        {
            ListarGrid();
        }

        private void GridVeiculo_CellClick(object sender, DataGridViewCellEventArgs e) //Configurando CellClick da GridVeiculo
        {
            txtIdVeiculo.Text = GridVeiculo.CurrentRow.Cells[0].Value.ToString();
            txtChassiVeiculo.Text = GridVeiculo.CurrentRow.Cells[1].Value.ToString();
            txtPlacaVeiculo.Text = GridVeiculo.CurrentRow.Cells[2].Value.ToString();
            txtModeloVeiculo.Text = GridVeiculo.CurrentRow.Cells[3].Value.ToString();
            txtCorVeiculo.Text = GridVeiculo.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
        }

        private void btnVoltarVeiculo_Click(object sender, EventArgs e) //Configurando botão voltar
        {
            this.Close();
        }

        private void txtCorVeiculo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) //Configurando keypress para dígito de apenas letras
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarVeiculo_Click(object sender, EventArgs e) //Configurando botão buscar
        {
            opc = "Buscar";
            iniciarOpc();

            if (txtPlacaVeiculo.Text == "") //Verificação de campos vazios
            {
                MessageBox.Show("Digite uma placa");
                return;
            }

            if (GridVeiculo.RowCount == 0) //Verificação de cadastro de veiculo
            {
                MessageBox.Show("Veículo não encontrado");
                ListarGrid();
            }
        }
    }
}