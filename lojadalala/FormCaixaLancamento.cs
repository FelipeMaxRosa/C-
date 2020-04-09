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
  public partial class FormCaixaLancamento : Form
  {
    //Atributos
    //------------------------------------------------------------------
    private FormCaixa frmCaixa;
    private BancoDados bd;
    private DataSet ds_entrada;
    private DataSet ds_saida;
    public bool entrada;
    public string usuario;
    public int iditem;

    //Construtor
    //------------------------------------------------------------------
    public FormCaixaLancamento(FormCaixa cx)
    {
      InitializeComponent();
      frmCaixa = cx;
      bd = new BancoDados();
    }

    //Metodos Eventos
    //------------------------------------------------------------------
    private void FormCaixaLancamento_KeyDown(object sender, KeyEventArgs e)
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
    }

    private void txtValor_Leave(object sender, EventArgs e)
    {
      if (txtValor.Text.Length == 0)
      {
        txtValor.Text = "0,00";
        btnSalvar.Enabled = false;
      }
      else
      {
        decimal valor = Convert.ToDecimal(txtValor.Text);
        txtValor.Text = valor.ToString("0.00");
        if (txtValor.Text == "0,00")
        {
          btnSalvar.Enabled = false;
        }
        else
        {
          btnSalvar.Enabled = true;
        }
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Caixa caixa = new Caixa();
      if (entrada)
      {
        caixa.IdCaixa = Convert.ToInt32(txtIdCaixa.Text);
        caixa.IdEntrada = iditem;
        caixa.Data = DateTime.Now;
        caixa.Valor = Convert.ToDecimal(txtValor.Text);
        caixa.Obs = "LANCAMENTO MANUAL";
        if (txtObs.Text.Length > 0)
        {
          caixa.Obs += ", " + txtObs.Text;
        }
        caixa.Usuario = usuario;
        caixa.InserirEntrada();
        caixa.ConsultaCaixaAberto();
      }
      else
      {
        caixa.IdCaixa = Convert.ToInt32(txtIdCaixa.Text);
        caixa.IdSaida = iditem;
        caixa.Data = DateTime.Now;
        caixa.Valor = Convert.ToDecimal(txtValor.Text);
        caixa.Obs = "LANCAMENTO MANUAL";
        if (txtObs.Text.Length > 0)
        {
          caixa.Obs += ", " + txtObs.Text;
        }
        caixa.Usuario = usuario;
        caixa.InserirSaida();
        caixa.ConsultaCaixaAberto();
      }
      //Carrega Grid de Entradas
      //-------------------------------------------------------------------------
      string SQL = "SELECT * FROM caixa_entrada WHERE idcaixa = '" + txtIdCaixa.Text + "' ORDER BY identrada DESC";
      string tabela_entrada = "caixa_entrada";
      ds_entrada = new DataSet();
      ds_entrada = bd.ConsultarParaGrid(SQL, tabela_entrada);
      frmCaixa.dataGridView1.DataSource = ds_entrada.Tables[tabela_entrada];

      //Carrega Grid de Entradas
      //-------------------------------------------------------------------------
      string SQL2 = "SELECT * FROM caixa_saida WHERE idcaixa = '" + txtIdCaixa.Text + "' ORDER BY idsaida DESC";
      string tabela_saida = "caixa_saida";
      ds_saida = new DataSet();
      ds_saida = bd.ConsultarParaGrid(SQL2, tabela_saida);
      frmCaixa.dataGridView2.DataSource = ds_saida.Tables[tabela_saida];

      frmCaixa.CalcularTotalEntradas();
      frmCaixa.CalcularTotalSaidas();
      frmCaixa.lblSaldoCaixa.Text = caixa.Saldo.ToString("0.00");
      this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }    
  }
}
