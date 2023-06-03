using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.modelo
{
    public class aplica_modelo
    {
        private int IDAplicacao;
        private string Nometalhao;
        private string Defensivo;
        private string Finalidade;
        private string PrincipioAtivo;
        private string ModoAcao;
        private string DosagemHa;
        private string DataAplicacao;

        public aplica_modelo()
        {
            Nometalhao = "";
            Defensivo = "";
            Finalidade = "";
            PrincipioAtivo = "";
            ModoAcao = "";
            DosagemHa = "";
            DataAplicacao = "";
        }

        public int id_aplicacao
        {
            get { return IDAplicacao; }
            set { IDAplicacao = value; }
        }

        public string nome_talhao
        {
            get { return this.Nometalhao; }
            set { Nometalhao = value; }
        }

        public string defensivo
        {
            get { return this.Defensivo; }
            set { Defensivo = value; }
        }

        public string finalidade
        {
            get { return this.Finalidade; }
            set { this.Finalidade = value; }
        }

        public string principio_ativo
        {
            get { return this.PrincipioAtivo; }
            set { this.PrincipioAtivo = value; }
        }

        public string modo_acao
        {
            get { return this.ModoAcao; }
            set { this.ModoAcao = value; }
        }

        public string dosagem_ha
        {
            get { return this.DosagemHa; }
            set { this.DosagemHa = value; }
        }

        public string data_aplicacao
        {
            get { return this.DataAplicacao; }
            set { this.DataAplicacao = value; }
        }
    }
}

