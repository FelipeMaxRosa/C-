namespace lojadalala
{
  partial class FormGridCaixas
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridCaixas));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idcaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataatual = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valorinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valorfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblNomeCliente = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dtFim = new System.Windows.Forms.DateTimePicker();
      this.dtInicio = new System.Windows.Forms.DateTimePicker();
      this.radPeriodo = new System.Windows.Forms.RadioButton();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.cbxSituacao = new System.Windows.Forms.ComboBox();
      this.radNumero = new System.Windows.Forms.RadioButton();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.txtIDCaixa = new System.Windows.Forms.TextBox();
      this.butSair = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcaixa,
            this.dataatual,
            this.valorinicial,
            this.valorfinal,
            this.saldo,
            this.estado});
      this.dataGridView1.Location = new System.Drawing.Point(327, 11);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(435, 269);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // idcaixa
      // 
      this.idcaixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idcaixa.DataPropertyName = "idcaixa";
      this.idcaixa.HeaderText = "ID";
      this.idcaixa.Name = "idcaixa";
      this.idcaixa.ReadOnly = true;
      this.idcaixa.Width = 43;
      // 
      // dataatual
      // 
      this.dataatual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataatual.DataPropertyName = "dataatual";
      this.dataatual.HeaderText = "Data";
      this.dataatual.Name = "dataatual";
      this.dataatual.ReadOnly = true;
      this.dataatual.Width = 55;
      // 
      // valorinicial
      // 
      this.valorinicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.valorinicial.DataPropertyName = "valorinicial";
      this.valorinicial.HeaderText = "Valor Inicial";
      this.valorinicial.Name = "valorinicial";
      this.valorinicial.ReadOnly = true;
      this.valorinicial.Width = 86;
      // 
      // valorfinal
      // 
      this.valorfinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.valorfinal.DataPropertyName = "valorfinal";
      this.valorfinal.HeaderText = "Valor Final";
      this.valorfinal.Name = "valorfinal";
      this.valorfinal.ReadOnly = true;
      this.valorfinal.Width = 81;
      // 
      // saldo
      // 
      this.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.saldo.DataPropertyName = "saldo";
      this.saldo.HeaderText = "Saldo";
      this.saldo.Name = "saldo";
      this.saldo.ReadOnly = true;
      this.saldo.Width = 58;
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
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.lblNomeCliente);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.dtFim);
      this.groupBox1.Controls.Add(this.dtInicio);
      this.groupBox1.Controls.Add(this.radPeriodo);
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.radNumero);
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.txtIDCaixa);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(2, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(319, 277);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por";
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
      // lblNomeCliente
      // 
      this.lblNomeCliente.AutoSize = true;
      this.lblNomeCliente.Location = new System.Drawing.Point(14, 153);
      this.lblNomeCliente.Name = "lblNomeCliente";
      this.lblNomeCliente.Size = new System.Drawing.Size(0, 13);
      this.lblNomeCliente.TabIndex = 82;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(169, 158);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 13);
      this.label3.TabIndex = 78;
      this.label3.Text = "Fim:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(14, 158);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 75;
      this.label2.Text = "Início:";
      // 
      // dtFim
      // 
      this.dtFim.Enabled = false;
      this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtFim.Location = new System.Drawing.Point(199, 155);
      this.dtFim.Name = "dtFim";
      this.dtFim.Size = new System.Drawing.Size(109, 21);
      this.dtFim.TabIndex = 4;
      // 
      // dtInicio
      // 
      this.dtInicio.Enabled = false;
      this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtInicio.Location = new System.Drawing.Point(52, 155);
      this.dtInicio.Name = "dtInicio";
      this.dtInicio.Size = new System.Drawing.Size(109, 21);
      this.dtInicio.TabIndex = 3;
      // 
      // radPeriodo
      // 
      this.radPeriodo.AutoSize = true;
      this.radPeriodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radPeriodo.Location = new System.Drawing.Point(17, 133);
      this.radPeriodo.Name = "radPeriodo";
      this.radPeriodo.Size = new System.Drawing.Size(65, 17);
      this.radPeriodo.TabIndex = 2;
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
            "ABERTO",
            "FECHADO",
            "TODOS"});
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
      this.radNumero.Size = new System.Drawing.Size(40, 17);
      this.radNumero.TabIndex = 40;
      this.radNumero.TabStop = true;
      this.radNumero.Text = "&ID:";
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
      this.btnPesquisar.TabIndex = 5;
      this.btnPesquisar.Text = "   Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // txtIDCaixa
      // 
      this.txtIDCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtIDCaixa.Location = new System.Drawing.Point(63, 21);
      this.txtIDCaixa.MaxLength = 50;
      this.txtIDCaixa.Name = "txtIDCaixa";
      this.txtIDCaixa.Size = new System.Drawing.Size(40, 21);
      this.txtIDCaixa.TabIndex = 0;
      this.txtIDCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCaixa_KeyPress);
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(681, 286);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 76;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(324, 291);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(141, 14);
      this.label5.TabIndex = 77;
      this.label5.Text = "F6 - Visualiza Lançamentos";
      this.label5.Visible = false;
      // 
      // FormGridCaixas
      // 
      this.AcceptButton = this.btnPesquisar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(767, 315);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormGridCaixas";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Caixas";
      this.Load += new System.EventHandler(this.FormGridCaixas_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGridCaixas_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcaixa;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataatual;
    private System.Windows.Forms.DataGridViewTextBoxColumn valorinicial;
    private System.Windows.Forms.DataGridViewTextBoxColumn valorfinal;
    private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.Label lblNomeCliente;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtFim;
    private System.Windows.Forms.DateTimePicker dtInicio;
    private System.Windows.Forms.RadioButton radPeriodo;
    private System.Windows.Forms.GroupBox groupBox4;
    public System.Windows.Forms.ComboBox cbxSituacao;
    private System.Windows.Forms.RadioButton radNumero;
    public System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.TextBox txtIDCaixa;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Label label5;
  }
}