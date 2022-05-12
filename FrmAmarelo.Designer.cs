namespace AppExemploMenu
{
    partial class FrmAmarelo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frm_Amarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Frm_Amarelo,
            this.FrmAzul,
            this.FrmVermelho});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // Frm_Amarelo
            // 
            this.Frm_Amarelo.Name = "Frm_Amarelo";
            this.Frm_Amarelo.Size = new System.Drawing.Size(180, 22);
            this.Frm_Amarelo.Text = "Form Amarelo";
            this.Frm_Amarelo.Click += new System.EventHandler(this.Frm_Amarelo_Click);
            // 
            // FrmAzul
            // 
            this.FrmAzul.Name = "FrmAzul";
            this.FrmAzul.Size = new System.Drawing.Size(180, 22);
            this.FrmAzul.Text = "Form Azul";
            this.FrmAzul.Click += new System.EventHandler(this.FrmAzul_Click);
            // 
            // FrmVermelho
            // 
            this.FrmVermelho.Name = "FrmVermelho";
            this.FrmVermelho.Size = new System.Drawing.Size(180, 22);
            this.FrmVermelho.Text = "Form Vermelho";
            this.FrmVermelho.Click += new System.EventHandler(this.FrmVermelho_Click);
            // 
            // FrmAmarelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAmarelo";
            this.Text = "FrmPart2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Frm_Amarelo;
        private System.Windows.Forms.ToolStripMenuItem FrmAzul;
        private System.Windows.Forms.ToolStripMenuItem FrmVermelho;
    }
}