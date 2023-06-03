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
    public partial class InfoPlantio : Form
    {
        
        public InfoPlantio()
        {
            InitializeComponent();
        }

        private void bt_voltar_info_plantio_Click(object sender, EventArgs e)
        {
            Plantios plantio = new Plantios();
            this.Hide();
            plantio.ShowDialog();
            this.Close();
        }

        private void InfoPlantio_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            tb_plantio.DataSource = conn.ObterDados("SELECT * from tb_cad_plantio");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
