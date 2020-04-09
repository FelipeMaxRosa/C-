using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lojadalala
{
  class Pagamento
  {
    //Atributos
    //--------------------------------------------------------------------------
    private int idPagamento;
    private int idVenda;
    private int idParcela;
    private decimal valorPago;
    private DateTime dataPagto;
    private string obs;
    private int idCliente;
    private int idFinalizadora;
    private string usuario;
    private DateTime novaData;
    private decimal novoValor;
    private decimal juros;

    private BancoDados bd;
    private DataSet ds;
    private MySqlCommand cmd;

    //Propriedades
    //--------------------------------------------------------------------------
    public int IdPagamento
    {
      get { return idPagamento; }
      set { idPagamento = value; }
    }

    public int IdVenda
    {
      get { return idVenda; }
      set { idVenda = value; }
    }

    public int IdParcela
    {
      get { return idParcela; }
      set { idParcela = value; }
    }

    public decimal ValorPago
    {
      get { return valorPago; }
      set { valorPago = value; }
    }

    public DateTime DataPagto
    {
      get { return dataPagto; }
      set { dataPagto = value; }
    }

    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }

    public int IdCliente
    {
      get { return idCliente; }
      set { idCliente = value; }
    }

    public int IdFinalizadora
    {
      get { return idFinalizadora; }
      set { idFinalizadora = value; }
    }

    public string Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }

    public DateTime NovaData
    {
      get { return novaData; }
      set { novaData = value; }
    }

    public decimal NovoValor
    {
      get { return novoValor; }
      set { novoValor = value; }
    }

    public decimal Juros
    {
      get { return juros; }
      set { juros = value; }
    }

    //Construtor
    //--------------------------------------------------------------------------
    public Pagamento()
    {
      bd = new BancoDados();
    }

    //Metodos Gerais
    //--------------------------------------------------------------------------
    public void AtualizarDebito(bool total)
    {
      string SQL2 = "";
      if (total)
      {
        SQL2 = "UPDATE cliente_debito SET valor = juros + valor - ?valor, juros = '0.00', estado = 'PAGA' WHERE idvenda = ?idvenda AND idparcela = ?idparcela";
        MySqlCommand cmd2 = new MySqlCommand();
        cmd2.CommandText = SQL2;

        MySqlParameter pVal2 = new MySqlParameter("?valor", valorPago);
        cmd2.Parameters.Add(pVal2);
        MySqlParameter pIdv2 = new MySqlParameter("?idvenda", idVenda);
        cmd2.Parameters.Add(pIdv2);
        MySqlParameter pIdp2 = new MySqlParameter("?idparcela", idParcela);
        cmd2.Parameters.Add(pIdp2);

        bd.AtualizarRegistro(cmd2);
        if (bd.Cont > 0)
        {
          bd.Cont = 0;
          MessageBox.Show("Pagamento efetuado com sucesso!", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      else
      {
        SQL2 = "UPDATE cliente_debito SET valor = ?valor, dtvencimento = ?novadata, juros = ?juros WHERE idvenda = ?idvenda AND idparcela = ?idparcela";
        MySqlCommand cmd2 = new MySqlCommand();
        cmd2.CommandText = SQL2;

        MySqlParameter pVal2 = new MySqlParameter("?valor", novoValor);
        cmd2.Parameters.Add(pVal2);
        MySqlParameter pNov2 = new MySqlParameter("?novadata", novaData);
        cmd2.Parameters.Add(pNov2);
        MySqlParameter pIdv2 = new MySqlParameter("?idvenda", idVenda);
        cmd2.Parameters.Add(pIdv2);
        MySqlParameter pIdp2 = new MySqlParameter("?idparcela", idParcela);
        cmd2.Parameters.Add(pIdp2);
        MySqlParameter pJur = new MySqlParameter("?juros", juros);
        cmd2.Parameters.Add(pJur);

        bd.AtualizarRegistro(cmd2);
        if (bd.Cont > 0)
        {
          bd.Cont = 0;
          MessageBox.Show("Pagamento Parcial efetuado com sucesso!", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    public void InserirPagamento(bool total)
    {
      string SQL = "";
      cmd = new MySqlCommand();

      if (total)
      {
        SQL = "INSERT INTO cliente_pagamento VALUES (NULL, ?idvenda, ?idparcela, ?valorpagto, ?datapagto, ?obs, ?idcliente, ?idfinalizadora, ?usuario)";
        cmd.CommandText = SQL;

        MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
        cmd.Parameters.Add(pIdv);
        MySqlParameter pIdp = new MySqlParameter("?idparcela", idParcela);
        cmd.Parameters.Add(pIdp);
        MySqlParameter pVal = new MySqlParameter("?valorpagto", valorPago);
        cmd.Parameters.Add(pVal);
        MySqlParameter pDat = new MySqlParameter("?datapagto", dataPagto);
        cmd.Parameters.Add(pDat);
        MySqlParameter pObs = new MySqlParameter("?obs", obs);
        cmd.Parameters.Add(pObs);
        MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
        cmd.Parameters.Add(pIdc);
        MySqlParameter pIdf = new MySqlParameter("?idfinalizadora", idFinalizadora);
        cmd.Parameters.Add(pIdf);
        MySqlParameter pUsu = new MySqlParameter("?usuario", usuario);
        cmd.Parameters.Add(pUsu);

        bd.InserirRegistro(cmd);
        if (bd.Cont > 0)
        {
          this.AtualizarDebito(true);
          SQL = "UPDATE venda_parcela SET estado = 'PAGA' WHERE idvenda = '" + idVenda + "' AND idparcela = '" + idParcela +  "'";
          cmd.CommandText = SQL;
          bd.AtualizarRegistro(cmd);
          bd.Cont = 0;
        }
      }
      else
      {
        SQL = "INSERT INTO cliente_pagamento VALUES (NULL, ?idvenda, ?idparcela, ?valorpagto, ?datapagto, ?obs, ?idcliente, ?idfinalizadora, ?usuario)";
        cmd.CommandText = SQL;

        MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
        cmd.Parameters.Add(pIdv);
        MySqlParameter pIdp = new MySqlParameter("?idparcela", idParcela);
        cmd.Parameters.Add(pIdp);
        MySqlParameter pVal = new MySqlParameter("?valorpagto", valorPago);
        cmd.Parameters.Add(pVal);
        MySqlParameter pDat = new MySqlParameter("?datapagto", dataPagto);
        cmd.Parameters.Add(pDat);
        MySqlParameter pObs = new MySqlParameter("?obs", obs);
        cmd.Parameters.Add(pObs);
        MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
        cmd.Parameters.Add(pIdc);
        MySqlParameter pIdf = new MySqlParameter("?idfinalizadora", idFinalizadora);
        cmd.Parameters.Add(pIdf);
        MySqlParameter pUsu = new MySqlParameter("?usuario", usuario);
        cmd.Parameters.Add(pUsu);

        bd.InserirRegistro(cmd);
        if (bd.Cont > 0)
        {
          bd.Cont = 0;
          this.AtualizarDebito(false);
        }
      }
    }

    public void InserirPagamentoAV(bool cliCad)
    {
      string SQL = "";
      cmd = new MySqlCommand();

      if (cliCad)
      {
        SQL = "INSERT INTO cliente_pagamento VALUES (NULL, ?idvenda, ?idparcela, ?valorpagto, ?datapagto, ?obs, ?idcliente, ?idfinalizadora, ?usuario)";
        cmd.CommandText = SQL;
        MySqlParameter pIdc = new MySqlParameter("?idcliente", idCliente);
        cmd.Parameters.Add(pIdc);
      }
      else
      {
        SQL = "INSERT INTO cliente_pagamento VALUES (NULL, ?idvenda, ?idparcela, ?valorpagto, ?datapagto, ?obs, NULL, ?idfinalizadora, ?usuario)";
        cmd.CommandText = SQL;
      }
      MySqlParameter pIdv = new MySqlParameter("?idvenda", idVenda);
      cmd.Parameters.Add(pIdv);
      MySqlParameter pIdp = new MySqlParameter("?idparcela", idParcela);
      cmd.Parameters.Add(pIdp);
      MySqlParameter pVal = new MySqlParameter("?valorpagto", valorPago);
      cmd.Parameters.Add(pVal);
      MySqlParameter pDat = new MySqlParameter("?datapagto", dataPagto);
      cmd.Parameters.Add(pDat);
      MySqlParameter pObs = new MySqlParameter("?obs", obs);
      cmd.Parameters.Add(pObs);
      MySqlParameter pIdf = new MySqlParameter("?idfinalizadora", idFinalizadora);
      cmd.Parameters.Add(pIdf);
      MySqlParameter pUsu = new MySqlParameter("?usuario", usuario);
      cmd.Parameters.Add(pUsu);
      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        bd.Cont = 0;
        this.AtualizarDebito(true);
      }
    }
  }
}
