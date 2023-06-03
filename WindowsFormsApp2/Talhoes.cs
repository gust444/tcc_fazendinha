using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.modelo;

namespace WindowsFormsApp2
{
    public partial class Talhoes : Form
    {
        talhoes_modelo TM = new talhoes_modelo();
        public Talhoes()
        {
            InitializeComponent();
        }

        private void bt_voltar_talhao_Click(object sender, EventArgs e)
        {
            MenuPrincipal inicio = new MenuPrincipal();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void bt_info_talhao_Click(object sender, EventArgs e)
        {
            InfoTalhoes info_talhao = new InfoTalhoes();
            this.Hide();    
            info_talhao.ShowDialog();
            this.Close();
        }

        private void bt_cad_talhao_Click(object sender, EventArgs e)
        {
            CadTalhoes cad_talhao = new CadTalhoes(TM);
            this.Hide();
            cad_talhao.ShowDialog();
            this.Close();
        }
    }
}
