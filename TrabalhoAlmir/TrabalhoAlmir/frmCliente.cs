using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAlmir.Camadas;

namespace TrabalhoAlmir
{
    public partial class frmCliente : Form
    {
        private object lstCliente;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void  Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtNumero.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtFone.Enabled = status;
            dgvClientes.Enabled = !status;

            //programando os botões
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtFone.Text = "";
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = bllCliente.Select();
            pnlPesquisa.Visible = false;
            Habilitar(false);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                lblId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtNumero.Text = dgvClientes.SelectedRows[0].Cells["numero"].Value.ToString();
                txtCidade.Text = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvClientes.SelectedRows[0].Cells["estado"].Value.ToString();
                txtFone.Text = dgvClientes.SelectedRows[0].Cells["fone"].Value.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblId.Text = "-1";
            Habilitar(true);
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                Habilitar(true);
                txtNome.Focus();
            }
            else
            {
                string msg = " Não tem registros para fazer edição ";
                MessageBox.Show(msg, "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            int id = Convert.ToInt32(lblId.Text);

            string msg;
            if (id == -1)
                msg = "Confirma inserção dos dados?";
            else msg = "Confirma alteração dos dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                cliente.id = id;
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.numero = txtNumero.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.fone = txtFone.Text;

                if (id == -1)
                    bllCli.Insert(cliente);
               else bllCli.Uptade(cliente);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
            limparCampos();
            Habilitar(false);



        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Deseja Remover o Cliente Selecionado?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    cliente.id = Convert.ToInt32(lblId.Text);
                    bllCli.Delete(cliente);
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
            limparCampos();
            Habilitar(false);

        }

       
        private void rbdTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Cliente bllProd = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllProd.Select();

        }

        private void rbdId_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rbdNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe a Descricao: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            if (pnlPesquisa.Visible == true)
                rbdTodos.Checked = true;
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Camadas.Model.Cliente> lstcliente = new List<Camadas.Model.Cliente>();
            Camadas.BLL.Cliente bllcliente = new Camadas.BLL.Cliente();

            if (rbdId.Checked)
            {
                if (txtPesquisa.Text != string.Empty)
                    lstCliente = bllcliente.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else MessageBox.Show("ID vazio", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbdNome.Checked)
                lstCliente = bllcliente.SelectByNome(txtPesquisa.Text.Trim());

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = lstCliente;
        }
    }
}

