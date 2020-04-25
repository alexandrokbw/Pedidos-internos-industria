using System.Data;
using System.Data.OleDb;
using System.Text;


namespace Estoque
{
    class Pedido
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        internal void salvarPedido(string nomeSolicitante, int idMaterial, string prioridade, string dataPedido, string horaPedido, string odf, string quantidade, string unidadeDeMedida, string lote, string observacao, string statusPedido)
        {

            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();

                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO TBPEDIDO( nomeSolicitante,idMaterial,prioridade, dataPedido, horaPedido,odf, um, quantidadePedido, lotePedido,observacao,statusPedido)");
                sql.Append(" VALUES(@nomeSolicitante,@idMaterial,@prioridade, @dataPedido, @horaPedido, @odf, @um,@quantidadePedido,@lotePedido,@observacao,@statusPedido)");

                comandoSql.Parameters.Add(new OleDbParameter("@nomeSolicitante", nomeSolicitante));
                comandoSql.Parameters.Add(new OleDbParameter("@idMaterial", idMaterial));
                comandoSql.Parameters.Add(new OleDbParameter("@prioridade", prioridade));
                comandoSql.Parameters.Add(new OleDbParameter("@dataPedido", dataPedido));
                comandoSql.Parameters.Add(new OleDbParameter("@horaPedido", horaPedido));
                comandoSql.Parameters.Add(new OleDbParameter("@odf", odf));
                comandoSql.Parameters.Add(new OleDbParameter("@quantidadePedido", quantidade));
                comandoSql.Parameters.Add(new OleDbParameter("@um", unidadeDeMedida));
                comandoSql.Parameters.Add(new OleDbParameter("@lotePedido", lote));
                comandoSql.Parameters.Add(new OleDbParameter("@observacao", observacao));
                comandoSql.Parameters.Add(new OleDbParameter("@statusPedido", statusPedido));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();

            }

        }

        internal DataTable listarTetalhesPedido(int idPedido)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" SELECT tbMaterial.*, tbPedido.*, tbPedido.idPedido");
                sql.Append(" FROM(tbMaterial INNER JOIN");
                sql.Append(" tbPedido ON tbMaterial.idMaterial = tbPedido.idMaterial)");
                sql.Append(" WHERE(tbPedido.idPedido = @idPedido)");

                comandoSql.Parameters.Add(new OleDbParameter("@idPedido", idPedido));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;



            }
        }
        internal void receberPedido(int idPedido, string dataRecebimento, string horaRecebimento, string nomeConferente, string quantidadeRecebida, string loteRecebido, string observacao, string statusPedido)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE tbPedido");
                sql.Append(" SET nomeConferente = @nomeConferente, dataRecebimento = @dataRecebimento, horaRecebimento = @horaRecebimento, quantidadeRecebida = @quantidadeRecebida, loteRecebido = @loteRecebido,observacao = @observacao, statusPedido = @statusPedido");
                sql.Append(" WHERE(tbPedido.idPedido = @idPedido)");


                comandoSql.Parameters.Add(new OleDbParameter("@nomeConferente", nomeConferente));
                comandoSql.Parameters.Add(new OleDbParameter("@dataRecebimento", dataRecebimento));
                comandoSql.Parameters.Add(new OleDbParameter("@horaRecebimento", horaRecebimento));
                comandoSql.Parameters.Add(new OleDbParameter("@quantidadeRecebida", quantidadeRecebida));
                comandoSql.Parameters.Add(new OleDbParameter("@loteRecebido", loteRecebido));
                comandoSql.Parameters.Add(new OleDbParameter("@observacao", observacao));
                comandoSql.Parameters.Add(new OleDbParameter("@statusPedido", statusPedido));
                comandoSql.Parameters.Add(new OleDbParameter("@idPedido", idPedido));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
                conexao.Close();
            }
        }

        internal void enviarPedido(int idPedido, string dataEnvio, string horaEnvio, string NotaFiscal, string Veiculo, string Quantidade, string loteEnviado, string nomeResponsavel, string observacao, string statusPedido)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                comandoSql.Parameters.Clear();

                sql.Append(" UPDATE tbPedido");
                sql.Append(" SET dataEnvio = @dataEnvio, horaEnvio = @horaEnvio, notaFiscal = @NotaFiscal, veiculo = @Veiculo, quantidadeEnviada = @Quantidade,loteEnviado=@loteEnviado, nomeResponsavel = @nomeResponsavel, observacao=@observacao,statusPedido = @statusPedido");
                sql.Append(" WHERE(idPedido = @idPedido)");

                comandoSql.Parameters.Add(new OleDbParameter("@dataEnvio", dataEnvio));
                comandoSql.Parameters.Add(new OleDbParameter("@horaEnvio", horaEnvio));
                comandoSql.Parameters.Add(new OleDbParameter("@NotaFiscal", NotaFiscal));
                comandoSql.Parameters.Add(new OleDbParameter("@Veiculo", Veiculo));
                comandoSql.Parameters.Add(new OleDbParameter("@Quantidade", Quantidade));
                comandoSql.Parameters.Add(new OleDbParameter("@loteEnviado", loteEnviado));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeResponsavel", nomeResponsavel));
                comandoSql.Parameters.Add(new OleDbParameter("@observacao", observacao));
                comandoSql.Parameters.Add(new OleDbParameter("@statusPedido", statusPedido));

                comandoSql.Parameters.Add(new OleDbParameter("@idPedido", idPedido));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
                conexao.Close();
            }
        }

        internal DataTable listarPedidoRecebido()
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT tbPedido.idPedido,tbPedido.prioridade, tbMaterial.codigo, tbMaterial.nomeMaterial, tbPedido.nomeSolicitante, tbPedido.nomeResponsavel, tbPedido.nomeConferente, tbPedido.dataPedido, tbPedido.horaPedido, tbPedido.dataEnvio, ");
                sql.Append(" tbPedido.horaEnvio, tbPedido.dataRecebimento, tbPedido.horaRecebimento, tbPedido.quantidadePedido, tbPedido.lotePedido, tbPedido.odf, tbPedido.quantidadeEnviada, tbPedido.loteEnviado, tbPedido.quantidadeRecebida, ");
                sql.Append(" tbPedido.loteRecebido, tbPedido.statusPedido");
                sql.Append(" FROM(tbMaterial INNER JOIN");
                sql.Append(" tbPedido ON tbMaterial.idMaterial = tbPedido.idMaterial)");
                sql.Append(" WHERE(tbPedido.statusPedido = 'Recebido')");
                sql.Append(" ORDER BY(tbPedido.dataRecebimento)DESC");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }

        internal DataTable listarPedidoEnviado()
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT tbPedido.prioridade, tbMaterial.codigo, tbMaterial.nomeMaterial, tbPedido.nomeResponsavel,tbPedido.quantidadePedido,tbPedido.um,tbPedido.lotePedido, tbPedido.dataEnvio, tbPedido.horaEnvio, tbPedido.notaFiscal, tbPedido.veiculo, tbPedido.quantidadeEnviada, tbPedido.loteEnviado,");
                sql.Append(" tbPedido.idPedido, tbPedido.statusPedido, tbPedido.observacao");
                sql.Append(" FROM(tbMaterial INNER JOIN");
                sql.Append(" tbPedido ON tbMaterial.idMaterial = tbPedido.idMaterial)");
                sql.Append(" WHERE(tbPedido.statusPedido = 'Enviado')");
                sql.Append(" ORDER BY(tbPedido.dataEnvio)");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }


        internal DataTable listarPedidoAguardando()
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT tbMaterial.codigo, tbMaterial.nomeMaterial, tbPedido.idPedido,tbPedido.nomeSolicitante, tbPedido.prioridade, tbPedido.dataPedido, tbPedido.horaPedido, tbPedido.quantidadePedido, tbPedido.um, tbPedido.lotePedido, tbPedido.odf,");
                sql.Append(" tbPedido.statusPedido,tbPedido.observacao");
                sql.Append(" FROM(tbMaterial INNER JOIN");
                sql.Append(" tbPedido ON tbMaterial.idMaterial = tbPedido.idMaterial)");
                sql.Append(" WHERE(tbPedido.statusPedido = 'Aguardando')");
                sql.Append(" ORDER BY(tbPedido.dataPedido)");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }
    }
}
