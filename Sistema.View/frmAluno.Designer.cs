namespace Sistema.View
{
    partial class frmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.GridAluno = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaCNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorárioDeAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtRgAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAluno_Strip = new System.Windows.Forms.MenuStrip();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCategoriacnhAluno = new System.Windows.Forms.ComboBox();
            this.txtHorarioDeAulaAluno = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GridAluno)).BeginInit();
            this.frmAluno_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridAluno
            // 
            this.GridAluno.AllowUserToAddRows = false;
            this.GridAluno.AllowUserToDeleteRows = false;
            this.GridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.CPF,
            this.RG,
            this.Telefone,
            this.CategoriaCNH,
            this.HorárioDeAula});
            resources.ApplyResources(this.GridAluno, "GridAluno");
            this.GridAluno.Name = "GridAluno";
            this.GridAluno.ReadOnly = true;
            this.GridAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAluno_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            resources.ApplyResources(this.CPF, "CPF");
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "rg";
            resources.ApplyResources(this.RG, "RG");
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "telefone";
            resources.ApplyResources(this.Telefone, "Telefone");
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // CategoriaCNH
            // 
            this.CategoriaCNH.DataPropertyName = "categoriacnh";
            resources.ApplyResources(this.CategoriaCNH, "CategoriaCNH");
            this.CategoriaCNH.Name = "CategoriaCNH";
            this.CategoriaCNH.ReadOnly = true;
            // 
            // HorárioDeAula
            // 
            this.HorárioDeAula.DataPropertyName = "Horariodeaula";
            resources.ApplyResources(this.HorárioDeAula, "HorárioDeAula");
            this.HorárioDeAula.Name = "HorárioDeAula";
            this.HorárioDeAula.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtNomeAluno
            // 
            resources.ApplyResources(this.txtNomeAluno, "txtNomeAluno");
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtCpfAluno
            // 
            resources.ApplyResources(this.txtCpfAluno, "txtCpfAluno");
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneAluno
            // 
            resources.ApplyResources(this.txtTelefoneAluno, "txtTelefoneAluno");
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtRgAluno
            // 
            resources.ApplyResources(this.txtRgAluno, "txtRgAluno");
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtIdAluno
            // 
            resources.ApplyResources(this.txtIdAluno, "txtIdAluno");
            this.txtIdAluno.Name = "txtIdAluno";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // novoToolStripMenuItem
            // 
            resources.ApplyResources(this.novoToolStripMenuItem, "novoToolStripMenuItem");
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // salvarToolStripMenuItem
            // 
            resources.ApplyResources(this.salvarToolStripMenuItem, "salvarToolStripMenuItem");
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // excluirToolStripMenuItem
            // 
            resources.ApplyResources(this.excluirToolStripMenuItem, "excluirToolStripMenuItem");
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // editarToolStripMenuItem
            // 
            resources.ApplyResources(this.editarToolStripMenuItem, "editarToolStripMenuItem");
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // frmAluno_Strip
            // 
            resources.ApplyResources(this.frmAluno_Strip, "frmAluno_Strip");
            this.frmAluno_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.btnVoltarAluno});
            this.frmAluno_Strip.Name = "frmAluno_Strip";
            // 
            // buscarToolStripMenuItem
            // 
            resources.ApplyResources(this.buscarToolStripMenuItem, "buscarToolStripMenuItem");
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnVoltarAluno
            // 
            resources.ApplyResources(this.btnVoltarAluno, "btnVoltarAluno");
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Click += new System.EventHandler(this.btnVoltarAluno_Click);
            // 
            // txtCategoriacnhAluno
            // 
            this.txtCategoriacnhAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoriacnhAluno.FormattingEnabled = true;
            this.txtCategoriacnhAluno.Items.AddRange(new object[] {
            resources.GetString("txtCategoriacnhAluno.Items"),
            resources.GetString("txtCategoriacnhAluno.Items1"),
            resources.GetString("txtCategoriacnhAluno.Items2"),
            resources.GetString("txtCategoriacnhAluno.Items3"),
            resources.GetString("txtCategoriacnhAluno.Items4")});
            resources.ApplyResources(this.txtCategoriacnhAluno, "txtCategoriacnhAluno");
            this.txtCategoriacnhAluno.Name = "txtCategoriacnhAluno";
            // 
            // txtHorarioDeAulaAluno
            // 
            resources.ApplyResources(this.txtHorarioDeAulaAluno, "txtHorarioDeAulaAluno");
            this.txtHorarioDeAulaAluno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHorarioDeAulaAluno.Name = "txtHorarioDeAulaAluno";
            this.txtHorarioDeAulaAluno.ShowUpDown = true;
            this.txtHorarioDeAulaAluno.Tag = "";
            this.txtHorarioDeAulaAluno.Value = new System.DateTime(2019, 11, 16, 0, 0, 0, 0);
            // 
            // frmAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHorarioDeAulaAluno);
            this.Controls.Add(this.txtCategoriacnhAluno);
            this.Controls.Add(this.txtIdAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRgAluno);
            this.Controls.Add(this.txtTelefoneAluno);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridAluno);
            this.Controls.Add(this.frmAluno_Strip);
            this.MainMenuStrip = this.frmAluno_Strip;
            this.Name = "frmAluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAluno)).EndInit();
            this.frmAluno_Strip.ResumeLayout(false);
            this.frmAluno_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCpfAluno;
        private System.Windows.Forms.MaskedTextBox txtTelefoneAluno;
        private System.Windows.Forms.MaskedTextBox txtRgAluno;
        private System.Windows.Forms.TextBox txtIdAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaCNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorárioDeAula;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip frmAluno_Strip;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarAluno;
        private System.Windows.Forms.ComboBox txtCategoriacnhAluno;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker txtHorarioDeAulaAluno;
    }
}