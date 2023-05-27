using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.modelo;

namespace WindowsFormsApp2.controle
{
    public class talhoes_controle
    {
        bool resultado = false;
        conexao com = new conexao();

        public bool CadTalhao(talhoes_modelo TM)
        {
            try
            {
                string sql = "INSERT INTO tb_add_talhao (nome_talhao,cult_atual,cult_ultima,area_talhao,qualidade_solo) values (@nome_talhao,@cult_atual,@cult_ultima,@area_talhao,@qualidade_solo)";
                string[] campos = { "@nome_talhao", "@cult_atual", "@cult_ultima", "@area_talhao", "@qualidade_solo" };
                string[] valores = { TM.nome_talhao, TM.cult_atual, TM.cult_ultima, TM.area_talhao, TM.qualidade_solo };
                if (com.cadastrar(campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);

            }

        }
        public bool AttTalhao(talhoes_modelo TM)
        {
            try
            {
                string sql = "UPDATE tb_add_talhao (nome_talhao,cult_atual,cult_ultima,area_talhao,qualidade_solo) values (@nome_talhao,@cult_atual,@cult_ultima,@area_talhao,@qualidade_solo)";
                string[] campos = { "@nome_talhao", "@cult_atual", "@cult_ultima", "@area_talhao", "@qualidade_solo" };
                string[] valores = { TM.nome_talhao, TM.cult_atual, TM.cult_ultima, TM.area_talhao, TM.qualidade_solo };
                if (com.atualizarDados(TM.id_talhao, campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;

            }

        }
        public bool DelTalhao(talhoes_modelo TM)
        {
            try
            {
                String SQL = "Delete from usuario where cod_usuario=@codigo";
                //chama o objeto conexao com o metodo apagar
                //passando os atributos codigo e sql 
                if (com.apagar(TM.id_talhao, SQL) == 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        public talhoes_modelo CarregarTalhao(int codigo, talhoes_modelo talhoes_modelo)
        {
            //chamo meu objeto usuario
          talhoes_modelo TM = new talhoes_modelo();
            try
            {
                com = new conexao();//chama o metodo conexao
                MySqlConnection conn = com.getConexao();//obtenho a conexao do banco
                conn.Open();//abro o banco de dados
                MySqlCommand cmd = conn.CreateCommand();//executo o comando sql
                //passa a string sql
                cmd.CommandText = "SELECT * from tb_add_talhao where id_talhao = @id_talhao";
                //altero a variavel de consulta pelo codigo
                cmd.Parameters.AddWithValue("@id_talhao", codigo);
                //executo a consulta sql
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)// existe registro
                {
                    registro.Read();// leia a informação
                    //alterando a informação do email para o modelo usuario
                    TM.nome_talhao = registro["nomeT"].ToString();
                    TM.cult_atual = registro["cultA"].ToString();
                    TM.cult_ultima = registro["cultU"].ToString();
                    TM.area_talhao = registro["areaT"].ToString();
                    TM.qualidade_solo = registro["qldS"].ToString();


                }
                conn.Close();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return TM;
        }
    }
}
