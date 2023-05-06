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
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            MenuPrincipal entrar = new MenuPrincipal();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }

        private void box_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
