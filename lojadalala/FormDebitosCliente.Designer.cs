namespace lojadalala
{
  partial class FormDebitosCliente
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebitosCliente));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idparcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dtvencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.butSair = new System.Windows.Forms.Button();
      this.btnEfetuarPagamento = new System.Windows.Forms.Button();
      this.lblTotal = new System.Windows.Forms.Label();
      this.lblTxtTotal = new System.Windows.Forms.Label();
      this.btnInserirJuros = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvenda,
            this.idparcela,
            this.dtvencimento,
            this.valor,
            this.juros,
            this.total,
            this.obs,
            this.estado,
            this.id_cliente});
      this.dataGridView1.Location = new System.Drawing.Point(3, 3);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(488, 221);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // idvenda
      // 
      this.idvenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idvenda.DataPropertyName = "idvenda";
      this.idvenda.HeaderText = "Venda";
      this.idvenda.Name = "idvenda";
      this.idvenda.ReadOnly = true;
      this.idvenda.Width = 62;
      // 
      // idparcela
      // 
      this.idparcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idparcela.DataPropertyName = "idparcela";
      this.idparcela.HeaderText = "Parcela";
      this.idparcela.Name = "idparcela";
      this.idparcela.ReadOnly = true;
      this.idparcela.Width = 67;
      // 
      // dtvencimento
      // 
      this.dtvencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dtvencimento.DataPropertyName = "dtvencimento";
      this.dtvencimento.HeaderText = "Vencimento";
      this.dtvencimento.Name = "dtvencimento";
      this.dtvencimento.ReadOnly = true;
      this.dtvencimento.Width = 87;
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
      // juros
      // 
      this.juros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.juros.DataPropertyName = "juros";
      this.juros.HeaderText = "Juros";
      this.juros.Name = "juros";
      this.juros.ReadOnly = true;
      this.juros.Width = 58;
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
      // obs
      // 
      this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obs.DataPropertyName = "obs";
      this.obs.HeaderText = "Observação";
      this.obs.Name = "obs";
      this.obs.ReadOnly = true;
      this.obs.Width = 90;
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
      // id_cliente
      // 
      this.id_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id_cliente.DataPropertyName = "idcliente";
      this.id_cliente.HeaderText = "Cód. Cliente";
      this.id_cliente.Name = "id_cliente";
      this.id_cliente.ReadOnly = true;
      this.id_cliente.Visible = false;
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(410, 254);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 2;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // btnEfetuarPagamento
      // 
      this.btnEfetuarPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnEfetuarPagamento.Enabled = false;
      this.btnEfetuarPagamento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEfetuarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEfetuarPagamento.Image")));
      this.btnEfetuarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEfetuarPagamento.Location = new System.Drawing.Point(3, 247);
      this.btnEfetuarPagamento.Name = "btnEfetuarPagamento";
      this.btnEfetuarPagamento.Size = new System.Drawing.Size(124, 30);
      this.btnEfetuarPagamento.TabIndex = 4;
      this.btnEfetuarPagamento.Text = "        Receber Conta";
      this.btnEfetuarPagamento.UseVisualStyleBackColor = true;
      this.btnEfetuarPagamento.Click += new System.EventHandler(this.btnEfetuarPagamento_Click);
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotal.Location = new System.Drawing.Point(434, 234);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(31, 13);
      this.lblTotal.TabIndex = 17;
      this.lblTotal.Text = "0,00";
      // 
      // lblTxtTotal
      // 
      this.lblTxtTotal.AutoSize = true;
      this.lblTxtTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTxtTotal.Location = new System.Drawing.Point(401, 234);
      this.lblTxtTotal.Name = "lblTxtTotal";
      this.lblTxtTotal.Size = new System.Drawing.Size(34, 14);
      this.lblTxtTotal.TabIndex = 16;
      this.lblTxtTotal.Text = "Total:";
      // 
      // btnInserirJuros
      // 
      this.btnInserirJuros.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnInserirJuros.Enabled = false;
      this.btnInserirJuros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInserirJuros.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirJuros.Image")));
      this.btnInserirJuros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInserirJuros.Location = new System.Drawing.Point(133, 247);
      this.btnInserirJuros.Name = "btnInserirJuros";
      this.btnInserirJuros.Size = new System.Drawing.Size(124, 30);
      this.btnInserirJuros.TabIndex = 4;
      this.btnInserirJuros.Text = "      Alterar Juros";
      this.btnInserirJuros.UseVisualStyleBackColor = true;
      this.btnInserirJuros.Click += new System.EventHandler(this.btnInserirJuros_Click);
      // 
      // FormDebitosCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(494, 281);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.lblTxtTotal);
      this.Controls.Add(this.btnInserirJuros);
      this.Controls.Add(this.btnEfetuarPagamento);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormDebitosCliente";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Débitos em Aberto ---> Cliente:";
      this.Load += new System.EventHandler(this.FormDebitosCliente_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.Button btnEfetuarPagamento;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblTxtTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
    private System.Windows.Forms.DataGridViewTextBoxColumn idparcela;
    private System.Windows.Forms.DataGridViewTextBoxColumn dtvencimento;
    private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    private System.Windows.Forms.DataGridViewTextBoxColumn juros;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
    private System.Windows.Forms.Button btnInserirJuros;
  }
}