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
  public partial class FormGridVenda : Form
  {
    //Atributos
    //---------------------------------------------------------------------
    private BancoDados bd;
    private DataSet ds;
    private FormVendas frmven;
    private FormPrincipal parent;

    //Construtor
    //---------------------------------------------------------------------
    public FormGridVenda(object frm1)
    {
      InitializeComponent();
      bd = new BancoDados();
      if (frm1 is FormVendas)
      {
        frmven = (FormVendas)frm1;  
      }
      else if (frm1 is FormPrincipal)
      {
        this.MdiParent = (FormPrincipal)frm1;
        parent = (FormPrincipal)frm1;
      }
      cbxSituacao.Text = "ABERTA";
      dtFim.Value = DateTime.Now;
      dtInicio.Value = DateTime.Now;
      txtNumeroVenda.Focus();
    }

    //Metodos Eventos
    //---------------------------------------------------------------------
    private void FormGridVenda_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM venda WHERE estado = 'FINALIZADA' ORDER BY idvenda DESC";
      string tabela = "venda";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["venda"];
      txtNumeroVenda.Select();
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      if (frmven != null)
      {
        frmven.txtNumVenda.Focus();
      }
      this.Close();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
        
      }
      else
      {
        if (frmven != null)
        {
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value);
          frmven.txtNumVenda.Text = dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value.ToString();
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value);
          frmven.dtVenda.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["datavenda"].Value);
          frmven.lblEstado.Text = dataGridView1.Rows[e.RowIndex].Cells["estado"].Value.ToString();
          frmven.lblVendedor.Text = dataGridView1.Rows[e.RowIndex].Cells["vendedor"].Value.ToString();
          frmven.lblTotalVenda.Text = dataGridView1.Rows[e.RowIndex].Cells["total"].Value.ToString();
          frmven.txtCodigoCliente.Text = dataGridView1.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
          frmven.txtObservacao.Text = dataGridView1.Rows[e.RowIndex].Cells["obs"].Value.ToString();
          frmven.txtCodigoCliente.Focus();
          frmven.txtNumVenda.Focus();
          frmven.butNovo.Focus();
          this.Dispose();
        }
        else if (parent != null)
        {
          frmven = new FormVendas(parent);
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value);
          frmven.txtNumVenda.Text = dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value.ToString();
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idvenda"].Value);
          frmven.dtVenda.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["datavenda"].Value);
          frmven.lblEstado.Text = dataGridView1.Rows[e.RowIndex].Cells["estado"].Value.ToString();
          frmven.lblVendedor.Text = dataGridView1.Rows[e.RowIndex].Cells["vendedor"].Value.ToString();
          frmven.lblTotalVenda.Text = dataGridView1.Rows[e.RowIndex].Cells["total"].Value.ToString();
          frmven.txtCodigoCliente.Text = dataGridView1.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
          frmven.txtObservacao.Text = dataGridView1.Rows[e.RowIndex].Cells["obs"].Value.ToString();
          frmven.Show();
          frmven.txtCodigoCliente.Focus();
          frmven.txtNumVenda.Focus();
          frmven.butNovo.Focus();
          this.Dispose();
        }
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (radNumero.Checked)
      {
        bool encontrado = false;
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          if (dataGridView1.Rows[i].Cells["idvenda"].Value.ToString().Contains(txtNumeroVenda.Text))
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
          txtNumeroVenda.Focus();
          txtNumeroVenda.SelectAll();
        }
      }
      else if (radCliente.Checked)
      {
        string SQL = "";
        if (cbxSituacao.Text == "TODAS")
        {
          SQL = "SELECT * FROM venda WHERE idcliente = '" + txtCodigoCliente.Text + "' ORDER BY idvenda ";
        }
        else
        {
          SQL = "SELECT * FROM venda WHERE estado = '" + cbxSituacao.Text + "' AND idcliente = '" + txtCodigoCliente.Text + "'ORDER BY idvenda ";
        }
        string tabela = "venda";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, tabela);
        dataGridView1.DataSource = ds.Tables["venda"];
        radNumero.Checked = true;
        txtNumeroVenda.Focus();
      }
      else if (radPeriodo.Checked)
      {
        string SQL = "";
        if (cbxSituacao.Text == "TODAS")
        {
          SQL = "SELECT * FROM venda WHERE datavenda BETWEEN '" + dtInicio.Value.Year + "-" + dtInicio.Value.Month + "-" + dtInicio.Value.Day + "' AND '" + dtFim.Value.Year + "-" + dtFim.Value.Month + "-" + dtFim.Value.Day + "' ORDER BY idvenda";
        }
        else
        {
          SQL = "SELECT * FROM venda WHERE estado = '" + cbxSituacao.Text + "' AND datavenda BETWEEN '" + dtInicio.Value.Year + "-" + dtInicio.Value.Month + "-" + dtInicio.Value.Day + "' AND '" + dtFim.Value.Year + "-" + dtFim.Value.Month + "-" + dtFim.Value.Day + "' ORDER BY idvenda";
        }
        string tabela = "venda";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, tabela);
        dataGridView1.DataSource = ds.Tables["venda"];
        radNumero.Checked = true;
        txtNumeroVenda.Focus();
      }
    }

    private void cbxSituacao_DropDownClosed(object sender, EventArgs e)
    {
      txtCodigoCliente.Clear();
      txtCodigoCliente.ReadOnly = true;
      txtCodigoCliente.TabStop = false;
      lblNomeCliente.Text = "";
      string SQL = "";
      if (cbxSituacao.Text == "TODAS")
      {
        SQL = "SELECT * FROM venda ORDER BY idvenda DESC";
      }
      else
      {
        SQL = "SELECT * FROM venda WHERE estado = '" + cbxSituacao.Text + "' ORDER BY idvenda DESC";
      }
      string tabela = "venda";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables["venda"];
      radNumero.Checked = true;
      txtNumeroVenda.Focus();
    }

    private void radNumero_CheckedChanged(object sender, EventArgs e)
    {
      if (radNumero.Checked == true)
      {
        //txtCodigoCliente.Clear();
        txtCodigoCliente.ReadOnly = true;
        txtCodigoCliente.TabStop = false;
        //lblNomeCliente.Text = "";
        btnConsCliente.Enabled = false;
        dtFim.Enabled = false;
        dtFim.TabStop = false;
        dtInicio.Enabled = false;
        dtInicio.TabStop = false;
        txtNumeroVenda.ReadOnly = false;
        txtNumeroVenda.TabStop = true;
        txtNumeroVenda.Focus();
        this.AcceptButton = btnPesquisar;
      }
    }

    private void radCliente_CheckedChanged(object sender, EventArgs e)
    {
      if (radCliente.Checked == true)
      {
        txtCodigoCliente.Clear();
        txtCodigoCliente.ReadOnly = false;
        txtCodigoCliente.TabStop = true;
        lblNomeCliente.Text = "";
        btnConsCliente.Enabled = true;
        dtFim.Enabled = false;
        dtFim.TabStop = false;
        dtInicio.Enabled = false;
        dtInicio.TabStop = false;
        txtNumeroVenda.Clear();
        txtNumeroVenda.ReadOnly = true;
        txtNumeroVenda.TabStop = false;
        txtCodigoCliente.Focus();
        this.AcceptButton = null;
      }
    }

    private void radPeriodo_CheckedChanged(object sender, EventArgs e)
    {
      if (radPeriodo.Checked == true)
      {
        txtCodigoCliente.Clear();
        txtCodigoCliente.ReadOnly = true;
        txtCodigoCliente.TabStop = false;
        lblNomeCliente.Text = "";
        btnConsCliente.Enabled = false;
        dtFim.Enabled = true;
        dtFim.TabStop = true;
        dtInicio.Enabled = true;
        dtInicio.TabStop = true;
        txtNumeroVenda.Clear();
        txtNumeroVenda.ReadOnly = true;
        txtNumeroVenda.TabStop = false;
        dtInicio.Focus();
        this.AcceptButton = null;
      }
    }

    private void btnConsCliente_Click(object sender, EventArgs e)
    {
      FormGridClientes grid = new FormGridClientes(this, "consulta_venda");
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
          //cbxSituacao.Focus();
          btnPesquisar.Focus();
        }
        else if (cli.Cpf == "")
        {
          cliPj.Cnpj = cli.Cnpj;
          cliPj.ConsultarRegistro();
          lblNomeCliente.Text = cliPj.Razaosocial;
          //cbxSituacao.Focus();
          btnPesquisar.Focus();
        }
        else
        {
          lblNomeCliente.Text = "";
          txtCodigoCliente.Clear();
          txtCodigoCliente.Focus();          
        }
      }
      else
      {
        lblNomeCliente.Text = "";
      }
    }

    private void FormGridVenda_KeyDown(object sender, KeyEventArgs e)
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

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e) 
    {
      if (e.KeyCode == Keys.Enter)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        if (frmven != null)
        {
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[i].Cells["idvenda"].Value);
          frmven.txtNumVenda.Text = dataGridView1.Rows[i].Cells["idvenda"].Value.ToString();
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[i].Cells["idvenda"].Value);
          frmven.dtVenda.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["datavenda"].Value);
          frmven.lblEstado.Text = dataGridView1.Rows[i].Cells["estado"].Value.ToString();
          frmven.lblVendedor.Text = dataGridView1.Rows[i].Cells["vendedor"].Value.ToString();
          frmven.lblTotalVenda.Text = dataGridView1.Rows[i].Cells["total"].Value.ToString();
          frmven.txtCodigoCliente.Text = dataGridView1.Rows[i].Cells["idcliente"].Value.ToString();
          frmven.txtObservacao.Text = dataGridView1.Rows[i].Cells["obs"].Value.ToString();
          frmven.txtCodigoCliente.Focus();
          frmven.txtNumVenda.Focus();
          frmven.butNovo.Focus();
          this.Dispose();
        }
        else if (parent != null)
        {
          frmven = new FormVendas(parent);
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[i].Cells["idvenda"].Value);
          frmven.txtNumVenda.Text = dataGridView1.Rows[i].Cells["idvenda"].Value.ToString();
          frmven.idVendaAtual = Convert.ToInt32(dataGridView1.Rows[i].Cells["idvenda"].Value);
          frmven.dtVenda.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["datavenda"].Value);
          frmven.lblEstado.Text = dataGridView1.Rows[i].Cells["estado"].Value.ToString();
          frmven.lblVendedor.Text = dataGridView1.Rows[i].Cells["vendedor"].Value.ToString();
          frmven.lblTotalVenda.Text = dataGridView1.Rows[i].Cells["total"].Value.ToString();
          frmven.txtCodigoCliente.Text = dataGridView1.Rows[i].Cells["idcliente"].Value.ToString();
          frmven.txtObservacao.Text = dataGridView1.Rows[i].Cells["obs"].Value.ToString();
          frmven.Show();
          frmven.txtCodigoCliente.Focus();
          frmven.txtNumVenda.Focus();
          frmven.butNovo.Focus();
          this.Dispose();
        }
      }
      else if (e.KeyCode == Keys.Escape)
      {
        this.CancelButton = butSair;
        radNumero.Checked = true;
        txtNumeroVenda.Clear();
        txtNumeroVenda.Focus();
      }
      else if (e.KeyCode == Keys.F6)
      {
        DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
        int i = linhaAtual.Index;
        FormGridItensVenda gridItens = new FormGridItensVenda();
        gridItens.idvenda = Convert.ToInt32(dataGridView1.Rows[i].Cells["idvenda"].Value);
        gridItens.Text = "Itens da Venda --> " + Convert.ToString(dataGridView1.Rows[i].Cells["idvenda"].Value);
        gridItens.MdiParent = this.ParentForm;
        gridItens.Show();
      }
    }

    private void txtNumeroVenda_KeyPress(object sender, KeyPressEventArgs e)
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
  }
}
