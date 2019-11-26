namespace Sistema.View
{
    partial class frmControleDeAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeAluno));
            this.txtIdControleDeAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeControleDeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridControleDeAluno = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrequenciaControleDeAluno = new System.Windows.Forms.TextBox();
            this.txtPagamentoControleDeAluno = new System.Windows.Forms.ComboBox();
            this.frmControleDeAluno_Strip = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltarAluno = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridControleDeAluno)).BeginInit();
            this.frmControleDeAluno_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdControleDeAluno
            // 
            this.txtIdControleDeAluno.Location = new System.Drawing.Point(758, 616);
            this.txtIdControleDeAluno.Name = "txtIdControleDeAluno";
            this.txtIdControleDeAluno.Size = new System.Drawing.Size(16, 25);
            this.txtIdControleDeAluno.TabIndex = 139;
            this.txtIdControleDeAluno.Visible = false;
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
            // txtNomeControleDeAluno
            // 
            this.txtNomeControleDeAluno.Location = new System.Drawing.Point(165, 69);
            this.txtNomeControleDeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeControleDeAluno.Name = "txtNomeControleDeAluno";
            this.txtNomeControleDeAluno.Size = new System.Drawing.Size(384, 25);
            this.txtNomeControleDeAluno.TabIndex = 1;
            this.txtNomeControleDeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeControleDeAluno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 134;
            this.label2.Text = "Frequência:";
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
            // GridControleDeAluno
            // 
            this.GridControleDeAluno.AllowUserToAddRows = false;
            this.GridControleDeAluno.AllowUserToDeleteRows = false;
            this.GridControleDeAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridControleDeAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.frequencia,
            this.pagamento});
            this.GridControleDeAluno.Location = new System.Drawing.Point(34, 422);
            this.GridControleDeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.GridControleDeAluno.Name = "GridControleDeAluno";
            this.GridControleDeAluno.ReadOnly = true;
            this.GridControleDeAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridControleDeAluno.Size = new System.Drawing.Size(486, 194);
            this.GridControleDeAluno.TabIndex = 133;
            this.GridControleDeAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridControleDeAluno_CellClick);
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
            // frequencia
            // 
            this.frequencia.DataPropertyName = "frequencia";
            this.frequencia.HeaderText = "Frequência";
            this.frequencia.Name = "frequencia";
            this.frequencia.ReadOnly = true;
            this.frequencia.Width = 112;
            // 
            // pagamento
            // 
            this.pagamento.DataPropertyName = "pagamento";
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 170;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 136;
            this.label4.Text = "Pagamento:";
            // 
            // txtFrequenciaControleDeAluno
            // 
            this.txtFrequenciaControleDeAluno.Location = new System.Drawing.Point(165, 116);
            this.txtFrequenciaControleDeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrequenciaControleDeAluno.Name = "txtFrequenciaControleDeAluno";
            this.txtFrequenciaControleDeAluno.Size = new System.Drawing.Size(384, 25);
            this.txtFrequenciaControleDeAluno.TabIndex = 2;
            this.txtFrequenciaControleDeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrequenciaControleDeAluno_KeyPress);
            // 
            // txtPagamentoControleDeAluno
            // 
            this.txtPagamentoControleDeAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPagamentoControleDeAluno.FormattingEnabled = true;
            this.txtPagamentoControleDeAluno.Items.AddRange(new object[] {
            "CARTÃO DE CRÉDITO",
            "BOLETO",
            "-"});
            this.txtPagamentoControleDeAluno.Location = new System.Drawing.Point(165, 173);
            this.txtPagamentoControleDeAluno.Name = "txtPagamentoControleDeAluno";
            this.txtPagamentoControleDeAluno.Size = new System.Drawing.Size(184, 25);
            this.txtPagamentoControleDeAluno.TabIndex = 3;
            // 
            // frmControleDeAluno_Strip
            // 
            this.frmControleDeAluno_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.frmControleDeAluno_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.btnVoltarAluno});
            this.frmControleDeAluno_Strip.Location = new System.Drawing.Point(0, 0);
            this.frmControleDeAluno_Strip.Name = "frmControleDeAluno_Strip";
            this.frmControleDeAluno_Strip.Size = new System.Drawing.Size(784, 25);
            this.frmControleDeAluno_Strip.TabIndex = 140;
            this.frmControleDeAluno_Strip.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoControleDeAluno_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.btnSalvarControleDeAluno_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.btnExcluirControleDeAluno_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditarControleDeAluno_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(136, 21);
            this.buscarToolStripMenuItem.Text = "Buscar (Nome)";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btnBuscarControleDeAluno_Click);
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAluno.Image")));
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(72, 21);
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.Click += new System.EventHandler(this.btnVoltarControleDeAluno_Click);
            // 
            // frmControleDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.frmControleDeAluno_Strip);
            this.Controls.Add(this.txtPagamentoControleDeAluno);
            this.Controls.Add(this.txtFrequenciaControleDeAluno);
            this.Controls.Add(this.txtIdControleDeAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeControleDeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridControleDeAluno);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmControleDeAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário - Controle De Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmControleDeAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControleDeAluno)).EndInit();
            this.frmControleDeAluno_Strip.ResumeLayout(false);
            this.frmControleDeAluno_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdControleDeAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeControleDeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridControleDeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrequenciaControleDeAluno;
        private System.Windows.Forms.ComboBox txtPagamentoControleDeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.MenuStrip frmControleDeAluno_Strip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarAluno;
    }
}