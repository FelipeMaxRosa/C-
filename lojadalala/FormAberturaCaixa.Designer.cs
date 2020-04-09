namespace lojadalala
{
  partial class FormAberturaCaixa
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
      this.dtDataAtual = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.txtValorDeFundo = new System.Windows.Forms.TextBox();
      this.btnAbrirCaixa = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtDataAtual
      // 
      this.dtDataAtual.Enabled = false;
      this.dtDataAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtDataAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtDataAtual.Location = new System.Drawing.Point(11, 17);
      this.dtDataAtual.Name = "dtDataAtual";
      this.dtDataAtual.Size = new System.Drawing.Size(113, 21);
      this.dtDataAtual.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 21);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(22, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "R$";
      // 
      // txtValorDeFundo
      // 
      this.txtValorDeFundo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValorDeFundo.Location = new System.Drawing.Point(35, 16);
      this.txtValorDeFundo.Name = "txtValorDeFundo";
      this.txtValorDeFundo.Size = new System.Drawing.Size(86, 23);
      this.txtValorDeFundo.TabIndex = 0;
      this.txtValorDeFundo.Text = "0,00";
      this.txtValorDeFundo.Leave += new System.EventHandler(this.txtValorDeFundo_Leave);
      this.txtValorDeFundo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDeFundo_KeyPress);
      // 
      // btnAbrirCaixa
      // 
      this.btnAbrirCaixa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAbrirCaixa.Location = new System.Drawing.Point(152, 72);
      this.btnAbrirCaixa.Name = "btnAbrirCaixa";
      this.btnAbrirCaixa.Size = new System.Drawing.Size(110, 29);
      this.btnAbrirCaixa.TabIndex = 1;
      this.btnAbrirCaixa.Text = "Abrir Caixa";
      this.btnAbrirCaixa.UseVisualStyleBackColor = true;
      this.btnAbrirCaixa.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtDataAtual);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(1, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(135, 45);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Data";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtValorDeFundo);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(1, 53);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(145, 48);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Valor de Fundo";
      // 
      // FormAberturaCaixa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(266, 108);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAbrirCaixa);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormAberturaCaixa";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Abertura de Caixa";
      this.Load += new System.EventHandler(this.FormAberturaCaixa_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAberturaCaixa_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dtDataAtual;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtValorDeFundo;
    private System.Windows.Forms.Button btnAbrirCaixa;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
  }
}