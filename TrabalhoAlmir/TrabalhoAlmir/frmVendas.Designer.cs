namespace TrabalhoAlmir
{
    partial class frmVendas
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
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.pnlItemVendas = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lbltr = new System.Windows.Forms.Label();
            this.btnGra = new System.Windows.Forms.Button();
            this.btnBaixa = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblstat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvItemVendas = new System.Windows.Forms.DataGridView();
            this.pnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.pnlItemVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVendas
            // 
            this.pnlVendas.BackColor = System.Drawing.Color.Silver;
            this.pnlVendas.Controls.Add(this.btnSair);
            this.pnlVendas.Controls.Add(this.btnGravar);
            this.pnlVendas.Controls.Add(this.btnCancelar);
            this.pnlVendas.Controls.Add(this.btnRemover);
            this.pnlVendas.Controls.Add(this.btnEditar);
            this.pnlVendas.Controls.Add(this.btnInserir);
            this.pnlVendas.Controls.Add(this.txtCliente);
            this.pnlVendas.Controls.Add(this.dtpData);
            this.pnlVendas.Controls.Add(this.cmbCliente);
            this.pnlVendas.Controls.Add(this.lblVendas);
            this.pnlVendas.Controls.Add(this.lblCliente);
            this.pnlVendas.Controls.Add(this.lblData);
            this.pnlVendas.Controls.Add(this.label1);
            this.pnlVendas.Controls.Add(this.dgvVendas);
            this.pnlVendas.Location = new System.Drawing.Point(12, 12);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(828, 295);
            this.pnlVendas.TabIndex = 0;
            this.pnlVendas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(682, 119);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 30);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Black;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(419, 119);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(109, 30);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(552, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Black;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(287, 119);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(109, 30);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(155, 119);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 30);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Black;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(28, 119);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(109, 30);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(97, 76);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(52, 26);
            this.txtCliente.TabIndex = 7;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(97, 38);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(323, 26);
            this.dtpData.TabIndex = 6;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(167, 76);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(253, 28);
            this.cmbCliente.TabIndex = 5;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // lblVendas
            // 
            this.lblVendas.BackColor = System.Drawing.Color.White;
            this.lblVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.Location = new System.Drawing.Point(98, 8);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(51, 20);
            this.lblVendas.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(24, 77);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 20);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente :";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(33, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 20);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendas :";
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(28, 155);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(763, 124);
            this.dgvVendas.TabIndex = 0;
            this.dgvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellContentClick);
            this.dgvVendas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVendas_CellMouseDoubleClick);
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // pnlItemVendas
            // 
            this.pnlItemVendas.BackColor = System.Drawing.Color.Silver;
            this.pnlItemVendas.Controls.Add(this.lblStatus);
            this.pnlItemVendas.Controls.Add(this.lblTroco);
            this.pnlItemVendas.Controls.Add(this.txtPago);
            this.pnlItemVendas.Controls.Add(this.txtValor);
            this.pnlItemVendas.Controls.Add(this.lblValor);
            this.pnlItemVendas.Controls.Add(this.lblPago);
            this.pnlItemVendas.Controls.Add(this.lbltr);
            this.pnlItemVendas.Controls.Add(this.btnGra);
            this.pnlItemVendas.Controls.Add(this.btnBaixa);
            this.pnlItemVendas.Controls.Add(this.btnCan);
            this.pnlItemVendas.Controls.Add(this.btnRem);
            this.pnlItemVendas.Controls.Add(this.btnEdt);
            this.pnlItemVendas.Controls.Add(this.btnIns);
            this.pnlItemVendas.Controls.Add(this.txtProduto);
            this.pnlItemVendas.Controls.Add(this.cmbProduto);
            this.pnlItemVendas.Controls.Add(this.lblId);
            this.pnlItemVendas.Controls.Add(this.lblProduto);
            this.pnlItemVendas.Controls.Add(this.lblstat);
            this.pnlItemVendas.Controls.Add(this.label5);
            this.pnlItemVendas.Controls.Add(this.dgvItemVendas);
            this.pnlItemVendas.Location = new System.Drawing.Point(12, 313);
            this.pnlItemVendas.Name = "pnlItemVendas";
            this.pnlItemVendas.Size = new System.Drawing.Size(828, 349);
            this.pnlItemVendas.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(509, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 26);
            this.lblStatus.TabIndex = 21;
            // 
            // lblTroco
            // 
            this.lblTroco.BackColor = System.Drawing.Color.White;
            this.lblTroco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(96, 137);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(76, 25);
            this.lblTroco.TabIndex = 20;
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(96, 108);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(76, 26);
            this.txtPago.TabIndex = 19;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(96, 74);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 26);
            this.txtValor.TabIndex = 18;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(11, 77);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(79, 20);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor R$ :";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(11, 111);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(79, 20);
            this.lblPago.TabIndex = 16;
            this.lblPago.Text = "Pago R$ :";
            // 
            // lbltr
            // 
            this.lbltr.AutoSize = true;
            this.lbltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltr.Location = new System.Drawing.Point(8, 142);
            this.lbltr.Name = "lbltr";
            this.lbltr.Size = new System.Drawing.Size(82, 20);
            this.lbltr.TabIndex = 15;
            this.lbltr.Text = "Troco R$ :";
            // 
            // btnGra
            // 
            this.btnGra.BackColor = System.Drawing.Color.Black;
            this.btnGra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGra.ForeColor = System.Drawing.Color.White;
            this.btnGra.Location = new System.Drawing.Point(552, 181);
            this.btnGra.Name = "btnGra";
            this.btnGra.Size = new System.Drawing.Size(109, 30);
            this.btnGra.TabIndex = 13;
            this.btnGra.Text = "&Gravar";
            this.btnGra.UseVisualStyleBackColor = false;
            this.btnGra.Click += new System.EventHandler(this.btnGra_Click);
            // 
            // btnBaixa
            // 
            this.btnBaixa.BackColor = System.Drawing.Color.Black;
            this.btnBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixa.ForeColor = System.Drawing.Color.White;
            this.btnBaixa.Location = new System.Drawing.Point(419, 181);
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(109, 30);
            this.btnBaixa.TabIndex = 12;
            this.btnBaixa.Text = "&Baixa";
            this.btnBaixa.UseVisualStyleBackColor = false;
            this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.Black;
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.ForeColor = System.Drawing.Color.White;
            this.btnCan.Location = new System.Drawing.Point(682, 181);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(109, 30);
            this.btnCan.TabIndex = 11;
            this.btnCan.Text = "&Cancelar";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.Color.Black;
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.ForeColor = System.Drawing.Color.White;
            this.btnRem.Location = new System.Drawing.Point(287, 181);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(109, 30);
            this.btnRem.TabIndex = 10;
            this.btnRem.Text = "&Remover";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.BackColor = System.Drawing.Color.Black;
            this.btnEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdt.ForeColor = System.Drawing.Color.White;
            this.btnEdt.Location = new System.Drawing.Point(155, 181);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(109, 30);
            this.btnEdt.TabIndex = 9;
            this.btnEdt.Text = "&Editar";
            this.btnEdt.UseVisualStyleBackColor = false;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.Black;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.Color.White;
            this.btnIns.Location = new System.Drawing.Point(28, 181);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(109, 30);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "&Inserir";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(97, 37);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(52, 26);
            this.txtProduto.TabIndex = 7;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // cmbProduto
            // 
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(167, 37);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(253, 28);
            this.cmbProduto.TabIndex = 5;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(98, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 20);
            this.lblId.TabIndex = 4;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(19, 40);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(73, 20);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto :";
            // 
            // lblstat
            // 
            this.lblstat.AutoSize = true;
            this.lblstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstat.Location = new System.Drawing.Point(439, 45);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(64, 20);
            this.lblstat.TabIndex = 2;
            this.lblstat.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id :";
            // 
            // dgvItemVendas
            // 
            this.dgvItemVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVendas.Location = new System.Drawing.Point(28, 217);
            this.dgvItemVendas.Name = "dgvItemVendas";
            this.dgvItemVendas.Size = new System.Drawing.Size(763, 124);
            this.dgvItemVendas.TabIndex = 0;
            this.dgvItemVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemVendas_CellContentClick);
            this.dgvItemVendas.DoubleClick += new System.EventHandler(this.dgvItemVendas_DoubleClick);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 674);
            this.Controls.Add(this.pnlItemVendas);
            this.Controls.Add(this.pnlVendas);
            this.Name = "frmVendas";
            this.Text = "Sistema de Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.pnlItemVendas.ResumeLayout(false);
            this.pnlItemVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel pnlItemVendas;
        private System.Windows.Forms.Button btnGra;
        private System.Windows.Forms.Button btnBaixa;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblstat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvItemVendas;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lbltr;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblStatus;
    }
}