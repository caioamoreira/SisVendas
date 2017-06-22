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
    public partial class frmVendas : Form
    {

        Camadas.Model.Produto produto = new Camadas.Model.Produto();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            HabilitaControlesVendas(false);
            HabilitaControlesItemVendas(false);
            LimpaControlesVendas();
            LimpaControlesIV();
            Camadas.BLL.Vendas bllVendas = new Camadas.BLL.Vendas();
            Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();

            dgvVendas.DataSource = bllVendas.Select();
            dgvItemVendas.DataSource = bllItemVendas.Select();

            //Carregamento de Combobox
            //Cliente
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCliente.Select();

            //Produto
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = bllProduto.Select();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaControlesVendas(bool status)
        {
            dtpData.Enabled = status;
            txtCliente.Enabled = status;
            cmbCliente.Enabled = status;
            dgvVendas.Enabled = !status;

            //botões
            btnInserir.Enabled = !status;
            btnInserir.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;

        }

        private void LimpaControlesVendas()
        {
            lblVendas.Text = "";
            txtCliente.Text = "";
            dtpData.Value = DateTime.Now.Date;

        }

        private void HabilitaControlesItemVendas(bool status)
        {
            txtProduto.Enabled = status;
            cmbProduto.Enabled = status;
            dgvItemVendas.Enabled = !status;

            //botões
            btnIns.Enabled = !status;
            btnEdt.Enabled = !status;
            btnRem.Enabled = !status;
            btnGra.Enabled = status;
            btnCan.Enabled = status;

        }

        private void LimpaControlesIV()
        {
            lblId.Text = "";
            txtProduto.Text = "";
            txtValor.Text = "";
            txtPago.Text = "";
            lblTroco.Text = "";
            lblStatus.Text = "";

        }

        private void RecuperaDadosProduto()
        {
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lstProd = new List<Camadas.Model.Produto>();
            lstProd = bllProduto.SelectById(Convert.ToInt32(txtProduto.Text));
            if (lstProd != null)
                produto = lstProd[0];
            else MessageBox.Show("Produto não encontrado");
            if (produto.status != 'E')
            {
                MessageBox.Show("Produto não pode ser Vendido!! " + produto.status);
                cmbProduto.Focus();
            }
            else
            {
                lblStatus.Text = produto.status.ToString();
                txtValor.Text = produto.valor.ToString();
            }


        }

       

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LimpaControlesVendas();
            lblVendas.Text = "-1";
            HabilitaControlesVendas(true);
            dtpData.Focus();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblVendas.Text != string.Empty)
            {
                HabilitaControlesVendas(true);
                dtpData.Focus();
            }
            else
            {
                string msg = "Não há Vendas para edição...";
                MessageBox.Show(msg, "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblVendas.Text != string.Empty)
            {
                msg = "Confirma Remoção de Vendas " + lblVendas.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblVendas.Text);
                    Camadas.BLL.Vendas bllVendas = new Camadas.BLL.Vendas();
                    Camadas.Model.Vendas vendas = new Camadas.Model.Vendas();
                    vendas.id = id;
                    // informar outros campos caso necessite no bll
                    bllVendas.Delete(vendas);
                    dgvVendas.DataSource = "";
                    dgvVendas.DataSource = bllVendas.Select();
                }
            }
            else
            {
                msg = "Não há Vendas para remoção...";
                MessageBox.Show(msg, "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaControlesVendas();
            HabilitaControlesVendas(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Vendas bllVendas = new Camadas.BLL.Vendas();
            Camadas.Model.Vendas vendas = new Camadas.Model.Vendas();
            int id = Convert.ToInt32(lblVendas.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão da Venda?";
            else msg = "Confirma Atualização da Venda?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                vendas.id = id;
                vendas.data = dtpData.Value;
                vendas.cliente = Convert.ToInt32(txtCliente.Text);
                vendas.nome = cmbCliente.Text;
             


                if (id == -1)  //-1 indica inserir 
                    bllVendas.Insert(vendas);
                else bllVendas.Update(vendas);
            }
            dgvVendas.DataSource = "";
            dgvVendas.DataSource = bllVendas.Select();  //atualiza a grid
            LimpaControlesVendas(); //limpa campos
            HabilitaControlesVendas(false);  //desabilita controles
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControlesVendas();
            HabilitaControlesVendas(false);

        }

        private void dgvVendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count > 0)
            {
                lblVendas.Text = dgvVendas.SelectedRows[0].Cells["id"].Value.ToString();
                txtCliente.Text = dgvVendas.SelectedRows[0].Cells["cliente"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
                dtpData.Value = Convert.ToDateTime(dgvVendas.SelectedRows[0].Cells["data"].Value.ToString());

                //atualizar gridview itens locação
                Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();
                int vendas = Convert.ToInt32(lblVendas.Text);
                dgvItemVendas.DataSource = "";
                dgvItemVendas.DataSource = bllItemVendas.SelectByVendas(vendas);


            }

            

        }

        private void dgvItemVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dgvItemVendas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count > 0)
            {
                lblId.Text = dgvItemVendas.SelectedRows[0].Cells["id"].Value.ToString();
                txtProduto.Text = dgvItemVendas.SelectedRows[0].Cells["produto"].Value.ToString();
                cmbProduto.SelectedValue = Convert.ToInt32(txtProduto.Text);
                txtValor.Text = dgvItemVendas.SelectedRows[0].Cells["valor"].Value.ToString();
                txtPago.Text = dgvItemVendas.SelectedRows[0].Cells["pago"].Value.ToString();
                lblTroco.Text = dgvItemVendas.SelectedRows[0].Cells["troco"].Value.ToString();


                //atualizar gridview itens locação
                Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();
                int vendas = Convert.ToInt32(lblId.Text);
                dgvItemVendas.DataSource = "";
                dgvItemVendas.DataSource = bllItemVendas.SelectByVendas(vendas);

            }
            

        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (lblVendas.Text != "" && lblVendas.Text != "-1")
            {
                LimpaControlesIV();
                lblId.Text = "-1";
                HabilitaControlesItemVendas(true);
                
               
                lblTroco.Text = "0";
                btnBaixa.Enabled = false;
                cmbProduto.Focus();
            }
            else
            {
                string msg = "Não há Vendas selecionada!!!";
                MessageBox.Show(msg, "Itens Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                HabilitaControlesItemVendas(true);
                txtProduto.Focus();
            }
            else
            {
                string msg = "Não há Itens Vendas para edição...";
                MessageBox.Show(msg, "Itens Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Confirma Remoção de Itens de Vendas " + lblId.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover Item Vendas", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();
                    Camadas.Model.ItemVendas itemVendas = new Camadas.Model.ItemVendas();
                    itemVendas.id = id;
                    // informar outros campos caso necessite no bll
                    bllItemVendas.Delete(itemVendas);
                    dgvItemVendas.DataSource = "";
                    dgvItemVendas.DataSource = bllItemVendas.Select();
                }
            }
            else
            {
                msg = "Não há Item Vendas para remoção...";
                MessageBox.Show(msg, "Item Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaControlesVendas();
            HabilitaControlesVendas(false);

        }

        private void btnGra_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();
            Camadas.Model.ItemVendas itemVendas = new Camadas.Model.ItemVendas();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão de Item de Vendas?";
            else msg = "Confirma Atualização de Item de Vendas?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Item de Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                itemVendas.id = id;
                itemVendas.vendas = Convert.ToInt32(lblVendas.Text);
                itemVendas.produto = Convert.ToInt32(txtProduto.Text);
                itemVendas.valor = Convert.ToSingle(txtValor.Text);
                itemVendas.pago = Convert.ToSingle(txtPago.Text);
                itemVendas.troco = Convert.ToSingle(lblTroco.Text);


                

                if (id == -1)  //-1 indica inserir 
                    bllItemVendas.Insert(itemVendas);
                else bllItemVendas.Update(itemVendas);
            }
            dgvItemVendas.DataSource = "";
            dgvItemVendas.DataSource = bllItemVendas.SelectByVendas(Convert.ToInt32(lblVendas.Text));  //atualiza a grid
            LimpaControlesIV(); //limpa campos
            HabilitaControlesItemVendas(false);  //desabilita controles

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            LimpaControlesIV();
            HabilitaControlesItemVendas(false);
            Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();
            dgvItemVendas.DataSource = bllItemVendas.SelectByVendas(Convert.ToInt32(lblVendas.Text));  //atualiza a grid

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cmbProduto.SelectedValue.ToString();
            RecuperaDadosProduto();


        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbProduto.SelectedValue = Convert.ToInt32(txtProduto.Text);
                RecuperaDadosProduto();
                txtValor.Focus();
            }
            catch
            {
                string msg = "Não existe código do Produto selecionado";
                MessageBox.Show(msg, "Combo Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtProduto.Focus();
            }

          
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemVendas bllItemVendas = new Camadas.BLL.ItemVendas();
            Camadas.Model.ItemVendas itemVendas = new Camadas.Model.ItemVendas();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id != -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Baixa de Item de Vendas?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Baixa Item de Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                itemVendas.id = id;
                
                itemVendas.produto = Convert.ToInt32(txtProduto.Text);               
                itemVendas.valor = Convert.ToSingle(txtValor.Text);
                itemVendas.pago = Convert.ToSingle(txtPago.Text);
                itemVendas.troco = Convert.ToSingle(lblTroco.Text);


                
                

               

                bllItemVendas.Baixa(itemVendas);
            }
            dgvItemVendas.DataSource = "";
            dgvItemVendas.DataSource = bllItemVendas.SelectByVendas(Convert.ToInt32(lblVendas.Text));  //atualiza a grid
            LimpaControlesIV(); //limpa campos
            HabilitaControlesItemVendas(false);

        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            RecuperaDadosProduto();
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
           

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();

        }
    }
}






