using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.modelo
{
    public class talhoes_modelo
    {
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

        public int Codigo
        {
            get { return CodigoUsuario; }
            set { CodigoUsuario = value; }
        }

        private string nome_talhao()
        {
            return this.nomeTalhao;
        }
        
        private string cult_atual()
        {
            return this.culturaAtual;
        }
        
        private string cult_ultima()
        {
            return this.ultimaCultura;
        }
        
        private string area_talhao()
        {
            return this.areaTalhao;
        }
        
        private string qualidade_solo()
        {
            return this.qldSolo;
        }
        
        public void setnome(string nome)
        {
            this.nome = nome;

        }
        public void setemail(string email)
        {
            this.email = email;
        }
        public void setfone(string fone)
        {
            this.fone = fone;
        }
    }
}
   

