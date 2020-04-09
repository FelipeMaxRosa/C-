using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using System.Threading;

namespace lojadalala
{
  
  public partial class FormPrincipal : Form
  {
    //Atributos
    FormCadClientes  frmCli = null;
    FormCadFornecedores frmForn = null;
    FormCadFuncao frmFuncao = null;
    FormCadFuncionarios frmFunc = null;
    FormCadProdutos frmProd = null;
    FormCadServicos frmServ = null;
    FormCadUsuarios frmUsu = null;
    FormCadFinalizadoras frmFin = null;
    FormAjuEstoque frmAju = null;
    FormVendas frmVen = null;
    FormVendaSimples frmVenAv = null;
    FormGridVenda gridVen = null;
    FormCaixa frmCaixa = null;
    FormAberturaCaixa frmAbe = null;
    FormFechamentoCaixa frmFec = null;
    FormGridCaixas gridCaixas = null;
    private int ibkp = 0;

    //Construtor
    public FormPrincipal()
    {
      InitializeComponent();
    }
    
    //Metodos Eventos
    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadClientes)
        {
          frm.BringToFront();
          open = true; 
        }
      }
      if (!open)
      {
        frmCli = new FormCadClientes(this);
        frmCli.Show();
      } 
    }

    private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFornecedores)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmForn = new FormCadFornecedores(this);
        frmForn.Show();
      } 
    }

    private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadProdutos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmProd = new FormCadProdutos(this);
        frmProd.Show();
      } 
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadClientes)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmCli = new FormCadClientes(this);
        frmCli.Show();
      } 
    }

    private void tsbtnFornecedores_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFornecedores)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmForn = new FormCadFornecedores(this);
        frmForn.Show();
      } 
    }

    private void tsbtnProdutos_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadProdutos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmProd = new FormCadProdutos(this);
        frmProd.Show();
      }
    }

    private void mecânicosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFuncionarios)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmFunc = new FormCadFuncionarios(this);
        frmFunc.Show();
      }
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente encerrar o aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      e.Cancel = (res == DialogResult.No);
    }

    private void cargosEFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFuncao)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmFuncao = new FormCadFuncao(this);
        frmFuncao.Show();
      }
    }

    private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadUsuarios)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmUsu = new FormCadUsuarios(this);
        frmUsu.Show();
      }
    }

    private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadServicos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmServ = new FormCadServicos(this);
        frmServ.Show();
      }
    }

    private void tsbtnServicos_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadServicos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmServ = new FormCadServicos(this);
        frmServ.Show();
      }
    }

    private void finalizadorasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadFinalizadoras)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmFin = new FormCadFinalizadoras(this);
        frmFin.Show();
      }
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormVendaSimples)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmVenAv = new FormVendaSimples(this);
        frmVenAv.lblTotalVenda.Text = "0,00";
        frmVenAv.dtVenda.Value = DateTime.Now;
        Venda venda = new Venda();
        venda.RetornaIdVenda();
        frmVenAv.txtNumVenda.Text = Convert.ToString(venda.IdVenda);
        frmVenAv.dtVenda.Focus();
        frmVenAv.Show();
      }
    }

    private void executarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a execução do backup do Banco de Dados?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        BancoDados bd = new BancoDados();
        Thread t = new Thread(bd.Backup_Process);
        t.Start();
        timer1.Enabled = true;
        //timer1.Start();
      }
    }

    private void abrirLocalDeBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      BancoDados bd = new BancoDados();
      Process.Start("C:\\LojadaLala\\Backup");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      ibkp += 1;
      if (ibkp == 3)
      {
        BancoDados bd = new BancoDados();
        string velho = "C:\\LojadaLala\\Backup\\lojadalala.sql";
        string novo = "C:\\LojadaLala\\Backup\\" + bd.Backup_Nome() + ".sql";
        File.Move(velho, novo);
        ibkp = 0;
        //timer1.Enabled = false;        
        timer1.Dispose();
      }
    }

    private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormAjuEstoque)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmAju = new FormAjuEstoque(this);
        frmAju.Usuario = lblUsuario.Text;
        frmAju.Show();
      }
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormAjuEstoque)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmAju = new FormAjuEstoque(this);
        frmAju.Usuario = lblUsuario.Text;
        frmAju.Show();
      }
    }

    private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }

    private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormVendaSimples)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmVenAv = new FormVendaSimples(this);
        frmVenAv.lblTotalVenda.Text = "0,00";
        frmVenAv.dtVenda.Value = DateTime.Now;
        Venda venda = new Venda();
        venda.RetornaIdVenda();
        frmVenAv.txtNumVenda.Text = Convert.ToString(venda.IdVenda);
        frmVenAv.dtVenda.Focus();
        frmVenAv.Show();
      }
    }

    private void aPrazoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormVendas)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmVen = new FormVendas(this);
        frmVen.txtNumVenda.Select();
        frmVen.Show();
      }
    }

    private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F3)
      {
        bool open = false;
        foreach (Form frm in this.MdiChildren)
        {
          if (frm is FormVendaSimples)
          {
            frm.BringToFront();
            open = true;
          }
        }
        if (!open)
        {
          frmVenAv = new FormVendaSimples(this);
          frmVenAv.lblTotalVenda.Text = "0,00";
          frmVenAv.dtVenda.Value = DateTime.Now;
          Venda venda = new Venda();
          venda.RetornaIdVenda();
          frmVenAv.txtNumVenda.Text = Convert.ToString(venda.IdVenda);
          frmVenAv.dtVenda.Focus();
          frmVenAv.Show();
        }
      }
    }

    private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormGridVenda)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        gridVen = new FormGridVenda(this);
        gridVen.Show();
      }
    }

    private void atualToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCaixa)
        {
          frm.BringToFront();
          open = true;
        }
      }

      Caixa caixa = new Caixa();
      caixa.ConsultaNumeroDeCaixasEmAberto();
      caixa.ConsultaCaixaAberto();
      if (caixa.NumCaixasAbertos == 0)
      {
        MessageBox.Show("Não existe Caixa Aberto!\nÉ necessário realizar a Abertura de Caixa.", "Caixa Atual", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        if (caixa.Data.Date == DateTime.Now.Date)
	      {
          if (!open)
          {
            frmCaixa = new FormCaixa(this);
            frmCaixa.dtCaixa.Value = caixa.Data;
            frmCaixa.txtIdCaixa.Text = caixa.IdCaixa.ToString();
            frmCaixa.lblEstado.Text = caixa.Estado;
            frmCaixa.lblFundo.Text = caixa.Valorinicial.ToString("0.00");
            frmCaixa.lblSaldoCaixa.Text = caixa.Saldo.ToString("0.00");
            frmCaixa.Show();
          }
	      }   
        else
        {
         // MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString() + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
          MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString("dd/MM/yyyy") + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      
    }

    private void aberturaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormAberturaCaixa)
        {
          frm.BringToFront();
          open = true;
        }
      }

      Caixa caixa = new Caixa();
      caixa.ConsultaNumeroDeCaixasEmAberto();
      caixa.ConsultaCaixaAberto();
      if (caixa.NumCaixasAbertos == 0)
      {
        if (!open)
        {
          frmAbe = new FormAberturaCaixa(this);
          frmAbe.Show();
        }
      }
      else
      {
        //MessageBox.Show("Existem Caixas Abertos\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString("dd/MM/yyyy") + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormFechamentoCaixa)
        {
          frm.BringToFront();
          open = true;
        }
      }

      Caixa caixa = new Caixa();
      caixa.ConsultaNumeroDeCaixasEmAberto();
      caixa.ConsultaCaixaAberto();
      if (caixa.NumCaixasAbertos == 0)
      {
        MessageBox.Show("Não existem Caixas Abertos para realizar o Fechamento!", "Fechamento de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        //MessageBox.Show("Existem Caixas Abertos\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        if (!open)
        {
          frmFec = new FormFechamentoCaixa(this);
          frmFec.Show();
        }
      }
    }

    private void toolStripButton6_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCaixa)
        {
          frm.BringToFront();
          open = true;
        }
      }

      Caixa caixa = new Caixa();
      caixa.ConsultaNumeroDeCaixasEmAberto();
      caixa.ConsultaCaixaAberto();
      if (caixa.NumCaixasAbertos == 0)
      {
        MessageBox.Show("Não existe Caixa Aberto!\nÉ necessário realizar a Abertura de Caixa.", "Caixa Atual", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        if (caixa.Data.Date == DateTime.Now.Date)
        {
          if (!open)
          {
            frmCaixa = new FormCaixa(this);
            frmCaixa.dtCaixa.Value = caixa.Data;
            frmCaixa.txtIdCaixa.Text = caixa.IdCaixa.ToString();
            frmCaixa.lblEstado.Text = caixa.Estado;
            frmCaixa.lblFundo.Text = caixa.Valorinicial.ToString("0.00");
            frmCaixa.lblSaldoCaixa.Text = caixa.Saldo.ToString("0.00");
            frmCaixa.Show();
          }
        }
        else
        {
          // MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString() + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
          MessageBox.Show("Existem Caixas Abertos do dia: " + caixa.Data.Date.ToString("dd/MM/yyyy") + "\nÉ necessário realizar o Fechamento de Caixa!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void porPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormGridCaixas)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        gridCaixas = new FormGridCaixas(this);
        gridCaixas.Show();
      }
    }

    private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AboutCrediario about = new AboutCrediario(this);
      about.Show();
    }
  }
}
