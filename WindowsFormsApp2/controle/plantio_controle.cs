using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.modelo;

namespace WindowsFormsApp2.controle
{
    public class plantio_controle
    {
        bool resultado = false;
        conexao com = new conexao();

        public bool CadPlantio(plantio_modelo PM)
        {
            try
            {
                string sql = "INSERT INTO tb_cad_plantio (nome_talhao,cultura,variedade,qtd_fertilizante,plantas_metro,plantas_ha,espacamento,data_plantio) values (@nome_talhao,@cultura,@variedade,@qtd_fertilizante,@plantas_metro,@plantas_ha,@espacamento,@data_plantio)";
                string[] campos = { "@nome_talhao", "@cultura", "@variedade", "@qtd_fertilizante", "@plantas_metro", "@plantas_ha", "@espacamento", "@data_plantio" };
                string[] valores = { PM.nome_talhao, PM.cultura, PM.variedade, PM.qtd_fertilizante, PM.plantas_metro, PM.plantas_ha, PM.espacamento, PM.data_plantio };
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
        public bool AttPlantio(plantio_modelo PM)
        {
            try
            {
                string sql = "UPDATE SET tb_cad_aplicacoes defensivo=@defensivo,finalidade=@finalidade,principio_ativo=@principio_ativo,modo_acao=@modo_acao,dosagem_ha=@dosagem_ha,data_aplicacao=@data_aplicacao";
                string[] campos = { "@nome_talhao", "@cultura", "@variedade", "@qtd_fertilizante", "@plantas_metro", "@plantas_ha", "@espacamento", "@data_plantio" };
                string[] valores = { PM.nome_talhao, PM.cultura, PM.variedade, PM.qtd_fertilizante, PM.plantas_metro, PM.plantas_ha, PM.espacamento, PM.data_plantio };
                if (com.atualizar(PM.id_plantio, campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DelPlantio(plantio_modelo PM)
        {
            try
            {
                String SQL = "Delete from usuario where cod_usuario=@codigo";
                //chama o objeto conexao com o metodo apagar
                //passando os atributos codigo e sql 
                if (com.apagar(PM.id_plantio, SQL) == 1)
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
        public plantio_modelo CarregarPlantio(int codigo, plantio_modelo plantio_modelo)
        {
            //chamo meu objeto usuario
            plantio_modelo PM = new plantio_modelo();
            try
            {
                com = new conexao();//chama o metodo conexao
                MySqlConnection conn = com.getConexao();//obtenho a conexao do banco
                conn.Open();//abro o banco de dados
                MySqlCommand cmd = conn.CreateCommand();//executo o comando sql
                //passa a string sql
                cmd.CommandText = "SELECT * from tb_cad_plantio where id_plantio = @id_plantio";
                //altero a variavel de consulta pelo codigo
                cmd.Parameters.AddWithValue("@id_plantio", codigo);
                //executo a consulta sql
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)// existe registro
                {
                    registro.Read();// leia a informação
                    //alterando a informação do email para o modelo usuario
                    PM.nome_talhao = registro["nomeT"].ToString();
                    PM.cultura = registro["cult"].ToString();
                    PM.variedade = registro["variedade"].ToString();
                    PM.qtd_fertilizante = registro["qtdFert"].ToString();
                    PM.plantas_metro = registro["plantasM"].ToString();
                    PM.plantas_ha = registro["plantasHa"].ToString();
                    PM.espacamento = registro["espacamento"].ToString();
                    PM.data_plantio = registro["dataPl"].ToString();

                }
                conn.Close();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return PM;
        }


    }
}
