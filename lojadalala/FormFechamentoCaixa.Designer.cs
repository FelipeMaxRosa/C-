namespace lojadalala
{
  partial class FormFechamentoCaixa
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idcaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataatual = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valorinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valorfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnFecharCaixa = new System.Windows.Forms.Button();
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
            this.idcaixa,
            this.dataatual,
            this.valorinicial,
            this.valorfinal,
            this.saldo,
            this.estado});
      this.dataGridView1.Location = new System.Drawing.Point(3, 4);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(413, 101);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
      this.valorinicial.HeaderText = "Fundo";
      this.valorinicial.Name = "valorinicial";
      this.valorinicial.ReadOnly = true;
      this.valorinicial.Width = 62;
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
      // btnFecharCaixa
      // 
      this.btnFecharCaixa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFecharCaixa.Location = new System.Drawing.Point(3, 111);
      this.btnFecharCaixa.Name = "btnFecharCaixa";
      this.btnFecharCaixa.Size = new System.Drawing.Size(110, 29);
      this.btnFecharCaixa.TabIndex = 2;
      this.btnFecharCaixa.Text = "Fechar Caixa";
      this.btnFecharCaixa.UseVisualStyleBackColor = true;
      this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
      // 
      // FormFechamentoCaixa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(418, 146);
      this.Controls.Add(this.btnFecharCaixa);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormFechamentoCaixa";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Fechamento de Caixa";
      this.Load += new System.EventHandler(this.FormFechamentoCaixa_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcaixa;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataatual;
    private System.Windows.Forms.DataGridViewTextBoxColumn valorinicial;
    private System.Windows.Forms.DataGridViewTextBoxColumn valorfinal;
    private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    private System.Windows.Forms.Button btnFecharCaixa;
  }
}