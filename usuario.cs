using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Estoque
{
    class usuario
    {
        OleDbCommand comandoSql = new OleDbCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();


        internal DataTable ListarUsuario()
        {
            using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
            {
                conexao.Open();
                sql.Append(" SELECT *");
                sql.Append(" FROM tbUsuario");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }

        internal DataTable verificarLogin(string login, string senha, string setor)
        {
            try
            {
                using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
                {
                    conexao.Open();
                    sql.Append(" SELECT nomeUsuario,login,senha,setor");
                    sql.Append(" FROM tbUsuario");
                    sql.Append(" WHERE(login = @login AND senha = @senha AND  setor = @setor)");

                    comandoSql.Parameters.Add(new OleDbParameter("@login", login));
                    comandoSql.Parameters.Add(new OleDbParameter("@senha", senha));
                    comandoSql.Parameters.Add(new OleDbParameter("@setor", setor));
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (System.Exception)
            {
                return dadosTabela;
            }
                
           
            
        }
        internal DataTable ListarSetorUsuario()
        {//Lista os setores disponiveis
            
            try
            {
                using (OleDbConnection conexao = new OleDbConnection(Conexao.stringDeConexao))
                {
                    conexao.Open();
                    sql.Append(" SELECT setor");
                    sql.Append(" FROM tbUsuario");
                    sql.Append(" GROUP BY setor");


                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Defina o banco de dados");
                return dadosTabela;
            }
           
        }

    }
}
