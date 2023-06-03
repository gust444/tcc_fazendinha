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
    public partial class CadAplicacoes : System.Windows.Forms.Form
    {
        public CadAplicacoes()
        {
            InitializeComponent();
        }

        private void bt_voltar_cad_aplica_Click(object sender, EventArgs e)
        {
            Aplicacoes aplicacao = new Aplicacoes();
            this.Hide();    
            aplicacao.ShowDialog();
            this.Close();
        }

        private void bt_confirma_cad_aplica_Click(object sender, EventArgs e)
        {
            
                aplica_controle AC = new aplica_controle();
                aplica_modelo AM = new aplica_modelo();
                AM.nome_talhao = txb_nomet_aplica.Text;
                AM.defensivo = txb_defensivo_aplica.Text;
                AM.finalidade = txb_finalidade_aplica.Text;
                AM.principio_ativo = txb_pativo_aplica.Text;
                AM.modo_acao = txb_modoa_aplica.Text;
                AM.dosagem_ha = txb_doseha_aplica.Text;
                AM.data_aplicacao = txb_data_aplica.Text;
             
            
            if(AC.CadAplicacao(AM) == true)
            {
                    MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
            
        }
    }
}
