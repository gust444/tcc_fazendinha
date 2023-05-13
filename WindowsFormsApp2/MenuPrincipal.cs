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
    public partial class MenuPrincipal : System.Windows.Forms.Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void bt_talhoes_Click(object sender, EventArgs e)
        {
            Talhoes talhoes = new Talhoes();
            this.Hide();
            talhoes.ShowDialog();
            this.Close();

        }

        private void bt_plantio_Click(object sender, EventArgs e)
        {
            Plantios plantio = new Plantios();
            this.Hide();
            plantio.ShowDialog();
            this.Close();

        }

        private void bt_aplicacao_Click(object sender, EventArgs e)
        {
            Aplicacoes aplicacao = new Aplicacoes();
            this.Hide();
            aplicacao.ShowDialog();
            this.Close();

        }
    }
}
