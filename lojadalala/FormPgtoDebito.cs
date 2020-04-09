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
  public partial class FormPgtoDebito : Form
  {
    //Atributos
    //----------------------------------------------------------------    
    private DataTable dt;

    public int idVendaAtual;
    public int idParcelaAtual;
    public int idCliente;
    public decimal valorParcelaAtual;
    public DateTime vencimentoParcelaAtual;
    public string usuario;

    //Construtor
    //----------------------------------------------------------------    
    public FormPgtoDebito()
    {
      InitializeComponent();
      dtDataAtual.Value = DateTime.Now;
      dtHoraAtual.Value = DateTime.Now;
    }

    //Metodos Eventos
    //----------------------------------------------------------------    
    private void comboBox1_DropDownClosed(object sender, EventArgs e)
    {
      if (cbxTipo.Text == "TOTAL")
      {
        gpbValor.Enabled = true;
        gpbDataHora.Enabled = true;
        gpbParcial.Visible = false;
        gpbObs.Enabled = true;
        gpbFormaPgto.Enabled = true;
        //txtValor.Text = txtValorAtual.Text;
        txtValor.Text = txtTotal.Text;
        txtValor.ReadOnly = true;
        txtValor.TabStop = false;
        dtDataAtual.Focus();
      }
      else if (cbxTipo.Text == "PARCIAL")
      {
        gpbValor.Enabled = true;
        gpbDataHora.Enabled = true;
        gpbParcial.Visible = true;
        gpbObs.Enabled = true;
        gpbFormaPgto.Enabled = true;
        txtValor.Text = "0,00";
        txtNovoJuros.Text = "0,00";
        txtNovoTotal.Text = txtTotal.Text;
        txtValor.ReadOnly = false;
        txtValor.TabStop = true;
        dtNovoVencimento.Value = DateTime.Now;
        //txtNovoValor.Text = txtValorAtual.Text;
        txtNovoValor.Text = txtTotal.Text;
        dtDataAtual.Focus();
      }
      dt = new DataTable();
      Finalizadora fin = new Finalizadora();
      dt = fin.PreencherCbx();
      cbxFormaPgto.DisplayMember = "descricao";
      cbxFormaPgto.ValueMember = "id";
      cbxFormaPgto.DataSource = dt;
      btnSalvar.Enabled = true;
    }

    private void FormPgtoDebito_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {
          SendKeys.Send("+{TAB}");
          e.SuppressKeyPress = true;
        }
        else
        {
          SendKeys.Send("{TAB}");
          e.SuppressKeyPress = true;
        }
      }
    }

    private void cbxTipo_Leave(object sender, EventArgs e)
    {
      if (cbxTipo.Text == "TOTAL")
      {
        gpbValor.Enabled = true;
        gpbDataHora.Enabled = true;
        gpbParcial.Visible = false;
        gpbObs.Enabled = true;
        gpbFormaPgto.Enabled = true;
        //txtValor.Text = txtValorAtual.Text;
        txtValor.Text = txtTotal.Text;
        dtDataAtual.Focus();
      }
      else if (cbxTipo.Text == "PARCIAL")
      {
        gpbValor.Enabled = true;
        gpbDataHora.Enabled = true;
        gpbParcial.Visible = true;
        gpbObs.Enabled = true;
        gpbFormaPgto.Enabled = true;
        txtValor.Text = "0,00";
        txtNovoJuros.Text = "0,00";
        txtNovoTotal.Text = txtTotal.Text;
        dtNovoVencimento.Value = DateTime.Now;
        //txtNovoValor.Text = txtValorAtual.Text;
        txtNovoValor.Text = txtTotal.Text;
        dtDataAtual.Focus();
      }
      dt = new DataTable();
      Finalizadora fin = new Finalizadora();
      dt = fin.PreencherCbx();
      cbxFormaPgto.DisplayMember = "descricao";
      cbxFormaPgto.ValueMember = "id";
      cbxFormaPgto.DataSource = dt;
      btnSalvar.Enabled = true;
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txtValor_Leave(object sender, EventArgs e)
    {
      if (txtValor.Text.Length != 0)
      {
        decimal valor = Convert.ToDecimal(txtValor.Text);
        txtValor.Text = valor.ToString("0.00");
        decimal valorAntigo = Convert.ToDecimal(txtTotal.Text);
        decimal valorAtual = valorAntigo - valor;
        txtNovoValor.Text = valorAtual.ToString("0.00");
        txtNovoTotal.Text = valorAtual.ToString("0.00");
      }
      else
      {
        txtValor.Text = "0,00";
        decimal valor = Convert.ToDecimal(txtValor.Text);
        decimal valorAntigo = Convert.ToDecimal(txtTotal.Text);
        decimal valorAtual = valorAntigo - valor;
        txtNovoValor.Text = valorAtual.ToString("0.00");
        txtNovoTotal.Text = valorAtual.ToString("0.00");
      }      
    }

    private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void txtNovoValor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();        
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma o pagamento do cliente?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Caixa caixa = new Caixa();
        caixa.ConsultaNumeroDeCaixasEmAberto();
        if (caixa.NumCaixasAbertos > 0)
        {
          caixa.ConsultaCaixaAberto();
          if (caixa.Data.Date == DateTime.Now.Date)
          {
            Pagamento pag = new Pagamento();
            pag.DataPagto = dtHoraAtual.Value;
            pag.IdCliente = idCliente;
            pag.IdFinalizadora = Convert.ToInt32(cbxFormaPgto.SelectedValue);
            pag.IdParcela = Convert.ToInt32(txtNumParcelaAtual.Text);
            pag.IdVenda = Convert.ToInt32(txtNumVendaAtual.Text);
            pag.Usuario = usuario;
            pag.ValorPago = Convert.ToDecimal(txtValor.Text);
            if (cbxTipo.Text == "TOTAL")
            {
              pag.Obs = "PAGAMENTO TOTAL   " + txtObs.Text;
              pag.InserirPagamento(true);
              caixa.ConsultaCaixaAberto();
              caixa.RetornaIdEntrada();
              caixa.Data = dtHoraAtual.Value;
              caixa.Valor = Convert.ToDecimal(txtValor.Text);
              caixa.Usuario = usuario;
              caixa.Obs = "PAGAMENTO TOTAL - VENDA N." + txtNumVendaAtual.Text + ", PARCELA N." + txtNumParcelaAtual.Text + " - " + txtObs.Text;
              caixa.InserirEntrada();
            }
            else if (cbxTipo.Text == "PARCIAL")
            {
              pag.Juros = Convert.ToDecimal(txtNovoJuros.Text);
              pag.Obs = "PAGAMENTO PARCIAL   " + txtObs.Text;
              pag.NovaData = dtNovoVencimento.Value;
              pag.NovoValor = Convert.ToDecimal(txtNovoValor.Text);
              pag.InserirPagamento(false);
              caixa.ConsultaCaixaAberto();
              caixa.RetornaIdEntrada();
              caixa.Data = dtHoraAtual.Value;
              caixa.Valor = Convert.ToDecimal(txtValor.Text);
              caixa.Usuario = usuario;
              caixa.Obs = "PAGAMENTO PARCIAL - VENDA N." + txtNumVendaAtual.Text + ", PARCELA N." + txtNumParcelaAtual.Text + " - " + txtObs.Text;
              caixa.InserirEntrada();
            }
            this.Close();
          }
          else
          {
            // MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString() + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString("dd/MM/yyyy") + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          MessageBox.Show("Não existem Caixa Abertos para o Recebimento da Conta!\nEfetue a Abertura de Caixa.", "Caixa não Aberto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
      }
    }

    private void dtDataAtual_Leave(object sender, EventArgs e)
    {
      dtHoraAtual.Value = dtDataAtual.Value;
    }

    private void txtNovoJuros_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void txtNovoJuros_Leave(object sender, EventArgs e)
    {
      if (txtNovoJuros.Text.Length == 0)
      {
        txtNovoJuros.Text = "0,00";
      }
      else
      {
        decimal valor = Convert.ToDecimal(txtNovoValor.Text);
        decimal juros = Convert.ToDecimal(txtNovoJuros.Text);
        txtNovoJuros.Text = juros.ToString("0.00");
        decimal total = valor + juros;
        txtNovoTotal.Text = total.ToString("0.00");
        btnSalvar.Enabled = true;
        btnSalvar.Focus();
      }
    }
  }
}
