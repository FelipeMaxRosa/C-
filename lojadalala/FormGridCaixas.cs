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
  public partial class FormGridCaixas : Form
  {
    //Jo 11.40 - Nao disse eu, se credes vereis a Gloria de Deus?
    //---------------------------------------------------------------------

    //Atributos
    //---------------------------------------------------------------------
    private BancoDados bd;
    private DataSet ds;
    private DataSet ds_saida;
    private DataSet ds_entrada;
    private FormCaixa frmCaixa;

    //Construtor
    //---------------------------------------------------------------------
    public FormGridCaixas(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      bd = new BancoDados();
      cbxSituacao.Text = "FECHADO";
      dtFim.Value = DateTime.Now;
      dtInicio.Value = DateTime.Now;
      txtIDCaixa.Focus();
    }

    //Metodos Eventos
    //---------------------------------------------------------------------
    private void FormGridCaixas_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM caixa WHERE estado = 'FECHADO' ORDER BY idcaixa DESC";
      string tabela = "caixa";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables[tabela];
      txtIDCaixa.Select();
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {

      }
      else
      {
        frmCaixa = new FormCaixa((FormPrincipal)this.MdiParent);
        frmCaixa.txtIdCaixa.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["idcaixa"].Value);
        frmCaixa.dtCaixa.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["dataatual"].Value);
        frmCaixa.lblEstado.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["estado"].Value);
        decimal fundo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["valorinicial"].Value);
        frmCaixa.lblFundo.Text = fundo.ToString("0.00");
        decimal saldo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["saldo"].Value);
        frmCaixa.lblSaldoCaixa.Text = saldo.ToString("0.00");

        //Carrega Grid de Entradas
        //-------------------------------------------------------------------------
        string SQL = "SELECT * FROM caixa_entrada WHERE idcaixa = '" + frmCaixa.txtIdCaixa.Text + "' ORDER BY identrada";
        string tabela_entrada = "caixa_entrada";
        ds_entrada = new DataSet();
        ds_entrada = bd.ConsultarParaGrid(SQL, tabela_entrada);
        frmCaixa.dataGridView1.DataSource = ds_entrada.Tables[tabela_entrada];

        //Carrega Grid de Entradas
        //-------------------------------------------------------------------------
        string SQL2 = "SELECT * FROM caixa_saida WHERE idcaixa = '" + frmCaixa.txtIdCaixa.Text + "' ORDER BY idsaida";
        string tabela_saida = "caixa_saida";
        ds_saida = new DataSet();
        ds_saida = bd.ConsultarParaGrid(SQL2, tabela_saida);
        frmCaixa.dataGridView2.DataSource = ds_saida.Tables[tabela_saida];

        frmCaixa.CalcularTotalEntradas();
        frmCaixa.CalcularTotalSaidas();

        if (dataGridView1.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "ABERTO")
        {

        }
        else
        {
          frmCaixa.btnNovaEntrada.Enabled = false;
          frmCaixa.btnNovaSaida.Enabled = false;
        }   

        frmCaixa.Show();
      }
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        frmCaixa = new FormCaixa((FormPrincipal)this.MdiParent);
        frmCaixa.txtIdCaixa.Text = Convert.ToString(dataGridView1.Rows[i].Cells["idcaixa"].Value);
        frmCaixa.dtCaixa.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dataatual"].Value);
        frmCaixa.lblEstado.Text = Convert.ToString(dataGridView1.Rows[i].Cells["estado"].Value);
        decimal fundo = Convert.ToDecimal(dataGridView1.Rows[i].Cells["valorinicial"].Value);
        frmCaixa.lblFundo.Text = fundo.ToString("0.00");
        decimal saldo = Convert.ToDecimal(dataGridView1.Rows[i].Cells["saldo"].Value);
        frmCaixa.lblSaldoCaixa.Text = saldo.ToString("0.00");

        //Carrega Grid de Entradas
        //-------------------------------------------------------------------------
        string SQL = "SELECT * FROM caixa_entrada WHERE idcaixa = '" + frmCaixa.txtIdCaixa.Text + "' ORDER BY identrada";
        string tabela_entrada = "caixa_entrada";
        ds_entrada = new DataSet();
        ds_entrada = bd.ConsultarParaGrid(SQL, tabela_entrada);
        frmCaixa.dataGridView1.DataSource = ds_entrada.Tables[tabela_entrada];

        //Carrega Grid de Entradas
        //-------------------------------------------------------------------------
        string SQL2 = "SELECT * FROM caixa_saida WHERE idcaixa = '" + frmCaixa.txtIdCaixa.Text + "' ORDER BY idsaida";
        string tabela_saida = "caixa_saida";
        ds_saida = new DataSet();
        ds_saida = bd.ConsultarParaGrid(SQL2, tabela_saida);
        frmCaixa.dataGridView2.DataSource = ds_saida.Tables[tabela_saida];

        frmCaixa.CalcularTotalEntradas();
        frmCaixa.CalcularTotalSaidas();

        if (dataGridView1.Rows[i].Cells["estado"].Value.ToString() == "ABERTO")
        {
          
        }
        else
        {
          frmCaixa.btnNovaEntrada.Enabled = false;
          frmCaixa.btnNovaSaida.Enabled = false;
        }       

        frmCaixa.Show();
      }
      else if (e.KeyCode == Keys.Escape)
      {
        this.CancelButton = butSair;
        radNumero.Checked = true;
        txtIDCaixa.Clear();
        txtIDCaixa.Focus();
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radNumero.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells["idcaixa"].Value.ToString().Contains(txtIDCaixa.Text))
          {
            dataGridView1.Focus();
            dataGridView1.FirstDisplayedScrollingRowIndex = i;
            dataGridView1.Refresh();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
            dataGridView1.Rows[i].Selected = true;
            encontrado = true;
            this.CancelButton = null;
            break;
          }
        }
        if (!encontrado)
        {
          MessageBox.Show("Nenhum registro encontrado com essas informações!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtIDCaixa.Focus();
          txtIDCaixa.SelectAll();
        }
      }
      else if (radPeriodo.Checked)
      {
        string SQL = "";
        if (cbxSituacao.Text == "TODOS")
        {
          SQL = "SELECT * FROM caixa WHERE dataatual BETWEEN '" + dtInicio.Value.Year + "-" + dtInicio.Value.Month + "-" + dtInicio.Value.Day + "' AND '" + dtFim.Value.Year + "-" + dtFim.Value.Month + "-" + dtFim.Value.Day + "' ORDER BY idcaixa DESC";
        }
        else
        {
          SQL = "SELECT * FROM caixa WHERE estado = '" + cbxSituacao.Text + "' AND dataatual BETWEEN '" + dtInicio.Value.Year + "-" + dtInicio.Value.Month + "-" + dtInicio.Value.Day + "' AND '" + dtFim.Value.Year + "-" + dtFim.Value.Month + "-" + dtFim.Value.Day + "' ORDER BY idcaixa DESC";
        }
        string tabela = "caixa";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, tabela);
        dataGridView1.DataSource = ds.Tables[tabela];
        radNumero.Checked = true;
        txtIDCaixa.Focus();
      }
    }

    private void FormGridCaixas_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {
          e.SuppressKeyPress = true;
          SendKeys.Send("+{TAB}");
        }
        else
        {
          e.SuppressKeyPress = true;
          SendKeys.Send("{TAB}");
        }
      }
      else if (e.KeyCode == Keys.Escape)
      {
        this.CancelButton = butSair;
        radNumero.Checked = true;
        txtIDCaixa.Clear();
        txtIDCaixa.Focus();
      }
    }

    private void cbxSituacao_DropDownClosed(object sender, EventArgs e)
    {
      string SQL = "";
      if (cbxSituacao.Text == "TODOS")
      {
        SQL = "SELECT * FROM caixa ORDER BY idcaixa DESC";
      }
      else
      {
        SQL = "SELECT * FROM caixa WHERE estado = '" + cbxSituacao.Text + "' ORDER BY idcaixa DESC";
      }
      string tabela = "caixa";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["caixa"];
      radNumero.Checked = true;
      txtIDCaixa.Focus();
    }

    private void radNumero_CheckedChanged(object sender, EventArgs e)
    {
      if (radNumero.Checked == true)
      {
        dtFim.Enabled = false;
        dtFim.TabStop = false;
        dtInicio.Enabled = false;
        dtInicio.TabStop = false;
        txtIDCaixa.ReadOnly = false;
        txtIDCaixa.TabStop = true;
        txtIDCaixa.Focus();
        this.AcceptButton = btnPesquisar;
      }
    }

    private void radPeriodo_CheckedChanged(object sender, EventArgs e)
    {
      if (radPeriodo.Checked == true)
      {
        dtFim.Enabled = true;
        dtFim.TabStop = true;
        dtInicio.Enabled = true;
        dtInicio.TabStop = true;
        txtIDCaixa.Clear();
        txtIDCaixa.ReadOnly = true;
        txtIDCaixa.TabStop = false;
        dtInicio.Focus();
        this.AcceptButton = null;
      }
    }

    private void dataGridView1_Enter(object sender, EventArgs e)
    {
      this.CancelButton = null;
      this.KeyPreview = false;
    }

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
      this.CancelButton = butSair;
      this.KeyPreview = true;
    }

    private void txtIDCaixa_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }
  }
}
