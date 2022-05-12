namespace AppExemploMenu
{
    partial class FrmVermelho
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.Frm_Vermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrmAmarelo,
            this.FrmAzul,
            this.Frm_Vermelho});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // FrmAmarelo
            // 
            this.FrmAmarelo.Name = "FrmAmarelo";
            this.FrmAmarelo.Size = new System.Drawing.Size(180, 22);
            this.FrmAmarelo.Text = "Form Amarelo";
            this.FrmAmarelo.Click += new System.EventHandler(this.FrmAmarelo_Click);
            // 
            // FrmAzul
            // 
            this.FrmAzul.Name = "FrmAzul";
            this.FrmAzul.Size = new System.Drawing.Size(180, 22);
            this.FrmAzul.Text = "Form Azul";
            this.FrmAzul.Click += new System.EventHandler(this.FrmAzul_Click);
            // 
            // Frm_Vermelho
            // 
            this.Frm_Vermelho.Name = "Frm_Vermelho";
            this.Frm_Vermelho.Size = new System.Drawing.Size(180, 22);
            this.Frm_Vermelho.Text = "Form Vermelho";
            this.Frm_Vermelho.Click += new System.EventHandler(this.Frm_Vermelho_Click);
            // 
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(677, 389);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVermelho";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FrmAmarelo;
        private System.Windows.Forms.ToolStripMenuItem FrmAzul;
        private System.Windows.Forms.ToolStripMenuItem Frm_Vermelho;
    }
}

