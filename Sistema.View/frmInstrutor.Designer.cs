namespace Sistema.View
{
    partial class frmInstrutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstrutor));
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdInstrutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRgInstrutor = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneInstrutor = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfInstrutor = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeInstrutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridInstrutor = new System.Windows.Forms.DataGridView();
            this.frmInstrutor_Strip = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltarAluno = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridInstrutor)).BeginInit();
            this.frmInstrutor_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 130;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 112;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 120;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "rg";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 110;
            // 
            // txtIdInstrutor
            // 
            this.txtIdInstrutor.Location = new System.Drawing.Point(758, 616);
            this.txtIdInstrutor.Name = "txtIdInstrutor";
            this.txtIdInstrutor.Size = new System.Drawing.Size(16, 25);
            this.txtIdInstrutor.TabIndex = 139;
            this.txtIdInstrutor.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(29, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 137;
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
            this.label4.TabIndex = 136;
            this.label4.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(755, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 138;
            this.label7.Text = "Id:";
            this.label7.Visible = false;
            // 
            // txtRgInstrutor
            // 
            this.txtRgInstrutor.Location = new System.Drawing.Point(165, 176);
            this.txtRgInstrutor.Mask = "AA-00,00,000";
            this.txtRgInstrutor.Name = "txtRgInstrutor";
            this.txtRgInstrutor.Size = new System.Drawing.Size(117, 25);
            this.txtRgInstrutor.TabIndex = 3;
            this.txtRgInstrutor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneInstrutor
            // 
            this.txtTelefoneInstrutor.Location = new System.Drawing.Point(165, 225);
            this.txtTelefoneInstrutor.Mask = "(00) 00000-0000";
            this.txtTelefoneInstrutor.Name = "txtTelefoneInstrutor";
            this.txtTelefoneInstrutor.Size = new System.Drawing.Size(117, 25);
            this.txtTelefoneInstrutor.TabIndex = 4;
            this.txtTelefoneInstrutor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpfInstrutor
            // 
            this.txtCpfInstrutor.Location = new System.Drawing.Point(165, 119);
            this.txtCpfInstrutor.Mask = "000-000-000-00";
            this.txtCpfInstrutor.Name = "txtCpfInstrutor";
            this.txtCpfInstrutor.Size = new System.Drawing.Size(117, 25);
            this.txtCpfInstrutor.TabIndex = 2;
            this.txtCpfInstrutor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeInstrutor
            // 
            this.txtNomeInstrutor.Location = new System.Drawing.Point(165, 69);
            this.txtNomeInstrutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeInstrutor.Name = "txtNomeInstrutor";
            this.txtNomeInstrutor.Size = new System.Drawing.Size(463, 25);
            this.txtNomeInstrutor.TabIndex = 1;
            this.txtNomeInstrutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeInstrutor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 134;
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
            this.label3.TabIndex = 135;
            this.label3.Text = "Nome:";
            // 
            // GridInstrutor
            // 
            this.GridInstrutor.AllowUserToAddRows = false;
            this.GridInstrutor.AllowUserToDeleteRows = false;
            this.GridInstrutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInstrutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.CPF,
            this.RG,
            this.Telefone});
            this.GridInstrutor.Location = new System.Drawing.Point(34, 422);
            this.GridInstrutor.Margin = new System.Windows.Forms.Padding(4);
            this.GridInstrutor.Name = "GridInstrutor";
            this.GridInstrutor.ReadOnly = true;
            this.GridInstrutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridInstrutor.Size = new System.Drawing.Size(555, 194);
            this.GridInstrutor.TabIndex = 133;
            this.GridInstrutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInstrutor_CellClick);
            // 
            // frmInstrutor_Strip
            // 
            this.frmInstrutor_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.frmInstrutor_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.btnVoltarAluno});
            this.frmInstrutor_Strip.Location = new System.Drawing.Point(0, 0);
            this.frmInstrutor_Strip.Name = "frmInstrutor_Strip";
            this.frmInstrutor_Strip.Size = new System.Drawing.Size(784, 25);
            this.frmInstrutor_Strip.TabIndex = 140;
            this.frmInstrutor_Strip.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoInstrutor_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.btnSalvarInstrutor_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.btnExcluirInstrutor_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditarInstrutor_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(136, 21);
            this.buscarToolStripMenuItem.Text = "Buscar (Nome)";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btnBuscarInstrutor_Click);
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAluno.Image")));
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(72, 21);
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.Click += new System.EventHandler(this.btnVoltarInstrutor_Click);
            // 
            // frmInstrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.frmInstrutor_Strip);
            this.Controls.Add(this.txtIdInstrutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRgInstrutor);
            this.Controls.Add(this.txtTelefoneInstrutor);
            this.Controls.Add(this.txtCpfInstrutor);
            this.Controls.Add(this.txtNomeInstrutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridInstrutor);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInstrutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário - Instrutor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInstrutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridInstrutor)).EndInit();
            this.frmInstrutor_Strip.ResumeLayout(false);
            this.frmInstrutor_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.TextBox txtIdInstrutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtRgInstrutor;
        private System.Windows.Forms.MaskedTextBox txtTelefoneInstrutor;
        private System.Windows.Forms.MaskedTextBox txtCpfInstrutor;
        private System.Windows.Forms.TextBox txtNomeInstrutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridInstrutor;
        private System.Windows.Forms.MenuStrip frmInstrutor_Strip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarAluno;
    }
}