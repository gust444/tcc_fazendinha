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
    public partial class Talhoes : Form
    {
        public Talhoes()
        {
            InitializeComponent();
        }

        private void bt_voltar_talhao_Click(object sender, EventArgs e)
        {
            MenuPrincipal inicio = new MenuPrincipal();
        }

        private void bt_info_talhao_Click(object sender, EventArgs e)
        {
            Form3 info_talhao = new Form3();
            this.Hide();    
            info_talhao.ShowDialog();
            this.Close();
        }
    }
}
