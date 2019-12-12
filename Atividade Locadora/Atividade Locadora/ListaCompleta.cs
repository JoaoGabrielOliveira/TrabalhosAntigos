using Locadora.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Locadora
{
    public partial class ListaCompleta : Form
    {
        public ListaCompleta()
        {
            InitializeComponent();
            DataView.DataSource = MetodosSQL.AtualizarFilmes();
            RADIO_titulo.Checked = true;

            if (EntUser.adm == false)
            {
                MENU_addFilme.Enabled = false;
                BTN_alterar.Visible = false;
                BTN_deletar.Visible = false;
            }

            if (EntUser.adm == true)
            {
                MENU_addFilme.Enabled = true;
            }
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = int.Parse(DataView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            MetodosSQL.SelecionarFilme(valor);
            LBL_titulo.Text = EntFilmes.nome;
            try
            {
                PIC_poster.Image = Image.FromFile(EntFilmes.img_src);
            }
            catch (Exception)
            {
                PIC_poster.Image = Properties.Resources.poster_default;
            }

            finally
            {
                BTN_detalhes.Visible = true;

                if (EntUser.adm == true)
                {
                    MENU_addFilme.Enabled = true;
                    BTN_alterar.Visible = true;
                    BTN_deletar.Visible = true;
                }

                else
                {

                        MENU_addFilme.Enabled = false;
                        BTN_alterar.Visible = false;
                        BTN_deletar.Visible = false;
                  
                }
            }
            
            


        }

        private void MENU_lista_Click(object sender, EventArgs e)
        {
            new frmHomeUser("").Visible = true;
            this.Enabled = false;
            this.Hide();
        }

        private void MENU_addFilme_Click(object sender, EventArgs e)
        {
            new InserirFilme(false).Visible = true;
            this.Enabled = false;
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new FilmeDetalhe().Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RADIO_id.Checked)
            {
                DataView.DataSource = MetodosSQL.Pesquisar(TXT_pesquisar.Text, "id");
            }

            if (RADIO_titulo.Checked)
            {
                DataView.DataSource = MetodosSQL.Pesquisar(TXT_pesquisar.Text, "nome");
            }

            if (RADIO_genero.Checked)
            {
                DataView.DataSource = MetodosSQL.Pesquisar(TXT_pesquisar.Text, "genero");
            }
        }

        private void ListaCompleta_Load(object sender, EventArgs e)
        {
            if (EntUser.adm == true)
            {
                MENU_addFilme.Enabled = true;
                //BTN_alterar.Visible = true;
                //BTN_deletar.Visible = true;
            }

            else
            {

                MENU_addFilme.Enabled = false;
                BTN_alterar.Visible = false;
                BTN_deletar.Visible = false;

            }
        }

        private void DataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_alterar_Click(object sender, EventArgs e)
        {
            new InserirFilme(true).Visible = true;
            this.Enabled = false;
            this.Hide();
        }

        private void BTN_deletar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
