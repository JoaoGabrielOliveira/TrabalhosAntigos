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
    public partial class FilmeDetalhe : Form
    {

        private Uri trailer; 
        public FilmeDetalhe()
        {
            InitializeComponent();

            if (EntFilmes.trailer != String.Empty)
            {
                trailer = new Uri(Application.StartupPath + @"/filme.html");
                //https://www.youtube.com/embed/iywaBOMvYLI
            }
            LBL_titulo.Text = EntFilmes.nome;
            LBL_genero.Text = EntFilmes.genero;
            LBL_textDuracao.Text = EntFilmes.duracao;
            LBL_txtSinopse.Text = EntFilmes.sinopse;
            try
            {
                PIC_poster.Image = Image.FromFile(EntFilmes.img_src);
            }
            catch (Exception)
            {
                PIC_poster.Image = Properties.Resources.poster_default;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BTN_closeTrailer.Visible = false;

        }

        private void BTN_trailer_Click(object sender, EventArgs e)
        {
            BTN_closeTrailer.Visible = true;
        }

        private void Flash_trailer_Enter(object sender, EventArgs e)
        {

        }
    }
}
