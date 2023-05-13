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
    public partial class CadTalhoes : Form
    {
        public CadTalhoes()
        {
            InitializeComponent();
        }

        private void bt_voltar_cad_talhao_Click(object sender, EventArgs e)
        {
            Talhoes talhoes = new Talhoes();
            this.Hide();
            talhoes.ShowDialog();   
            this.Close();
        }

        private void bt_cad_talhao_Click(object sender, EventArgs e)
        {

        }
    }
}
