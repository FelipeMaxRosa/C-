using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lojadalala
{
  public partial class FormGridItensVenda : Form
  {
    //Atributos
    //--------------------------------------------------------------
    private BancoDados bd;
    private DataSet ds;
    private DataSet dsTotal;
    private ItemVenda item;
    public int idvenda;

    //Construtor
    //--------------------------------------------------------------
    public FormGridItensVenda()
    {
      InitializeComponent();
      bd = new BancoDados();
      item = new ItemVenda();
    }

    //Metodos Eventos
    //--------------------------------------------------------------
    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (this.dataGridView1.RowCount > 0)
      {
        if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() == "CANCELADO")
        {
          e.CellStyle.ForeColor = Color.Red;
          e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }
      }
    }

    private void FormGridItensVenda_Load(object sender, EventArgs e)
    {
      //string SQL = "SELECT * FROM venda_item WHERE idvenda = '" + idvenda + "' ORDER BY idvenda ";
      string tabela = "venda_item";
      item.IdVenda = idvenda;
      item.ConsultarParaGrid();
      dataGridView1.DataSource = item.ds.Tables[tabela];

      string SQL2 = "SELECT SUM(total) FROM venda_item WHERE idvenda = '" + idvenda + "' AND estado = 'OK'";
      dsTotal = new DataSet();
      dsTotal = bd.ConsultarRegistro(SQL2, tabela);
      lblTotalItens.Text = dsTotal.Tables[0].Rows[0][0].ToString();

      dataGridView1.Focus();
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
