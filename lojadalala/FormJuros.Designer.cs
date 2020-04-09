namespace lojadalala
{
  partial class FormJuros
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJuros));
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
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.groupBox7.SuspendLayout();
      this.SuspendLayout();
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
      this.groupBox7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox7.Location = new System.Drawing.Point(6, 3);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(513, 80);
      this.groupBox7.TabIndex = 0;
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
      this.txtNumParcelaAtual.TabIndex = 1;
      this.txtNumParcelaAtual.TabStop = false;
      // 
      // txtNumVendaAtual
      // 
      this.txtNumVendaAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNumVendaAtual.Location = new System.Drawing.Point(87, 22);
      this.txtNumVendaAtual.Name = "txtNumVendaAtual";
      this.txtNumVendaAtual.ReadOnly = true;
      this.txtNumVendaAtual.Size = new System.Drawing.Size(49, 21);
      this.txtNumVendaAtual.TabIndex = 0;
      this.txtNumVendaAtual.TabStop = false;
      // 
      // txtJuros
      // 
      this.txtJuros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtJuros.Location = new System.Drawing.Point(225, 49);
      this.txtJuros.Name = "txtJuros";
      this.txtJuros.Size = new System.Drawing.Size(49, 21);
      this.txtJuros.TabIndex = 4;
      this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
      // 
      // txtTotal
      // 
      this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotal.Location = new System.Drawing.Point(391, 49);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(68, 21);
      this.txtTotal.TabIndex = 5;
      this.txtTotal.TabStop = false;
      // 
      // txtValorAtual
      // 
      this.txtValorAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValorAtual.Location = new System.Drawing.Point(87, 49);
      this.txtValorAtual.Name = "txtValorAtual";
      this.txtValorAtual.ReadOnly = true;
      this.txtValorAtual.Size = new System.Drawing.Size(68, 21);
      this.txtValorAtual.TabIndex = 3;
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
      this.dtVencimentoAtual.TabIndex = 2;
      this.dtVencimentoAtual.TabStop = false;
      this.dtVencimentoAtual.Value = new System.DateTime(1900, 1, 1, 19, 36, 0, 0);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
      this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancelar.Location = new System.Drawing.Point(123, 89);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(111, 30);
      this.btnCancelar.TabIndex = 9;
      this.btnCancelar.Text = "   Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
      this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSalvar.Location = new System.Drawing.Point(6, 89);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(111, 30);
      this.btnSalvar.TabIndex = 8;
      this.btnSalvar.Text = "  Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // FormJuros
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(525, 123);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.groupBox7);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormJuros";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Juros";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormJuros_KeyDown);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox7;
    public System.Windows.Forms.TextBox txtNumParcelaAtual;
    public System.Windows.Forms.TextBox txtNumVendaAtual;
    public System.Windows.Forms.TextBox txtJuros;
    public System.Windows.Forms.TextBox txtTotal;
    public System.Windows.Forms.TextBox txtValorAtual;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.DateTimePicker dtVencimentoAtual;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;
  }
}