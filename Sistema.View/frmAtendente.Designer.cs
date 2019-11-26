namespace Sistema.View
{
    partial class frmAtendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendente));
            this.txtIdAtendente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRgAtendente = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneAtendente = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfAtendente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeAtendente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridAtendente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmAtendente_Strip = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltarAluno = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridAtendente)).BeginInit();
            this.frmAtendente_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdAtendente
            // 
            this.txtIdAtendente.Location = new System.Drawing.Point(758, 616);
            this.txtIdAtendente.Name = "txtIdAtendente";
            this.txtIdAtendente.Size = new System.Drawing.Size(16, 25);
            this.txtIdAtendente.TabIndex = 127;
            this.txtIdAtendente.Visible = false;
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
            // txtRgAtendente
            // 
            this.txtRgAtendente.Location = new System.Drawing.Point(165, 176);
            this.txtRgAtendente.Mask = "AA-00,000,000";
            this.txtRgAtendente.Name = "txtRgAtendente";
            this.txtRgAtendente.Size = new System.Drawing.Size(118, 25);
            this.txtRgAtendente.TabIndex = 3;
            this.txtRgAtendente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneAtendente
            // 
            this.txtTelefoneAtendente.Location = new System.Drawing.Point(165, 225);
            this.txtTelefoneAtendente.Mask = "(00) 00000-0000";
            this.txtTelefoneAtendente.Name = "txtTelefoneAtendente";
            this.txtTelefoneAtendente.Size = new System.Drawing.Size(118, 25);
            this.txtTelefoneAtendente.TabIndex = 4;
            this.txtTelefoneAtendente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpfAtendente
            // 
            this.txtCpfAtendente.Location = new System.Drawing.Point(165, 119);
            this.txtCpfAtendente.Mask = "000-000-000-00";
            this.txtCpfAtendente.Name = "txtCpfAtendente";
            this.txtCpfAtendente.Size = new System.Drawing.Size(118, 25);
            this.txtCpfAtendente.TabIndex = 2;
            this.txtCpfAtendente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(29, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 123;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 122;
            this.label4.Text = "RG:";
            // 
            // txtNomeAtendente
            // 
            this.txtNomeAtendente.Location = new System.Drawing.Point(165, 69);
            this.txtNomeAtendente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeAtendente.Name = "txtNomeAtendente";
            this.txtNomeAtendente.Size = new System.Drawing.Size(462, 25);
            this.txtNomeAtendente.TabIndex = 1;
            this.txtNomeAtendente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAtendente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 120;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 121;
            this.label3.Text = "Nome:";
            // 
            // GridAtendente
            // 
            this.GridAtendente.AllowUserToAddRows = false;
            this.GridAtendente.AllowUserToDeleteRows = false;
            this.GridAtendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAtendente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.CPF,
            this.RG,
            this.Telefone});
            this.GridAtendente.Location = new System.Drawing.Point(34, 422);
            this.GridAtendente.Margin = new System.Windows.Forms.Padding(4);
            this.GridAtendente.Name = "GridAtendente";
            this.GridAtendente.ReadOnly = true;
            this.GridAtendente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAtendente.Size = new System.Drawing.Size(555, 194);
            this.GridAtendente.TabIndex = 119;
            this.GridAtendente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAtendente_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 120;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 112;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "rg";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 110;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 130;
            // 
            // frmAtendente_Strip
            // 
            this.frmAtendente_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.frmAtendente_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.btnVoltarAluno});
            this.frmAtendente_Strip.Location = new System.Drawing.Point(0, 0);
            this.frmAtendente_Strip.Name = "frmAtendente_Strip";
            this.frmAtendente_Strip.Size = new System.Drawing.Size(784, 25);
            this.frmAtendente_Strip.TabIndex = 128;
            this.frmAtendente_Strip.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoAtendente_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.btnSalvarAtendente_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.btnExcluirAtendente_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditarAtendente_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(136, 21);
            this.buscarToolStripMenuItem.Text = "Buscar (Nome)";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btnBuscarAtendente_Click);
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAluno.Image")));
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(72, 21);
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.Click += new System.EventHandler(this.btnVoltarAtendente_Click);
            // 
            // frmAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.frmAtendente_Strip);
            this.Controls.Add(this.txtIdAtendente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRgAtendente);
            this.Controls.Add(this.txtTelefoneAtendente);
            this.Controls.Add(this.txtCpfAtendente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeAtendente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridAtendente);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário - Atendente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAtendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAtendente)).EndInit();
            this.frmAtendente_Strip.ResumeLayout(false);
            this.frmAtendente_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdAtendente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtRgAtendente;
        private System.Windows.Forms.MaskedTextBox txtTelefoneAtendente;
        private System.Windows.Forms.MaskedTextBox txtCpfAtendente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeAtendente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.MenuStrip frmAtendente_Strip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarAluno;
    }
}