namespace Sistema.View
{
    partial class frmCadastroSistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroSistema));
            this.txtIdCadastroSistema = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuarioCadastroSistema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaCadastroSistema = new System.Windows.Forms.TextBox();
            this.GridCadastroSistema = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmCadastroSistema_Strip = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltarAluno = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridCadastroSistema)).BeginInit();
            this.frmCadastroSistema_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdCadastroSistema
            // 
            this.txtIdCadastroSistema.Location = new System.Drawing.Point(758, 616);
            this.txtIdCadastroSistema.Name = "txtIdCadastroSistema";
            this.txtIdCadastroSistema.Size = new System.Drawing.Size(16, 25);
            this.txtIdCadastroSistema.TabIndex = 127;
            this.txtIdCadastroSistema.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(755, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 126;
            this.label7.Text = "Id:";
            this.label7.Visible = false;
            // 
            // txtUsuarioCadastroSistema
            // 
            this.txtUsuarioCadastroSistema.Location = new System.Drawing.Point(165, 69);
            this.txtUsuarioCadastroSistema.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioCadastroSistema.Name = "txtUsuarioCadastroSistema";
            this.txtUsuarioCadastroSistema.Size = new System.Drawing.Size(384, 25);
            this.txtUsuarioCadastroSistema.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 120;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 121;
            this.label3.Text = "Usuário:";
            // 
            // txtSenhaCadastroSistema
            // 
            this.txtSenhaCadastroSistema.Location = new System.Drawing.Point(165, 119);
            this.txtSenhaCadastroSistema.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaCadastroSistema.Name = "txtSenhaCadastroSistema";
            this.txtSenhaCadastroSistema.PasswordChar = '*';
            this.txtSenhaCadastroSistema.Size = new System.Drawing.Size(384, 25);
            this.txtSenhaCadastroSistema.TabIndex = 2;
            // 
            // GridCadastroSistema
            // 
            this.GridCadastroSistema.AllowUserToAddRows = false;
            this.GridCadastroSistema.AllowUserToDeleteRows = false;
            this.GridCadastroSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCadastroSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Senha});
            this.GridCadastroSistema.Location = new System.Drawing.Point(32, 447);
            this.GridCadastroSistema.Margin = new System.Windows.Forms.Padding(4);
            this.GridCadastroSistema.Name = "GridCadastroSistema";
            this.GridCadastroSistema.ReadOnly = true;
            this.GridCadastroSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCadastroSistema.Size = new System.Drawing.Size(316, 194);
            this.GridCadastroSistema.TabIndex = 130;
            this.GridCadastroSistema.Visible = false;
            this.GridCadastroSistema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCadastroSistema_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 120;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Width = 112;
            // 
            // frmCadastroSistema_Strip
            // 
            this.frmCadastroSistema_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.frmCadastroSistema_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.btnVoltarAluno});
            this.frmCadastroSistema_Strip.Location = new System.Drawing.Point(0, 0);
            this.frmCadastroSistema_Strip.Name = "frmCadastroSistema_Strip";
            this.frmCadastroSistema_Strip.Size = new System.Drawing.Size(784, 25);
            this.frmCadastroSistema_Strip.TabIndex = 131;
            this.frmCadastroSistema_Strip.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Visible = false;
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoCadastroSistema_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.btnSalvarCadastroSistema_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Visible = false;
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.btnExcluirCadastroSistema_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Visible = false;
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditarCadastroSistema_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(147, 21);
            this.buscarToolStripMenuItem.Text = "Buscar (Usuário)";
            this.buscarToolStripMenuItem.Visible = false;
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btnBuscarCadastroSistema_Click);
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAluno.Image")));
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(72, 21);
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.Click += new System.EventHandler(this.btnVoltarCadastroSistema_Click);
            // 
            // frmCadastroSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.frmCadastroSistema_Strip);
            this.Controls.Add(this.GridCadastroSistema);
            this.Controls.Add(this.txtSenhaCadastroSistema);
            this.Controls.Add(this.txtIdCadastroSistema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsuarioCadastroSistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastroSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCadastroSistema)).EndInit();
            this.frmCadastroSistema_Strip.ResumeLayout(false);
            this.frmCadastroSistema_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCadastroSistema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuarioCadastroSistema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaCadastroSistema;
        private System.Windows.Forms.DataGridView GridCadastroSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.MenuStrip frmCadastroSistema_Strip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarAluno;
    }
}