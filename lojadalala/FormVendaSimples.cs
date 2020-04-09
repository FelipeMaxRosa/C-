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
  public partial class FormVendaSimples : Form
  {
    //Atributos
    //-------------------------------------------------------------
    private string usuarioAtual;
    public bool novaVenda = false;
    private Venda venda;
    public int idVendaAtual = 0;
    private DataSet ds;
    private DataTable dtFin;
    private DataTable dt;
    private DataRow dr;

    //Propriedades
    //-------------------------------------------------------------
    public string UsuarioAtual
    {
      get { return usuarioAtual; }
      set { usuarioAtual = value; }
    }

    //Construtor
    //-------------------------------------------------------------
    public FormVendaSimples(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      usuarioAtual = parent.lblUsuario.Text;
      lblVendedor.Text = parent.lblUsuario.Text;
      dtFin = new DataTable();
      Finalizadora fin = new Finalizadora();
      dtFin = fin.PreencherCbx();
      cbxFormaPgto.DisplayMember = "descricao";
      cbxFormaPgto.ValueMember = "id";
      cbxFormaPgto.DataSource = dtFin;
      dt = new DataTable();
      dt.Columns.Add("iditem", typeof(int));
      dt.Columns.Add("idvenda", typeof(int));
      dt.Columns.Add("idproduto", typeof(int));
      dt.Columns.Add("descricao", typeof(string));
      dt.Columns.Add("preco", typeof(decimal));
      dt.Columns.Add("qtde", typeof(int));
      dt.Columns.Add("subtotal", typeof(decimal));
      dt.Columns.Add("desconto", typeof(decimal));
      dt.Columns.Add("total", typeof(decimal));
      dt.Columns.Add("estado", typeof(string));
      dataGridView1.DataSource = dt;
      txtCodProduto.Select();
    }

    //Metodos Gerais
    //-------------------------------------------------------------
    public void HabiDesaCamposItem(bool flag)
    {
      txtQtdeProduto.ReadOnly = !flag;
      txtQtdeProduto.TabStop = flag;
      txtDescontoProduto.ReadOnly = !flag;
      txtDescontoProduto.TabStop = flag;
    }

    public void LimparCamposItem()
    {
      txtCodProduto.Clear();
      txtQtdeProduto.Clear();
      txtDescontoProduto.Clear();
      txtTotalProduto.Clear();
      txtDescProduto.Clear();
      txtPrecoProduto.Clear();
    }

    public void CalcularTotalItens()
    {
      decimal total = 0.00M;
      if (dataGridView1.RowCount > 0)
      {
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells["estado"].Value.ToString() == "OK")
          {
            total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["total"].Value);
          }
        }
        lblTotalVenda.Text = total.ToString("0.00");
      }
      else
      {
        lblTotalVenda.Text = total.ToString("0.00");
      }
    }
    //Metodos Eventos
    //-------------------------------------------------------------
    private void HabiDesaCampos(bool flag)
    { 
      //ReadOnly
      txtNumVenda.ReadOnly = flag;
      txtCodProduto.ReadOnly = !flag;
      txtQtdeProduto.ReadOnly = !flag;
      txtDescontoProduto.ReadOnly = !flag;
      txtPrecoProduto.ReadOnly = !flag;

      //Enabled
      dtVenda.Enabled = flag;
      btnConsultaProduto.Enabled = flag;

      //TabStop
      txtNumVenda.TabStop = !flag;
      txtCodProduto.TabStop = flag;
      txtQtdeProduto.TabStop = flag;
      txtDescontoProduto.TabStop = flag;


    }

    private void chkClienteCadastrado_CheckedChanged(object sender, EventArgs e)
    {
      if (chkClienteCadastrado.Checked)
      {
        gpbCliente.Enabled = true;
        txtCodigoCliente.Clear();
        lblNomeCliente.Text = "";
        txtCodigoCliente.Focus();
      }
      else
      {
        txtCodigoCliente.Clear();
        lblNomeCliente.Text = "";
        gpbCliente.Enabled = false;
        txtCodProduto.Focus();
      }
    }

    private void btnConsultaProduto_Click(object sender, EventArgs e)
    {
      FormGridProdutos grid = new FormGridProdutos(this, "venda2");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void txtCodProduto_Leave(object sender, EventArgs e)
    {
      if (txtCodProduto.Text.Length != 0)
      {
        Produtos prod = new Produtos();
        prod.Id = Convert.ToInt32(txtCodProduto.Text);
        prod.LocalizaProduto();

        if (prod.Descricao != null)
        {
          this.HabiDesaCamposItem(true);
          txtDescProduto.Text = prod.Descricao;
          txtPrecoProduto.Text = prod.PrecoVenda.ToString("0.00");
          txtDescontoProduto.Text = "0,00";
          txtQtdeProduto.Text = "1";
          decimal totalproduto = Convert.ToDecimal(txtPrecoProduto.Text) * Convert.ToDecimal(txtQtdeProduto.Text);
          txtTotalProduto.Text = totalproduto.ToString("0.00");
          btnInserirItem.Enabled = true;
          txtQtdeProduto.Select();
        }
        else
        {
          txtCodProduto.Clear();
          txtDescProduto.Clear();
          txtPrecoProduto.Clear();
          txtQtdeProduto.Clear();
          txtDescontoProduto.Clear();
          txtTotalProduto.Clear();
          btnInserirItem.Enabled = false;
          txtCodProduto.Focus();
          this.HabiDesaCamposItem(false);
        }
      }
      else
      {
        txtDescProduto.Clear();
        txtPrecoProduto.Clear();
        txtQtdeProduto.Clear();
        txtDescontoProduto.Clear();
        txtTotalProduto.Clear();
        btnInserirItem.Enabled = false;
        this.HabiDesaCamposItem(false);
      }
    }

    private void FormVendaSimples_KeyDown(object sender, KeyEventArgs e)
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
      else if (e.KeyCode == Keys.F3)
      {
        if (chkClienteCadastrado.Checked)
        {
          if (txtCodigoCliente.Text.Length == 0)
          {
            MessageBox.Show("Favor informar para qual Cliente será efetuada a Venda!", "Informar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            gpbFinalizar.Enabled = false;
            gpbItem.Enabled = true;
            lblTroco.Text = "";
            txtValor.Clear();
            txtCodigoCliente.Focus();
          }
          else
          {
            gpbFinalizar.Enabled = true;
            gpbItem.Enabled = false;
            lblTroco.Text = "0,00";
            txtValor.Text = lblTotalVenda.Text;
            if (lblTotalVenda.Text == "0,00")
            {
              btnFinalizarVenda.Enabled = false;
            }
            else
            {
              btnFinalizarVenda.Enabled = true;
            }
            txtValor.Focus();
          }
        }
        else
        {
          gpbFinalizar.Enabled = true;
          gpbItem.Enabled = false;
          lblTroco.Text = "0,00";
          txtValor.Text = lblTotalVenda.Text;
          if (lblTotalVenda.Text == "0,00")
          {
            btnFinalizarVenda.Enabled = false;
          }
          else
          {
            btnFinalizarVenda.Enabled = true;
          }
          txtValor.Focus();
        }        
      }
      else if (e.KeyCode == Keys.F2)
      {
        gpbFinalizar.Enabled = false;
        gpbItem.Enabled = true;
        lblTroco.Text = "";
        txtValor.Clear();
        txtCodProduto.Focus();
      }
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtQtdeProduto_Leave(object sender, EventArgs e)
    {
      if (txtQtdeProduto.ReadOnly == false)
      {
        if (txtQtdeProduto.Text.Length != 0)
        {
          decimal desconto = Convert.ToDecimal(txtDescontoProduto.Text);
          txtDescontoProduto.Text = desconto.ToString("0.00");
          int qtd = Convert.ToInt32(txtQtdeProduto.Text);
          decimal desc = Convert.ToDecimal(txtDescontoProduto.Text);
          decimal precounit = Convert.ToDecimal(txtPrecoProduto.Text) * (1 - (desc / 100));
          decimal total = qtd * precounit;
          txtTotalProduto.Text = total.ToString("0.00");
        }
        else
        {
          txtQtdeProduto.Text = "1";
          int qtd = Convert.ToInt32(txtQtdeProduto.Text);
          decimal desc = Convert.ToDecimal(txtDescontoProduto.Text);
          decimal precounit = Convert.ToDecimal(txtPrecoProduto.Text) * (1 - (desc / 100));
          decimal total = qtd * precounit;
          txtTotalProduto.Text = total.ToString("0.00");
        }  
      }
    }

    private void txtQtdeProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtDescontoProduto_Leave(object sender, EventArgs e)
    {
      if (txtDescontoProduto.ReadOnly == false)
      {
        if (txtDescontoProduto.Text.Length != 0)
        {
          decimal desconto = Convert.ToDecimal(txtDescontoProduto.Text);
          txtDescontoProduto.Text = desconto.ToString("0.00");
          int qtd = Convert.ToInt32(txtQtdeProduto.Text);
          decimal desc = Convert.ToDecimal(txtDescontoProduto.Text);
          decimal precounit = Convert.ToDecimal(txtPrecoProduto.Text) * (1 - (desc / 100));
          decimal total = qtd * precounit;
          txtTotalProduto.Text = total.ToString("0.00");
        }
        else
        {
          txtDescontoProduto.Text = "0,00";
          int qtd = Convert.ToInt32(txtQtdeProduto.Text);
          decimal desc = Convert.ToDecimal(txtDescontoProduto.Text);
          decimal precounit = Convert.ToDecimal(txtPrecoProduto.Text) * (1 - (desc / 100));
          decimal total = qtd * precounit;
          txtTotalProduto.Text = total.ToString("0.00");
        }   
      }
    }

    private void txtDescontoProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void txtCodProduto_Enter(object sender, EventArgs e)
    {
      txtCodProduto.SelectAll();
    }

    private void btnConsultaCliente_Click(object sender, EventArgs e)
    {
      FormGridClientes grid = new FormGridClientes(this, "venda2");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void txtCodigoCliente_Leave(object sender, EventArgs e)
    {
      if (txtCodigoCliente.Text.Length != 0)
      {
        Cliente cli = new Cliente();
        PessoaFisica cliPf = new PessoaFisica();
        PessoaJuridica cliPj = new PessoaJuridica();
        cli.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
        cli.LocalizaCliente();
        if (cli.Cnpj == "")
        {
          cliPf.Cpf = cli.Cpf;
          cliPf.ConsultarRegistro();
          lblNomeCliente.Text = cliPf.Nome;
          txtCodProduto.Focus();
        }
        else if (cli.Cpf == "")
        {
          cliPj.Cnpj = cli.Cnpj;
          cliPj.ConsultarRegistro();
          lblNomeCliente.Text = cliPj.Razaosocial;
          txtCodProduto.Focus();
        }
        else
        {
          txtCodigoCliente.Clear();
          lblNomeCliente.Text = "";
          txtCodigoCliente.Focus();
        }
      }
      else
      {
        txtCodigoCliente.Clear();
        lblNomeCliente.Text = "";
      }
    }

    private void btnInserirItem_Click(object sender, EventArgs e)
    {
      dt = new DataTable();
      dt = (DataTable)dataGridView1.DataSource;

      dr = dt.NewRow();
      int i = dt.Rows.Count + 1;
      dr["iditem"] = i;
      //dr["idvenda"] = txtNumVenda.Text;
      dr["idproduto"] = txtCodProduto.Text;
      dr["descricao"] = txtDescProduto.Text;
      dr["qtde"] = txtQtdeProduto.Text;
      dr["preco"] = txtPrecoProduto.Text;
      decimal subtotal = Convert.ToDecimal(txtQtdeProduto.Text) * Convert.ToDecimal(txtPrecoProduto.Text);
      dr["subtotal"] = subtotal.ToString("0.00");
      dr["desconto"] = txtDescontoProduto.Text;
      dr["total"] = txtTotalProduto.Text;
      dr["estado"] = "OK";
      dt.Rows.Add(dr);
      dataGridView1.DataSource = dt;

      this.HabiDesaCamposItem(false);
      this.LimparCamposItem();
      btnInserirItem.Enabled = false;
      if (dataGridView1.Rows[0].Cells["estado"].Value.ToString() == "CANCELADO")
      {
        btnCancelarItem.Enabled = false;
      }
      else
      {
        btnCancelarItem.Enabled = true;
      }
      this.CalcularTotalItens();
      txtCodProduto.Focus();
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (this.dataGridView1.RowCount > 0)
      {
        if (dataGridView1.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "CANCELADO")
        {
          e.CellStyle.ForeColor = Color.Red;
          e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }
      }
    }

    private void btnCancelarItem_Click(object sender, EventArgs e)
    {
      DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
      int i = linhaAtual.Index;
      DialogResult res = MessageBox.Show("Confirma a exclusão do produto?\nItem: " + dataGridView1.Rows[i].Cells["iditem"].Value.ToString() + " \nDescrição: " + dataGridView1.Rows[i].Cells["descricao"].Value.ToString() + "\nTotal do Cancelamento: R$ " + dataGridView1.Rows[i].Cells["total"].Value.ToString(), "Exclusão de Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        dt = new DataTable();
        dt = (DataTable)dataGridView1.DataSource;
        dt.Rows[i]["estado"] = "CANCELADO";
        dataGridView1.DataSource = dt;
        dataGridView1.FirstDisplayedScrollingRowIndex = i;
        dataGridView1.Refresh();
        dataGridView1.Rows[i].Selected = true;
        btnCancelarItem.Enabled = false;
        this.CalcularTotalItens();
      }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (dataGridView1.RowCount > 0 && e.RowIndex >= 0)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (dataGridView1.Rows[i].Cells["estado"].Value.ToString() == "CANCELADO")
        {
          btnCancelarItem.Enabled = false;
        }
        else
        {
          btnCancelarItem.Enabled = true;
        }
      }
    }

    private void btnFinalizarVenda_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a finalização da venda?", "Finalizar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Caixa caixa = new Caixa();
        caixa.ConsultaNumeroDeCaixasEmAberto();
        if (caixa.NumCaixasAbertos > 0)
        {
          caixa.ConsultaCaixaAberto();
          if (caixa.Data.Date == DateTime.Now.Date)
          {
            Venda venda = new Venda();
            venda.RetornaIdVenda();
            txtNumVenda.Text = Convert.ToString(venda.IdVenda);
            venda.DataVenda = dtVenda.Value;
            venda.Estado = "FINALIZADA";
            if (chkClienteCadastrado.Checked)
            {
              venda.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
            }
            venda.Observacao = "VENDA A VISTA N. " + txtNumVenda.Text + ", PAGAMENTO REALIZADO EM: " + cbxFormaPgto.Text;
            venda.TotalVenda = Convert.ToDecimal(lblTotalVenda.Text);
            venda.Vendedor = lblVendedor.Text;
            if (chkClienteCadastrado.Checked)
            {
              venda.InserirVendaAV(true);
            }
            else
            {
              venda.InserirVendaAV(false);
            }

            //Inseri os itens na tabela venda_item
            //-----------------------------------------------------
            ItemVenda item = new ItemVenda();
            item.IdVenda = Convert.ToInt32(txtNumVenda.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
              item.IdItem = Convert.ToInt32(dataGridView1.Rows[i].Cells["iditem"].Value);
              item.Desconto = Convert.ToDecimal(dataGridView1.Rows[i].Cells["desconto"].Value);
              item.Estado = Convert.ToString(dataGridView1.Rows[i].Cells["estado"].Value);
              item.IdProduto = Convert.ToInt32(dataGridView1.Rows[i].Cells["idproduto"].Value);
              item.Preco = Convert.ToDecimal(dataGridView1.Rows[i].Cells["preco"].Value);
              item.Qtde = Convert.ToInt32(dataGridView1.Rows[i].Cells["qtde"].Value);
              item.Total = Convert.ToDecimal(dataGridView1.Rows[i].Cells["total"].Value);
              item.InserirItem();
            }

            Produtos prod = new Produtos();
            prod.Usuario = lblVendedor.Text;
            try
            {
              for (int i = 0; i < dataGridView1.RowCount; i++)
              {
                if (dataGridView1.Rows[i].Cells["estado"].Value.ToString() == "OK")
                {
                  prod.Id = Convert.ToInt32(dataGridView1.Rows[i].Cells["idproduto"].Value); //column 01
                  prod.AtualizarEstoque("VENDA A VISTA N." + txtNumVenda.Text, "NEGATIVO", Convert.ToInt32(dataGridView1.Rows[i].Cells["qtde"].Value)); //column 03 
                }
              }
              prod.Call_SP_EstadoProduto();
            }
            catch (Exception ex)
            {
              throw ex;
            }
            try
            {
              Parcela parcela = new Parcela();
              parcela.IdVenda = Convert.ToInt32(txtNumVenda.Text);
              parcela.Prazo = 0;
              parcela.Estado = "PAGA";
              parcela.Obs = "";
              parcela.IdParcela = 1;
              parcela.DataVencimento = dtVenda.Value;
              parcela.ValorParcela = Convert.ToDecimal(lblTotalVenda.Text);
              if (chkClienteCadastrado.Checked)
              {
                parcela.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
                parcela.InserirParcelaAV(true);
              }
              else
              {
                parcela.InserirParcelaAV(false);
              }

            }
            catch (Exception)
            {
              throw;
            }
            try
            {
              Pagamento pag = new Pagamento();
              pag.DataPagto = DateTime.Now;
              pag.IdFinalizadora = Convert.ToInt32(cbxFormaPgto.SelectedValue);
              pag.IdParcela = 1;
              pag.IdVenda = venda.IdVenda;
              pag.Usuario = usuarioAtual;
              pag.ValorPago = venda.TotalVenda;
              pag.Obs = "VENDA A VISTA";
              if (chkClienteCadastrado.Checked)
              {
                pag.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
                pag.InserirPagamentoAV(true);
                caixa.Obs = "VENDA A VISTA N. " + txtNumVenda.Text + " - CLIENTE: " + lblNomeCliente.Text + "";
              }
              else
              {
                pag.InserirPagamentoAV(false);
                caixa.Obs = "VENDA A VISTA N. " + txtNumVenda.Text;
              }
              caixa.ConsultaCaixaAberto();
              caixa.RetornaIdEntrada();
              caixa.Data = DateTime.Now;
              caixa.Valor = Convert.ToDecimal(txtValor.Text);
              caixa.Usuario = usuarioAtual;
              caixa.InserirEntrada();
            }
            catch (Exception)
            {
              throw;
            }

            //Organiza Tela para uma nova venda...
            //--------------------------------------------------
            //Zera DataGrid...
            dt = new DataTable();
            dt.Columns.Add("iditem", typeof(int));
            dt.Columns.Add("idvenda", typeof(int));
            dt.Columns.Add("idproduto", typeof(int));
            dt.Columns.Add("descricao", typeof(string));
            dt.Columns.Add("preco", typeof(decimal));
            dt.Columns.Add("qtde", typeof(int));
            dt.Columns.Add("subtotal", typeof(decimal));
            dt.Columns.Add("desconto", typeof(decimal));
            dt.Columns.Add("total", typeof(decimal));
            dt.Columns.Add("estado", typeof(string));
            dataGridView1.DataSource = dt;
            btnCancelarItem.Enabled = false;

            lblNomeCliente.Text = "";
            txtCodigoCliente.Clear();
            gpbCliente.Enabled = false;
            chkClienteCadastrado.Checked = false;
            txtValor.Clear();
            lblTroco.Text = "";
            lblTotalVenda.Text = "0,00";
            gpbFinalizar.Enabled = false;
            gpbItem.Enabled = true;

            int idVendaAtual = Convert.ToInt32(txtNumVenda.Text);
            //Gera novo ID de venda
            //----------------------------------------------------
            venda.RetornaIdVenda();
            txtNumVenda.Text = Convert.ToString(venda.IdVenda);
            this.CalcularTotalItens();
            txtCodProduto.Focus();

            //Imprime a Venda
            //----------------------------------------------------
            DialogResult res2 = MessageBox.Show("Deseja Emitir a Relação de Produtos da Venda?", "Venda Finalizada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res2 == DialogResult.Yes)
            {
              FormRelVenda rel = new FormRelVenda();
              rel.MdiParent = this.ParentForm;
              rel.idvenda = idVendaAtual;
              rel.Show();
            }
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

    private void btnConsGeral_Click(object sender, EventArgs e)
    {
      FormGridVenda grid = new FormGridVenda(this);
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void txtValor_Leave(object sender, EventArgs e)
    {
      if (txtValor.Text.Length == 0)
      {
        txtValor.Text = lblTotalVenda.Text;
      }
      else
      {
        decimal totalVenda = Convert.ToDecimal(lblTotalVenda.Text);
        decimal pago = Convert.ToDecimal(txtValor.Text);
        txtValor.Text = pago.ToString("0.00");
        decimal troco = pago - totalVenda;
        lblTroco.Text = troco.ToString("0.00");
      }
    }

    private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

    private void gpbCliente_Enter(object sender, EventArgs e)
    {
      gpbFinalizar.Enabled = false;
      gpbItem.Enabled = true;
      lblTroco.Text = "";
      txtValor.Clear();
    }
  }
}
