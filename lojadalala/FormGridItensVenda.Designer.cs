namespace lojadalala
{
  partial class FormGridItensVenda
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridItensVenda));
      this.butSair = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.iditem = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTotalItens = new System.Windows.Forms.Label();
      this.lblTxtTotal = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // butSair
      // 
      this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.butSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.butSair.Location = new System.Drawing.Point(588, 219);
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
            this.iditem,
            this.idproduto,
            this.descricao,
            this.qtde,
            this.preco,
            this.subtotal,
            this.desconto,
            this.total,
            this.estado});
      this.dataGridView1.Location = new System.Drawing.Point(3, 4);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(666, 209);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
      // lblTotalItens
      // 
      this.lblTotalItens.AutoSize = true;
      this.lblTotalItens.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalItens.Location = new System.Drawing.Point(63, 222);
      this.lblTotalItens.Name = "lblTotalItens";
      this.lblTotalItens.Size = new System.Drawing.Size(38, 14);
      this.lblTotalItens.TabIndex = 17;
      this.lblTotalItens.Text = "0,00";
      // 
      // lblTxtTotal
      // 
      this.lblTxtTotal.AutoSize = true;
      this.lblTxtTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTxtTotal.Location = new System.Drawing.Point(0, 222);
      this.lblTxtTotal.Name = "lblTxtTotal";
      this.lblTxtTotal.Size = new System.Drawing.Size(56, 14);
      this.lblTxtTotal.TabIndex = 16;
      this.lblTxtTotal.Text = "TOTAL:";
      // 
      // FormGridItensVenda
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butSair;
      this.ClientSize = new System.Drawing.Size(673, 248);
      this.Controls.Add(this.lblTotalItens);
      this.Controls.Add(this.lblTxtTotal);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.butSair);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormGridItensVenda";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Itens da Venda - 1";
      this.Load += new System.EventHandler(this.FormGridItensVenda_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button butSair;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn iditem;
    private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
    private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.Label lblTotalItens;
    private System.Windows.Forms.Label lblTxtTotal;

  }
}