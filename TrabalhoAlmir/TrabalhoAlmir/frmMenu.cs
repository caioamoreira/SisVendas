using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAlmir
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto();
            frmProd.MdiParent = this;
            frmProd.Show();

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVen = new frmVendas();
            frmVen.MdiParent = this;
            frmVen.Show();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.MdiParent = this;
            frmSob.Show();


        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio.relProd.impRelProd();
         

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio.relCliente.impRelCliente();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorio.relVendas.impRelVendas();
        }
    }
}
