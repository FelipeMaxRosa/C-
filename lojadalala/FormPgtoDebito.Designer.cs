namespace lojadalala
{
  partial class FormPgtoDebito
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPgtoDebito));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.gpbObs = new System.Windows.Forms.GroupBox();
      this.txtObs = new System.Windows.Forms.TextBox();
      this.gpbFormaPgto = new System.Windows.Forms.GroupBox();
      this.cbxFormaPgto = new System.Windows.Forms.ComboBox();
      this.gpbParcial = new System.Windows.Forms.GroupBox();
      this.txtNovoValor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNovoJuros = new System.Windows.Forms.TextBox();
      this.txtNovoTotal = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dtNovoVencimento = new System.Windows.Forms.DateTimePicker();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.gpbDataHora = new System.Windows.Forms.GroupBox();
      this.dtDataAtual = new System.Windows.Forms.DateTimePicker();
      this.dtHoraAtual = new System.Windows.Forms.DateTimePicker();
      this.gpbValor = new System.Windows.Forms.GroupBox();
      this.txtValor = new System.Windows.Forms.TextBox();
      this.label26 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cbxTipo = new System.Windows.Forms.ComboBox();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.txtNumParcelaAtual = new System.Windows.Forms.TextBox();
      this.txtNumVendaAtual = new System.Windows.Forms.TextBox();
      this.txtJuros = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.txtValorAtual = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dtVencimentoAtual = new System.Windows.Forms.DateTimePicker();
      this.groupBox1.SuspendLayout();
      this.gpbObs.SuspendLayout();
      this.gpbFormaPgto.SuspendLayout();
      this.gpbParcial.SuspendLayout();
      this.gpbDataHora.SuspendLayout();
      this.gpbValor.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnCancelar);
      this.groupBox1.Controls.Add(this.btnSalvar);
      this.groupBox1.Controls.Add(this.gpbObs);
      this.groupBox1.Controls.Add(this.gpbFormaPgto);
      this.groupBox1.Controls.Add(this.gpbParcial);
      this.groupBox1.Controls.Add(this.gpbDataHora);
      this.groupBox1.Controls.Add(this.gpbValor);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(7, 88);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(513, 257);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados do Recebimento";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
      this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancelar.Location = new System.Drawing.Point(123, 218);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(111, 30);
      this.btnCancelar.TabIndex = 7;
      this.btnCancelar.Text = "   Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSalvar.Enabled = false;
      this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
      this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSalvar.Location = new System.Drawing.Point(6, 218);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(111, 30);
      this.btnSalvar.TabIndex = 6;
      this.btnSalvar.Text = "  Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // gpbObs
      // 
      this.gpbObs.Controls.Add(this.txtObs);
      this.gpbObs.Enabled = false;
      this.gpbObs.Location = new System.Drawing.Point(6, 133);
      this.gpbObs.Name = "gpbObs";
      this.gpbObs.Size = new System.Drawing.Size(278, 78);
      this.gpbObs.TabIndex = 4;
      this.gpbObs.TabStop = false;
      this.gpbObs.Text = "Observação";
      // 
      // txtObs
      // 
      this.txtObs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtObs.Location = new System.Drawing.Point(7, 17);
      this.txtObs.MaxLength = 250;
      this.txtObs.Multiline = true;
      this.txtObs.Name = "txtObs";
      this.txtObs.Size = new System.Drawing.Size(261, 52);
      this.txtObs.TabIndex = 0;
      // 
      // gpbFormaPgto
      // 
      this.gpbFormaPgto.Controls.Add(this.cbxFormaPgto);
      this.gpbFormaPgto.Enabled = false;
      this.gpbFormaPgto.Location = new System.Drawing.Point(6, 79);
      this.gpbFormaPgto.Name = "gpbFormaPgto";
      this.gpbFormaPgto.Size = new System.Drawing.Size(246, 51);
      this.gpbFormaPgto.TabIndex = 3;
      this.gpbFormaPgto.TabStop = false;
      this.gpbFormaPgto.Text = "Forma de Pagamento";
      // 
      // cbxFormaPgto
      // 
      this.cbxFormaPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxFormaPgto.FormattingEnabled = true;
      this.cbxFormaPgto.Location = new System.Drawing.Point(7, 19);
      this.cbxFormaPgto.Name = "cbxFormaPgto";
      this.cbxFormaPgto.Size = new System.Drawing.Size(230, 21);
      this.cbxFormaPgto.TabIndex = 0;
      // 
      // gpbParcial
      // 
      this.gpbParcial.Controls.Add(this.txtNovoValor);
      this.gpbParcial.Controls.Add(this.label2);
      this.gpbParcial.Controls.Add(this.txtNovoJuros);
      this.gpbParcial.Controls.Add(this.txtNovoTotal);
      this.gpbParcial.Controls.Add(this.label1);
      this.gpbParcial.Controls.Add(this.dtNovoVencimento);
      this.gpbParcial.Controls.Add(this.label10);
      this.gpbParcial.Controls.Add(this.label9);
      this.gpbParcial.Location = new System.Drawing.Point(290, 79);
      this.gpbParcial.Name = "gpbParcial";
      this.gpbParcial.Size = new System.Drawing.Size(215, 132);
      this.gpbParcial.TabIndex = 5;
      this.gpbParcial.TabStop = false;
      this.gpbParcial.Text = "Nova Conta - Vencimento/Valor";
      this.gpbParcial.Visible = false;
      // 
      // txtNovoValor
      // 
      this.txtNovoValor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNovoValor.Location = new System.Drawing.Point(78, 47);
      this.txtNovoValor.Name = "txtNovoValor";
      this.txtNovoValor.ReadOnly = true;
      this.txtNovoValor.Size = new System.Drawing.Size(75, 21);
      this.txtNovoValor.TabIndex = 1;
      this.txtNovoValor.TabStop = false;
      this.txtNovoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoValor_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(6, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 96;
      this.label2.Text = "Vencimento:";
      // 
      // txtNovoJuros
      // 
      this.txtNovoJuros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNovoJuros.Location = new System.Drawing.Point(78, 73);
      this.txtNovoJuros.Name = "txtNovoJuros";
      this.txtNovoJuros.Size = new System.Drawing.Size(49, 21);
      this.txtNovoJuros.TabIndex = 2;
      this.txtNovoJuros.Leave += new System.EventHandler(this.txtNovoJuros_Leave);
      this.txtNovoJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoJuros_KeyPress);
      // 
      // txtNovoTotal
      // 
      this.txtNovoTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNovoTotal.Location = new System.Drawing.Point(78, 99);
      this.txtNovoTotal.Name = "txtNovoTotal";
      this.txtNovoTotal.ReadOnly = true;
      this.txtNovoTotal.Size = new System.Drawing.Size(68, 21);
      this.txtNovoTotal.TabIndex = 3;
      this.txtNovoTotal.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 96;
      this.label1.Text = "Valor (R$):";
      // 
      // dtNovoVencimento
      // 
      this.dtNovoVencimento.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtNovoVencimento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtNovoVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtNovoVencimento.Location = new System.Drawing.Point(78, 20);
      this.dtNovoVencimento.Name = "dtNovoVencimento";
      this.dtNovoVencimento.Size = new System.Drawing.Size(106, 21);
      this.dtNovoVencimento.TabIndex = 0;
      this.dtNovoVencimento.Value = new System.DateTime(1900, 1, 1, 19, 36, 0, 0);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(13, 102);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(59, 13);
      this.label10.TabIndex = 96;
      this.label10.Text = "Total (R$):";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(14, 76);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(61, 13);
      this.label9.TabIndex = 96;
      this.label9.Text = "Juros (R$):";
      // 
      // gpbDataHora
      // 
      this.gpbDataHora.Controls.Add(this.dtDataAtual);
      this.gpbDataHora.Controls.Add(this.dtHoraAtual);
      this.gpbDataHora.Enabled = false;
      this.gpbDataHora.Location = new System.Drawing.Point(147, 20);
      this.gpbDataHora.Name = "gpbDataHora";
      this.gpbDataHora.Size = new System.Drawing.Size(215, 53);
      this.gpbDataHora.TabIndex = 1;
      this.gpbDataHora.TabStop = false;
      this.gpbDataHora.Text = "Data/Hora";
      // 
      // dtDataAtual
      // 
      this.dtDataAtual.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtDataAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtDataAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtDataAtual.Location = new System.Drawing.Point(9, 20);
      this.dtDataAtual.Name = "dtDataAtual";
      this.dtDataAtual.Size = new System.Drawing.Size(106, 21);
      this.dtDataAtual.TabIndex = 0;
      this.dtDataAtual.Value = new System.DateTime(1900, 1, 1, 19, 36, 0, 0);
      this.dtDataAtual.Leave += new System.EventHandler(this.dtDataAtual_Leave);
      // 
      // dtHoraAtual
      // 
      this.dtHoraAtual.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtHoraAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtHoraAtual.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtHoraAtual.Location = new System.Drawing.Point(121, 20);
      this.dtHoraAtual.Name = "dtHoraAtual";
      this.dtHoraAtual.Size = new System.Drawing.Size(85, 21);
      this.dtHoraAtual.TabIndex = 1;
      this.dtHoraAtual.Value = new System.DateTime(1900, 1, 1, 19, 36, 0, 0);
      // 
      // gpbValor
      // 
      this.gpbValor.Controls.Add(this.txtValor);
      this.gpbValor.Controls.Add(this.label26);
      this.gpbValor.Enabled = false;
      this.gpbValor.Location = new System.Drawing.Point(368, 20);
      this.gpbValor.Name = "gpbValor";
      this.gpbValor.Size = new System.Drawing.Size(119, 53);
      this.gpbValor.TabIndex = 2;
      this.gpbValor.TabStop = false;
      this.gpbValor.Text = "Valor Pago";
      // 
      // txtValor
      // 
      this.txtValor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValor.Location = new System.Drawing.Point(35, 20);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(75, 21);
      this.txtValor.TabIndex = 0;
      this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
      this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label26.Location = new System.Drawing.Point(9, 23);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(20, 13);
      this.label26.TabIndex = 94;
      this.label26.Text = "R$";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cbxTipo);
      this.groupBox2.Location = new System.Drawing.Point(6, 20);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(135, 53);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Opção";
      // 
      // cbxTipo
      // 
      this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxTipo.FormattingEnabled = true;
      this.cbxTipo.Items.AddRange(new object[] {
            "TOTAL",
            "PARCIAL"});
      this.cbxTipo.Location = new System.Drawing.Point(6, 20);
      this.cbxTipo.Name = "cbxTipo";
      this.cbxTipo.Size = new System.Drawing.Size(121, 21);
      this.cbxTipo.TabIndex = 0;
      this.cbxTipo.Leave += new System.EventHandler(this.cbxTipo_Leave);
      this.cbxTipo.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.txtNumParcelaAtual);
      this.groupBox7.Controls.Add(this.txtNumVendaAtual);
      this.groupBox7.Controls.Add(this.txtJuros);
      this.groupBox7.Controls.Add(this.txtTotal);
      this.groupBox7.Controls.Add(this.txtValorAtual);
      this.groupBox7.Controls.Add(this.label6);
      this.groupBox7.Controls.Add(this.label3);
      this.groupBox7.Controls.Add(this.label7);
      this.groupBox7.Controls.Add(this.label8);
      this.groupBox7.Controls.Add(this.label5);
      this.groupBox7.Controls.Add(this.label4);
      this.groupBox7.Controls.Add(this.dtVencimentoAtual);
      this.groupBox7.Enabled = false;
      this.groupBox7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox7.Location = new System.Drawing.Point(7, 2);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(513, 80);
      this.groupBox7.TabIndex = 98;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Conta Atual";
      // 
      // txtNumParcelaAtual
      // 
      this.txtNumParcelaAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNumParcelaAtual.Location = new System.Drawing.Point(225, 22);
      this.txtNumParcelaAtual.Name = "txtNumParcelaAtual";
      this.txtNumParcelaAtual.ReadOnly = true;
      this.txtNumParcelaAtual.Size = new System.Drawing.Size(49, 21);
      this.txtNumParcelaAtual.TabIndex = 95;
      this.txtNumParcelaAtual.TabStop = false;
      // 
      // txtNumVendaAtual
      // 
      this.txtNumVendaAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNumVendaAtual.Location = new System.Drawing.Point(87, 22);
      this.txtNumVendaAtual.Name = "txtNumVendaAtual";
      this.txtNumVendaAtual.ReadOnly = true;
      this.txtNumVendaAtual.Size = new System.Drawing.Size(49, 21);
      this.txtNumVendaAtual.TabIndex = 95;
      this.txtNumVendaAtual.TabStop = false;
      // 
      // txtJuros
      // 
      this.txtJuros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtJuros.Location = new System.Drawing.Point(225, 49);
      this.txtJuros.Name = "txtJuros";
      this.txtJuros.ReadOnly = true;
      this.txtJuros.Size = new System.Drawing.Size(49, 21);
      this.txtJuros.TabIndex = 95;
      this.txtJuros.TabStop = false;
      // 
      // txtTotal
      // 
      this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotal.Location = new System.Drawing.Point(391, 49);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(68, 21);
      this.txtTotal.TabIndex = 95;
      this.txtTotal.TabStop = false;
      // 
      // txtValorAtual
      // 
      this.txtValorAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValorAtual.Location = new System.Drawing.Point(87, 49);
      this.txtValorAtual.Name = "txtValorAtual";
      this.txtValorAtual.ReadOnly = true;
      this.txtValorAtual.Size = new System.Drawing.Size(68, 21);
      this.txtValorAtual.TabIndex = 95;
      this.txtValorAtual.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(148, 25);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(74, 13);
      this.label6.TabIndex = 96;
      this.label6.Text = "Núm. Parcela:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(319, 25);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 96;
      this.label3.Text = "Vencimento:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(161, 52);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(61, 13);
      this.label7.TabIndex = 96;
      this.label7.Text = "Juros (R$):";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(305, 52);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(84, 13);
      this.label8.TabIndex = 96;
      this.label8.Text = "TOTAL (R$):";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(10, 25);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 96;
      this.label5.Text = "Núm. Venda:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(22, 52);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 13);
      this.label4.TabIndex = 96;
      this.label4.Text = "Valor (R$):";
      // 
      // dtVencimentoAtual
      // 
      this.dtVencimentoAtual.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtVencimentoAtual.Enabled = false;
      this.dtVencimentoAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtVencimentoAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtVencimentoAtual.Location = new System.Drawing.Point(391, 22);
      this.dtVencimentoAtual.Name = "dtVencimentoAtual";
      this.dtVencimentoAtual.Size = new System.Drawing.Size(106, 21);
      this.dtVencimentoAtual.TabIndex = 79;
      this.dtVencimentoAtual.TabStop = false;
      this.dtVencimentoAtual.Value = new System.DateTime(1900, 1, 1, 19, 36, 0, 0);
      // 
      // FormPgtoDebito
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(532, 355);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormPgtoDebito";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Recebimento de Conta";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPgtoDebito_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.gpbObs.ResumeLayout(false);
      this.gpbObs.PerformLayout();
      this.gpbFormaPgto.ResumeLayout(false);
      this.gpbParcial.ResumeLayout(false);
      this.gpbParcial.PerformLayout();
      this.gpbDataHora.ResumeLayout(false);
      this.gpbValor.ResumeLayout(false);
      this.gpbValor.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    public System.Windows.Forms.DateTimePicker dtDataAtual;
    public System.Windows.Forms.DateTimePicker dtHoraAtual;
    private System.Windows.Forms.Label label26;
    public System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.ComboBox cbxTipo;
    private System.Windows.Forms.GroupBox gpbDataHora;
    private System.Windows.Forms.GroupBox gpbValor;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox gpbParcial;
    public System.Windows.Forms.TextBox txtNovoValor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.DateTimePicker dtNovoVencimento;
    private System.Windows.Forms.GroupBox groupBox7;
    public System.Windows.Forms.TextBox txtNumParcelaAtual;
    public System.Windows.Forms.TextBox txtNumVendaAtual;
    public System.Windows.Forms.TextBox txtValorAtual;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.DateTimePicker dtVencimentoAtual;
    private System.Windows.Forms.GroupBox gpbFormaPgto;
    private System.Windows.Forms.ComboBox cbxFormaPgto;
    private System.Windows.Forms.GroupBox gpbObs;
    public System.Windows.Forms.TextBox txtObs;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnCancelar;
    public System.Windows.Forms.TextBox txtJuros;
    public System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    public System.Windows.Forms.TextBox txtNovoJuros;
    public System.Windows.Forms.TextBox txtNovoTotal;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
  }
}