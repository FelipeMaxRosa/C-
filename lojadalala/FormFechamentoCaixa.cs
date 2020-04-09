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
  public partial class FormFechamentoCaixa : Form
  {
    //Atributos
    //--------------------------------------------------------------------
    private DataSet ds;
    private BancoDados bd;

    //Construtor
    //--------------------------------------------------------------------
    public FormFechamentoCaixa(FormPrincipal parent)
    {
      InitializeComponent();
      bd = new BancoDados();
      this.MdiParent = parent;
    }

    //Metodos 
    //--------------------------------------------------------------------
    private void FormFechamentoCaixa_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM caixa WHERE estado = 'ABERTO' ORDER BY idcaixa ";
      string tabela = "caixa";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      dataGridView1.DataSource = ds.Tables[tabela];
    }

    private void btnFecharCaixa_Click(object sender, EventArgs e)
    {
      DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
      int i = linhaAtual.Index;
      DateTime data = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dataatual"].Value);

      DialogResult res = MessageBox.Show("Confirma o Fechamento do Caixa do Dia: " + data.Date.ToString("dd/MM/yyyy") + " ?", "Fechamento de Caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Caixa caixa = new Caixa();
        caixa.IdCaixa = Convert.ToInt32(dataGridView1.Rows[i].Cells["idcaixa"].Value);
        caixa.FechamentoDeCaixa();
        this.Close();
      }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnFecharCaixa.PerformClick();
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      btnFecharCaixa.PerformClick();
    }
    
  }
}
