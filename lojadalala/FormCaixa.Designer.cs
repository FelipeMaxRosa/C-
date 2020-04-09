namespace lojadalala
{
  partial class FormCaixa
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
      this.gpbEntradas = new System.Windows.Forms.GroupBox();
      this.label9 = new System.Windows.Forms.Label();
      this.lblTotalEntradas = new System.Windows.Forms.Label();
      this.lblTxtTotal = new System.Windows.Forms.Label();
      this.btnNovaEntrada = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idcaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gpbSaidas = new System.Windows.Forms.GroupBox();
      this.label10 = new System.Windows.Forms.Label();
      this.lblTotalSaidas = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnNovaSaida = new System.Windows.Forms.Button();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.idsaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.datasaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valorsaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.usuariosaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obssaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idcaixasaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.lblFundo = new System.Windows.Forms.Label();
      this.lblEstado = new System.Windows.Forms.Label();
      this.txtIdCaixa = new System.Windows.Forms.TextBox();
      this.dtCaixa = new System.Windows.Forms.DateTimePicker();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.butSair = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.lblSaldoCaixa = new System.Windows.Forms.Label();
      this.gpbEntradas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.gpbSaidas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // gpbEntradas
      // 
      this.gpbEntradas.Controls.Add(this.label9);
      this.gpbEntradas.Controls.Add(this.lblTotalEntradas);
      this.gpbEntradas.Controls.Add(this.lblTxtTotal);
      this.gpbEntradas.Controls.Add(this.btnNovaEntrada);
      this.gpbEntradas.Controls.Add(this.dataGridView1);
      this.gpbEntradas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbEntradas.Location = new System.Drawing.Point(4, 56);
      this.gpbEntradas.Name = "gpbEntradas";
      this.gpbEntradas.Size = new System.Drawing.Size(362, 309);
      this.gpbEntradas.TabIndex = 0;
      this.gpbEntradas.TabStop = false;
      this.gpbEntradas.Text = "Entradas";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label9.Location = new System.Drawing.Point(261, 282);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(22, 13);
      this.label9.TabIndex = 69;
      this.label9.Text = "R$";
      // 
      // lblTotalEntradas
      // 
      this.lblTotalEntradas.AutoSize = true;
      this.lblTotalEntradas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalEntradas.Location = new System.Drawing.Point(285, 282);
      this.lblTotalEntradas.Name = "lblTotalEntradas";
      this.lblTotalEntradas.Size = new System.Drawing.Size(35, 14);
      this.lblTotalEntradas.TabIndex = 17;
      this.lblTotalEntradas.Text = "0,00";
      // 
      // lblTxtTotal
      // 
      this.lblTxtTotal.AutoSize = true;
      this.lblTxtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTxtTotal.Location = new System.Drawing.Point(211, 282);
      this.lblTxtTotal.Name = "lblTxtTotal";
      this.lblTxtTotal.Size = new System.Drawing.Size(46, 13);
      this.lblTxtTotal.TabIndex = 16;
      this.lblTxtTotal.Text = "TOTAL:";
      // 
      // btnNovaEntrada
      // 
      this.btnNovaEntrada.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNovaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaEntrada.Image")));
      this.btnNovaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnNovaEntrada.Location = new System.Drawing.Point(7, 274);
      this.btnNovaEntrada.Name = "btnNovaEntrada";
      this.btnNovaEntrada.Size = new System.Drawing.Size(116, 30);
      this.btnNovaEntrada.TabIndex = 1;
      this.btnNovaEntrada.Text = "       Nova Entrada";
      this.btnNovaEntrada.UseVisualStyleBackColor = true;
      this.btnNovaEntrada.Click += new System.EventHandler(this.btnNovaEntrada_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data,
            this.valor,
            this.usuario,
            this.obs,
            this.idcaixa});
      this.dataGridView1.Location = new System.Drawing.Point(7, 17);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(348, 254);
      this.dataGridView1.TabIndex = 0;
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.DataPropertyName = "identrada";
      this.id.HeaderText = "ID";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 43;
      // 
      // data
      // 
      this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.data.DataPropertyName = "data";
      this.data.HeaderText = "Data";
      this.data.Name = "data";
      this.data.ReadOnly = true;
      this.data.Width = 55;
      // 
      // valor
      // 
      this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.valor.DataPropertyName = "valor";
      this.valor.HeaderText = "Valor";
      this.valor.Name = "valor";
      this.valor.ReadOnly = true;
      this.valor.Width = 56;
      // 
      // usuario
      // 
      this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.usuario.DataPropertyName = "usuario";
      this.usuario.HeaderText = "Usuário";
      this.usuario.Name = "usuario";
      this.usuario.ReadOnly = true;
      this.usuario.Width = 68;
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
      // idcaixa
      // 
      this.idcaixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idcaixa.DataPropertyName = "idcaixa";
      this.idcaixa.HeaderText = "idcaixa";
      this.idcaixa.Name = "idcaixa";
      this.idcaixa.ReadOnly = true;
      this.idcaixa.Visible = false;
      // 
      // gpbSaidas
      // 
      this.gpbSaidas.Controls.Add(this.label10);
      this.gpbSaidas.Controls.Add(this.lblTotalSaidas);
      this.gpbSaidas.Controls.Add(this.label2);
      this.gpbSaidas.Controls.Add(this.btnNovaSaida);
      this.gpbSaidas.Controls.Add(this.dataGridView2);
      this.gpbSaidas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbSaidas.Location = new System.Drawing.Point(372, 56);
      this.gpbSaidas.Name = "gpbSaidas";
      this.gpbSaidas.Size = new System.Drawing.Size(362, 309);
      this.gpbSaidas.TabIndex = 1;
      this.gpbSaidas.TabStop = false;
      this.gpbSaidas.Text = "Saídas";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label10.Location = new System.Drawing.Point(263, 282);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(22, 13);
      this.label10.TabIndex = 69;
      this.label10.Text = "R$";
      // 
      // lblTotalSaidas
      // 
      this.lblTotalSaidas.AutoSize = true;
      this.lblTotalSaidas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalSaidas.Location = new System.Drawing.Point(287, 282);
      this.lblTotalSaidas.Name = "lblTotalSaidas";
      this.lblTotalSaidas.Size = new System.Drawing.Size(35, 14);
      this.lblTotalSaidas.TabIndex = 17;
      this.lblTotalSaidas.Text = "0,00";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(213, 282);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "TOTAL:";
      // 
      // btnNovaSaida
      // 
      this.btnNovaSaida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNovaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaSaida.Image")));
      this.btnNovaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnNovaSaida.Location = new System.Drawing.Point(7, 274);
      this.btnNovaSaida.Name = "btnNovaSaida";
      this.btnNovaSaida.Size = new System.Drawing.Size(116, 30);
      this.btnNovaSaida.TabIndex = 1;
      this.btnNovaSaida.Text = "     Nova Saída";
      this.btnNovaSaida.UseVisualStyleBackColor = true;
      this.btnNovaSaida.Click += new System.EventHandler(this.btnNovaSaida_Click);
      // 
      // dataGridView2
      // 
      this.dataGridView2.AllowUserToAddRows = false;
      this.dataGridView2.AllowUserToDeleteRows = false;
      this.dataGridView2.AllowUserToOrderColumns = true;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsaida,
            this.datasaida,
            this.valorsaida,
            this.usuariosaida,
            this.obssaida,
            this.idcaixasaida});
      this.dataGridView2.Location = new System.Drawing.Point(7, 17);
      this.dataGridView2.MultiSelect = false;
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.ReadOnly = true;
      this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView2.Size = new System.Drawing.Size(348, 254);
      this.dataGridView2.TabIndex = 0;
      // 
      // idsaida
      // 
      this.idsaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idsaida.DataPropertyName = "idsaida";
      this.idsaida.HeaderText = "ID";
      this.idsaida.Name = "idsaida";
      this.idsaida.ReadOnly = true;
      this.idsaida.Width = 43;
      // 
      // datasaida
      // 
      this.datasaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.datasaida.DataPropertyName = "data";
      this.datasaida.HeaderText = "Data";
      this.datasaida.Name = "datasaida";
      this.datasaida.ReadOnly = true;
      this.datasaida.Width = 55;
      // 
      // valorsaida
      // 
      this.valorsaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.valorsaida.DataPropertyName = "valor";
      this.valorsaida.HeaderText = "Valor";
      this.valorsaida.Name = "valorsaida";
      this.valorsaida.ReadOnly = true;
      this.valorsaida.Width = 56;
      // 
      // usuariosaida
      // 
      this.usuariosaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.usuariosaida.DataPropertyName = "usuario";
      this.usuariosaida.HeaderText = "Usuário";
      this.usuariosaida.Name = "usuariosaida";
      this.usuariosaida.ReadOnly = true;
      this.usuariosaida.Width = 68;
      // 
      // obssaida
      // 
      this.obssaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obssaida.DataPropertyName = "obs";
      this.obssaida.HeaderText = "Observação";
      this.obssaida.Name = "obssaida";
      this.obssaida.ReadOnly = true;
      this.obssaida.Width = 90;
      // 
      // idcaixasaida
      // 
      this.idcaixasaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idcaixasaida.DataPropertyName = "idcaixa";
      this.idcaixasaida.HeaderText = "idcaixa";
      this.idcaixasaida.Name = "idcaixasaida";
      this.idcaixasaida.ReadOnly = true;
      this.idcaixasaida.Visible = false;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label8);
      this.groupBox3.Controls.Add(this.lblFundo);
      this.groupBox3.Controls.Add(this.lblEstado);
      this.groupBox3.Controls.Add(this.txtIdCaixa);
      this.groupBox3.Controls.Add(this.dtCaixa);
      this.groupBox3.Controls.Add(this.label7);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(4, 2);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(478, 44);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Caixa Atual";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label8.Location = new System.Drawing.Point(411, 18);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(22, 13);
      this.label8.TabIndex = 68;
      this.label8.Text = "R$";
      // 
      // lblFundo
      // 
      this.lblFundo.AutoSize = true;
      this.lblFundo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFundo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblFundo.Location = new System.Drawing.Point(431, 16);
      this.lblFundo.Name = "lblFundo";
      this.lblFundo.Size = new System.Drawing.Size(33, 18);
      this.lblFundo.TabIndex = 68;
      this.lblFundo.Text = "0,00";
      // 
      // lblEstado
      // 
      this.lblEstado.AutoSize = true;
      this.lblEstado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblEstado.Location = new System.Drawing.Point(299, 16);
      this.lblEstado.Name = "lblEstado";
      this.lblEstado.Size = new System.Drawing.Size(57, 18);
      this.lblEstado.TabIndex = 68;
      this.lblEstado.Text = "ABERTO";
      // 
      // txtIdCaixa
      // 
      this.txtIdCaixa.Location = new System.Drawing.Point(43, 16);
      this.txtIdCaixa.Name = "txtIdCaixa";
      this.txtIdCaixa.ReadOnly = true;
      this.txtIdCaixa.Size = new System.Drawing.Size(50, 21);
      this.txtIdCaixa.TabIndex = 2;
      this.txtIdCaixa.TabStop = false;
      // 
      // dtCaixa
      // 
      this.dtCaixa.Enabled = false;
      this.dtCaixa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtCaixa.Location = new System.Drawing.Point(135, 16);
      this.dtCaixa.Name = "dtCaixa";
      this.dtCaixa.Size = new System.Drawing.Size(102, 21);
      this.dtCaixa.TabIndex = 20;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(369, 18);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(41, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "Fundo:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(256, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Estado:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(99, 19);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Data:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(19, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID:";
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(653, 371);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 2;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.lblSaldoCaixa);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(588, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(146, 44);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "SALDO";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(24, 20);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(24, 14);
      this.label5.TabIndex = 24;
      this.label5.Text = "R$";
      // 
      // lblSaldoCaixa
      // 
      this.lblSaldoCaixa.AutoSize = true;
      this.lblSaldoCaixa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSaldoCaixa.Location = new System.Drawing.Point(48, 17);
      this.lblSaldoCaixa.Name = "lblSaldoCaixa";
      this.lblSaldoCaixa.Size = new System.Drawing.Size(44, 19);
      this.lblSaldoCaixa.TabIndex = 25;
      this.lblSaldoCaixa.Text = "0,00";
      // 
      // FormCaixa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(738, 399);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.gpbSaidas);
      this.Controls.Add(this.gpbEntradas);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormCaixa";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Caixa";
      this.Load += new System.EventHandler(this.FormCaixa_Load);
      this.gpbEntradas.ResumeLayout(false);
      this.gpbEntradas.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.gpbSaidas.ResumeLayout(false);
      this.gpbSaidas.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gpbEntradas;
    public System.Windows.Forms.Button btnNovaEntrada;
    private System.Windows.Forms.GroupBox gpbSaidas;
    public System.Windows.Forms.Button btnNovaSaida;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lblTotalEntradas;
    private System.Windows.Forms.Label lblTxtTotal;
    private System.Windows.Forms.Label lblTotalSaidas;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtIdCaixa;
    public System.Windows.Forms.Label lblEstado;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.Label label8;
    public System.Windows.Forms.Label lblFundo;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn data;
    private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcaixa;
    public System.Windows.Forms.DateTimePicker dtCaixa;
    private System.Windows.Forms.DataGridViewTextBoxColumn idsaida;
    private System.Windows.Forms.DataGridViewTextBoxColumn datasaida;
    private System.Windows.Forms.DataGridViewTextBoxColumn valorsaida;
    private System.Windows.Forms.DataGridViewTextBoxColumn usuariosaida;
    private System.Windows.Forms.DataGridViewTextBoxColumn obssaida;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcaixasaida;
    public System.Windows.Forms.Label label9;
    public System.Windows.Forms.Label label10;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.Label lblSaldoCaixa;
    public System.Windows.Forms.DataGridView dataGridView1;
    public System.Windows.Forms.DataGridView dataGridView2;
  }
}