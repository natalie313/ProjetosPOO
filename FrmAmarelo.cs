using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAmarelo : Form
    {
        public FrmAmarelo()
        {
            InitializeComponent();
        }

        private void Frm_Amarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo();   //Indico qual form será aberto;
            this.Close();   //fecha o forms atual;
            frm.ShowDialog();
        }

        private void FrmAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul();   //Indico qual form será aberto;
            this.Close();   //fecha o forms atual;
            frm.ShowDialog();
        }

        private void FrmVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho();   //Indico qual form será aberto;
            this.Close();   //fecha o forms atual;
            frm.ShowDialog();
        }
    }
}
