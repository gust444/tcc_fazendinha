using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.modelo
{
    public class plantio_modelo
    {
        private int IDPlantio;
        private string nomeTalhao;
        private string Cultura;
        private string Variedade;
        private string QtdFertilizante;
        private string PlantasMetro;
        private string PlantasHa;
        private string Espacamento;
        private string DataPlantio;

        public plantio_modelo()
        {
            nomeTalhao = "";
            Cultura = "";
            Variedade = "";
            QtdFertilizante = "";
            PlantasMetro = "";
            PlantasHa = "";
            Espacamento = "";
            DataPlantio = "";
        }

        public int id_plantio
        {
            get { return IDPlantio; }
            set { IDPlantio = value; }
        }

        public string nome_talhao
        {
            get { return nomeTalhao; }
            set { nomeTalhao = value; }
        }

        public string cultura
        {
            get { return this.Cultura; }
            set { Cultura = value; }
        }

        public string variedade
        {
            get { return this.Variedade; }
            set { this.Variedade = value; }
        }

        public string qtd_fertilizante
        {
            get { return this.QtdFertilizante; }
            set { this.QtdFertilizante = value; }
        }

        public string plantas_metro
        {
            get { return this.PlantasMetro; }
            set { this.PlantasMetro = value; }
        }

        public string plantas_ha
        {
            get { return this.PlantasHa; }
            set { this.PlantasHa = value; }
        }

        public string espacamento
        {
            get { return this.Espacamento; }
            set { this.Espacamento = value; }
        }

        public string data_plantio
        {
            get { return this.DataPlantio; }
            set { this.DataPlantio = value; }
        }
    }
}
