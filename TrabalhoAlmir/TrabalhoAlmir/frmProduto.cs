﻿using System;
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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = bllProd.Select();
            pnlPesquisa.Visible = false;
            Habilitar(false);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Habilitar(bool status)
        {
            txtQuantidade.Enabled = status;
            txtDescricao.Enabled = status;
            txtValor.Enabled = status;
            txtStatus.Enabled = status;
            dgvProduto.Enabled = !status;

            //botões
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = "";
            txtQuantidade.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtStatus.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblId.Text = "-1";
            Habilitar(true);
            txtQuantidade.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                Habilitar(true);
                txtQuantidade.Focus();
            }
            else
            {
                string msg = "Não há Registro para edição...";
                MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Confirma Remoção do Produto" + txtDescricao.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
                    Camadas.Model.Produto produto = new Camadas.Model.Produto();
                    produto.id = id;
                    // informar outros campos caso necessite no bll
                    bllProd.Delete(produto);
                    dgvProduto.DataSource = "";
                    dgvProduto.DataSource = bllProd.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limparCampos();
            Habilitar(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            Camadas.Model.Produto produto = new Camadas.Model.Produto();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                produto.id = id;
                produto.quantidade = Convert.ToInt32(txtValor.Text);
                produto.descricao = txtDescricao.Text;
                produto.valor = Convert.ToSingle(txtValor.Text);
                produto.status = Convert.ToChar(txtStatus.Text);
                if (id == -1)  //-1 indica inserir 
                    bllProd.Insert(produto);
                else bllProd.Update(produto);
            }
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();  //atualiza a grid
            limparCampos(); //limpa campos
            Habilitar(false);  //desabilita controles

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            {
                limparCampos();
                Habilitar(false);
            }

        }

        private void dgvProduto_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                lblId.Text = dgvProduto.SelectedRows[0].Cells["id"].Value.ToString();
                txtQuantidade.Text = dgvProduto.SelectedRows[0].Cells["quantidade"].Value.ToString();
                txtDescricao.Text = dgvProduto.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtValor.Text = dgvProduto.SelectedRows[0].Cells["valor"].Value.ToString();
                txtStatus.Text = dgvProduto.SelectedRows[0].Cells["status"].Value.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            if (pnlPesquisa.Visible == true)
                rbdTodos.Checked = true;

        }

        private void rbdTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();

        }

        private void rbdCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();

        }

        private void rbdDescricao_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe a Descricao: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Camadas.Model.Produto> lstPro = new List<Camadas.Model.Produto>();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            if (rbdCodigo.Checked)
            {
                if (txtPesquisa.Text != string.Empty)
                    lstPro = bllProd.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else MessageBox.Show("ID vazio", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbdDescricao.Checked)
                lstPro = bllProd.SelectByDescricao(txtPesquisa.Text.Trim());

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = lstPro;
        }

        private void pnlPesquisa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





