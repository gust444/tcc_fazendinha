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
                string sql = "INSERT INTO tb_cad_aplicacoes (defensivo,finalidade,principio_ativo,modo_acao,dosagem_ha,data_aplicacao) values (@nome_talhao,@cult_atual,@cult_ultima,@area_talhao,@qualidade_solo)";
                string[] campos = { "@defensivo", "@finalidade", "@principio_ativo", "@modo_acao", "@dosagem_ha", "@data_aplicacao" };
                string[] valores = { AM.defensivo, AM.finalidade, AM.principio_ativo, AM.modo_acao, AM.dosagem_ha, AM.data_aplicacao };
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
    }
}
