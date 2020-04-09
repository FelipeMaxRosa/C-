namespace lojadalala
{
  partial class FormCaixaLancamento
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixaLancamento));
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtObs = new System.Windows.Forms.TextBox();
      this.txtValor = new System.Windows.Forms.TextBox();
      this.txtIdCaixa = new System.Windows.Forms.TextBox();
      this.dtCaixa = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtObs);
      this.groupBox3.Controls.Add(this.txtValor);
      this.groupBox3.Controls.Add(this.txtIdCaixa);
      this.groupBox3.Controls.Add(this.dtCaixa);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(2, 1);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(277, 150);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Dados do Lançamento";
      // 
      // txtObs
      // 
      this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtObs.Location = new System.Drawing.Point(6, 92);
      this.txtObs.Multiline = true;
      this.txtObs.Name = "txtObs";
      this.txtObs.Size = new System.Drawing.Size(262, 49);
      this.txtObs.TabIndex = 3;
      // 
      // txtValor
      // 
      this.txtValor.Location = new System.Drawing.Point(192, 49);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(76, 21);
      this.txtValor.TabIndex = 2;
      this.txtValor.Text = "0,00";
      this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
      this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
      // 
      // txtIdCaixa
      // 
      this.txtIdCaixa.Location = new System.Drawing.Point(52, 20);
      this.txtIdCaixa.Name = "txtIdCaixa";
      this.txtIdCaixa.ReadOnly = true;
      this.txtIdCaixa.Size = new System.Drawing.Size(50, 21);
      this.txtIdCaixa.TabIndex = 0;
      this.txtIdCaixa.TabStop = false;
      // 
      // dtCaixa
      // 
      this.dtCaixa.Enabled = false;
      this.dtCaixa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtCaixa.Location = new System.Drawing.Point(52, 47);
      this.dtCaixa.Name = "dtCaixa";
      this.dtCaixa.Size = new System.Drawing.Size(96, 21);
      this.dtCaixa.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(3, 76);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Observação";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(153, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Valor:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(13, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Data:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(9, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Caixa:";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
      this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancelar.Location = new System.Drawing.Point(119, 157);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(111, 30);
      this.btnCancelar.TabIndex = 2;
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
      this.btnSalvar.Location = new System.Drawing.Point(2, 157);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(111, 30);
      this.btnSalvar.TabIndex = 1;
      this.btnSalvar.Text = "  Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // FormCaixaLancamento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(282, 191);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.groupBox3);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCaixaLancamento";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Nova";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCaixaLancamento_KeyDown);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox3;
    public System.Windows.Forms.TextBox txtIdCaixa;
    public System.Windows.Forms.DateTimePicker dtCaixa;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtObs;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;
  }
}