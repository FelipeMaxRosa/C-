namespace lojadalala
{
  partial class FormRelVenda
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
      this.components = new System.ComponentModel.Container();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelVenda));
      this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsVenda2 = new lojadalala.dsVenda2();
      this.venda_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.venda_parcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.vendaTableAdapter = new lojadalala.dsVenda2TableAdapters.vendaTableAdapter();
      this.venda_itemTableAdapter = new lojadalala.dsVenda2TableAdapters.venda_itemTableAdapter();
      this.venda_parcelaTableAdapter = new lojadalala.dsVenda2TableAdapters.venda_parcelaTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsVenda2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.venda_itemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.venda_parcelaBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // vendaBindingSource
      // 
      this.vendaBindingSource.DataMember = "venda";
      this.vendaBindingSource.DataSource = this.dsVenda2;
      // 
      // dsVenda2
      // 
      this.dsVenda2.DataSetName = "dsVenda2";
      this.dsVenda2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // venda_itemBindingSource
      // 
      this.venda_itemBindingSource.DataMember = "venda_item";
      this.venda_itemBindingSource.DataSource = this.dsVenda2;
      // 
      // venda_parcelaBindingSource
      // 
      this.venda_parcelaBindingSource.DataMember = "venda_parcela";
      this.venda_parcelaBindingSource.DataSource = this.dsVenda2;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "dsVenda_venda";
      reportDataSource1.Value = this.vendaBindingSource;
      reportDataSource2.Name = "dsVenda_venda_item";
      reportDataSource2.Value = this.venda_itemBindingSource;
      reportDataSource3.Name = "dsVenda_venda_parcela";
      reportDataSource3.Value = this.venda_parcelaBindingSource;
      reportDataSource4.Name = "dsVenda2_venda";
      reportDataSource4.Value = this.vendaBindingSource;
      reportDataSource5.Name = "dsVenda2_venda_item";
      reportDataSource5.Value = this.venda_itemBindingSource;
      reportDataSource6.Name = "dsVenda2_venda_parcela";
      reportDataSource6.Value = this.venda_parcelaBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "lojadalala.Report_Venda.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ShowBackButton = false;
      this.reportViewer1.ShowDocumentMapButton = false;
      this.reportViewer1.ShowFindControls = false;
      this.reportViewer1.Size = new System.Drawing.Size(679, 492);
      this.reportViewer1.TabIndex = 0;
      // 
      // vendaTableAdapter
      // 
      this.vendaTableAdapter.ClearBeforeFill = true;
      // 
      // venda_itemTableAdapter
      // 
      this.venda_itemTableAdapter.ClearBeforeFill = true;
      // 
      // venda_parcelaTableAdapter
      // 
      this.venda_parcelaTableAdapter.ClearBeforeFill = true;
      // 
      // FormRelVenda
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(679, 492);
      this.Controls.Add(this.reportViewer1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormRelVenda";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Relatório de Produtos da Venda";
      this.Load += new System.EventHandler(this.FormRelVenda_Load);
      ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsVenda2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.venda_itemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.venda_parcelaBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource vendaBindingSource;
    //private lojadalala.dsVenda2 dsVenda2;
    private System.Windows.Forms.BindingSource venda_itemBindingSource;
    private System.Windows.Forms.BindingSource venda_parcelaBindingSource;
    private lojadalala.dsVenda2TableAdapters.vendaTableAdapter vendaTableAdapter;
    private lojadalala.dsVenda2TableAdapters.venda_itemTableAdapter venda_itemTableAdapter;
    private lojadalala.dsVenda2TableAdapters.venda_parcelaTableAdapter venda_parcelaTableAdapter;
    private dsVenda2 dsVenda2;
  }
}