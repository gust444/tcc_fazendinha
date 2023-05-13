using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Plantios : Form
    {
        public Plantios()
        {
            InitializeComponent();
        }

        private void bt_voltar_plantio_Click(object sender, EventArgs e)
        {
            MenuPrincipal inicio = new MenuPrincipal();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void bt_cad_plantio_Click(object sender, EventArgs e)
        {
            CadPlantio cad_plantio = new CadPlantio();
            this.Hide();    
            cad_plantio.ShowDialog();
            this.Close();
        }

        private void bt_info_plantio_Click(object sender, EventArgs e)
        {
            InfoPlantio info_plantio = new InfoPlantio();
            this.Hide();
            info_plantio.ShowDialog();
            this.Close();
        }
    }
}
