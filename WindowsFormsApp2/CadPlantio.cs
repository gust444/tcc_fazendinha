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
    }
}
