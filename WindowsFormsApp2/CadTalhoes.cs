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
            try 
            {
                talhoes_controle TC = new talhoes_controle();
                talhoes_modelo TM = new talhoes_modelo();
                TM.nome_talhao = txb_nome_t.Text;
                TM.cult_atual = txb_culta_t.Text;
                TM.cult_ultima = txb_cultu_t.Text;
                TM.area_talhao = txb_area_t.Text;
                TM.qualidade_solo = txb_qsolo_t.Text;

                TC.CadTalhao(TM);

                talhoes_controle controle_talhoes = new talhoes_controle();
                if (controle_talhoes.CadTalhao(TM) == true)
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar!");
            }

        }
    }
}
