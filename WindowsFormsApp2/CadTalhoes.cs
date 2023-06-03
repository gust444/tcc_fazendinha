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

        talhoes_modelo TM = new talhoes_modelo();
        public CadTalhoes(talhoes_modelo tM)
        {
            InitializeComponent();
            TM = tM;
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
            
               
                TM.nome_talhao = txb_nome_t.Text;
                TM.cult_atual = txb_culta_t.Text;
                TM.cult_ultima = txb_cultu_t.Text;
                TM.area_talhao = txb_area_t.Text;
                TM.qualidade_solo = txb_qsolo_t.Text;
                talhoes_controle TC = new talhoes_controle();
                
                
            if (TC.CadTalhao(TM) == true)
            {
               MessageBox.Show("Cadastrado com sucesso!");
            }
                
            else
            {
               MessageBox.Show("Erro ao cadastrar!");
            }
           

        }

        private void CadTalhoes_Load(object sender, EventArgs e)
        {
            if (TM != null)
                txb_id_talhao.Text =Convert.ToString(TM.id_talhao);
            txb_nome_t.Text=TM.nome_talhao;
              txb_culta_t.Text = TM.cult_atual;
              txb_cultu_t.Text=TM.cult_ultima;
             txb_area_t.Text= TM.area_talhao;
            txb_qsolo_t.Text= TM.qualidade_solo;
        }

        private void bt_salvar_talhao_Click(object sender, EventArgs e)
        {
            

            //TM.id_talhao = Covert.ToStrig(txb_id_talhao.Text);
            TM.nome_talhao = txb_nome_t.Text;
            TM.cult_atual = txb_culta_t.Text;
            TM.cult_ultima = txb_cultu_t.Text;
            TM.area_talhao = txb_area_t.Text;
            TM.qualidade_solo = txb_qsolo_t.Text;
            talhoes_controle TC = new talhoes_controle();


            if (TC.AttTalhao(TM) == true)
            {
                MessageBox.Show("Atualizado com sucesso!");
            }

            else
            {
                MessageBox.Show("Erro ao atualizar!");
            }

        }
    }
}
