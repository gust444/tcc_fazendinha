using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.modelo
{
    public class talhoes_modelo
    {

        private int IDTalhao;
        private string NomeTalhao;
        private string CulturaAtual;
        private string UltimaCultura;
        private string AreaTalhao;
        private string QldSolo;

        public talhoes_modelo()
        {
            NomeTalhao = "";
            CulturaAtual = "";
            UltimaCultura = "";
            AreaTalhao = "";
            QldSolo = "";
        }

        public int id_talhao
        {
            get { return IDTalhao; }
            set { IDTalhao = value; }
        }

        public string nome_talhao
        {
            get { return this.NomeTalhao; }
            set { NomeTalhao = value; }
        }

        public string cult_atual
        {
            get { return this.CulturaAtual; }
            set { this.CulturaAtual = value; }
        }

        public string cult_ultima
        {
            get { return this.UltimaCultura; }
            set { this.UltimaCultura = value; }
        }

        public string area_talhao
        {
            get { return this.AreaTalhao; }
            set { this.AreaTalhao= value; }
        }

        public string qualidade_solo
        {
            get { return this.QldSolo; }
            set { this.QldSolo = value; }
        }
        
       
        
    }
}
   

