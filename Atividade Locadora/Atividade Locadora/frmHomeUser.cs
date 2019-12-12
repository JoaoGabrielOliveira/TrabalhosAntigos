using Locadora.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Locadora
{
    public partial class frmHomeUser : Form
    {
        public frmHomeUser(String valor)
        {
            InitializeComponent();
            if (EntUser.adm == false)
            {
                Menu_addFilmes.Enabled = false;
            }

            if (EntUser.adm == true)
            {
                Menu_addFilmes.Enabled = true;
            }
        }

        public string[,] Posters = MetodosSQL.PegarPosters();

        private void frmHomeUser_Load(object sender, EventArgs e)
        {
            //{ PIC_poster1.Image = Image.FromFile(Posters[0, 0]); }
            //{ PIC_poster2.Image = Image.FromFile(Posters[1, 0]); }
            { PIC_poster3.Image = Image.FromFile(Posters[2, 0]); }
            { PIC_poster4.Image = Image.FromFile(Posters[3, 0]); }
            { PIC_poster5.Image = Image.FromFile(Posters[4, 0]); }
            { PIC_poster6.Image = Image.FromFile(Posters[5, 0]); }
            { PIC_poster7.Image = Image.FromFile(Posters[6, 0]); }

            LBL_poster1.Text = Posters[0, 1];
            LBL_poster2.Text = Posters[1, 1];
            LBL_poster3.Text = Posters[2, 1];
            LBL_poster4.Text = Posters[3, 1];
            LBL_poster5.Text = Posters[4, 1];
            LBL_poster6.Text = Posters[5, 1];
            lbl7.Text = Posters[6, 1];


        }

        private void BTN_lista_Click(object sender, EventArgs e)
        {

        }

        private void BTN_adicionarFilme_Click(object sender, EventArgs e)
        {
            new InserirFilme(false).Visible = true;
            this.Enabled = false;
            this.Hide();
        }


        private void adicionarFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InserirFilme(false).Visible = true;
            Enabled = false;
            Hide();
        }

        private void PIC_poster1_Click(object sender, EventArgs e)
        {
            // EntFilmes id = Posters[0,2];
    }

        private void ListaDeFilmesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new ListaCompleta().Visible = true;

            Enabled = false;
            Hide();
        }

        private void EditarFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InserirFilme(true).Visible = true;
            Enabled = false;
            Hide();
        }



    }
}
