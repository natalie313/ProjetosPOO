namespace AppExemploMenu
{
    partial class FrmAzul
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
            this.Exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.Frm_Azul = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exibir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Exibir
            // 
            this.Exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrmAmarelo,
            this.Frm_Azul,
            this.FrmVermelho});
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(47, 20);
            this.Exibir.Text = "Exibir";
            // 
            // FrmAmarelo
            // 
            this.FrmAmarelo.Name = "FrmAmarelo";
            this.FrmAmarelo.Size = new System.Drawing.Size(180, 22);
            this.FrmAmarelo.Text = "Form Amarelo";
            this.FrmAmarelo.Click += new System.EventHandler(this.FrmAmarelo_Click);
            // 
            // Frm_Azul
            // 
            this.Frm_Azul.Name = "Frm_Azul";
            this.Frm_Azul.Size = new System.Drawing.Size(180, 22);
            this.Frm_Azul.Text = "Form Azul";
            this.Frm_Azul.Click += new System.EventHandler(this.Frm_Azul_Click);
            // 
            // FrmVermelho
            // 
            this.FrmVermelho.Name = "FrmVermelho";
            this.FrmVermelho.Size = new System.Drawing.Size(180, 22);
            this.FrmVermelho.Text = "Form Vermelho";
            this.FrmVermelho.Click += new System.EventHandler(this.FrmVermelho_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAzul";
            this.Text = "FrmPart3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Exibir;
        private System.Windows.Forms.ToolStripMenuItem FrmAmarelo;
        private System.Windows.Forms.ToolStripMenuItem Frm_Azul;
        private System.Windows.Forms.ToolStripMenuItem FrmVermelho;
    }
}