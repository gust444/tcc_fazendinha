using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class InfoTalhoes : Form
    {
        talhoes_modelo modelo_talhao = new talhoes_modelo();
        public InfoTalhoes()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();   
            tb_talhao.DataSource = conn.ObterDados("SELECT * from tb_add_talhao");
        }

        private void bt_voltar_info_talhao_Click(object sender, EventArgs e)
        {
            Talhoes talhoes = new Talhoes();
            this.Hide();
            talhoes.ShowDialog();
            this.Close();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
