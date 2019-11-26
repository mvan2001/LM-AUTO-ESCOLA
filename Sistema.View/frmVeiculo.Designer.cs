namespace Sistema.View
{
    partial class frmVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculo));
            this.txtIdVeiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.txtChassiVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridVeiculo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtModeloVeiculo = new System.Windows.Forms.TextBox();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.frmVeiculo_Strip = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltarAluno = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculo)).BeginInit();
            this.frmVeiculo_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdVeiculo
            // 
            this.txtIdVeiculo.Location = new System.Drawing.Point(758, 616);
            this.txtIdVeiculo.Name = "txtIdVeiculo";
            this.txtIdVeiculo.Size = new System.Drawing.Size(16, 25);
            this.txtIdVeiculo.TabIndex = 139;
            this.txtIdVeiculo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(29, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 137;
            this.label5.Text = "Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 136;
            this.label4.Text = "Modelo:";
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
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(165, 119);
            this.txtPlacaVeiculo.Mask = "AAA-0000";
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(71, 25);
            this.txtPlacaVeiculo.TabIndex = 2;
            this.txtPlacaVeiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtChassiVeiculo
            // 
            this.txtChassiVeiculo.Location = new System.Drawing.Point(165, 69);
            this.txtChassiVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtChassiVeiculo.Name = "txtChassiVeiculo";
            this.txtChassiVeiculo.Size = new System.Drawing.Size(384, 25);
            this.txtChassiVeiculo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 134;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "N° do Chassi:";
            // 
            // GridVeiculo
            // 
            this.GridVeiculo.AllowUserToAddRows = false;
            this.GridVeiculo.AllowUserToDeleteRows = false;
            this.GridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Chassi,
            this.Placa,
            this.modelo,
            this.cor});
            this.GridVeiculo.Location = new System.Drawing.Point(34, 422);
            this.GridVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.GridVeiculo.Name = "GridVeiculo";
            this.GridVeiculo.ReadOnly = true;
            this.GridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVeiculo.Size = new System.Drawing.Size(578, 194);
            this.GridVeiculo.TabIndex = 133;
            this.GridVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVeiculo_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Chassi
            // 
            this.Chassi.DataPropertyName = "chassi";
            this.Chassi.HeaderText = "Nº do Chassi";
            this.Chassi.Name = "Chassi";
            this.Chassi.ReadOnly = true;
            this.Chassi.Width = 150;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 120;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 112;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "cor";
            this.cor.HeaderText = "Cor";
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            this.cor.Width = 110;
            // 
            // txtModeloVeiculo
            // 
            this.txtModeloVeiculo.Location = new System.Drawing.Point(165, 176);
            this.txtModeloVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModeloVeiculo.Name = "txtModeloVeiculo";
            this.txtModeloVeiculo.Size = new System.Drawing.Size(384, 25);
            this.txtModeloVeiculo.TabIndex = 3;
            
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Location = new System.Drawing.Point(165, 225);
            this.txtCorVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(384, 25);
            this.txtCorVeiculo.TabIndex = 4;
            this.txtCorVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorVeiculo_KeyPress);
            // 
            // frmVeiculo_Strip
            // 
            this.frmVeiculo_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.frmVeiculo_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.btnVoltarAluno});
            this.frmVeiculo_Strip.Location = new System.Drawing.Point(0, 0);
            this.frmVeiculo_Strip.Name = "frmVeiculo_Strip";
            this.frmVeiculo_Strip.Size = new System.Drawing.Size(784, 25);
            this.frmVeiculo_Strip.TabIndex = 140;
            this.frmVeiculo_Strip.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoVeiculo_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.btnSalvarVeiculo_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.btnExcluirVeiculo_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditarVeiculo_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(134, 21);
            this.buscarToolStripMenuItem.Text = "Buscar (Placa)";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btnBuscarVeiculo_Click);
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAluno.Image")));
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(72, 21);
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.Click += new System.EventHandler(this.btnVoltarVeiculo_Click);
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.frmVeiculo_Strip);
            this.Controls.Add(this.txtCorVeiculo);
            this.Controls.Add(this.txtModeloVeiculo);
            this.Controls.Add(this.txtIdVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlacaVeiculo);
            this.Controls.Add(this.txtChassiVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridVeiculo);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário - Veículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculo)).EndInit();
            this.frmVeiculo_Strip.ResumeLayout(false);
            this.frmVeiculo_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdVeiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtPlacaVeiculo;
        private System.Windows.Forms.TextBox txtChassiVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridVeiculo;
        private System.Windows.Forms.TextBox txtModeloVeiculo;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.MenuStrip frmVeiculo_Strip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarAluno;
    }
}