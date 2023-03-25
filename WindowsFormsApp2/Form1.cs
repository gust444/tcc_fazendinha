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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Form2 entrar = new Form2();
            entrar.ShowDialog();
            this.Close();
        }

        private void box_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
