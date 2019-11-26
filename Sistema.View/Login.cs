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
    public partial class Login : Form
    {
        public Form telaprincipal; //Declarando telaprincipal

        public Login()
        {
            InitializeComponent();
        }

        private void Login_KeyUp(object sender, KeyEventArgs e) //Configurando botão login para ENTER 
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) //Conjunto de condições para error provider
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                epUsuario.Icon = Properties.Resources.Error;
                epUsuario.SetError(txtUsuario, "Insira o usuário");
            }

            else
            {
                epUsuario.Icon = Properties.Resources.Check;
                epUsuario.SetError(txtUsuario, "OK");
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                epSenha.Icon = Properties.Resources.Error;
                epSenha.SetError(txtSenha, "Insira a senha");
            }

            else
            {
                epSenha.Icon = Properties.Resources.Check;
                epSenha.SetError(txtSenha, "OK");
            }

            if (txtUsuario.Text == "")
            {
                epUsuario.Icon = Properties.Resources.Error;
                epUsuario.SetError(txtUsuario, "Insira o usuário");
                return;
            }

            if (txtSenha.Text == "")
            {
                epSenha.Icon = Properties.Resources.Error;
                epSenha.SetError(txtSenha, "Insira a senha");
                return;
            }

            try
            {
                CadastroSistemaEnt obj = new CadastroSistemaEnt();
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;
                obj = new CadastroSistemaModel().Login(obj);

                if (obj.Usuario == null) //Caso usuário não esteja cadastrado
                {
                    lbMensagem.Text = "Usuário e/ou senha não encontrado";
                    lbMensagem.ForeColor = Color.Red;
                    return;
                }

                MenuPrincipal Form = new MenuPrincipal() { telaprincipal = this }; //Fechando tela de login e abrindo menu principal
                this.Hide();
                Form.Show();

                //Caso esteja cadastrado
                MessageBox.Show("Bem-vindo ao sistema");
            }

            catch (Exception ex) //Caso ocorra erro
            {
                MessageBox.Show("Erro ao logar" + ex.Message);
                this.Hide();
                this.Close();
                {
                }
            }
        }

        private void btnCadastroSistema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Atalho para fazer cadastro no sistema
        {
            frmCadastroSistema form = new frmCadastroSistema();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit(); //Chamando opção sair
        }
    }
}