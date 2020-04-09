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
  public partial class FormDebitosCliente : Form
  {
    //Atributos
    //--------------------------------------------------------------------
    public int idcliente;
    public string usuario;
    private BancoDados bd;
    private DataSet ds;
    private DateTime dataAtual;

    //Construtor
    //--------------------------------------------------------------------
    public FormDebitosCliente()
    {
      InitializeComponent();
      bd = new BancoDados();
      dataAtual = DateTime.Now;
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
          total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["total"].Value);
        }
        lblTotal.Text = total.ToString("0.00");
      }
    }

    //Metodos Eventos
    //--------------------------------------------------------------------
    private void FormDebitosCliente_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT idvenda, idparcela, dtvencimento, valor, juros, (valor + juros)total, obs, estado, idcliente FROM cliente_debito WHERE idcliente = '" + idcliente + "' AND estado = 'ABERTA' ORDER BY dtvencimento";
      string tabela = "cliente_debito";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables[tabela];
      if (dataGridView1.RowCount > 0)
      {
        btnEfetuarPagamento.Enabled = true;
        btnInserirJuros.Enabled = true;
        this.AtualizarTotal();
      }
      else
      {
        btnEfetuarPagamento.Enabled = false;
        btnInserirJuros.Enabled = false;
      }
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dataGridView1.RowCount > 0)
      {
        if (Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["dtvencimento"].Value) < dataAtual)
        {
          e.CellStyle.ForeColor = Color.Red;
          e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }
      }
    }

    private void btnEfetuarPagamento_Click(object sender, EventArgs e)
    {
      DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
      int i = linhaAtual.Index;
      FormPgtoDebito frmPg = new FormPgtoDebito();
      frmPg.MdiParent = this.ParentForm;
      frmPg.txtNumParcelaAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idparcela"].Value);
      frmPg.txtNumVendaAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idvenda"].Value);
      frmPg.txtValorAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["valor"].Value);
      frmPg.txtTotal.Text = Convert.ToString(dataGridView1.Rows[i].Cells["total"].Value);
      frmPg.txtJuros.Text = Convert.ToString(dataGridView1.Rows[i].Cells["juros"].Value);
      frmPg.dtVencimentoAtual.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dtvencimento"].Value);
      frmPg.idCliente = Convert.ToInt32(dataGridView1.Rows[i].Cells["id_cliente"].Value);
      frmPg.usuario = usuario;
      frmPg.Show();
      this.Dispose();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
        
      }
      else
      {
        FormPgtoDebito frmPg = new FormPgtoDebito();
        frmPg.MdiParent = this.ParentForm;
        frmPg.txtNumParcelaAtual.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["idparcela"].Value);
        frmPg.txtNumVendaAtual.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value);
        frmPg.txtValorAtual.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["valor"].Value);
        frmPg.txtJuros.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["juros"].Value);
        frmPg.txtTotal.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["total"].Value);
        frmPg.dtVencimentoAtual.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["dtvencimento"].Value);
        frmPg.idCliente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_cliente"].Value);
        frmPg.usuario = usuario;
        frmPg.Show();
        this.Dispose();
      }
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        FormPgtoDebito frmPg = new FormPgtoDebito();
        frmPg.MdiParent = this.ParentForm;
        frmPg.txtNumParcelaAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idparcela"].Value);
        frmPg.txtNumVendaAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idvenda"].Value);
        frmPg.txtValorAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["valor"].Value);
        frmPg.txtTotal.Text = Convert.ToString(dataGridView1.Rows[i].Cells["total"].Value);
        frmPg.txtJuros.Text = Convert.ToString(dataGridView1.Rows[i].Cells["juros"].Value);
        frmPg.dtVencimentoAtual.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dtvencimento"].Value);
        frmPg.idCliente = Convert.ToInt32(dataGridView1.Rows[i].Cells["id_cliente"].Value);
        frmPg.usuario = usuario;
        frmPg.Show();
        this.Dispose();
      }
    }

    private void btnInserirJuros_Click(object sender, EventArgs e)
    {
      DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
      int i = linhaAtual.Index;
      FormJuros frmJur = new FormJuros();
      frmJur.MdiParent = this.ParentForm;
      frmJur.txtNumParcelaAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idparcela"].Value);
      frmJur.txtNumVendaAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idvenda"].Value);
      frmJur.txtValorAtual.Text = Convert.ToString(dataGridView1.Rows[i].Cells["valor"].Value);
      frmJur.txtTotal.Text = Convert.ToString(dataGridView1.Rows[i].Cells["total"].Value);
      frmJur.txtJuros.Text = Convert.ToString(dataGridView1.Rows[i].Cells["juros"].Value);
      frmJur.dtVencimentoAtual.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dtvencimento"].Value);
      frmJur.Show();
      this.Dispose();
    }
  }
}
