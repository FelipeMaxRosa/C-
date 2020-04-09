namespace lojadalala
{
  partial class FormTipoVenda
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoVenda));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAV = new System.Windows.Forms.Button();
      this.btnAP = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(21, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(42, 44);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(69, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(220, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Qual o tipo de venda que deseja efetuar?";
      // 
      // btnAV
      // 
      this.btnAV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAV.Location = new System.Drawing.Point(113, 59);
      this.btnAV.Name = "btnAV";
      this.btnAV.Size = new System.Drawing.Size(86, 26);
      this.btnAV.TabIndex = 0;
      this.btnAV.Text = "à &Vista";
      this.btnAV.UseVisualStyleBackColor = true;
      this.btnAV.Click += new System.EventHandler(this.btnAV_Click);
      // 
      // btnAP
      // 
      this.btnAP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAP.Location = new System.Drawing.Point(203, 59);
      this.btnAP.Name = "btnAP";
      this.btnAP.Size = new System.Drawing.Size(86, 26);
      this.btnAP.TabIndex = 1;
      this.btnAP.Text = "a &Prazo";
      this.btnAP.UseVisualStyleBackColor = true;
      this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
      // 
      // FormTipoVenda
      // 
      this.AcceptButton = this.btnAV;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(310, 97);
      this.Controls.Add(this.btnAP);
      this.Controls.Add(this.btnAV);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormTipoVenda";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tipo de Venda";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnAV;
    private System.Windows.Forms.Button btnAP;
  }
}