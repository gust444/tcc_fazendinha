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
using WindowsFormsApp2.controle;
using WindowsFormsApp2.modelo;

namespace WindowsFormsApp2
{
    public partial class InfoTalhoes : Form
    {
        talhoes_modelo TM = new talhoes_modelo();
        talhoes_controle TC = new talhoes_controle();
        int codigo;
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

        private void bt_apagar_talhoes_Click(object sender, EventArgs e)
        {
            //atribuo o conteúdo do text codigo usuário para o modelo

            TM.id_talhao = Convert.ToInt32(codigo);
            //se executar o metodo apagar corretamente retorna verdade
            if (TC.DelTalhao(TM) == true)
            {
                MessageBox.Show("Usuário excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuário não foi possivel a exclusão ");
            }
        }

        private void tb_talhao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //pega o ID do usuário
                codigo = Convert.ToInt32(tb_talhao.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                MessageBox.Show("Codigo selecionado:" + codigo);
                // carrega as informações na classe usuario
               
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao acessar o codigo: " + ex.Message);
            }
        }

        private void bt_editar_talhao_Click(object sender, EventArgs e)
        { 
            TM = TC.CarregarTalhao(codigo, TM);
            CadTalhoes cadT = new CadTalhoes(TM);
            this.Hide();
            cadT.ShowDialog();
            this.Close();
        }
    }
}
