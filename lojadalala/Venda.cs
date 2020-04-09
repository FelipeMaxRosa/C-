using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lojadalala
{
  class Venda
  {
    //Atributos
    //--------------------------------------------------------
    private int idVenda;
    private int idCliente;
    private DateTime dataVenda;
    private string observacao;
    private string estado;
    private string vendedor;
    private decimal totalVenda;
    //--------------------------------------------------------
    private BancoDados bd;
    private MySqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    //Propriedades
    //--------------------------------------------------------
    public int IdVenda
    {
      get { return idVenda; }
      set { idVenda = value; }
    }
    public int IdCliente
    {
      get { return idCliente; }
      set { idCliente = value; }
    }
    public DateTime DataVenda
    {
      get { return dataVenda; }
      set { dataVenda = value; }
    }
    public string Observacao
    {
      get { return observacao; }
      set { observacao = value; }
    }
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }
    public string Vendedor
    {
      get { return vendedor; }
      set { vendedor = value; }
    }
    public decimal TotalVenda
    {
      get { return totalVenda; }
      set { totalVenda = value; }
    }

    //Construtor
    //--------------------------------------------------------
    public Venda()
    {
      bd = new BancoDados();
    }

    //Metodos Gerais
    //--------------------------------------------------------
    public void InserirVenda()
    {
      string SQL = "INSERT INTO venda VALUES(?idvenda, ?estado, ?datavenda, ?vendedor, ?totalvenda, ?obs, ?idcliente)";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);
      MySqlParameter pEst = new MySqlParameter("?estado", estado);
      cmd.Parameters.Add(pEst);
      MySqlParameter pDtv = new MySqlParameter("?datavenda", dataVenda);
      cmd.Parameters.Add(pDtv);
      MySqlParameter pVend = new MySqlParameter("?vendedor", vendedor);
      cmd.Parameters.Add(pVend);
      MySqlParameter pTot = new MySqlParameter("?totalvenda", totalVenda);
      cmd.Parameters.Add(pTot);
      MySqlParameter pObs = new MySqlParameter("?obs", observacao);
      cmd.Parameters.Add(pObs);
      MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
      cmd.Parameters.Add(pIdc);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        //MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void InserirVendaAV(bool cliCad)
    {
      string SQL = "";
      if (cliCad)
      {
        SQL = "INSERT INTO venda VALUES(?idvenda, ?estado, ?datavenda, ?vendedor, ?totalvenda, ?obs, ?idcliente)";
        cmd = new MySqlCommand();
        cmd.CommandText = SQL;
        MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
        cmd.Parameters.Add(pIdc);
      }
      else
      {
        SQL = "INSERT INTO venda VALUES(?idvenda, ?estado, ?datavenda, ?vendedor, ?totalvenda, ?obs, ?idcliente)";
        cmd = new MySqlCommand();
        cmd.CommandText = SQL;
        MySqlParameter pIdc = new MySqlParameter("?idcliente", DBNull.Value);
        cmd.Parameters.Add(pIdc);
      }

      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);
      MySqlParameter pEst = new MySqlParameter("?estado", estado);
      cmd.Parameters.Add(pEst);
      MySqlParameter pDtv = new MySqlParameter("?datavenda", dataVenda);
      cmd.Parameters.Add(pDtv);
      MySqlParameter pVend = new MySqlParameter("?vendedor", vendedor);
      cmd.Parameters.Add(pVend);
      MySqlParameter pTot = new MySqlParameter("?totalvenda", totalVenda);
      cmd.Parameters.Add(pTot);
      MySqlParameter pObs = new MySqlParameter("?obs", observacao);
      cmd.Parameters.Add(pObs);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        //MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void RetornaIdVenda()
    {
      string SQL = "SELECT idvenda FROM venda ORDER BY idvenda DESC LIMIT 1";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;
      idVenda = bd.RetornaQtdeRegistros(cmd);
      idVenda++;
    }

    public void ConsultaVenda()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM venda WHERE idvenda = ?id";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pId = new MySqlParameter("?id", idVenda);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM venda WHERE idvenda = '" + idVenda + "'";
        string tabela = "venda";

        ds = bd.ConsultarRegistro(SQL, tabela);
        idVenda = Convert.ToInt32(ds.Tables[0].Rows[0]["idvenda"]);
        estado = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
        dataVenda = Convert.ToDateTime(ds.Tables[0].Rows[0]["datavenda"]);
        vendedor = Convert.ToString(ds.Tables[0].Rows[0]["vendedor"]);
        totalVenda = Convert.ToDecimal(ds.Tables[0].Rows[0]["totalvenda"]);
        observacao = Convert.ToString(ds.Tables[0].Rows[0]["obs"]);
        if (ds.Tables[0].Rows[0]["idcliente"] == DBNull.Value)
        {
          idCliente = 0;
        }
        else
        {
          idCliente = Convert.ToInt32(ds.Tables[0].Rows[0]["idcliente"]);
        }        
      }
      else
      {
        MessageBox.Show("Número de venda não realizada!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AlterarVenda()
    {
      string SQL = "UPDATE venda SET obs = ?obs WHERE idvenda = ?idvenda";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pObs = new MySqlParameter("?obs", observacao);
      cmd.Parameters.Add(pObs);
      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Informações da Venda atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void FinalizarVenda()
    {
      string SQL = "UPDATE venda SET estado = 'FINALIZADA' WHERE idvenda = ?idvenda";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }

    public void AtualizarTotal()
    {
      string SQL = "UPDATE venda SET totalvenda = ?total WHERE idvenda = ?idvenda";
      cmd = new MySqlCommand();
      cmd.CommandText = SQL;

      MySqlParameter pTot = new MySqlParameter("?total", totalVenda);
      cmd.Parameters.Add(pTot);
      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
      }
    }
  }
}
