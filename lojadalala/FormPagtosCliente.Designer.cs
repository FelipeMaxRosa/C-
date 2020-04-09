namespace lojadalala
{
  partial class FormPagtosCliente
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagtosCliente));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idpagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.data_pagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valor_pagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idparcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTotal = new System.Windows.Forms.Label();
      this.lblTxtTotal = new System.Windows.Forms.Label();
      this.butSair = new System.Windows.Forms.Button();
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
            this.idpagamento,
            this.data_pagto,
            this.valor_pagto,
            this.descricao,
            this.idvenda,
            this.idparcela,
            this.obs,
            this.usuario,
            this.idcliente});
      this.dataGridView1.Location = new System.Drawing.Point(3, 3);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(620, 221);
      this.dataGridView1.TabIndex = 1;
      // 
      // idpagamento
      // 
      this.idpagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idpagamento.DataPropertyName = "idpagamento";
      this.idpagamento.HeaderText = "Cód.";
      this.idpagamento.Name = "idpagamento";
      this.idpagamento.ReadOnly = true;
      this.idpagamento.Width = 55;
      // 
      // data_pagto
      // 
      this.data_pagto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.data_pagto.DataPropertyName = "data_pagto";
      this.data_pagto.HeaderText = "Data";
      this.data_pagto.Name = "data_pagto";
      this.data_pagto.ReadOnly = true;
      this.data_pagto.Width = 55;
      // 
      // valor_pagto
      // 
      this.valor_pagto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.valor_pagto.DataPropertyName = "valor_pagto";
      this.valor_pagto.HeaderText = "Valor";
      this.valor_pagto.Name = "valor_pagto";
      this.valor_pagto.ReadOnly = true;
      this.valor_pagto.Width = 56;
      // 
      // descricao
      // 
      this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.descricao.DataPropertyName = "descricao";
      this.descricao.HeaderText = "Espécie";
      this.descricao.Name = "descricao";
      this.descricao.ReadOnly = true;
      this.descricao.Width = 68;
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
      // obs
      // 
      this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obs.DataPropertyName = "obs";
      this.obs.HeaderText = "Observação";
      this.obs.Name = "obs";
      this.obs.ReadOnly = true;
      this.obs.Width = 90;
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
      // idcliente
      // 
      this.idcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idcliente.DataPropertyName = "idcliente";
      this.idcliente.HeaderText = "Cliente";
      this.idcliente.Name = "idcliente";
      this.idcliente.ReadOnly = true;
      this.idcliente.Visible = false;
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotal.Location = new System.Drawing.Point(560, 235);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(35, 13);
      this.lblTotal.TabIndex = 20;
      this.lblTotal.Text = "0,00";
      // 
      // lblTxtTotal
      // 
      this.lblTxtTotal.AutoSize = true;
      this.lblTxtTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTxtTotal.Location = new System.Drawing.Point(529, 235);
      this.lblTxtTotal.Name = "lblTxtTotal";
      this.lblTxtTotal.Size = new System.Drawing.Size(34, 14);
      this.lblTxtTotal.TabIndex = 19;
      this.lblTxtTotal.Text = "Total:";
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(542, 257);
      this.butSair.Name = "butSair";
      this.butSair.Size = new System.Drawing.Size(81, 23);
      this.butSair.TabIndex = 18;
      this.butSair.Text = "Sair";
      this.butSair.UseVisualStyleBackColor = true;
      this.butSair.Click += new System.EventHandler(this.butSair_Click);
      // 
      // FormPagtosCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(624, 281);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.lblTxtTotal);
      this.Controls.Add(this.butSair);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormPagtosCliente";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pagamentos - Cliente:";
      this.Load += new System.EventHandler(this.FormPagtosCliente_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblTxtTotal;
    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridViewTextBoxColumn idpagamento;
    private System.Windows.Forms.DataGridViewTextBoxColumn data_pagto;
    private System.Windows.Forms.DataGridViewTextBoxColumn valor_pagto;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
    private System.Windows.Forms.DataGridViewTextBoxColumn idparcela;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
  }
}