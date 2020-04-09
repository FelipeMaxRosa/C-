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
  public partial class FormVendas : Form
  {
    //Atributos
    //-------------------------------------------------------------
    private string usuarioAtual;
    public bool novaVenda = false;
    private Venda venda;
    public int idVendaAtual = 0;
    private DataSet ds;
    private DataTable dt;

    //Propriedades
    //-------------------------------------------------------------
    public string UsuarioAtual
    {
      get { return usuarioAtual; }
      set { usuarioAtual = value; }
    }

    //Construtor
    //-------------------------------------------------------------
    public FormVendas(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      //txtNumVenda.Select();
      usuarioAtual = parent.lblUsuario.Text;
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
    }

    //Metodos Gerais
    //-------------------------------------------------------------
    public void HabiDesaCampos(bool flag)
    {
      //Read Only
      txtNumVenda.ReadOnly = flag;
      txtCodigoCliente.ReadOnly = !flag;
      txtObservacao.ReadOnly = !flag;

      //Enabled
      btnConsGeral.Enabled = !flag;
      btnConsCliente.Enabled = flag;
      dtVenda.Enabled = flag;

      //TabStop
      txtCodigoCliente.TabStop = flag;
      txtNumVenda.TabStop = !flag;
      txtObservacao.TabStop = flag;
      btnConsCliente.TabStop = flag;
      btnConsGeral.TabStop = !flag;
      dtVenda.TabStop = flag;
    }

    public void LimparCampos()
    {
      txtNumVenda.Clear();
      txtCodigoCliente.Clear();
      tbApelido.Clear();
      tbCpfCnpj.Clear();
      tbEmail.Clear();
      tbNome.Clear();
      tbRgIe.Clear();
      tbTelefone1.Clear();
      tbTelefone2.Clear();
      txtPrecoProduto.Clear();
      txtObservacao.Clear();
      lblEstado.Text = "";
      lblVendedor.Text = "";
      lblTotalVenda.Text = "";
      dtVenda.Text = "01/01/1900";
    }

    public void LimparCamposCliente()
    {
      txtCodigoCliente.Clear();
      tbApelido.Clear();
      tbCpfCnpj.Clear();
      tbEmail.Clear();
      tbNome.Clear();
      tbRgIe.Clear();
      tbTelefone1.Clear();
      tbTelefone2.Clear();
    }

    public void OrganizaBotoes()
    {
      btnConsGeral.Enabled = true;
      btnConsCliente.Enabled = false;
      butCancelar.Enabled = false;
      butConsultar.Enabled = true;
      butNovo.Enabled = true;
      butSalvar.Enabled = false;
    }

    public void AtualizarGrid()
    {
      ItemVenda item = new ItemVenda();
      item.IdVenda = idVendaAtual;
      item.ConsultarParaGrid();
      ds = item.ds;
      dataGridView1.DataSource = ds.Tables["venda_item"];
    }

    public void HabiDesaParcelas(bool flag, string numPar, decimal valor, int prazo)
    {
      decimal valorParcela = valor / Convert.ToInt32(numPar);
      if (numPar == "01")
      {
        dtP01.Enabled = flag;
        dtP01.TabStop = flag;
        txtValorP1.ReadOnly = !flag;
        txtValorP1.TabStop = flag;
        dtP02.Enabled = !flag;
        dtP02.TabStop = !flag;
        txtValorP2.ReadOnly = flag;
        txtValorP2.TabStop = !flag;
        dtP03.Enabled = !flag;
        dtP03.TabStop = !flag;
        txtValorP3.ReadOnly = flag;
        txtValorP3.TabStop = !flag;
        dtP04.Enabled = !flag;
        dtP04.TabStop = !flag;
        txtValorP4.ReadOnly = flag;
        txtValorP4.TabStop = !flag;
        dtP05.Enabled = !flag;
        dtP05.TabStop = !flag;
        txtValorP5.ReadOnly = flag;
        txtValorP5.TabStop = !flag;
        dtP06.Enabled = !flag;
        dtP06.TabStop = !flag;
        txtValorP6.ReadOnly = flag;
        txtValorP6.TabStop = !flag;
        dtP01.Value = dtVenda.Value;
        dtP01.Value = dtP01.Value.AddDays(prazo);
        txtValorP1.Text = valorParcela.ToString("0.00");
      }
      else if (numPar == "02")
      {
        dtP01.Enabled = flag;
        dtP01.TabStop = flag;
        txtValorP1.ReadOnly = !flag;
        txtValorP1.TabStop = flag;
        dtP02.Enabled = flag;
        dtP02.TabStop = flag;
        txtValorP2.ReadOnly = !flag;
        txtValorP2.TabStop = flag;
        dtP03.Enabled = !flag;
        dtP03.TabStop = !flag;
        txtValorP3.ReadOnly = flag;
        txtValorP3.TabStop = !flag;
        dtP04.Enabled = !flag;
        dtP04.TabStop = !flag;
        txtValorP4.ReadOnly = flag;
        txtValorP4.TabStop = !flag;
        dtP05.Enabled = !flag;
        dtP05.TabStop = !flag;
        txtValorP5.ReadOnly = flag;
        txtValorP5.TabStop = !flag;
        dtP06.Enabled = !flag;
        dtP06.TabStop = !flag;
        txtValorP6.ReadOnly = flag;
        txtValorP6.TabStop = !flag;
        dtP01.Value = dtVenda.Value;
        dtP02.Value = dtP01.Value.AddDays(prazo);
        txtValorP1.Text = valorParcela.ToString("0.00");
        txtValorP2.Text = valorParcela.ToString("0.00");
      }
      else if (numPar == "03")
      {
        dtP01.Enabled = flag;
        dtP01.TabStop = flag;
        txtValorP1.ReadOnly = !flag;
        txtValorP1.TabStop = flag;
        dtP02.Enabled = flag;
        dtP02.TabStop = flag;
        txtValorP2.ReadOnly = !flag;
        txtValorP2.TabStop = flag;
        dtP03.Enabled = flag;
        dtP03.TabStop = flag;
        txtValorP3.ReadOnly = !flag;
        txtValorP3.TabStop = flag;
        dtP04.Enabled = !flag;
        dtP04.TabStop = !flag;
        txtValorP4.ReadOnly = flag;
        txtValorP4.TabStop = !flag;
        dtP05.Enabled = !flag;
        dtP05.TabStop = !flag;
        txtValorP5.ReadOnly = flag;
        txtValorP5.TabStop = !flag;
        dtP06.Enabled = !flag;
        dtP06.TabStop = !flag;
        txtValorP6.ReadOnly = flag;
        txtValorP6.TabStop = !flag;
        dtP01.Value = dtVenda.Value;
        dtP02.Value = dtP01.Value.AddDays(prazo);
        dtP03.Value = dtP02.Value.AddDays(prazo);
        txtValorP1.Text = valorParcela.ToString("0.00");
        txtValorP2.Text = valorParcela.ToString("0.00");
        txtValorP3.Text = valorParcela.ToString("0.00");
      }
      else if (numPar == "04")
      {
        dtP01.Enabled = flag;
        dtP01.TabStop = flag;
        txtValorP1.ReadOnly = !flag;
        txtValorP1.TabStop = flag;
        dtP02.Enabled = flag;
        dtP02.TabStop = flag;
        txtValorP2.ReadOnly = !flag;
        txtValorP2.TabStop = flag;
        dtP03.Enabled = flag;
        dtP03.TabStop = flag;
        txtValorP3.ReadOnly = !flag;
        txtValorP3.TabStop = flag;
        dtP04.Enabled = flag;
        dtP04.TabStop = flag;
        txtValorP4.ReadOnly = !flag;
        txtValorP4.TabStop = flag;
        dtP05.Enabled = !flag;
        dtP05.TabStop = !flag;
        txtValorP5.ReadOnly = flag;
        txtValorP5.TabStop = !flag;
        dtP06.Enabled = !flag;
        dtP06.TabStop = !flag;
        txtValorP6.ReadOnly = flag;
        txtValorP6.TabStop = !flag;
        dtP01.Value = dtVenda.Value;
        dtP02.Value = dtP01.Value.AddDays(prazo);
        dtP03.Value = dtP02.Value.AddDays(prazo);
        dtP04.Value = dtP03.Value.AddDays(prazo);
        txtValorP1.Text = valorParcela.ToString("0.00");
        txtValorP2.Text = valorParcela.ToString("0.00");
        txtValorP3.Text = valorParcela.ToString("0.00");
        txtValorP4.Text = valorParcela.ToString("0.00");
      }
      else if (numPar == "05")
      {
        dtP01.Enabled = flag;
        dtP01.TabStop = flag;
        txtValorP1.ReadOnly = !flag;
        txtValorP1.TabStop = flag;
        dtP02.Enabled = flag;
        dtP02.TabStop = flag;
        txtValorP2.ReadOnly = !flag;
        txtValorP2.TabStop = flag;
        dtP03.Enabled = flag;
        dtP03.TabStop = flag;
        txtValorP3.ReadOnly = !flag;
        txtValorP3.TabStop = flag;
        dtP04.Enabled = flag;
        dtP04.TabStop = flag;
        txtValorP4.ReadOnly = !flag;
        txtValorP4.TabStop = flag;
        dtP05.Enabled = flag;
        dtP05.TabStop = flag;
        txtValorP5.ReadOnly = !flag;
        txtValorP5.TabStop = flag;
        dtP06.Enabled = !flag;
        dtP06.TabStop = !flag;
        txtValorP6.ReadOnly = flag;
        txtValorP6.TabStop = !flag;
        dtP01.Value = dtVenda.Value;
        dtP02.Value = dtP01.Value.AddDays(prazo);
        dtP03.Value = dtP02.Value.AddDays(prazo);
        dtP04.Value = dtP03.Value.AddDays(prazo);
        dtP05.Value = dtP04.Value.AddDays(prazo);
        txtValorP1.Text = valorParcela.ToString("0.00");
        txtValorP2.Text = valorParcela.ToString("0.00");
        txtValorP3.Text = valorParcela.ToString("0.00");
        txtValorP4.Text = valorParcela.ToString("0.00");
        txtValorP5.Text = valorParcela.ToString("0.00");
      }
      else if (numPar == "06")
      {
        dtP01.Enabled = flag;
        dtP01.TabStop = flag;
        txtValorP1.ReadOnly = !flag;
        txtValorP1.TabStop = flag;
        dtP02.Enabled = flag;
        dtP02.TabStop = flag;
        txtValorP2.ReadOnly = !flag;
        txtValorP2.TabStop = flag;
        dtP03.Enabled = flag;
        dtP03.TabStop = flag;
        txtValorP3.ReadOnly = !flag;
        txtValorP3.TabStop = flag;
        dtP04.Enabled = flag;
        dtP04.TabStop = flag;
        txtValorP4.ReadOnly = !flag;
        txtValorP4.TabStop = flag;
        dtP05.Enabled = flag;
        dtP05.TabStop = flag;
        txtValorP5.ReadOnly = !flag;
        txtValorP5.TabStop = flag;
        dtP06.Enabled = flag;
        dtP06.TabStop = flag;
        txtValorP6.ReadOnly = !flag;
        txtValorP6.TabStop = flag;
        dtP01.Value = dtVenda.Value;
        dtP02.Value = dtP01.Value.AddDays(prazo);
        dtP03.Value = dtP02.Value.AddDays(prazo);
        dtP04.Value = dtP03.Value.AddDays(prazo);
        dtP05.Value = dtP04.Value.AddDays(prazo);
        dtP06.Value = dtP05.Value.AddDays(prazo);
        txtValorP1.Text = valorParcela.ToString("0.00");
        txtValorP2.Text = valorParcela.ToString("0.00");
        txtValorP3.Text = valorParcela.ToString("0.00");
        txtValorP4.Text = valorParcela.ToString("0.00");
        txtValorP5.Text = valorParcela.ToString("0.00");
        txtValorP6.Text = valorParcela.ToString("0.00");
      }
    }

    public void LimparParcelas()
    {
      txtValorP1.Clear();
      txtValorP2.Clear();
      txtValorP3.Clear();
      txtValorP4.Clear();
      txtValorP5.Clear();
      txtValorP6.Clear();
      dtP01.Value = Convert.ToDateTime("01/01/1900");
      dtP02.Value = Convert.ToDateTime("01/01/1900");
      dtP03.Value = Convert.ToDateTime("01/01/1900");
      dtP04.Value = Convert.ToDateTime("01/01/1900");
      dtP05.Value = Convert.ToDateTime("01/01/1900");
      dtP06.Value = Convert.ToDateTime("01/01/1900");
    }

    public void HabiDesaCamposItem(bool flag)
    {
      txtQtdeProduto.ReadOnly = !flag;
      txtDescontoProduto.ReadOnly = !flag;
      txtQtdeProduto.TabStop = flag;
      txtDescontoProduto.TabStop = flag;
    }

    public void CalcularTotalParcelas(string parcelas)
    {
      decimal totalparc = 0.00M;
      switch (cbxParcelas.Text)
      {
        case "01":
          totalparc = Convert.ToDecimal(txtValorP1.Text);
          break;
        case "02":
          totalparc = Convert.ToDecimal(txtValorP1.Text) + Convert.ToDecimal(txtValorP2.Text);
          break;
        case "03":
          totalparc = Convert.ToDecimal(txtValorP1.Text) + Convert.ToDecimal(txtValorP2.Text) + Convert.ToDecimal(txtValorP3.Text);
          break;
        case "04":
          totalparc = Convert.ToDecimal(txtValorP1.Text) + Convert.ToDecimal(txtValorP2.Text) + Convert.ToDecimal(txtValorP3.Text) + Convert.ToDecimal(txtValorP4.Text);
          break;
        case "05":
          totalparc = Convert.ToDecimal(txtValorP1.Text) + Convert.ToDecimal(txtValorP2.Text) + Convert.ToDecimal(txtValorP3.Text) + Convert.ToDecimal(txtValorP4.Text) + Convert.ToDecimal(txtValorP5.Text);
          break;
        case "06":
          totalparc = Convert.ToDecimal(txtValorP1.Text) + Convert.ToDecimal(txtValorP2.Text) + Convert.ToDecimal(txtValorP3.Text) + Convert.ToDecimal(txtValorP4.Text) + Convert.ToDecimal(txtValorP5.Text) + Convert.ToDecimal(txtValorP6.Text);
          break;
      }
      lblTotalParcelas.Text = totalparc.ToString("0.00");
    }

    //Metodos Eventos
    //------------------------------------------------------------
    private void butNovo_Click(object sender, EventArgs e)
    {
      novaVenda = true;
      this.LimparCampos();
      this.HabiDesaCampos(true);
      this.CancelButton = butCancelar;
      //lblEstado.Text = "ABERTA";
      lblVendedor.Text = usuarioAtual;
      lblTotalVenda.Text = "0,00";
      butNovo.Enabled = false;
      butConsultar.Enabled = false;
      butCancelar.Enabled = true;
      dtVenda.Value = DateTime.Now;
      venda = new Venda();
      venda.RetornaIdVenda();
      txtNumVenda.Text = Convert.ToString(venda.IdVenda);
      tabControl1.SelectedTab = tabPageVenda;
      dtVenda.Focus();
    }

    private void FormVendas_KeyDown(object sender, KeyEventArgs e)
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
      if (e.KeyCode == Keys.F6)
      {
        if (btnConsGeral.Enabled == true)
        {
          FormGridVenda grid = new FormGridVenda(this);
          grid.MdiParent = this.ParentForm;
          grid.Show(); 
        }
      }
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
          radPessoaFisica.Checked = true;
          tbApelido.Text = cliPf.Apelido;
          tbCpfCnpj.Text = cliPf.Cpf;
          tbEmail.Text = cli.Email;
          tbNome.Text = cliPf.Nome;
          tbRgIe.Text = cliPf.Rg;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          cbxSituacao.Text = cli.Situacao;
          if (novaVenda)
          {
            butSalvar.Enabled = true;  
          }          
          txtObservacao.Focus();
        }
        else if (cli.Cpf == "")
        {
          cliPj.Cnpj = cli.Cnpj;
          cliPj.ConsultarRegistro();
          radPessoaJuridica.Checked = true;
          tbCpfCnpj.Text = cliPj.Cnpj;
          tbEmail.Text = cli.Email;
          tbNome.Text = cliPj.Razaosocial;
          tbApelido.Text = cliPj.Nomefantasia;
          tbRgIe.Text = cliPj.Ie;
          tbTelefone1.Text = cli.Telefone1;
          tbTelefone2.Text = cli.Telefone2;
          cbxSituacao.Text = cli.Situacao;
          if (novaVenda)
          {
            butSalvar.Enabled = true;
          }
          txtObservacao.Focus();
        }
        else
        {
          this.LimparCamposCliente();
          txtCodigoCliente.Focus();
          butSalvar.Enabled = false;
        }
      }
      else
      {
        this.LimparCamposCliente();        
      }
    }

    private void butSalvar_Click(object sender, EventArgs e)
    {
      if (novaVenda)
      {
        DialogResult res = MessageBox.Show("Confirma nova venda para o Cliente?", "Nova Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          venda = new Venda();
          venda.RetornaIdVenda();
          txtNumVenda.Text = Convert.ToString(venda.IdVenda);
          //venda.IdVenda = Convert.ToInt32(txtNumVenda.Text);
          venda.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
          venda.DataVenda = dtVenda.Value;
          venda.Estado = "ABERTA";
          venda.Observacao = txtObservacao.Text;
          venda.TotalVenda = Convert.ToDecimal(lblTotalVenda.Text);
          venda.Vendedor = lblVendedor.Text;
          venda.InserirVenda();
          idVendaAtual = venda.IdVenda;
          lblEstado.Text = "ABERTA";

          this.OrganizaBotoes();
          this.HabiDesaCampos(false);
          novaVenda = false;

          DialogResult res2 = MessageBox.Show("Deseja inserir os itens da venda?", "Nova Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res2 == DialogResult.Yes)
          {
            tabControl1.SelectedTab = tabPageItens;
            txtCodProduto.Select();
          }
        }
      }
      else
      {

      }
    }

    private void txtNumVenda_Enter(object sender, EventArgs e)
    {
      txtNumVenda.SelectAll();
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
          btnSalvarItem.Enabled = true;
          txtQtdeProduto.Select();
        }
        else
        {
          this.HabiDesaCamposItem(false);
          txtCodProduto.Clear();
          txtDescProduto.Clear();
          txtPrecoProduto.Clear();
          txtQtdeProduto.Clear();
          txtDescontoProduto.Clear();
          txtTotalProduto.Clear();
          btnSalvarItem.Enabled = false;
          txtCodProduto.Focus();
        }
      }
      else
      {
        this.HabiDesaCamposItem(false);
        txtDescProduto.Clear();
        txtPrecoProduto.Clear();
        txtQtdeProduto.Clear();
        txtDescontoProduto.Clear();
        txtTotalProduto.Clear();
        btnSalvarItem.Enabled = false;
      }
    }

    private void btnConsCliente_Click(object sender, EventArgs e)
    {
      this.LimparCamposCliente();
      FormGridClientes grid = new FormGridClientes(this, "venda");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void txtCodigoCliente_Enter(object sender, EventArgs e)
    {
      txtCodigoCliente.SelectAll();
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tabPageItens_Enter(object sender, EventArgs e)
    {
      if (idVendaAtual != 0)
      {
        if (lblEstado.Text == "ABERTA")
        {
          grbItem.Enabled = true;
          ItemVenda ven = new ItemVenda();
          ven.IdVenda = idVendaAtual;
          ven.ConsultarParaGrid();
          dataGridView1.DataSource = ven.ds.Tables["venda_item"];
          if (dataGridView1.RowCount > 0)
          {
            if (dataGridView1.Rows[0].Cells["estado"].Value.ToString() == "CANCELADO")
            {
              btnCancelarItem.Enabled = false;
            }
            else
            {
              btnCancelarItem.Enabled = true;
            }
          }
          else
          {
            btnCancelarItem.Enabled = false;
          }
        }
        else
        {
          lblTotalItens.Text = lblTotalVenda.Text;
          grbItem.Enabled = false;
          ItemVenda ven = new ItemVenda();
          ven.IdVenda = Convert.ToInt32(txtNumVenda.Text);
          ven.ConsultarParaGrid();
          dataGridView1.DataSource = ven.ds.Tables["venda_item"];
        }
        txtCodProduto.Select();
      }
      else
      {
        grbItem.Enabled = false;
        ItemVenda ven = new ItemVenda();
        ven.IdVenda = idVendaAtual;
        ven.ConsultarParaGrid();
        dataGridView1.DataSource = ven.ds.Tables["venda_item"];
      }      
    }

    private void txtNumVenda_Leave(object sender, EventArgs e)
    {
      if (txtNumVenda.Text.Length != 0)
      {
        venda = new Venda();
        venda.IdVenda = Convert.ToInt32(txtNumVenda.Text);
        venda.ConsultaVenda();
        if (venda.Estado != null)
        {
          lblEstado.Text = venda.Estado;
          lblVendedor.Text = venda.Vendedor;
          lblTotalVenda.Text = venda.TotalVenda.ToString("0.00");
          lblTotalItens.Text = venda.TotalVenda.ToString("0.00");
          if (venda.IdCliente != 0)
          {
            txtCodigoCliente.Text = Convert.ToString(venda.IdCliente);
            Cliente cli = new Cliente();
            PessoaFisica cliPf = new PessoaFisica();
            PessoaJuridica cliPj = new PessoaJuridica();
            cli.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
            cli.LocalizaCliente();
            if (cli.Cnpj == "")
            {
              cliPf.Cpf = cli.Cpf;
              cliPf.ConsultarRegistro();
              radPessoaFisica.Checked = true;
              tbApelido.Text = cliPf.Apelido;
              tbCpfCnpj.Text = cliPf.Cpf;
              tbEmail.Text = cli.Email;
              tbNome.Text = cliPf.Nome;
              tbRgIe.Text = cliPf.Rg;
              tbTelefone1.Text = cli.Telefone1;
              tbTelefone2.Text = cli.Telefone2;
              cbxSituacao.Text = cli.Situacao;
            }
            else if (cli.Cpf == "")
            {
              cliPj.Cnpj = cli.Cnpj;
              cliPj.ConsultarRegistro();
              radPessoaJuridica.Checked = true;
              tbCpfCnpj.Text = cliPj.Cnpj;
              tbEmail.Text = cli.Email;
              tbNome.Text = cliPj.Razaosocial;
              tbApelido.Text = cliPj.Nomefantasia;
              tbRgIe.Text = cliPj.Ie;
              tbTelefone1.Text = cli.Telefone1;
              tbTelefone2.Text = cli.Telefone2;
              cbxSituacao.Text = cli.Situacao;
            }
          }
          else
          {
            this.LimparCamposCliente();
          }
          dtVenda.Value = venda.DataVenda;
          txtObservacao.Text = venda.Observacao;
          idVendaAtual = venda.IdVenda;
          butNovo.Focus();
        }
        else
        {
          idVendaAtual = 0;
          this.LimparCampos();
          this.LimparCamposCliente();
          txtNumVenda.Focus();
        }
      }
      else 
      {
        idVendaAtual = 0;
        this.LimparCampos();
        this.LimparCamposCliente();
      }
    }

    private void butCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.LimparCamposCliente();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        txtNumVenda.Focus();
        this.CancelButton = butSair;
        novaVenda = false;
      }
    }

    private void btnSalvarItem_Click(object sender, EventArgs e)
    {
      ItemVenda item = new ItemVenda();
      item.IdVenda = idVendaAtual;
      item.GerarNovoItem();
      item.Desconto = Convert.ToDecimal(txtDescontoProduto.Text);
      item.Estado = "OK";
      item.IdProduto = Convert.ToInt32(txtCodProduto.Text);
      item.Preco = Convert.ToDecimal(txtPrecoProduto.Text);
      item.Qtde = Convert.ToInt32(txtQtdeProduto.Text);
      item.Total = Convert.ToDecimal(txtTotalProduto.Text);
      item.InserirItem();
      item.CalcularTotalGeral();
      Venda ven = new Venda();
      ven.IdVenda = item.IdVenda;
      ven.TotalVenda = item.Totalgeral;
      ven.AtualizarTotal();
      lblTotalItens.Text = item.Totalgeral.ToString("0.00");
      lblTotalVenda.Text = item.Totalgeral.ToString("0.00");
      item.ConsultarParaGrid();
      dataGridView1.DataSource = item.ds.Tables["venda_item"];
      txtCodProduto.Clear();
      txtDescProduto.Clear();
      txtQtdeProduto.Clear();
      txtPrecoProduto.Clear();
      txtDescontoProduto.Clear();
      txtTotalProduto.Clear();
      dataGridView1.Focus();
      if (dataGridView1.Rows[0].Cells[8].Value.ToString() == "CANCELADO")
      {
        btnCancelarItem.Enabled = false;
      }
      else
      {
        btnCancelarItem.Enabled = true;
      }
      this.HabiDesaCamposItem(false);
      txtCodProduto.Focus();
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

    private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtQtdeProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtDescontoProduto_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
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

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (dataGridView1.RowCount > 0 && e.RowIndex >= 0)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (lblEstado.Text == "ABERTA" && idVendaAtual != 0)
        {
          //if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "CANCELADO")
          if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "CANCELADO")
          {
            btnCancelarItem.Enabled = false;
          }
          else
          {
            btnCancelarItem.Enabled = true;
          }
        }
      }
    }

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

    private void btnCancelarItem_Click(object sender, EventArgs e)
    {
      DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
      int i = linhaAtual.Index;
      DialogResult res = MessageBox.Show("Confirma a exclusão do produto?\nItem: " + dataGridView1.Rows[i].Cells["iditem"].Value.ToString() + " \nDescrição: " + dataGridView1.Rows[i].Cells["descricao"].Value.ToString() + "\nTotal do Cancelamento: R$ " + dataGridView1.Rows[i].Cells["total"].Value.ToString(), "Exclusão de Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        ItemVenda item = new ItemVenda();
        item.IdItem = Convert.ToInt32(dataGridView1.Rows[i].Cells["iditem"].Value);
        item.IdVenda = idVendaAtual;
        item.ExcluirItem();
        item.CalcularTotalGeral();
        Venda ven = new Venda();
        ven.IdVenda = item.IdVenda;
        ven.TotalVenda = item.Totalgeral;
        ven.AtualizarTotal();
        lblTotalItens.Text = item.Totalgeral.ToString("0.00");
        lblTotalVenda.Text = item.Totalgeral.ToString("0.00");
        this.AtualizarGrid();
        btnCancelarItem.Enabled = false;
        dataGridView1.FirstDisplayedScrollingRowIndex = i;
        dataGridView1.Refresh();
        dataGridView1.Rows[i].Selected = true;
      }
    }

    private void btnConsProduto_Click(object sender, EventArgs e)
    {
      FormGridProdutos grid = new FormGridProdutos(this, "venda");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void cbxParcelas_DropDownClosed(object sender, EventArgs e)
    {
      decimal totalParc = Convert.ToDecimal(lblTotalItens.Text);
      this.LimparParcelas();
      switch (cbxParcelas.Text)
      {
        case "01":
          this.HabiDesaParcelas(true, "01", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "02":
          this.HabiDesaParcelas(true, "02", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "03":
          this.HabiDesaParcelas(true, "03", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "04":
          this.HabiDesaParcelas(true, "04", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "05":
          this.HabiDesaParcelas(true, "05", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "06":
          this.HabiDesaParcelas(true, "06", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
      }
      this.CalcularTotalParcelas(cbxParcelas.Text);
      nudPrazo.Focus();
    }

    private void cbxParcelas_SelectedIndexChanged(object sender, EventArgs e)
    {
      decimal totalParc = Convert.ToDecimal(lblTotalItens.Text);
      this.LimparParcelas();
      switch (cbxParcelas.Text)
      {
        case "01":
          this.HabiDesaParcelas(true, "01", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "02":
          this.HabiDesaParcelas(true, "02", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "03":
          this.HabiDesaParcelas(true, "03", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "04":
          this.HabiDesaParcelas(true, "04", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "05":
          this.HabiDesaParcelas(true, "05", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
        case "06":
          this.HabiDesaParcelas(true, "06", totalParc, Convert.ToInt32(nudPrazo.Value));
          break;
      }
      this.CalcularTotalParcelas(cbxParcelas.Text);
    }

    private void tabPagePagamento_Enter(object sender, EventArgs e)
    {
      if (idVendaAtual != 0)
      {
        lblTotalItens2.Text = lblTotalItens.Text;
        if (lblEstado.Text == "ABERTA")
        {
          gpbParcela.Enabled = true;
          btnFinalizarVenda.Enabled = true;
          btnCalculadora.Enabled = true;
          if (cbxParcelas.Text == "")
          {
            cbxParcelas.Text = "01";
          }    
        }
        else if(lblEstado.Text == "FINALIZADA")
        {
          gpbParcela.Enabled = false;
          btnFinalizarVenda.Enabled = false;
          btnCalculadora.Enabled = true;
          btnEmitirRelatorio.Enabled = true;
          
          Parcela parcela = new Parcela();
          parcela.IdVenda = idVendaAtual;
          //parcela.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
          parcela.ConsutarParcela();
          cbxParcelas.Text = parcela.QtdeParcelas.ToString("00");
          //nudPrazo.Value = Convert.ToDecimal(parcela.Prazo);
          nudPrazo.Value = Convert.ToDecimal(parcela.Ds.Tables["venda_parcela"].Rows[0]["prazo"]);
          switch (cbxParcelas.Text)
          {
            case "01":
              dtP01.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[0]["dtvencimento"]);
              txtValorP1.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[0]["valor"]);
              break;
            case "02":
              dtP01.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[0]["dtvencimento"]);
              txtValorP1.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[0]["valor"]);
              dtP02.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[1]["dtvencimento"]);
              txtValorP2.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[1]["valor"]);
              break;
            case "03":
              dtP01.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[0]["dtvencimento"]);
              txtValorP1.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[0]["valor"]);
              dtP02.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[1]["dtvencimento"]);
              txtValorP2.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[1]["valor"]);
              dtP03.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[2]["dtvencimento"]);
              txtValorP3.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[2]["valor"]);
              break;
            case "04":
              dtP01.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[0]["dtvencimento"]);
              txtValorP1.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[0]["valor"]);
              dtP02.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[1]["dtvencimento"]);
              txtValorP2.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[1]["valor"]);
              dtP03.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[2]["dtvencimento"]);
              txtValorP3.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[2]["valor"]);
              dtP04.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[3]["dtvencimento"]);
              txtValorP4.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[3]["valor"]);
              break;
            case "05":
              dtP01.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[0]["dtvencimento"]);
              txtValorP1.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[0]["valor"]);
              dtP02.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[1]["dtvencimento"]);
              txtValorP2.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[1]["valor"]);
              dtP03.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[2]["dtvencimento"]);
              txtValorP3.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[2]["valor"]);
              dtP04.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[3]["dtvencimento"]);
              txtValorP4.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[3]["valor"]);
              dtP05.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[4]["dtvencimento"]);
              txtValorP5.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[4]["valor"]);
              break;
            case "06":
              dtP01.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[0]["dtvencimento"]);
              txtValorP1.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[0]["valor"]);
              dtP02.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[1]["dtvencimento"]);
              txtValorP2.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[1]["valor"]);
              dtP03.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[2]["dtvencimento"]);
              txtValorP3.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[2]["valor"]);
              dtP04.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[3]["dtvencimento"]);
              txtValorP4.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[3]["valor"]);
              dtP05.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[4]["dtvencimento"]);
              txtValorP5.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[4]["valor"]);
              dtP06.Value = Convert.ToDateTime(parcela.Ds.Tables["venda_parcela"].Rows[5]["dtvencimento"]);
              txtValorP6.Text = Convert.ToString(parcela.Ds.Tables["venda_parcela"].Rows[5]["valor"]);
              break;
          }
          lblTotalParcelas.Text = lblTotalVenda.Text;
          lblTotalItens2.Text = lblTotalVenda.Text;
          //lblTotalParcelas.Text = lblTotalItens2.Text;
        }
        else
        {
          cbxParcelas.Text = "01";
          lblTotalParcelas.Text = "0,00";
          this.LimparParcelas();
        }
      }
      else
      {
        this.LimparParcelas();
        gpbParcela.Enabled = false;
        btnFinalizarVenda.Enabled = false;
        btnCalculadora.Enabled = false;
        btnEmitirRelatorio.Enabled = false;
      }
    }

    private void txtValorP1_Leave(object sender, EventArgs e)
    {
      this.CalcularTotalParcelas(cbxParcelas.Text);
      decimal val = Convert.ToDecimal(txtValorP1.Text);
      txtValorP1.Text = val.ToString("0.00");
    }

    private void txtValorP2_Leave(object sender, EventArgs e)
    {
      this.CalcularTotalParcelas(cbxParcelas.Text);
      decimal val = Convert.ToDecimal(txtValorP2.Text);
      txtValorP2.Text = val.ToString("0.00");
    }

    private void txtValorP3_Leave(object sender, EventArgs e)
    {
      this.CalcularTotalParcelas(cbxParcelas.Text);
      decimal val = Convert.ToDecimal(txtValorP3.Text);
      txtValorP3.Text = val.ToString("0.00");
    }

    private void txtValorP4_Leave(object sender, EventArgs e)
    {
      this.CalcularTotalParcelas(cbxParcelas.Text);
      decimal val = Convert.ToDecimal(txtValorP4.Text);
      txtValorP4.Text = val.ToString("0.00");
    }

    private void txtValorP5_Leave(object sender, EventArgs e)
    {
      this.CalcularTotalParcelas(cbxParcelas.Text);
      decimal val = Convert.ToDecimal(txtValorP5.Text);
      txtValorP5.Text = val.ToString("0.00");
    }

    private void txtValorP6_Leave(object sender, EventArgs e)
    {
      this.CalcularTotalParcelas(cbxParcelas.Text);
      decimal val = Convert.ToDecimal(txtValorP6.Text);
      txtValorP6.Text = val.ToString("0.00");
    }

    private void nudPrazo_ValueChanged(object sender, EventArgs e)
    {
      decimal totalParc = Convert.ToDecimal(lblTotalItens.Text);
      this.LimparParcelas();
      this.HabiDesaParcelas(true, cbxParcelas.Text, totalParc, Convert.ToInt32(nudPrazo.Value));
    }

    private void nudPrazo_Enter(object sender, EventArgs e)
    {
      nudPrazo.Select();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("calc"); 
    }

    private void btnFinalizarVenda_Click(object sender, EventArgs e)
    {
      if (lblTotalItens.Text == lblTotalParcelas.Text)
      {
        DialogResult res = MessageBox.Show("Confirma a finalização da venda?", "Finalizar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
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
            Venda venda = new Venda();
            venda.IdVenda = Convert.ToInt32(txtNumVenda.Text);
            venda.FinalizarVenda();
            lblEstado.Text = "FINALIZADA";
          }
          catch (Exception ex2)
          {            
            throw ex2;
          }
          try
          {
            Parcela parcela = new Parcela();
            parcela.IdVenda = Convert.ToInt32(txtNumVenda.Text);
            parcela.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
            parcela.Prazo = Convert.ToInt32(nudPrazo.Value);
            parcela.Estado = "ABERTA";
            parcela.Obs = "";
            switch (cbxParcelas.Text)
            {
              case "01":
                parcela.IdParcela = 1;
                parcela.DataVencimento = dtP01.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP1.Text);
                parcela.InserirParcela();
                break;
              case "02":
                parcela.IdParcela = 1;
                parcela.DataVencimento = dtP01.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP1.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 2;
                parcela.DataVencimento = dtP02.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP2.Text);
                parcela.InserirParcela();
                break;
              case "03":
                parcela.IdParcela = 1;
                parcela.DataVencimento = dtP01.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP1.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 2;
                parcela.DataVencimento = dtP02.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP2.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 3;
                parcela.DataVencimento = dtP03.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP3.Text);
                parcela.InserirParcela();
                break;
              case "04":
                parcela.IdParcela = 1;
                parcela.DataVencimento = dtP01.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP1.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 2;
                parcela.DataVencimento = dtP02.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP2.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 3;
                parcela.DataVencimento = dtP03.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP3.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 4;
                parcela.DataVencimento = dtP04.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP4.Text);
                parcela.InserirParcela();
                break;
              case "05":
                parcela.IdParcela = 1;
                parcela.DataVencimento = dtP01.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP1.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 2;
                parcela.DataVencimento = dtP02.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP2.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 3;
                parcela.DataVencimento = dtP03.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP3.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 4;
                parcela.DataVencimento = dtP04.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP4.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 5;
                parcela.DataVencimento = dtP05.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP5.Text);
                parcela.InserirParcela();
                break;
              case "06":
                parcela.IdParcela = 1;
                parcela.DataVencimento = dtP01.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP1.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 2;
                parcela.DataVencimento = dtP02.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP2.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 3;
                parcela.DataVencimento = dtP03.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP3.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 4;
                parcela.DataVencimento = dtP04.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP4.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 5;
                parcela.DataVencimento = dtP05.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP5.Text);
                parcela.InserirParcela();
                parcela.IdParcela = 6;
                parcela.DataVencimento = dtP06.Value;
                parcela.ValorParcela = Convert.ToDecimal(txtValorP6.Text);
                parcela.InserirParcela();
                break;
            }
          }
          catch (Exception ex3)
          {
            throw ex3;
          }
          btnEmitirRelatorio.Enabled = true;
          tabControl1.SelectedTab = tabPageVenda;
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.LimparParcelas();
          cbxParcelas.Text = "01";
          lblTotalParcelas.Text = "0,00";
          this.CancelButton = butSair;

          //Imprime a Venda
          //----------------------------------------------------
          DialogResult res2 = MessageBox.Show("Venda finalizada com sucesso!\nDeseja Emitir a Relação de Produtos da Venda?", "Venda Finalizada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (res2 == DialogResult.Yes)
          {
            FormRelVenda rel = new FormRelVenda();
            rel.MdiParent = this.ParentForm;
            rel.idvenda = Convert.ToInt32(txtNumVenda.Text);
            rel.Show();
          }
        }
      }
      else
      {
        MessageBox.Show("Total das parcelas não confere com o total da compra!\nVerifique os valores.", "Aviso");
      }
    }

    private void lblTotalParcelas_TextChanged(object sender, EventArgs e)
    {
      if (lblEstado.Text == "ABERTA")
      {
        if (lblTotalItens2.Text == lblTotalParcelas.Text)
        {
          btnFinalizarVenda.Enabled = true;
        }
        else
        {
          btnFinalizarVenda.Enabled = false;
        } 
      }
    }

    private void btnConsGeral_Click(object sender, EventArgs e)
    {
      FormGridVenda grid = new FormGridVenda(this);
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void radPessoaJuridica_CheckedChanged(object sender, EventArgs e)
    {
      labNome.Text = "Razão Social:";
      labNome.Location = new Point(5, 53);
      labApelidoNFantasia.Text = "N. Fantasia:";
      labApelidoNFantasia.Location = new Point(10, 80);
      labRgIe.Text = "IE:";
      labRgIe.Location = new Point(450, 80);
      labCpfCnpj.Text = "CNPJ:";
      labCpfCnpj.Location = new Point(256, 80);
      tbCpfCnpj.Mask = "00,000,000/0000-00";
      tbRgIe.MaxLength = 15;
    }

    private void radPessoaFisica_CheckedChanged(object sender, EventArgs e)
    {
      labNome.Text = "Nome:";
      labNome.Location = new Point(38, 53);
      labApelidoNFantasia.Text = "Apelido:";
      labApelidoNFantasia.Location = new Point(30, 80);
      labRgIe.Text = "RG:";
      labRgIe.Location = new Point(446, 80);
      labCpfCnpj.Text = "CPF:";
      labCpfCnpj.Location = new Point(261, 80);
      tbCpfCnpj.Mask = "000,000,000-00";
      tbRgIe.MaxLength = 12;
    }

    private void butConsultar_Click(object sender, EventArgs e)
    {
      if (txtNumVenda.Text.Length != 0)
      {
        venda = new Venda();
        venda.IdVenda = Convert.ToInt32(txtNumVenda.Text);
        venda.ConsultaVenda();
        if (venda.Estado != null)
        {
          lblEstado.Text = venda.Estado;
          lblVendedor.Text = venda.Vendedor;
          lblTotalVenda.Text = venda.TotalVenda.ToString("0.00");
          lblTotalItens.Text = venda.TotalVenda.ToString("0.00");
          if (venda.IdCliente != 0)
          {
            txtCodigoCliente.Text = Convert.ToString(venda.IdCliente);
            Cliente cli = new Cliente();
            PessoaFisica cliPf = new PessoaFisica();
            PessoaJuridica cliPj = new PessoaJuridica();
            cli.IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
            cli.LocalizaCliente();
            if (cli.Cnpj == "")
            {
              cliPf.Cpf = cli.Cpf;
              cliPf.ConsultarRegistro();
              radPessoaFisica.Checked = true;
              tbApelido.Text = cliPf.Apelido;
              tbCpfCnpj.Text = cliPf.Cpf;
              tbEmail.Text = cli.Email;
              tbNome.Text = cliPf.Nome;
              tbRgIe.Text = cliPf.Rg;
              tbTelefone1.Text = cli.Telefone1;
              tbTelefone2.Text = cli.Telefone2;
              cbxSituacao.Text = cli.Situacao;
            }
            else if (cli.Cpf == "")
            {
              cliPj.Cnpj = cli.Cnpj;
              cliPj.ConsultarRegistro();
              radPessoaJuridica.Checked = true;
              tbCpfCnpj.Text = cliPj.Cnpj;
              tbEmail.Text = cli.Email;
              tbNome.Text = cliPj.Razaosocial;
              tbApelido.Text = cliPj.Nomefantasia;
              tbRgIe.Text = cliPj.Ie;
              tbTelefone1.Text = cli.Telefone1;
              tbTelefone2.Text = cli.Telefone2;
              cbxSituacao.Text = cli.Situacao;
            }
          }
          else
          {
            this.LimparCamposCliente();
          }
          dtVenda.Value = venda.DataVenda;
          txtObservacao.Text = venda.Observacao;
          idVendaAtual = venda.IdVenda;
          butNovo.Focus();
        }
        else
        {
          idVendaAtual = 0;
          this.LimparCampos();
          this.LimparCamposCliente();
          txtNumVenda.Focus();
        }
      }
      else
      {
        FormGridVenda grid = new FormGridVenda(this);
        grid.MdiParent = this.ParentForm;
        grid.Show();
      }
    }

    private void btnEmitirRelatorio_Click(object sender, EventArgs e)
    {
      FormRelVenda rel = new FormRelVenda();
      rel.MdiParent = this.ParentForm;
      rel.idvenda = Convert.ToInt32(txtNumVenda.Text);
      rel.Show();
    }

    private void txtNumVenda_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtValorP1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }    
  }
}
