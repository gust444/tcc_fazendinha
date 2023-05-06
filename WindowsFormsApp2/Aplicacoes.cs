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
    public partial class Aplicacoes : System.Windows.Forms.Form
    {
        public Aplicacoes()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bt_cad_aplica_Click(object sender, EventArgs e)
        {
            CadAplicacoes cad_aplicacao = new CadAplicacoes();  
            this.Hide();
            cad_aplicacao.ShowDialog();
            this.Close();
        }

        private void bt_info_aplica_Click(object sender, EventArgs e)
        {
            InfoAplicacoes info_aplica = new InfoAplicacoes();    
            this.Hide();
            info_aplica.ShowDialog();
            this.Close();
        }
    }
}
