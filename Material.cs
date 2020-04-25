using System.Data;
using System.Data.OleDb;
using System.Text;

namespace Estoque
{
    class Material
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        internal DataTable listarMaterial()
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT idMaterial, codigo, nomeMaterial,unidadeDeMedida");
                sql.Append(" FROM tbMaterial");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                conexao.Close();
                return dadosTabela;
            }
        }

        internal void atualiza(int idMaterial, string codigo, string nomeMaterial, string unidadeDeMedida)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" UPDATE tbMaterial");
                sql.Append(" SET codigo = @codigo, nomeMaterial = @nomeMaterial, unidadeDeMedida = @unidadeDeMedida");
                sql.Append(" WHERE (tbMaterial.idMaterial = @idMaterial)");

                comandoSql.Parameters.Add(new OleDbParameter("@codigo", codigo));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeMaterial", nomeMaterial));
                comandoSql.Parameters.Add(new OleDbParameter("@unidadeDeMedida", unidadeDeMedida));
                comandoSql.Parameters.Add(new OleDbParameter("@idMaterial", idMaterial));


                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
                conexao.Close();
            }
        }

        internal void salvar(string codigo, string nomeMaterial, string unidadeDeMedida)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();

                comandoSql.Parameters.Clear();
                sql.Append(" INSERT INTO tbMaterial (codigo,nomeMaterial,unidadeDeMedida)");
                sql.Append(" VALUES(@codigo,@nomeMaterial,@unidadeDeMedida)");


                comandoSql.Parameters.Add(new OleDbParameter("@codigo", codigo));
                comandoSql.Parameters.Add(new OleDbParameter("@nomeMaterial", nomeMaterial));
                comandoSql.Parameters.Add(new OleDbParameter("@unidadeDeMedida", unidadeDeMedida));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                conexao.Close();
                comandoSql.ExecuteNonQuery();

            }
        }

        internal DataTable pesquisarMaterial(string codigo)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT idMaterial, codigo, nomeMaterial,unidadeDeMedida");
                sql.Append(" FROM tbMaterial");
                sql.Append(" WHERE(codigo LIKE'%'+ @codigo+'%')");

                comandoSql.Parameters.Add(new OleDbParameter("@codigo", codigo));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                conexao.Close();
                return dadosTabela;
            }
        }

        internal void excluir(int idMaterial)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();

                comandoSql.Parameters.Clear();
                sql.Append(" DELETE FROM tbMaterial");
                sql.Append(" WHERE(tbMaterial.idMaterial = @idMaterial)");


                comandoSql.Parameters.Add(new OleDbParameter("@idMaterial", idMaterial));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
                conexao.Close();
            }
        }

        internal DataTable pesquisarMaterialPeloNome(string nome)
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT idMaterial, codigo, nomeMaterial,unidadeDeMedida");
                sql.Append(" FROM tbMaterial");
                sql.Append(" WHERE(nomeMaterial LIKE'%'+ @nome+'%')");

                comandoSql.Parameters.Add(new OleDbParameter("@nome", nome));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                conexao.Close();
                return dadosTabela;
                

            }
        }
       
    }

}