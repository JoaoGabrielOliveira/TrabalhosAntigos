using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Locadora.Serviços;

namespace Atividade_Locadora
{
    public partial class login : Form
    {
        public String id_Usuario = "";
        public login()
        {
            InitializeComponent();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (contUsuario % 2 == 1)
            {
                txtEmail.Visible = false;
                txtSenha.Visible = false;
                txtcadNome.Visible = false;
                txtcadEmail.Visible = false;
                txtcadSenha.Visible = false;
                txtcadconfSenha.Visible = false;
                btnconf_email.Visible = false;
                lbl1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                btnCadastrar.Visible = false;
                btnLogin.Visible = false;
                lklTrocar.Visible = false;

                txtadmSenha.Visible = true;
                txtadmUsename.Visible = true;
                btnEntrar.Visible = true;
                label2.Visible = true;
                label3.Visible = true;

                titulo.Text = "Administrador";
                contUsuario++;

            }
            else if (contUsuario % 2 == 0)
            {

                txtadmSenha.Visible = false;
                txtadmUsename.Visible = false;
                btnEntrar.Visible = false;

                txtEmail.Visible = true;
                txtSenha.Visible = true;
                txtcadNome.Visible = false;
                txtcadEmail.Visible = false;
                txtcadSenha.Visible = false;
                txtcadconfSenha.Visible = false;
                btnconf_email.Visible = false;
                lbl1.Visible = true;
                label1.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                btnCadastrar.Visible = false;
                btnLogin.Visible = true;
                lklTrocar.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                titulo.Text = "Entrar no LocalFilmes";
                lklTrocar.Text = "Cadastro";
                contUsuario++;
            }
        }
        int contTrocar = 1;
        int contUsuario = 1;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (contTrocar % 2 == 1)
            {
                txtEmail.Visible = false;
                txtSenha.Visible = false;
                txtcadNome.Visible = true;
                txtcadEmail.Visible = true;
                txtcadSenha.Visible = true;
                txtcadconfSenha.Visible = true;
                btnconf_email.Visible = true;
                lbl1.Visible = false;
                label1.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                lblEsqueciSenha.Visible = false;
                btnLogin.Visible = false;
                titulo.Text = "Criar Uma conta ";
                lklTrocar.Text = "Login";
                contTrocar++;
            }
            else if (contTrocar % 2 == 0)
            {
                txtEmail.Visible = true;
                txtSenha.Visible = true;
                txtcadNome.Visible = false;
                txtcadEmail.Visible = false;
                txtcadSenha.Visible = false;
                txtcadconfSenha.Visible = false;
                btnconf_email.Visible = false;
                lbl1.Visible = true;
                label1.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                lblEsqueciSenha.Visible = true;
                btnLogin.Visible = true;
                btnCadastrar.Visible = false;
                titulo.Text = "Entrar no LocalFilmes";
                lklTrocar.Text = "Cadastro";
                contTrocar++;
            }
        }




        private void entrarAdm(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source=localhost;Initial Catalog=bancoLocadora;Persist Security Info=True;User ID=etec;Password=1234";

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;
                sql = "Select id_usuario from administrador where usename = '" + txtadmUsename.Text + "' and senha = '" + txtadmSenha.Text + "'";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    id_Usuario = id_Usuario + dataReader.GetValue(0);
                    if (id_Usuario != "")
                    {

                        dataReader.Close();
                        command.Dispose();
                        cnn.Close();
                        //page.Visible = true;
                        this.Hide();
                    }
                }

                MessageBox.Show("Não Encontramos essas informações no sistema");

                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Erro! ...");
            }

        }




        private void entrarUser(object sender, EventArgs e)
        {
            if (MetodosSQL.Login(txtEmail.Text, txtSenha.Text))
            {
                frmHomeUser page = new frmHomeUser(id_Usuario);
                page.Visible = true;
                this.Hide();
            }

            else
            {
                MessageBox.Show("Email invalido ou senha");
            }

        }

        private void cadastrar(object sender, EventArgs e)
        {
            try
            {
                string sql;
                SqlConnection cnn;

                cnn = new SqlConnection(MetodosSQL.connectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (txtSenha.Text.Length > 6 && txtSenha.Text.Length < 16)
                {
                    if (txtcadEmail.Text != "" && txtcadNome.Text != "" && txtcadSenha.Text != "")
                    {
                        sql = "insert into usuario (nome,email,senha,adm) values ('" + txtcadNome.Text + "','" + txtcadEmail.Text + "','" + txtcadSenha.Text + "',1);";
                        command = new SqlCommand(sql, cnn);
                        adapter.InsertCommand = new SqlCommand(sql, cnn);


                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Dados cadastrados com Sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        command.Dispose();

                    }
                }


                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Erro no envio de dados! ...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCadastrar.Visible = true;
        }
        public void verificar()
        {
            string email = txtcadEmail.Text;
            Regex regver = new Regex(("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$"));
            Match match = regver.Match(email);
            if (match.Success)
            {
                MessageBox.Show("Email Valido");
            }
            else
            {
                MessageBox.Show("Email Invalido");
            }

        }

        private void Hover(object sender, EventArgs e)
        {
            lblEsqueciSenha.ForeColor = Color.Red;
        }

        private void LblEsqueciSenha_Click(object sender, EventArgs e)
        {
            if (MetodosSQL.Login(txtEmail.Text))
            {
                MessageBox.Show("Email carregado!");
                if (MetodosSQL.SendEmail("Esqueceu sua Senha", "<h2>Você solicitou que sua senha fosse enviada.</h2>" +
                    "<p>Sua <b>senha</b> é:</p>" +
                    "<p><b>" + EntUser.senha + "</b></p>", EntUser.email, EntUser.nome))
                {
                    MessageBox.Show("Email enviado!");
                }

                else
                {
                    MessageBox.Show("Email não enviado!\nEmail invalido!");
                }
            }

            else
            {
                MessageBox.Show("Email não cadastrado");
            }
        }

        private void DDLeave(object sender, EventArgs e)
        {
            lblEsqueciSenha.ForeColor = Color.FromArgb(0,255,235);
        }
    }
}
