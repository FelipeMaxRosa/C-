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
  public partial class FormTipoVenda : Form
  {
    FormCadClientes cadCli = null;
    public FormTipoVenda(FormCadClientes frm)
    {
      InitializeComponent();
      cadCli = frm;

    }

    private void btnAP_Click(object sender, EventArgs e)
    {
      FormVendas frmv = new FormVendas((FormPrincipal)cadCli.ParentForm);
      frmv.UsuarioAtual = cadCli.frmp.lblUsuario.Text;
      frmv.Show();
      frmv.butNovo.PerformClick();
      frmv.txtCodigoCliente.Text = cadCli.tbCodigoCliente.Text;
      frmv.txtCodigoCliente.Focus();
      frmv.txtObservacao.Focus();
      //cadCli.Dispose();
      this.Dispose();      
    }

    private void btnAV_Click(object sender, EventArgs e)
    {
      FormVendaSimples frmVenAv = new FormVendaSimples((FormPrincipal)cadCli.ParentForm);
      frmVenAv.lblTotalVenda.Text = "0,00";
      frmVenAv.dtVenda.Value = DateTime.Now;
      Venda venda = new Venda();
      venda.RetornaIdVenda();
      frmVenAv.Show();
      frmVenAv.txtNumVenda.Text = Convert.ToString(venda.IdVenda);
      frmVenAv.dtVenda.Focus();
      frmVenAv.chkClienteCadastrado.Checked = true;
      frmVenAv.txtCodigoCliente.Text = cadCli.tbCodigoCliente.Text;
      frmVenAv.lblNomeCliente.Text = cadCli.tbNome.Text;
      frmVenAv.txtCodProduto.Focus();
      //cadCli.Dispose();
      this.Dispose();      
    }
  }
}
