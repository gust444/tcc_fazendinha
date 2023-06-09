﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.modelo;

namespace WindowsFormsApp2.controle
{
    public class aplica_controle
    {
        bool resultado = false;
        conexao com = new conexao();

        public bool CadAplicacao(aplica_modelo AM)
        {
            try
            {
                string sql = "INSERT INTO tb_cad_aplicacoes (nome_talhao,defensivo,finalidade,principio_ativo,modo_acao,dosagem_ha,data_aplicacao) values (@nome_talhao,@defensivo,@finalidade,@principio_ativo,@modo_acao,@dosagem_ha,@data_aplicacao)";
                string[] campos = { "@nome_talhao", "@defensivo", "@finalidade", "@principio_ativo", "@modo_acao", "@dosagem_ha", "@data_aplicacao" };
                string[] valores = { AM.nome_talhao, AM.defensivo, AM.finalidade, AM.principio_ativo, AM.modo_acao, AM.dosagem_ha, AM.data_aplicacao };
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
        public bool AttAplica(aplica_modelo AM)
        {
            try
            {
                string sql = "UPDATE SET tb_cad_aplicacoes nome_talhao=@nome_talhao,defensivo=@defensivo,finalidade=@finalidade,principio_ativo=@principio_ativo,modo_acao=@modo_acao,dosagem_ha=@dosagem_ha,data_aplicacao=@data_aplicacao";
                string[] campos = { "@nome_talhao","@defensivo", "@finalidade", "@principio_ativo", "@modo_acao", "@dosagem_ha", "@data_aplicacao" };
                string[] valores = { AM.nome_talhao, AM.defensivo, AM.finalidade, AM.principio_ativo, AM.modo_acao, AM.dosagem_ha, AM.data_aplicacao };
                if (com.atualizar(AM.id_aplicacao, campos, valores, sql) >= 1)
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
        public bool DelAplica(aplica_modelo AM)
        {
            try
            {
                String SQL = "Delete from usuario where cod_usuario=@codigo";
                //chama o objeto conexao com o metodo apagar
                //passando os atributos codigo e sql 
                if (com.apagar(AM.id_aplicacao, SQL) == 1)
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
        public aplica_modelo CarregarAplica(int codigo, aplica_modelo aplica_modelo)
        {
            //chamo meu objeto usuario
            aplica_modelo AM = new aplica_modelo();
            try
            {
                com = new conexao();//chama o metodo conexao
                MySqlConnection conn = com.getConexao();//obtenho a conexao do banco
                conn.Open();//abro o banco de dados
                MySqlCommand cmd = conn.CreateCommand();//executo o comando sql
                //passa a string sql
                cmd.CommandText = "SELECT * from tb_cad_aplica where id_aplicacao = @id_aplicacao";
                //altero a variavel de consulta pelo codigo
                cmd.Parameters.AddWithValue("@id_aplicacao", codigo);
                //executo a consulta sql
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)// existe registro
                {
                    registro.Read();// leia a informação
                    //alterando a informação do email para o modelo usuario
                    AM.nome_talhao = registro["nomeT"].ToString();
                    AM.defensivo = registro["defensivo"].ToString();
                    AM.finalidade = registro["finalidade"].ToString();
                    AM.principio_ativo = registro["princAtivo"].ToString();
                    AM.modo_acao = registro["modoA"].ToString();
                    AM.dosagem_ha = registro["doseHa"].ToString();
                    AM.data_aplicacao = registro["dataAp"].ToString();

                }
                conn.Close();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return AM;
        }
    }
}
