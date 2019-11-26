namespace Sistema.View
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.label1 = new System.Windows.Forms.Label();
            this.Sobre_Strip = new System.Windows.Forms.MenuStrip();
            this.btnVoltarSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sobre_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Versão 1.0";
            // 
            // Sobre_Strip
            // 
            this.Sobre_Strip.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Sobre_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltarSobre});
            this.Sobre_Strip.Location = new System.Drawing.Point(0, 0);
            this.Sobre_Strip.Name = "Sobre_Strip";
            this.Sobre_Strip.Size = new System.Drawing.Size(784, 25);
            this.Sobre_Strip.TabIndex = 141;
            this.Sobre_Strip.Text = "menuStrip1";
            this.Sobre_Strip.Click += new System.EventHandler(this.btnVoltarSobre_Click);
            // 
            // btnVoltarSobre
            // 
            this.btnVoltarSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarSobre.Image")));
            this.btnVoltarSobre.Name = "btnVoltarSobre";
            this.btnVoltarSobre.Size = new System.Drawing.Size(72, 21);
            this.btnVoltarSobre.Text = "Voltar";
            this.btnVoltarSobre.Click += new System.EventHandler(this.btnVoltarSobre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 17);
            this.label2.TabIndex = 143;
            this.label2.Text = "Desenvolvido Por Lucas e Matheus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 142;
            this.label3.Text = "Versão 2.0";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sobre_Strip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Sobre_Strip.ResumeLayout(false);
            this.Sobre_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip Sobre_Strip;
        private System.Windows.Forms.ToolStripMenuItem btnVoltarSobre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}