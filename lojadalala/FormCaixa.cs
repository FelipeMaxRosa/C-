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
  public partial class FormCaixa : Form
  {
    //Atributos
    //-----------------------------------------------------------------------------
    private DataSet ds_entrada;
    private DataSet ds_saida;
    private BancoDados bd;
    //Construtor
    //-----------------------------------------------------------------------------
    public FormCaixa(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      bd = new BancoDados();
    }

    //Metodos Gerais
    //-----------------------------------------------------------------------------
    public void CalcularTotalEntradas()
    {
      decimal entradas = 0.00M;
      if (dataGridView1.RowCount > 0)
      {        
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          entradas += Convert.ToDecimal(dataGridView1.Rows[i].Cells["valor"].Value);
        }
        lblTotalEntradas.Text = entradas.ToString("0.00");
      }
    }

    public void CalcularTotalSaidas()
    {
      decimal saidas = 0.00M;
      if (dataGridView2.RowCount > 0)
      {
        for (int i = 0; i < dataGridView2.RowCount; i++)
        {
          saidas += Convert.ToDecimal(dataGridView2.Rows[i].Cells["valorsaida"].Value);
        }
      }
      lblTotalSaidas.Text = saidas.ToString("0.00");
    }

    //Metodos Eventos
    //-----------------------------------------------------------------------------
    private void button1_Click(object sender, EventArgs e)
    {
      Caixa caixa = new Caixa();
      caixa.ConsultaNumeroDeCaixasEmAberto();
      //MessageBox.Show("Ultimo valor final: " + caixa.NumCaixasAbertos.ToString("0.00"), "Teste");
      MessageBox.Show("Numero de caixas em aberto: " + caixa.NumCaixasAbertos.ToString(), "Teste");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Caixa caixa = new Caixa();
      caixa.Data = dtCaixa.Value;
      caixa.RetornaUltimoValorFinal();
      caixa.Valorinicial = caixa.Valorfinal;
      caixa.AberturaDeCaixa();
    }

    private void FormCaixa_Load(object sender, EventArgs e)
    {
      //Carrega Grid de Entradas
      //-------------------------------------------------------------------------
      string SQL = "SELECT * FROM caixa_entrada WHERE idcaixa = '" + txtIdCaixa.Text + "' ORDER BY identrada DESC";
      string tabela_entrada = "caixa_entrada";
      ds_entrada = new DataSet();
      ds_entrada = bd.ConsultarParaGrid(SQL, tabela_entrada);
      dataGridView1.DataSource = ds_entrada.Tables[tabela_entrada];

      //Carrega Grid de Entradas
      //-------------------------------------------------------------------------
      string SQL2 = "SELECT * FROM caixa_saida WHERE idcaixa = '" + txtIdCaixa.Text + "' ORDER BY idsaida DESC";
      string tabela_saida = "caixa_saida";
      ds_saida = new DataSet();
      ds_saida = bd.ConsultarParaGrid(SQL2, tabela_saida);
      dataGridView2.DataSource = ds_saida.Tables[tabela_saida];

      this.CalcularTotalEntradas();
      this.CalcularTotalSaidas();
    }

    private void butSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnNovaEntrada_Click(object sender, EventArgs e)
    {
      FormCaixaLancamento lanc = new FormCaixaLancamento(this);
      FormPrincipal pri = (FormPrincipal)this.ParentForm;
      lanc.MdiParent = this.ParentForm;
      lanc.txtIdCaixa.Text = this.txtIdCaixa.Text;
      lanc.dtCaixa.Value = this.dtCaixa.Value;
      lanc.usuario = pri.lblUsuario.Text;
      int item = dataGridView1.RowCount + 1;
      lanc.Text = "Nova Entrada";
      lanc.iditem = item;
      lanc.entrada = true;
      lanc.Show();
    }

    private void btnNovaSaida_Click(object sender, EventArgs e)
    {
      FormCaixaLancamento lanc = new FormCaixaLancamento(this);
      FormPrincipal pri = (FormPrincipal)this.ParentForm;
      lanc.MdiParent = this.ParentForm;
      lanc.txtIdCaixa.Text = this.txtIdCaixa.Text;
      lanc.dtCaixa.Value = this.dtCaixa.Value;
      lanc.usuario = pri.lblUsuario.Text;
      int item = dataGridView2.RowCount + 1;
      lanc.Text = "Nova Saída";
      lanc.iditem = item;
      lanc.entrada = false;
      lanc.Show();
    }
  }
}
