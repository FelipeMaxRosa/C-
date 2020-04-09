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
  public partial class FormJuros : Form
  {
    public FormJuros()
    {
      InitializeComponent();
    }

    private void txtJuros_Leave(object sender, EventArgs e)
    {
      if (txtJuros.Text.Length == 0)
      {
        txtJuros.Text = "0,00";
      }
      else
      {
        decimal juros = Convert.ToDecimal(txtJuros.Text);
        txtJuros.Text = juros.ToString("0.00");
        decimal valorAtual = Convert.ToDecimal(txtValorAtual.Text);
        decimal total = juros + valorAtual;
        txtTotal.Text = total.ToString("0.00");
      }
    }

    private void FormJuros_KeyDown(object sender, KeyEventArgs e)
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

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma o novo valor da parcela para: R$ " + txtTotal.Text + " ?", "Juros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Parcela par = new Parcela();
        par.IdVenda = Convert.ToInt32(txtNumVendaAtual.Text);
        par.IdParcela = Convert.ToInt32(txtNumParcelaAtual.Text);
        par.Juros = Convert.ToDecimal(txtJuros.Text);
        par.InserirJuros();
        this.Close();
      }
    }
  }
}
