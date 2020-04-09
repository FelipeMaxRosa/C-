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
  public partial class FormPagtosCliente : Form
  {
    //Atributos
    //--------------------------------------------------------------------
    public int codigoCliente;
    public int mesAtual;
    private BancoDados bd;
    private DataSet ds;

    //Construtor
    //--------------------------------------------------------------------
    public FormPagtosCliente()
    {
      InitializeComponent();
      bd = new BancoDados();
    }

    //Metodos Gerais
    //--------------------------------------------------------------------
    private void AtualizarTotal()
    {
      if (dataGridView1.RowCount > 0)
      {
        decimal total = 0.00M;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["valor_pagto"].Value);
        }
        lblTotal.Text = total.ToString("0.00");
      }
    }

    private void FormPagtosCliente_Load(object sender, EventArgs e)
    {
      //mesAtual = DateTime.Now.Month;
      string SQL = "SELECT p.idpagamento, p.data_pagto, p.valor_pagto, f.descricao, p.idvenda, p.idparcela, p.obs, p.usuario, p.idcliente FROM cliente_pagamento p, finalizadoras f WHERE p.idcliente = '" + codigoCliente + "' AND p.idfinalizadora = f.id ORDER BY p.data_pagto DESC";
      string tabela = "cliente_pagamento";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables[tabela];
      if (dataGridView1.RowCount > 0)
      {
        this.AtualizarTotal();
      }
      else
      {
      }
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
