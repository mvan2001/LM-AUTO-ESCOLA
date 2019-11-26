namespace Sistema.View
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal2_Strip = new System.Windows.Forms.MenuStrip();
            this.encerrarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal_Strip = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuPrincipal2_Strip.SuspendLayout();
            this.MenuPrincipal_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem1.Image")));
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(109, 54);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // MenuPrincipal2_Strip
            // 
            this.MenuPrincipal2_Strip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrincipal2_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.MenuPrincipal2_Strip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.MenuPrincipal2_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1,
            this.encerrarSessãoToolStripMenuItem});
            this.MenuPrincipal2_Strip.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal2_Strip.Name = "MenuPrincipal2_Strip";
            this.MenuPrincipal2_Strip.Size = new System.Drawing.Size(1324, 58);
            this.MenuPrincipal2_Strip.TabIndex = 1;
            this.MenuPrincipal2_Strip.Text = "menuStrip1";
            // 
            // encerrarSessãoToolStripMenuItem
            // 
            this.encerrarSessãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("encerrarSessãoToolStripMenuItem.Image")));
            this.encerrarSessãoToolStripMenuItem.Name = "encerrarSessãoToolStripMenuItem";
            this.encerrarSessãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.encerrarSessãoToolStripMenuItem.Size = new System.Drawing.Size(179, 54);
            this.encerrarSessãoToolStripMenuItem.Text = "Encerrar sessão";
            this.encerrarSessãoToolStripMenuItem.Click += new System.EventHandler(this.encerrarSessãoToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(212, 221);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // atendenteToolStripMenuItem
            // 
            this.atendenteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.atendenteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atendenteToolStripMenuItem.Image")));
            this.atendenteToolStripMenuItem.Name = "atendenteToolStripMenuItem";
            this.atendenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.atendenteToolStripMenuItem.Size = new System.Drawing.Size(212, 221);
            this.atendenteToolStripMenuItem.Text = "Atendente";
            this.atendenteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.atendenteToolStripMenuItem.Click += new System.EventHandler(this.atendenteToolStripMenuItem_Click);
            // 
            // instrutorToolStripMenuItem
            // 
            this.instrutorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.instrutorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instrutorToolStripMenuItem.Image")));
            this.instrutorToolStripMenuItem.Name = "instrutorToolStripMenuItem";
            this.instrutorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.instrutorToolStripMenuItem.Size = new System.Drawing.Size(212, 221);
            this.instrutorToolStripMenuItem.Text = "Instrutor";
            this.instrutorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.instrutorToolStripMenuItem.Click += new System.EventHandler(this.instrutorToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.veículoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("veículoToolStripMenuItem.Image")));
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(212, 221);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // controleDeAlunoToolStripMenuItem
            // 
            this.controleDeAlunoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.controleDeAlunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controleDeAlunoToolStripMenuItem.Image")));
            this.controleDeAlunoToolStripMenuItem.Name = "controleDeAlunoToolStripMenuItem";
            this.controleDeAlunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.controleDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(212, 221);
            this.controleDeAlunoToolStripMenuItem.Text = "Controle De Aluno";
            this.controleDeAlunoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.controleDeAlunoToolStripMenuItem.Click += new System.EventHandler(this.controleDeAlunoToolStripMenuItem_Click);
            // 
            // MenuPrincipal_Strip
            // 
            this.MenuPrincipal_Strip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrincipal_Strip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuPrincipal_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.MenuPrincipal_Strip.GripMargin = new System.Windows.Forms.Padding(2);
            this.MenuPrincipal_Strip.ImageScalingSize = new System.Drawing.Size(200, 200);
            this.MenuPrincipal_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.atendenteToolStripMenuItem,
            this.instrutorToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.controleDeAlunoToolStripMenuItem});
            this.MenuPrincipal_Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuPrincipal_Strip.Location = new System.Drawing.Point(0, 58);
            this.MenuPrincipal_Strip.Margin = new System.Windows.Forms.Padding(1);
            this.MenuPrincipal_Strip.Name = "MenuPrincipal_Strip";
            this.MenuPrincipal_Strip.Padding = new System.Windows.Forms.Padding(150, 150, 0, 3);
            this.MenuPrincipal_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuPrincipal_Strip.ShowItemToolTips = true;
            this.MenuPrincipal_Strip.Size = new System.Drawing.Size(1324, 374);
            this.MenuPrincipal_Strip.Stretch = false;
            this.MenuPrincipal_Strip.TabIndex = 0;
            this.MenuPrincipal_Strip.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1279, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1279, 684);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 684);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "LM AUTO-ESCOLA ©";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1324, 710);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuPrincipal_Strip);
            this.Controls.Add(this.MenuPrincipal2_Strip);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal2_Strip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.MenuPrincipal2_Strip.ResumeLayout(false);
            this.MenuPrincipal2_Strip.PerformLayout();
            this.MenuPrincipal_Strip.ResumeLayout(false);
            this.MenuPrincipal_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip MenuPrincipal2_Strip;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeAlunoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuPrincipal_Strip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem encerrarSessãoToolStripMenuItem;
    }
}