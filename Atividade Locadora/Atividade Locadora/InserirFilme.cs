using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Serviços;

namespace Atividade_Locadora
{
    public partial class InserirFilme : Form
    {
        public InserirFilme(bool tipo)
        {
            InitializeComponent();
            BTN_salvar.Visible = true;
            if (tipo == true) {
                this.Text = "Atualizar Filmes";
                BTN_alterar.Visible = true;
                BTN_salvar.Visible = false;

                TXT_nome.Text = EntFilmes.nome;
                SLC_genero.Text = EntFilmes.genero;
                TXT_duracao.Text = EntFilmes.duracao;
                TXT_sinopse.Text = EntFilmes.sinopse;
                TXT_trailer.Text = EntFilmes.trailer;
                try { 
                    PIC_poster.Image = Image.FromFile(EntFilmes.img_src);
                }
                catch
                {
                    PIC_poster.Image = Atividade_Locadora.Properties.Resources.poster_default;
                }
                EntFilmes.id_admin = EntUser.id;

            }

            else
            {
                this.Text = "Inserir Filmes";
                BTN_alterar.Visible = false;
                BTN_salvar.Visible = true;
            }

        }

        

        private void AdicionarFota()
        {
            DLG_img.FileName = "";
            DLG_img.Title = "Selecionar a Imagem do Poster";
            if (DLG_img.ShowDialog() == DialogResult.OK)
            {
                PIC_poster.Image = Image.FromFile(DLG_img.FileName);
                TXT_img.Text = DLG_img.FileName;
                LBL_img.Visible = false;
            }
            else
            {
                MessageBox.Show("Você não selecionou nenhum Poster", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Add_Poster(object sender, EventArgs e)
        {
            AdicionarFota();
            
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            try { 
            EntFilmes.nome =    TXT_nome.Text;
            EntFilmes.genero =  SLC_genero.Text;
            EntFilmes.duracao = TXT_duracao.Text;
            EntFilmes.sinopse = TXT_sinopse.Text;
            string[] split = TXT_trailer.Text.Split("=".ToCharArray());
            EntFilmes.trailer = split[1];
            EntFilmes.img_src = TXT_img.Text;
            EntFilmes.id_admin = "1";

            if (MetodosSQL.InserirFilme())
            {
                TXT_nome.Text = "";
                SLC_genero.Text = "";
                TXT_duracao.Text = "";
                TXT_sinopse.Text = "";
                PIC_poster.Image = null;
            }

            else
            {

            }
            }

            catch (Exception )
            {

            }

        }

        private void Teste()
        {
            TXT_nome.Text = "Nasce uma estrela";
            SLC_genero.Text = "Drama";
            TXT_duracao.Text = "02:16:00";
            TXT_sinopse.Text = "Jackson Maine (Bradley Cooper) é um cantor no auge da fama. Um dia, após deixar uma apresentação, ele para em um bar para beber algo. É quando conhece Ally (Lady Gaga), uma insegura cantora que ganha a vida trabalhando em um restaurante. Jackson se encanta pela mulher e seu talento, decidindo acolhê-la debaixo de suas asas. Ao mesmo tempo em que Ally ascende ao estrelato, Jackson vive uma crise pessoal e profissional devido aos problemas com o álcool.";
            TXT_trailer.Text = "https://www.youtube.com/watch?v=WGsA2aXYBGo";
        }

        private void BTN_voltar_Click(object sender, EventArgs e)
        {
            new frmHomeUser("1").Visible = true;
            this.Enabled = false;
            this.Hide();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) { }
                //txtSenha.Focus();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) { }
                //btnEntrar.PerformClick();
        }

        private void InserirFilme_Load(object sender, EventArgs e)
        {

        }

        private void BTN_alterar_Click(object sender, EventArgs e)
        {
            EntFilmes.nome = TXT_nome.Text;
            EntFilmes.genero = SLC_genero.Text;
            EntFilmes.duracao = TXT_duracao.Text;
            EntFilmes.sinopse = TXT_sinopse.Text;
            string[] split = TXT_trailer.Text.Split("=".ToCharArray());
            EntFilmes.trailer = split[1];
            EntFilmes.img_src = TXT_img.Text;
            EntFilmes.id_admin = "1";

            MetodosSQL.AlterarFilme(int.Parse(EntFilmes.id));
        }
    }
}
