﻿using System;
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
    public partial class InfoAplicacoes : Form
    {
        public InfoAplicacoes()
        {
            InitializeComponent();
        }

        private void bt_voltar_info_aplica_Click(object sender, EventArgs e)
        {
            Aplicacoes aplicacao = new Aplicacoes();
            this.Hide();
            aplicacao.ShowDialog();
            this.Close();
        }

        private void InfoAplicacoes_Load(object sender, EventArgs e)
        {
            
        }

    

        private void tb_aplica_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InfoAplicacoes_Load_1(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            tb_aplica.DataSource = conn.ObterDados("SELECT * from tb_cad_aplicacoes");
        }

        private void tb_aplica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
