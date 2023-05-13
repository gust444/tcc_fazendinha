using System;
using System.Collections.Generic;
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
    }
}
