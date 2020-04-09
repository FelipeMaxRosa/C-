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
  public partial class FormAberturaCaixa : Form
  {
    //Atributos
    //---------------------------------------------------------
    Caixa caixa = null;
    public FormAberturaCaixa(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      caixa = new Caixa();
      caixa.Valorinicial = Convert.ToDecimal(txtValorDeFundo.Text);
      caixa.Valorfinal = Convert.ToDecimal(txtValorDeFundo.Text);
      caixa.Saldo = 0.00M;
      caixa.Data = dtDataAtual.Value;
      caixa.AberturaDeCaixa();
      this.Close();
    }

    private void FormAberturaCaixa_Load(object sender, EventArgs e)
    {
      dtDataAtual.Value = DateTime.Now;
      txtValorDeFundo.SelectAll();
    }

    private void FormAberturaCaixa_KeyDown(object sender, KeyEventArgs e)
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

    private void txtValorDeFundo_Leave(object sender, EventArgs e)
    {
      if (txtValorDeFundo.Text.Length == 0)
      {
        txtValorDeFundo.Text = "0,00";
      }
      else
      {
        decimal valor = Convert.ToDecimal(txtValorDeFundo.Text);
        txtValorDeFundo.Text = valor.ToString("0.00");
      }
    }

    private void txtValorDeFundo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }
  }
}
