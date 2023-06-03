using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2
{
    internal class conexao
    {
        static private string servidor = "localhost";
        static private string db = "dtbs_fazenda";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conn = null;
        static public string StrCon = "server=" + servidor + ";database=" + db + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getConexao()
        {
            conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool Conectar()
        {
            var result = false;
            try
            {
                getConexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public int cadastrar(string[] campos, string[] valores, string SQLinsert)
        {
            int registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLinsert, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQLinsert;
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();
                conn.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        //metodo apagar
        public int apagar(int codigo, string SQLDeletar)
        {
            //defino a varaivel de controle
            int registro = -1;
            try
            {


                conn = getConexao();//pegar a instrução de conexao
                conn.Open();//abro o banco de dados
                            //chamo o comando sql para montar a query
                MySqlCommand cmd = new MySqlCommand(SQLDeletar, conn);
                //converto a string no comando sql
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQLDeletar;//passo o comando de apagar
                cmd.Parameters.AddWithValue("@codigo", codigo);//adiciona o codigo a string
                registro = cmd.ExecuteNonQuery();//executa a query
                conn.Close();
                return registro;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int atualizar(int codigo, string[] campos, string[] valores, string sql)
        {
            int registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                for (int i = 0; i < campos.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                cmd.Parameters.AddWithValue("@codigo", codigo);
                registro = cmd.ExecuteNonQuery();
                conn.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ObterDados(string sql)
        {
            DataTable dt = new DataTable();
            conn = getConexao();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            //fazer a consulta da informação passada pela query
            MySqlDataAdapter dados = new MySqlDataAdapter(cmd);
            dados.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
