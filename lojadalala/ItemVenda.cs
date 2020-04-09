using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lojadalala
{
  class ItemVenda
  {
    //Atributos
    //--------------------------------------------------------------------
    private int idItem;
    private int idVenda;
    private int idProduto;
    private decimal preco;
    private int qtde;
    private decimal desconto;
    private decimal total;
    private decimal totalgeral;
    private string estado;
    //--------------------------------------------------------------------
    private BancoDados bd;
    private MySqlCommand cmd;
    public DataSet ds;
    private DataTable dt;
    
    //Propriedades
    //--------------------------------------------------------------------
    public int IdItem
    {
      get { return idItem; }
      set { idItem = value; }
    }
    public int IdVenda
    {
      get { return idVenda; }
      set { idVenda = value; }
    }
    public int IdProduto
    {
      get { return idProduto; }
      set { idProduto = value; }
    }
    public decimal Preco
    {
      get { return preco; }
      set { preco = value; }
    }
    public int Qtde
    {
      get { return qtde; }
      set { qtde = value; }
    }
    public decimal Desconto
    {
      get { return desconto; }
      set { desconto = value; }
    }
    public decimal Total
    {
      get { return total; }
      set { total = value; }
    }
    public decimal Totalgeral
    {
      get { return totalgeral; }
      set { totalgeral = value; }
    }    
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }
    //Construtor
    //--------------------------------------------------------------------
    public ItemVenda()
    {
      bd = new BancoDados();
    }
    //Metodos Gerais
    //--------------------------------------------------------------------
    public void GerarNovoItem()
    {
      string SQL = "SELECT iditem FROM venda_item WHERE idvenda = ?idvenda ORDER BY iditem DESC LIMIT 1";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);

      idItem = bd.RetornaQtdeRegistros(cmd);
      idItem++;
    }

    public void InserirItem()
    {
      string SQL = "INSERT INTO venda_item VALUES (?iditem, ?idvenda, ?idproduto, ?preco, ?qtde, ?desconto, ?total, ?estado)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdi = new MySqlParameter("?iditem", idItem);
      cmd.Parameters.Add(pIdi);
      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);
      MySqlParameter pIdp = new MySqlParameter("?idproduto", idProduto);
      cmd.Parameters.Add(pIdp);
      MySqlParameter pPre = new MySqlParameter("?preco", preco);
      cmd.Parameters.Add(pPre);
      MySqlParameter pQtd = new MySqlParameter("?qtde", qtde);
      cmd.Parameters.Add(pQtd);
      MySqlParameter pDes = new MySqlParameter("?desconto", desconto);
      cmd.Parameters.Add(pDes);
      MySqlParameter pTot = new MySqlParameter("?total", total);
      cmd.Parameters.Add(pTot);
      MySqlParameter pEst = new MySqlParameter("?estado", estado);
      cmd.Parameters.Add(pEst);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void ConsultarParaGrid()
    {
      string SQL = "SELECT i.iditem, i.idproduto, p.descricao, i.qtde, i.preco, (i.preco*i.qtde)subtotal, i.desconto, i.total, i.estado FROM venda_item AS i INNER JOIN produtos AS p ON i.idproduto = p.id WHERE i.idvenda = '" + idVenda + "' ORDER BY i.iditem ASC";
      string tabela = "venda_item";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
      //dataGridView1.DataSource = ds.Tables["venda_item"];
    }

    public void LimparGrid()
    {
      string SQL = "SELECT i.iditem, i.idproduto, p.descricao, i.preco, i.qtde, (i.preco*i.qtde)subtotal, i.desconto, i.total, i.estado FROM venda_item AS i INNER JOIN produtos AS p ON i.idproduto = p.id WHERE i.idvenda = 0";
      string tabela = "venda_item";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
    }

    public void CalcularTotalGeral()
    {
      string SQL = "SELECT SUM(total) total FROM venda_item WHERE idvenda = '" + idVenda + "' AND estado = 'OK'";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      ds = new DataSet();
      ds = bd.ConsultarRegistro(SQL, "venda_item");
      if (ds.Tables[0].Rows[0]["total"] == DBNull.Value)
      {
        totalgeral = 0.00M;
      }
      else
      {
        totalgeral = Convert.ToDecimal(ds.Tables[0].Rows[0]["total"]);
      }
    }

    public void ExcluirItem()
    {
      string SQL = "UPDATE venda_item SET estado = 'CANCELADO' WHERE iditem = ?iditem AND idvenda = ?idvenda";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdi = new MySqlParameter("?iditem", idItem);
      cmd.Parameters.Add(pIdi);
      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);

      bd.ExcluirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

  }
}
