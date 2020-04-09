using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lojadalala
{
  public partial class FormRelVenda : Form
  {
    public int idvenda;
    public FormRelVenda()
    {
      InitializeComponent();
    }

    private void FormRelVenda_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dsVenda.venda' table. You can move, or remove it, as needed.
      //this.vendaTableAdapter.Fill(this.dsVenda.venda);
      // TODO: This line of code loads data into the 'dsVenda.venda_item' table. You can move, or remove it, as needed.
      //this.venda_itemTableAdapter.Fill(this.dsVenda.venda_item);
      // TODO: This line of code loads data into the 'dsVenda.venda_parcela' table. You can move, or remove it, as needed.
      //this.venda_parcelaTableAdapter.Fill(this.dsVenda.venda_parcela);
      // TODO: This line of code loads data into the 'dsVenda2.venda' table. You can move, or remove it, as needed.
      this.vendaTableAdapter.Fill(this.dsVenda2.venda, idvenda);
      // TODO: This line of code loads data into the 'dsVenda2.venda_item' table. You can move, or remove it, as needed.
      this.venda_itemTableAdapter.Fill(this.dsVenda2.venda_item, idvenda);
      // TODO: This line of code loads data into the 'dsVenda2.venda_parcela' table. You can move, or remove it, as needed.
      this.venda_parcelaTableAdapter.Fill(this.dsVenda2.venda_parcela, idvenda);

      this.reportViewer1.RefreshReport();
    }
  }
}
