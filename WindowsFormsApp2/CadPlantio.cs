using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.controle;
using WindowsFormsApp2.modelo;

namespace WindowsFormsApp2
{
    public partial class CadPlantio : Form
    {
        public CadPlantio()
        {
            InitializeComponent();
        }

        private void bt_voltar_cad_plantio_Click(object sender, EventArgs e)
        {
            Plantios plantio = new Plantios ();
            this.Hide();
            plantio.ShowDialog();
            this.Close();
        }

        private void bt_cad_plantio_Click(object sender, EventArgs e)
        {
            try
            {
                plantio_controle PC = new plantio_controle();
                plantio_modelo PM = new plantio_modelo();
                PM.nome_talhao = txb_nomet_plantio.Text;
                PM.cultura = txb_cultura_plantio.Text;
                PM.variedade = txb_variedade_plantio.Text;
                PM.qtd_fertilizante = txb_qtdf_plantio.Text;
                PM.plantas_metro = txb_qtdp_mt_plantio.Text;
                PM.plantas_ha = txb_qtdp_ha_plantio.Text;
                PM.espacamento = txb_espacamento_plantio.Text;
                PM.data_plantio = txb_data_plantio.Text;

                PC.CadPlantio(PM);

                plantio_controle controle_plantio = new plantio_controle();
                if (controle_plantio.CadPlantio(PM) == true)
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }
        }
}
    

