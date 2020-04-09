using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lojadalala
{
  class Parcela
  {
    //Atributos
    //--------------------------------------------------------
    private int idParcela;
    private int idVenda;
    private DateTime dataVencimento;
    private decimal valorParcela;
    private int prazo;
    private int idCliente;
    private int qtdeParcelas;
    private string estado;
    private string obs;
    private decimal juros;
    //--------------------------------------------------------
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    //Propriedades
    //--------------------------------------------------------
    public int IdParcela
    {
      get { return idParcela; }
      set { idParcela = value; }
    }
    public int IdVenda
    {
      get { return idVenda; }
      set { idVenda = value; }
    }
    public DateTime DataVencimento
    {
      get { return dataVencimento; }
      set { dataVencimento = value; }
    }
    public decimal ValorParcela
    {
      get { return valorParcela; }
      set { valorParcela = value; }
    }
    public int IdCliente
    {
      get { return idCliente; }
      set { idCliente = value; }
    }
    public int QtdeParcelas
    {
      get { return qtdeParcelas; }
      set { qtdeParcelas = value; }
    }
    public DataSet Ds
    {
      get { return ds; }
      set { ds = value; }
    }
    public int Prazo
    {
      get { return prazo; }
      set { prazo = value; }
    }
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }
    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }
    public decimal Juros
    {
      get { return juros; }
      set { juros = value; }
    }

    //Construtor
    //--------------------------------------------------------
    public Parcela()
    {
      bd = new BancoDados();
    }

    //Metodos Gerais
    //--------------------------------------------------------
    public void InserirParcela()
    {
      string SQL = "INSERT INTO venda_parcela VALUES (?idvenda, ?idparcela, ?dtvenc, ?valor, ?idcliente, ?prazo, ?estado, ?obs, '0.00')";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);
      MySqlParameter pIdp = new MySqlParameter("?idparcela", idParcela);
      cmd.Parameters.Add(pIdp);
      MySqlParameter pDtv = new MySqlParameter("?dtvenc", dataVencimento);
      cmd.Parameters.Add(pDtv);
      MySqlParameter pVal = new MySqlParameter("?valor", valorParcela);
      cmd.Parameters.Add(pVal);
      MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
      cmd.Parameters.Add(pIdc);
      MySqlParameter pPra = new MySqlParameter("?prazo", prazo);
      cmd.Parameters.Add(pPra);
      MySqlParameter pEst = new MySqlParameter("?estado", estado);
      cmd.Parameters.Add(pEst);
      MySqlParameter pObs = new MySqlParameter("?obs", obs);
      cmd.Parameters.Add(pObs);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void InserirParcelaAV(bool cliCad)
    {
      string SQL = "";
      if (cliCad)
      {
        SQL = "INSERT INTO venda_parcela VALUES (?idvenda, ?idparcela, ?dtvenc, ?valor, ?idcliente, ?prazo, ?estado, ?obs, '0.00')";
        cmd = new MySqlCommand();
        cmd.CommandText = SQL;
        MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
        cmd.Parameters.Add(pIdc);
        MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
        cmd.Parameters.Add(pIdv);
        MySqlParameter pIdp = new MySqlParameter("?idparcela", idParcela);
        cmd.Parameters.Add(pIdp);
        MySqlParameter pDtv = new MySqlParameter("?dtvenc", dataVencimento);
        cmd.Parameters.Add(pDtv);
        MySqlParameter pVal = new MySqlParameter("?valor", valorParcela);
        cmd.Parameters.Add(pVal);
        MySqlParameter pPra = new MySqlParameter("?prazo", prazo);
        cmd.Parameters.Add(pPra);
        MySqlParameter pEst = new MySqlParameter("?estado", estado);
        cmd.Parameters.Add(pEst);
        MySqlParameter pObs = new MySqlParameter("?obs", obs);
        cmd.Parameters.Add(pObs);
      }
      else
      {
        SQL = "INSERT INTO venda_parcela VALUES (?idvenda, ?idparcela, ?dtvenc, ?valor, ?idcliente, ?prazo, ?estado, ?obs, '0.00')";
        cmd = new MySqlCommand();
        cmd.CommandText = SQL;
        MySqlParameter pIdc = new MySqlParameter("?idcliente", DBNull.Value);
        cmd.Parameters.Add(pIdc);
        MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
        cmd.Parameters.Add(pIdv);
        MySqlParameter pIdp = new MySqlParameter("?idparcela", idParcela);
        cmd.Parameters.Add(pIdp);
        MySqlParameter pDtv = new MySqlParameter("?dtvenc", dataVencimento);
        cmd.Parameters.Add(pDtv);
        MySqlParameter pVal = new MySqlParameter("?valor", valorParcela);
        cmd.Parameters.Add(pVal);
        MySqlParameter pPra = new MySqlParameter("?prazo", prazo);
        cmd.Parameters.Add(pPra);
        MySqlParameter pEst = new MySqlParameter("?estado", estado);
        cmd.Parameters.Add(pEst);
        MySqlParameter pObs = new MySqlParameter("?obs", obs);
        cmd.Parameters.Add(pObs);
      }

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void ConsutarParcela()
    {
      string SQL = "";
      //SQL = "SELECT COUNT(*) FROM venda_parcela WHERE idvenda = ?idvenda AND idcliente = ?idcliente";
      SQL = "SELECT COUNT(*) FROM venda_parcela WHERE idvenda = ?idvenda";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);
      //MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
      //cmd.Parameters.Add(pIdc);
      qtdeParcelas = bd.RetornaQtdeRegistros(cmd);

      //SQL = "SELECT * FROM venda_parcela WHERE idvenda = '" + idVenda.ToString() + "' AND idcliente = '" + idCliente.ToString() + "'";
      SQL = "SELECT * FROM venda_parcela WHERE idvenda = '" + idVenda.ToString() + "'";
      ds = bd.ConsultarRegistro(SQL, "venda_parcela");      
    }

    public void InserirJuros()
    {
      string SQL = "UPDATE cliente_debito SET juros = ?juros WHERE idvenda = ?idvenda AND idparcela = ?idparcela";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdv2 = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv2);
      MySqlParameter pIdp2 = new MySqlParameter("?idparcela", idParcela);
      cmd.Parameters.Add(pIdp2);
      MySqlParameter pJur2 = new MySqlParameter("?juros", juros);
      cmd.Parameters.Add(pJur2);
      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Valor da Parcela Atualizado com Sucesso!", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }
  }
}
