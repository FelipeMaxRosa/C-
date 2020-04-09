using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lojadalala
{
  class Caixa
  {
    //Atributos
    //-----------------------------------------------------------------
    private int idCaixa;
    private int idEntrada;
    private int idSaida;
    private decimal valor;
    private DateTime data;
    private string usuario;
    private string obs;
    private int numCaixasAbertos;
    private decimal valorinicial;
    private decimal valorfinal;
    private decimal saldo;
    private string estado;

    private BancoDados bd;
    private DataSet ds;
    private MySqlCommand cmd;

    //Propriedades
    //-----------------------------------------------------------------
    public int IdCaixa
    {
      get { return idCaixa; }
      set { idCaixa = value; }
    }
    public int IdEntrada
    {
      get { return idEntrada; }
      set { idEntrada = value; }
    }
    public int IdSaida
    {
      get { return idSaida; }
      set { idSaida = value; }
    }
    public decimal Valor
    {
      get { return valor; }
      set { valor = value; }
    }
    public DateTime Data
    {
      get { return data; }
      set { data = value; }
    }
    public string Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }
    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }
    public int NumCaixasAbertos
    {
      get { return numCaixasAbertos; }
      set { numCaixasAbertos = value; }
    }
    public decimal Valorinicial
    {
      get { return valorinicial; }
      set { valorinicial = value; }
    }
    public decimal Valorfinal
    {
      get { return valorfinal; }
      set { valorfinal = value; }
    }
    public decimal Saldo
    {
      get { return saldo; }
      set { saldo = value; }
    }
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }

    //Construtor
    //-----------------------------------------------------------------
    public Caixa()
    {
      bd = new BancoDados();
    }

    //Metodos Gerais
    //-----------------------------------------------------------------
    public void InserirEntrada()
    {
      string SQL = "INSERT INTO caixa_entrada VALUES (?identrada, ?idcaixa, ?data, ?valor, ?usuario, ?obs)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIde = new MySqlParameter("?identrada", idEntrada);
      cmd.Parameters.Add(pIde);
      MySqlParameter pIdc = new MySqlParameter("?idcaixa", idCaixa);
      cmd.Parameters.Add(pIdc);
      MySqlParameter pDat = new MySqlParameter("?data", data);
      cmd.Parameters.Add(pDat);
      MySqlParameter pVal = new MySqlParameter("?valor", valor);
      cmd.Parameters.Add(pVal);
      MySqlParameter pUsu = new MySqlParameter("?usuario", usuario);
      cmd.Parameters.Add(pUsu);
      MySqlParameter pObs = new MySqlParameter("?obs", obs);
      cmd.Parameters.Add(pObs);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void InserirSaida()
    {
      string SQL = "INSERT INTO caixa_saida VALUES (?idsaida, ?idcaixa, ?data, ?valor, ?usuario, ?obs)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIds = new MySqlParameter("?idsaida", idSaida);
      cmd.Parameters.Add(pIds);
      MySqlParameter pIdc = new MySqlParameter("?idcaixa", idCaixa);
      cmd.Parameters.Add(pIdc);
      MySqlParameter pDat = new MySqlParameter("?data", data);
      cmd.Parameters.Add(pDat);
      MySqlParameter pVal = new MySqlParameter("?valor", valor);
      cmd.Parameters.Add(pVal);
      MySqlParameter pUsu = new MySqlParameter("?usuario", usuario);
      cmd.Parameters.Add(pUsu);
      MySqlParameter pObs = new MySqlParameter("?obs", obs);
      cmd.Parameters.Add(pObs);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void RetornaIdEntrada()
    {
      string SQL = "SELECT identrada FROM caixa_entrada WHERE idcaixa = ?idcaixa ORDER BY identrada DESC LIMIT 1";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdc = new MySqlParameter("?idcaixa", idCaixa);
      cmd.Parameters.Add(pIdc);

      idEntrada = bd.RetornaQtdeRegistros(cmd);
      idEntrada++;
    }

    public void RetornaIdSaida()
    {
      string SQL = "SELECT idsaida FROM caixa_saida WHERE idcaixa = ?idcaixa ORDER BY idsaida DESC LIMIT 1";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdc = new MySqlParameter("?idcaixa", idCaixa);
      cmd.Parameters.Add(pIdc);

      idSaida = bd.RetornaQtdeRegistros(cmd);
      idSaida++;
    }

    public void ConsultarParaGridEntrada()
    {
      string SQL = "SELECT * FROM caixa_entrada WHERE idcaixa = '" + idCaixa + "' ORDER BY identrada DESC";
      string tabela = "caixa_entrada";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
    }

    public void ConsultarParaGridSaida()
    {
      string SQL = "SELECT * FROM caixa_saida WHERE idcaixa = '" + idCaixa + "' ORDER BY idsaida DESC";
      string tabela = "caixa_saida";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, tabela);
    }

    public void ConsultaNumeroDeCaixasEmAberto()
    {
      string SQL = "SELECT COUNT(*) FROM caixa WHERE estado = 'ABERTO'";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      numCaixasAbertos = bd.RetornaQtdeRegistros(cmd);
    }

    public void ConsultaCaixaAberto()
    {
      string SQL = "SELECT * FROM caixa WHERE estado = 'ABERTO'";
      string tabela = "caixa";
      ds = bd.ConsultarRegistro(SQL, tabela);
      if (ds.Tables[0].Rows.Count > 0)
      {
        data = Convert.ToDateTime(ds.Tables[0].Rows[0]["dataatual"]);
        idCaixa = Convert.ToInt32(ds.Tables[0].Rows[0]["idcaixa"]);
        estado = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
        valorfinal = Convert.ToDecimal(ds.Tables[0].Rows[0]["valorfinal"]);
        valorinicial = Convert.ToDecimal(ds.Tables[0].Rows[0]["valorinicial"]);
        saldo = Convert.ToDecimal(ds.Tables[0].Rows[0]["saldo"]);

      }      
    }

    public void AberturaDeCaixa()
    {
      string SQL = "INSERT INTO caixa (dataatual, valorinicial, valorfinal, saldo, estado) VALUES (?dataAtual, ?valorInicial, ?valorfinal, ?saldo, 'ABERTO')";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      //Parametros
      //----------------------------
      MySqlParameter pDat = new MySqlParameter("?dataAtual", data);
      cmd.Parameters.Add(pDat);
      MySqlParameter pValIni = new MySqlParameter("?valorInicial", valorinicial);
      cmd.Parameters.Add(pValIni);
      MySqlParameter pValFin = new MySqlParameter("?valorfinal", valorfinal);
      cmd.Parameters.Add(pValFin);
      MySqlParameter pSaldo = new MySqlParameter("?saldo", saldo);
      cmd.Parameters.Add(pSaldo);
      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
        MessageBox.Show("Abertuda de caixa realizada com sucesso!", "Abertura", MessageBoxButtons.OK, MessageBoxIcon.Warning);        
      }
    }

    public void FechamentoDeCaixa()
    {
      string SQL = "UPDATE caixa SET estado = 'FECHADO' WHERE idcaixa = ?idcaixa";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      //Parametros
      //----------------------------
      MySqlParameter pIdc = new MySqlParameter("?idcaixa", idCaixa);
      cmd.Parameters.Add(pIdc);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
        MessageBox.Show("Fechamento de caixa realizado com sucesso!", "Abertura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void RetornaUltimoValorFinal()
    {
      string SQL = "SELECT valorfinal FROM caixa ORDER BY idcaixa DESC LIMIT 1";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      valorfinal = bd.RetornaValor(cmd);
    }
  }
}
