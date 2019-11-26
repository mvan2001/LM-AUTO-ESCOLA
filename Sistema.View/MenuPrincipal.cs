using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View
{
    public partial class MenuPrincipal : Form
    {
        public Form telaprincipal; //Declarando telaprincipal

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAluno().Show(); //Chamando form frmaluno
        }

        private void atendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAtendente().Show(); //Chamando form frmatendente
        }

        private void instrutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInstrutor().Show(); //Chamando form frminstrutor
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVeiculo().Show(); //Chamando form frmveículo
        }

        private void controleDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmControleDeAluno().Show(); //Chamando form frmcontroledealuno
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobre().Show(); //Chamando form sobre
        }    

        private void MenuPrincipal_Load(object sender, EventArgs e) //Configurando para exibir data
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void timer1_Tick(object sender, EventArgs e) //Configurando para exibir hora
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void encerrarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechando form
            new Login().Show();  //Abrindo form login
        }
    }
}