namespace lojadalala
{
  partial class FormVendaSimples
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendaSimples));
      this.gpbItem = new System.Windows.Forms.GroupBox();
      this.btnCancelarItem = new System.Windows.Forms.Button();
      this.btnInserirItem = new System.Windows.Forms.Button();
      this.txtTotalProduto = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.txtDescontoProduto = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.txtPrecoProduto = new System.Windows.Forms.TextBox();
      this.txtQtdeProduto = new System.Windows.Forms.TextBox();
      this.txtDescProduto = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.btnConsultaProduto = new System.Windows.Forms.Button();
      this.label11 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.txtCodProduto = new System.Windows.Forms.TextBox();
      this.btnSair = new System.Windows.Forms.Button();
      this.gpbNumeroVenda = new System.Windows.Forms.GroupBox();
      this.txtNumVenda = new System.Windows.Forms.TextBox();
      this.dtVenda = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.lblVendedor = new System.Windows.Forms.Label();
      this.lblTotalVenda = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.iditem = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.chkClienteCadastrado = new System.Windows.Forms.CheckBox();
      this.gpbCliente = new System.Windows.Forms.GroupBox();
      this.btnConsultaCliente = new System.Windows.Forms.Button();
      this.txtCodigoCliente = new System.Windows.Forms.TextBox();
      this.lblNomeCliente = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.gpbFinalizar = new System.Windows.Forms.GroupBox();
      this.txtValor = new System.Windows.Forms.TextBox();
      this.lblTroco = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label26 = new System.Windows.Forms.Label();
      this.cbxFormaPgto = new System.Windows.Forms.ComboBox();
      this.btnFinalizarVenda = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.gpbItem.SuspendLayout();
      this.gpbNumeroVenda.SuspendLayout();
      this.groupBox8.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.gpbCliente.SuspendLayout();
      this.gpbFinalizar.SuspendLayout();
      this.SuspendLayout();
      // 
      // gpbItem
      // 
      this.gpbItem.Controls.Add(this.btnCancelarItem);
      this.gpbItem.Controls.Add(this.btnInserirItem);
      this.gpbItem.Controls.Add(this.txtTotalProduto);
      this.gpbItem.Controls.Add(this.label14);
      this.gpbItem.Controls.Add(this.txtDescontoProduto);
      this.gpbItem.Controls.Add(this.label13);
      this.gpbItem.Controls.Add(this.txtPrecoProduto);
      this.gpbItem.Controls.Add(this.txtQtdeProduto);
      this.gpbItem.Controls.Add(this.txtDescProduto);
      this.gpbItem.Controls.Add(this.label12);
      this.gpbItem.Controls.Add(this.btnConsultaProduto);
      this.gpbItem.Controls.Add(this.label11);
      this.gpbItem.Controls.Add(this.label8);
      this.gpbItem.Controls.Add(this.label9);
      this.gpbItem.Controls.Add(this.txtCodProduto);
      this.gpbItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbItem.Location = new System.Drawing.Point(4, 104);
      this.gpbItem.Name = "gpbItem";
      this.gpbItem.Size = new System.Drawing.Size(380, 140);
      this.gpbItem.TabIndex = 3;
      this.gpbItem.TabStop = false;
      this.gpbItem.Text = "Itens - F2";
      // 
      // btnCancelarItem
      // 
      this.btnCancelarItem.Enabled = false;
      this.btnCancelarItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarItem.Image")));
      this.btnCancelarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancelarItem.Location = new System.Drawing.Point(279, 101);
      this.btnCancelarItem.Name = "btnCancelarItem";
      this.btnCancelarItem.Size = new System.Drawing.Size(92, 30);
      this.btnCancelarItem.TabIndex = 10;
      this.btnCancelarItem.Text = "     Excluir";
      this.btnCancelarItem.UseVisualStyleBackColor = true;
      this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
      // 
      // btnInserirItem
      // 
      this.btnInserirItem.Enabled = false;
      this.btnInserirItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInserirItem.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirItem.Image")));
      this.btnInserirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInserirItem.Location = new System.Drawing.Point(279, 69);
      this.btnInserirItem.Name = "btnInserirItem";
      this.btnInserirItem.Size = new System.Drawing.Size(92, 30);
      this.btnInserirItem.TabIndex = 9;
      this.btnInserirItem.Text = "     Inserir";
      this.btnInserirItem.UseVisualStyleBackColor = true;
      this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
      // 
      // txtTotalProduto
      // 
      this.txtTotalProduto.Location = new System.Drawing.Point(194, 98);
      this.txtTotalProduto.Name = "txtTotalProduto";
      this.txtTotalProduto.ReadOnly = true;
      this.txtTotalProduto.Size = new System.Drawing.Size(63, 21);
      this.txtTotalProduto.TabIndex = 8;
      this.txtTotalProduto.TabStop = false;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(153, 101);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(35, 13);
      this.label14.TabIndex = 94;
      this.label14.Text = "Total:";
      // 
      // txtDescontoProduto
      // 
      this.txtDescontoProduto.Location = new System.Drawing.Point(89, 98);
      this.txtDescontoProduto.Name = "txtDescontoProduto";
      this.txtDescontoProduto.ReadOnly = true;
      this.txtDescontoProduto.Size = new System.Drawing.Size(49, 21);
      this.txtDescontoProduto.TabIndex = 6;
      this.txtDescontoProduto.TabStop = false;
      this.txtDescontoProduto.Leave += new System.EventHandler(this.txtDescontoProduto_Leave);
      this.txtDescontoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoProduto_KeyPress);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(10, 101);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(75, 13);
      this.label13.TabIndex = 92;
      this.label13.Text = "Desconto(%):";
      // 
      // txtPrecoProduto
      // 
      this.txtPrecoProduto.Location = new System.Drawing.Point(194, 71);
      this.txtPrecoProduto.Name = "txtPrecoProduto";
      this.txtPrecoProduto.ReadOnly = true;
      this.txtPrecoProduto.Size = new System.Drawing.Size(63, 21);
      this.txtPrecoProduto.TabIndex = 7;
      this.txtPrecoProduto.TabStop = false;
      // 
      // txtQtdeProduto
      // 
      this.txtQtdeProduto.Location = new System.Drawing.Point(89, 71);
      this.txtQtdeProduto.Name = "txtQtdeProduto";
      this.txtQtdeProduto.ReadOnly = true;
      this.txtQtdeProduto.Size = new System.Drawing.Size(49, 21);
      this.txtQtdeProduto.TabIndex = 5;
      this.txtQtdeProduto.TabStop = false;
      this.txtQtdeProduto.Leave += new System.EventHandler(this.txtQtdeProduto_Leave);
      this.txtQtdeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeProduto_KeyPress);
      // 
      // txtDescProduto
      // 
      this.txtDescProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescProduto.Location = new System.Drawing.Point(89, 44);
      this.txtDescProduto.Name = "txtDescProduto";
      this.txtDescProduto.ReadOnly = true;
      this.txtDescProduto.Size = new System.Drawing.Size(282, 21);
      this.txtDescProduto.TabIndex = 4;
      this.txtDescProduto.TabStop = false;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(152, 74);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(38, 13);
      this.label12.TabIndex = 37;
      this.label12.Text = "Preço:";
      // 
      // btnConsultaProduto
      // 
      this.btnConsultaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaProduto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaProduto.Location = new System.Drawing.Point(144, 20);
      this.btnConsultaProduto.Name = "btnConsultaProduto";
      this.btnConsultaProduto.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaProduto.TabIndex = 1;
      this.btnConsultaProduto.Text = "...";
      this.btnConsultaProduto.UseVisualStyleBackColor = true;
      this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(50, 74);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(35, 13);
      this.label11.TabIndex = 37;
      this.label11.Text = "Qtde:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(28, 47);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(57, 13);
      this.label8.TabIndex = 37;
      this.label8.Text = "Descrição:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(41, 23);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(44, 13);
      this.label9.TabIndex = 36;
      this.label9.Text = "Código:";
      // 
      // txtCodProduto
      // 
      this.txtCodProduto.Location = new System.Drawing.Point(89, 20);
      this.txtCodProduto.Name = "txtCodProduto";
      this.txtCodProduto.Size = new System.Drawing.Size(49, 21);
      this.txtCodProduto.TabIndex = 0;
      this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
      this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
      this.txtCodProduto.Enter += new System.EventHandler(this.txtCodProduto_Enter);
      // 
      // btnSair
      // 
      this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSair.Location = new System.Drawing.Point(574, 452);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(86, 26);
      this.btnSair.TabIndex = 6;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // gpbNumeroVenda
      // 
      this.gpbNumeroVenda.Controls.Add(this.txtNumVenda);
      this.gpbNumeroVenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbNumeroVenda.Location = new System.Drawing.Point(4, 2);
      this.gpbNumeroVenda.Name = "gpbNumeroVenda";
      this.gpbNumeroVenda.Size = new System.Drawing.Size(85, 49);
      this.gpbNumeroVenda.TabIndex = 0;
      this.gpbNumeroVenda.TabStop = false;
      this.gpbNumeroVenda.Text = "Número";
      // 
      // txtNumVenda
      // 
      this.txtNumVenda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNumVenda.Location = new System.Drawing.Point(5, 18);
      this.txtNumVenda.MaxLength = 6;
      this.txtNumVenda.Name = "txtNumVenda";
      this.txtNumVenda.ReadOnly = true;
      this.txtNumVenda.Size = new System.Drawing.Size(74, 23);
      this.txtNumVenda.TabIndex = 0;
      // 
      // dtVenda
      // 
      this.dtVenda.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtVenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtVenda.Location = new System.Drawing.Point(92, 68);
      this.dtVenda.Name = "dtVenda";
      this.dtVenda.Size = new System.Drawing.Size(106, 21);
      this.dtVenda.TabIndex = 79;
      this.dtVenda.Value = new System.DateTime(1900, 1, 1, 19, 36, 0, 0);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(7, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 80;
      this.label2.Text = "Data da Venda:";
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.lblVendedor);
      this.groupBox8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox8.Location = new System.Drawing.Point(491, 2);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBox8.Size = new System.Drawing.Size(169, 33);
      this.groupBox8.TabIndex = 100;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Vendedor(a)";
      // 
      // lblVendedor
      // 
      this.lblVendedor.AutoSize = true;
      this.lblVendedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblVendedor.Location = new System.Drawing.Point(7, 15);
      this.lblVendedor.Name = "lblVendedor";
      this.lblVendedor.Size = new System.Drawing.Size(0, 13);
      this.lblVendedor.TabIndex = 67;
      // 
      // lblTotalVenda
      // 
      this.lblTotalVenda.AutoSize = true;
      this.lblTotalVenda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalVenda.Location = new System.Drawing.Point(130, 452);
      this.lblTotalVenda.Name = "lblTotalVenda";
      this.lblTotalVenda.Size = new System.Drawing.Size(44, 19);
      this.lblTotalVenda.TabIndex = 104;
      this.lblTotalVenda.Text = "0,00";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iditem,
            this.idvenda,
            this.idproduto,
            this.descricao,
            this.qtde,
            this.preco,
            this.subtotal,
            this.desconto,
            this.total,
            this.estado});
      this.dataGridView1.Location = new System.Drawing.Point(4, 252);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(656, 192);
      this.dataGridView1.TabIndex = 5;
      this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      // 
      // iditem
      // 
      this.iditem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.iditem.DataPropertyName = "iditem";
      this.iditem.HeaderText = "Item";
      this.iditem.Name = "iditem";
      this.iditem.ReadOnly = true;
      this.iditem.Width = 54;
      // 
      // idvenda
      // 
      this.idvenda.DataPropertyName = "idvenda";
      this.idvenda.HeaderText = "idvenda";
      this.idvenda.Name = "idvenda";
      this.idvenda.ReadOnly = true;
      this.idvenda.Visible = false;
      // 
      // idproduto
      // 
      this.idproduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idproduto.DataPropertyName = "idproduto";
      this.idproduto.HeaderText = "Código";
      this.idproduto.Name = "idproduto";
      this.idproduto.ReadOnly = true;
      this.idproduto.Width = 65;
      // 
      // descricao
      // 
      this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.descricao.DataPropertyName = "descricao";
      this.descricao.HeaderText = "Descrição";
      this.descricao.Name = "descricao";
      this.descricao.ReadOnly = true;
      this.descricao.Width = 78;
      // 
      // qtde
      // 
      this.qtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.qtde.DataPropertyName = "qtde";
      this.qtde.HeaderText = "Qtde";
      this.qtde.Name = "qtde";
      this.qtde.ReadOnly = true;
      this.qtde.Width = 56;
      // 
      // preco
      // 
      this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.preco.DataPropertyName = "preco";
      this.preco.HeaderText = "Preço";
      this.preco.Name = "preco";
      this.preco.ReadOnly = true;
      this.preco.Width = 59;
      // 
      // subtotal
      // 
      this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.subtotal.DataPropertyName = "subtotal";
      this.subtotal.HeaderText = "Subtotal";
      this.subtotal.Name = "subtotal";
      this.subtotal.ReadOnly = true;
      this.subtotal.Width = 72;
      // 
      // desconto
      // 
      this.desconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.desconto.DataPropertyName = "desconto";
      this.desconto.HeaderText = "Desc(%)";
      this.desconto.Name = "desconto";
      this.desconto.ReadOnly = true;
      this.desconto.Width = 74;
      // 
      // total
      // 
      this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.total.DataPropertyName = "total";
      this.total.HeaderText = "Total";
      this.total.Name = "total";
      this.total.ReadOnly = true;
      this.total.Width = 56;
      // 
      // estado
      // 
      this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.estado.DataPropertyName = "estado";
      this.estado.HeaderText = "Estado";
      this.estado.Name = "estado";
      this.estado.ReadOnly = true;
      this.estado.Width = 65;
      // 
      // chkClienteCadastrado
      // 
      this.chkClienteCadastrado.AutoSize = true;
      this.chkClienteCadastrado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkClienteCadastrado.Location = new System.Drawing.Point(253, 21);
      this.chkClienteCadastrado.Name = "chkClienteCadastrado";
      this.chkClienteCadastrado.Size = new System.Drawing.Size(118, 17);
      this.chkClienteCadastrado.TabIndex = 1;
      this.chkClienteCadastrado.Text = "Cliente Ca&dastrado";
      this.chkClienteCadastrado.UseVisualStyleBackColor = true;
      this.chkClienteCadastrado.CheckedChanged += new System.EventHandler(this.chkClienteCadastrado_CheckedChanged);
      // 
      // gpbCliente
      // 
      this.gpbCliente.Controls.Add(this.btnConsultaCliente);
      this.gpbCliente.Controls.Add(this.txtCodigoCliente);
      this.gpbCliente.Controls.Add(this.lblNomeCliente);
      this.gpbCliente.Controls.Add(this.label3);
      this.gpbCliente.Controls.Add(this.label1);
      this.gpbCliente.Enabled = false;
      this.gpbCliente.Location = new System.Drawing.Point(252, 35);
      this.gpbCliente.Name = "gpbCliente";
      this.gpbCliente.Size = new System.Drawing.Size(408, 63);
      this.gpbCliente.TabIndex = 2;
      this.gpbCliente.TabStop = false;
      this.gpbCliente.Enter += new System.EventHandler(this.gpbCliente_Enter);
      // 
      // btnConsultaCliente
      // 
      this.btnConsultaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsultaCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultaCliente.Location = new System.Drawing.Point(114, 14);
      this.btnConsultaCliente.Name = "btnConsultaCliente";
      this.btnConsultaCliente.Size = new System.Drawing.Size(27, 22);
      this.btnConsultaCliente.TabIndex = 1;
      this.btnConsultaCliente.Text = "...";
      this.btnConsultaCliente.UseVisualStyleBackColor = true;
      this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
      // 
      // txtCodigoCliente
      // 
      this.txtCodigoCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigoCliente.Location = new System.Drawing.Point(59, 15);
      this.txtCodigoCliente.Name = "txtCodigoCliente";
      this.txtCodigoCliente.Size = new System.Drawing.Size(49, 21);
      this.txtCodigoCliente.TabIndex = 0;
      this.txtCodigoCliente.Leave += new System.EventHandler(this.txtCodigoCliente_Leave);
      this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
      // 
      // lblNomeCliente
      // 
      this.lblNomeCliente.AutoSize = true;
      this.lblNomeCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNomeCliente.Location = new System.Drawing.Point(59, 41);
      this.lblNomeCliente.Name = "lblNomeCliente";
      this.lblNomeCliente.Size = new System.Drawing.Size(0, 13);
      this.lblNomeCliente.TabIndex = 48;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(17, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 48;
      this.label3.Text = "Nome:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(11, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 48;
      this.label1.Text = "Código:";
      // 
      // gpbFinalizar
      // 
      this.gpbFinalizar.Controls.Add(this.txtValor);
      this.gpbFinalizar.Controls.Add(this.lblTroco);
      this.gpbFinalizar.Controls.Add(this.label6);
      this.gpbFinalizar.Controls.Add(this.label4);
      this.gpbFinalizar.Controls.Add(this.label5);
      this.gpbFinalizar.Controls.Add(this.label26);
      this.gpbFinalizar.Controls.Add(this.cbxFormaPgto);
      this.gpbFinalizar.Controls.Add(this.btnFinalizarVenda);
      this.gpbFinalizar.Enabled = false;
      this.gpbFinalizar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbFinalizar.Location = new System.Drawing.Point(390, 104);
      this.gpbFinalizar.Name = "gpbFinalizar";
      this.gpbFinalizar.Size = new System.Drawing.Size(270, 140);
      this.gpbFinalizar.TabIndex = 4;
      this.gpbFinalizar.TabStop = false;
      this.gpbFinalizar.Text = "Forma de Pagamento - F3";
      // 
      // txtValor
      // 
      this.txtValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValor.Location = new System.Drawing.Point(34, 47);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(75, 22);
      this.txtValor.TabIndex = 1;
      this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
      this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
      // 
      // lblTroco
      // 
      this.lblTroco.AutoSize = true;
      this.lblTroco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.lblTroco.Location = new System.Drawing.Point(178, 110);
      this.lblTroco.Name = "lblTroco";
      this.lblTroco.Size = new System.Drawing.Size(0, 19);
      this.lblTroco.TabIndex = 101;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.label6.Location = new System.Drawing.Point(201, 92);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(42, 13);
      this.label6.TabIndex = 101;
      this.label6.Text = "-------";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.label4.Location = new System.Drawing.Point(159, 92);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 13);
      this.label4.TabIndex = 101;
      this.label4.Text = "TROCO";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.label5.Location = new System.Drawing.Point(159, 113);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(22, 13);
      this.label5.TabIndex = 101;
      this.label5.Text = "R$";
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label26.Location = new System.Drawing.Point(7, 52);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(22, 13);
      this.label26.TabIndex = 101;
      this.label26.Text = "R$";
      // 
      // cbxFormaPgto
      // 
      this.cbxFormaPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxFormaPgto.FormattingEnabled = true;
      this.cbxFormaPgto.Location = new System.Drawing.Point(10, 20);
      this.cbxFormaPgto.Name = "cbxFormaPgto";
      this.cbxFormaPgto.Size = new System.Drawing.Size(230, 21);
      this.cbxFormaPgto.TabIndex = 0;
      // 
      // btnFinalizarVenda
      // 
      this.btnFinalizarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnFinalizarVenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFinalizarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarVenda.Image")));
      this.btnFinalizarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnFinalizarVenda.Location = new System.Drawing.Point(10, 104);
      this.btnFinalizarVenda.Name = "btnFinalizarVenda";
      this.btnFinalizarVenda.Size = new System.Drawing.Size(143, 30);
      this.btnFinalizarVenda.TabIndex = 2;
      this.btnFinalizarVenda.Text = "     Finalizar Venda";
      this.btnFinalizarVenda.UseVisualStyleBackColor = true;
      this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(1, 453);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(123, 16);
      this.label7.TabIndex = 105;
      this.label7.Text = "TOTAL DA VENDA:";
      // 
      // FormVendaSimples
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(665, 483);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.gpbFinalizar);
      this.Controls.Add(this.gpbCliente);
      this.Controls.Add(this.chkClienteCadastrado);
      this.Controls.Add(this.lblTotalVenda);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.groupBox8);
      this.Controls.Add(this.dtVenda);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.gpbNumeroVenda);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.gpbItem);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormVendaSimples";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Venda - À Vista";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVendaSimples_KeyDown);
      this.gpbItem.ResumeLayout(false);
      this.gpbItem.PerformLayout();
      this.gpbNumeroVenda.ResumeLayout(false);
      this.gpbNumeroVenda.PerformLayout();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.gpbCliente.ResumeLayout(false);
      this.gpbCliente.PerformLayout();
      this.gpbFinalizar.ResumeLayout(false);
      this.gpbFinalizar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gpbItem;
    public System.Windows.Forms.Button btnCancelarItem;
    public System.Windows.Forms.Button btnInserirItem;
    private System.Windows.Forms.TextBox txtTotalProduto;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox txtDescontoProduto;
    private System.Windows.Forms.Label label13;
    public System.Windows.Forms.TextBox txtPrecoProduto;
    public System.Windows.Forms.TextBox txtQtdeProduto;
    public System.Windows.Forms.TextBox txtDescProduto;
    private System.Windows.Forms.Label label12;
    public System.Windows.Forms.Button btnConsultaProduto;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    public System.Windows.Forms.TextBox txtCodProduto;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.GroupBox gpbNumeroVenda;
    public System.Windows.Forms.TextBox txtNumVenda;
    public System.Windows.Forms.DateTimePicker dtVenda;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox8;
    public System.Windows.Forms.Label lblVendedor;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox gpbCliente;
    public System.Windows.Forms.TextBox txtCodigoCliente;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnConsultaCliente;
    public System.Windows.Forms.Label lblTotalVenda;
    private System.Windows.Forms.GroupBox gpbFinalizar;
    public System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.ComboBox cbxFormaPgto;
    private System.Windows.Forms.Button btnFinalizarVenda;
    public System.Windows.Forms.Label lblNomeCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn iditem;
    private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
    private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
    private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.Label lblTroco;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.CheckBox chkClienteCadastrado;
    private System.Windows.Forms.Label label7;
  }
}