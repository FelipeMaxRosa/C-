namespace lojadalala
{
  partial class FormGridVenda
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridVenda));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cbxVendedor = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnConsCliente = new System.Windows.Forms.Button();
      this.lblNomeCliente = new System.Windows.Forms.Label();
      this.radCliente = new System.Windows.Forms.RadioButton();
      this.txtCodigoCliente = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dtFim = new System.Windows.Forms.DateTimePicker();
      this.dtInicio = new System.Windows.Forms.DateTimePicker();
      this.radVendedor = new System.Windows.Forms.RadioButton();
      this.radPeriodo = new System.Windows.Forms.RadioButton();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.cbxSituacao = new System.Windows.Forms.ComboBox();
      this.radNumero = new System.Windows.Forms.RadioButton();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.txtNumeroVenda = new System.Windows.Forms.TextBox();
      this.butSair = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.datavenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cbxVendedor);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnConsCliente);
      this.groupBox1.Controls.Add(this.lblNomeCliente);
      this.groupBox1.Controls.Add(this.radCliente);
      this.groupBox1.Controls.Add(this.txtCodigoCliente);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.dtFim);
      this.groupBox1.Controls.Add(this.dtInicio);
      this.groupBox1.Controls.Add(this.radVendedor);
      this.groupBox1.Controls.Add(this.radPeriodo);
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.radNumero);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.txtNumeroVenda);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(2, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(319, 277);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por";
      // 
      // cbxVendedor
      // 
      this.cbxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxVendedor.FormattingEnabled = true;
      this.cbxVendedor.Location = new System.Drawing.Point(17, 246);
      this.cbxVendedor.Name = "cbxVendedor";
      this.cbxVendedor.Size = new System.Drawing.Size(121, 21);
      this.cbxVendedor.TabIndex = 9;
      this.cbxVendedor.Visible = false;
      this.cbxVendedor.DropDownClosed += new System.EventHandler(this.cbxSituacao_DropDownClosed);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(14, 103);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(97, 14);
      this.label4.TabIndex = 83;
      this.label4.Text = "FILTRAR POR";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(107, 97);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(204, 17);
      this.label1.TabIndex = 83;
      this.label1.Text = "                                                 ";
      // 
      // btnConsCliente
      // 
      this.btnConsCliente.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnConsCliente.Enabled = false;
      this.btnConsCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsCliente.Location = new System.Drawing.Point(133, 126);
      this.btnConsCliente.Name = "btnConsCliente";
      this.btnConsCliente.Size = new System.Drawing.Size(27, 22);
      this.btnConsCliente.TabIndex = 4;
      this.btnConsCliente.Text = "...";
      this.btnConsCliente.UseVisualStyleBackColor = true;
      this.btnConsCliente.Click += new System.EventHandler(this.btnConsCliente_Click);
      // 
      // lblNomeCliente
      // 
      this.lblNomeCliente.AutoSize = true;
      this.lblNomeCliente.Location = new System.Drawing.Point(14, 153);
      this.lblNomeCliente.Name = "lblNomeCliente";
      this.lblNomeCliente.Size = new System.Drawing.Size(0, 13);
      this.lblNomeCliente.TabIndex = 82;
      // 
      // radCliente
      // 
      this.radCliente.AutoSize = true;
      this.radCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radCliente.Location = new System.Drawing.Point(17, 127);
      this.radCliente.Name = "radCliente";
      this.radCliente.Size = new System.Drawing.Size(62, 17);
      this.radCliente.TabIndex = 2;
      this.radCliente.Text = "&Cliente:";
      this.radCliente.UseVisualStyleBackColor = true;
      this.radCliente.CheckedChanged += new System.EventHandler(this.radCliente_CheckedChanged);
      // 
      // txtCodigoCliente
      // 
      this.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCodigoCliente.Location = new System.Drawing.Point(87, 126);
      this.txtCodigoCliente.MaxLength = 50;
      this.txtCodigoCliente.Name = "txtCodigoCliente";
      this.txtCodigoCliente.ReadOnly = true;
      this.txtCodigoCliente.Size = new System.Drawing.Size(40, 21);
      this.txtCodigoCliente.TabIndex = 3;
      this.txtCodigoCliente.Leave += new System.EventHandler(this.txtCodigoCliente_Leave);
      this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCliente_KeyPress);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(169, 198);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 13);
      this.label3.TabIndex = 78;
      this.label3.Text = "Fim:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(14, 198);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 75;
      this.label2.Text = "Início:";
      // 
      // dtFim
      // 
      this.dtFim.Enabled = false;
      this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtFim.Location = new System.Drawing.Point(199, 195);
      this.dtFim.Name = "dtFim";
      this.dtFim.Size = new System.Drawing.Size(109, 21);
      this.dtFim.TabIndex = 7;
      // 
      // dtInicio
      // 
      this.dtInicio.Enabled = false;
      this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtInicio.Location = new System.Drawing.Point(52, 195);
      this.dtInicio.Name = "dtInicio";
      this.dtInicio.Size = new System.Drawing.Size(109, 21);
      this.dtInicio.TabIndex = 6;
      // 
      // radVendedor
      // 
      this.radVendedor.AutoSize = true;
      this.radVendedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radVendedor.Location = new System.Drawing.Point(17, 223);
      this.radVendedor.Name = "radVendedor";
      this.radVendedor.Size = new System.Drawing.Size(75, 17);
      this.radVendedor.TabIndex = 8;
      this.radVendedor.Text = "Ven&dedor:";
      this.radVendedor.UseVisualStyleBackColor = true;
      this.radVendedor.Visible = false;
      this.radVendedor.CheckedChanged += new System.EventHandler(this.radPeriodo_CheckedChanged);
      // 
      // radPeriodo
      // 
      this.radPeriodo.AutoSize = true;
      this.radPeriodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radPeriodo.Location = new System.Drawing.Point(17, 173);
      this.radPeriodo.Name = "radPeriodo";
      this.radPeriodo.Size = new System.Drawing.Size(65, 17);
      this.radPeriodo.TabIndex = 5;
      this.radPeriodo.Text = "&Período:";
      this.radPeriodo.UseVisualStyleBackColor = true;
      this.radPeriodo.CheckedChanged += new System.EventHandler(this.radPeriodo_CheckedChanged);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.cbxSituacao);
      this.groupBox4.Location = new System.Drawing.Point(17, 48);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(135, 47);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Situação";
      // 
      // cbxSituacao
      // 
      this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxSituacao.FormattingEnabled = true;
      this.cbxSituacao.Items.AddRange(new object[] {
            "ABERTA",
            "FINALIZADA",
            "TODAS"});
      this.cbxSituacao.Location = new System.Drawing.Point(6, 17);
      this.cbxSituacao.Name = "cbxSituacao";
      this.cbxSituacao.Size = new System.Drawing.Size(121, 21);
      this.cbxSituacao.TabIndex = 0;
      this.cbxSituacao.DropDownClosed += new System.EventHandler(this.cbxSituacao_DropDownClosed);
      // 
      // radNumero
      // 
      this.radNumero.AutoSize = true;
      this.radNumero.Checked = true;
      this.radNumero.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radNumero.Location = new System.Drawing.Point(17, 22);
      this.radNumero.Name = "radNumero";
      this.radNumero.Size = new System.Drawing.Size(66, 17);
      this.radNumero.TabIndex = 40;
      this.radNumero.TabStop = true;
      this.radNumero.Text = "&Número:";
      this.radNumero.UseVisualStyleBackColor = true;
      this.radNumero.CheckedChanged += new System.EventHandler(this.radNumero_CheckedChanged);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
      this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPesquisar.Location = new System.Drawing.Point(172, 68);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(109, 27);
      this.btnPesquisar.TabIndex = 10;
      this.btnPesquisar.Text = "   Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // txtNumeroVenda
      // 
      this.txtNumeroVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumeroVenda.Location = new System.Drawing.Point(87, 21);
      this.txtNumeroVenda.MaxLength = 50;
      this.txtNumeroVenda.Name = "txtNumeroVenda";
      this.txtNumeroVenda.Size = new System.Drawing.Size(40, 21);
      this.txtNumeroVenda.TabIndex = 0;
      this.txtNumeroVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroVenda_KeyPress);
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(738, 286);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 1;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvenda,
            this.datavenda,
            this.total,
            this.estado,
            this.obs,
            this.vendedor,
            this.idcliente});
      this.dataGridView1.Location = new System.Drawing.Point(327, 11);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(492, 269);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // idvenda
      // 
      this.idvenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idvenda.DataPropertyName = "idvenda";
      this.idvenda.HeaderText = "Número";
      this.idvenda.Name = "idvenda";
      this.idvenda.ReadOnly = true;
      this.idvenda.Width = 69;
      // 
      // datavenda
      // 
      this.datavenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.datavenda.DataPropertyName = "datavenda";
      this.datavenda.HeaderText = "Data";
      this.datavenda.Name = "datavenda";
      this.datavenda.ReadOnly = true;
      this.datavenda.Width = 55;
      // 
      // total
      // 
      this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.total.DataPropertyName = "totalvenda";
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
      // obs
      // 
      this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obs.DataPropertyName = "obs";
      this.obs.HeaderText = "Observação";
      this.obs.Name = "obs";
      this.obs.ReadOnly = true;
      this.obs.Width = 90;
      // 
      // vendedor
      // 
      this.vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.vendedor.DataPropertyName = "vendedor";
      this.vendedor.HeaderText = "Vendedor";
      this.vendedor.Name = "vendedor";
      this.vendedor.ReadOnly = true;
      this.vendedor.Width = 78;
      // 
      // idcliente
      // 
      this.idcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idcliente.DataPropertyName = "idcliente";
      this.idcliente.HeaderText = "Cliente";
      this.idcliente.Name = "idcliente";
      this.idcliente.ReadOnly = true;
      this.idcliente.Width = 65;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(324, 291);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(148, 14);
      this.label5.TabIndex = 75;
      this.label5.Text = "F6 - Visualiza Itens da Venda";
      // 
      // FormGridVenda
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(823, 316);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label5);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormGridVenda";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Vendas";
      this.Load += new System.EventHandler(this.FormGridVenda_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGridVenda_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radNumero;
    private System.Windows.Forms.TextBox txtNumeroVenda;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
    private System.Windows.Forms.DataGridViewTextBoxColumn datavenda;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnConsCliente;
    private System.Windows.Forms.RadioButton radCliente;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtFim;
    private System.Windows.Forms.DateTimePicker dtInicio;
    private System.Windows.Forms.RadioButton radPeriodo;
    public System.Windows.Forms.Label lblNomeCliente;
    public System.Windows.Forms.TextBox txtCodigoCliente;
    public System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RadioButton radVendedor;
    private System.Windows.Forms.ComboBox cbxVendedor;
    public System.Windows.Forms.ComboBox cbxSituacao;
    private System.Windows.Forms.Label label5;
  }
}