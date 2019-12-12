using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Serviços
{
    class MetodosSQL
    {
        
        public static string connectionString = @"Data Source=EL319;Initial Catalog=systemLocadora;Persist Security Info=True;User ID=etec;Password=1234";
        //np:\\.\pipe\LOCALDB#86C717FF\tsql\query 
        //@"Data Source=EL319;Initial Catalog=systemLocadora;Persist Security Info=True;User ID=etec;Password=1234"
        //@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=systemLocadora;Persist Security Info=True;"

        public static SqlConnection conn = new SqlConnection(MetodosSQL.connectionString);

        public static DataTable AtualizarFilmes()
        {
            conn.Open();

            DataTable tabelas = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as ID, nome as Titulo, genero as '" + "Gênero" + "' FROM filmes", conn); //, genero as Genêro, sinopse as Sinopse
            adapter.Fill(tabelas);

            conn.Close();

            return tabelas;
        }

        public static bool InserirFilme()
        {
            conn.Open();

            SqlCommand command = new SqlCommand("INSERT INTO filmes" +
                "(nome,genero,sinopse,duracao, id_admin, img_src,trailer) VALUES" +
                "('" + EntFilmes.nome + "'," +
                "'" + EntFilmes.genero + "'," +
                "'" + EntFilmes.sinopse + " '," +
                "'" + EntFilmes.duracao + "'," +
                int.Parse(EntFilmes.id_admin) + "," +
                "'" + EntFilmes.img_src + "'," +
                "'" + EntFilmes.trailer + "');", conn);  //URL do trailer do filme
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir dados\n" + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally {
                conn.Close();
            }


        }

        public static void SelecionarFilme(int ID)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM filmes WHERE id =" + ID, conn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                EntFilmes.id = dataReader.GetValue(0).ToString();
                EntFilmes.nome = dataReader.GetValue(1).ToString();
                EntFilmes.genero = dataReader.GetValue(2).ToString();
                EntFilmes.sinopse = dataReader.GetValue(3).ToString();
                EntFilmes.img_src = dataReader.GetValue(4).ToString();
                EntFilmes.duracao = dataReader.GetValue(5).ToString();
                EntFilmes.trailer = dataReader.GetValue(6).ToString();
                EntFilmes.id_admin = dataReader.GetValue(7).ToString();
            }

            conn.Close();
        }

        public static bool DeletarFilme(int ID)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("DELETE FROM filmes WHERE id="+ ID + "", conn);  //URL do trailer do filme
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Excluir dados\n" + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool AlterarFilme(int ID)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("Update filmes set nome='"+ EntFilmes.nome + "',genero='"+ EntFilmes.genero + "', duracao='"+ EntFilmes.duracao + "', sinopse='"+ EntFilmes.sinopse+"',trailer='" + EntFilmes.trailer + "'  where id =" +  ID + "", conn);  //URL do trailer do filme
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Atualizar dados\n" + e, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public static string[,] PegarPosters()
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT TOP 7 img_src,nome,id FROM filmes", conn);
            SqlDataReader dataReader = command.ExecuteReader();
            string[,] lista = new string[7, 3];
            int i = 0;
            while (dataReader.Read())
            {
                lista[i, 0] = dataReader.GetValue(0).ToString();
                lista[i, 1] = dataReader.GetValue(1).ToString();
                lista[i, 2] = dataReader.GetValue(2).ToString();
                i++;
            }

            conn.Close();

            return lista;
        }

        public static DataTable Pesquisar(string pesquisa, string filtro){
            conn.Open();

            DataTable tabelas = new DataTable();
            string sqlcode = "";

            if (filtro == null)
            {
                sqlcode = "SELECT id as ID, nome as Titulo, as genero as 'Gênero' FROM filmes WHERE Titulo like '%" + pesquisa + "%' ORDER BY";
            }

            else
            {
                sqlcode = "SELECT id as ID, nome as Titulo FROM filmes WHERE " + filtro + " like '%" + pesquisa + "%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(sqlcode, conn); //, genero as Genêro, sinopse as Sinopse
            adapter.Fill(tabelas);
            conn.Close();
            return tabelas;
        }

        public static bool Login(string Email, string Senha)
        {
            try
            {
                conn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                string sql = "Select id_usuario,nome,email,senha,adm from usuario where email = '" + Email + "' and senha = '" + Senha + "'";

                command = new SqlCommand(sql, conn);

                dataReader = command.ExecuteReader();

                if (!dataReader.Read())
                {
                    dataReader.Close();
                    command.Dispose();
                    conn.Close();
                    return false;
                }
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlDataReader data = cmd.ExecuteReader();

                dataReader.Close();
                command.Dispose();
                conn.Close();


                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read()) 
                {
                    EntUser.id = dataReader.GetValue(0).ToString();
                    EntUser.nome = dataReader.GetValue(1).ToString();
                    EntUser.email = dataReader.GetValue(2).ToString();
                    EntUser.senha = dataReader.GetValue(3).ToString();
                        if (dataReader.GetValue(4).ToString() == "1")
                        {
                            EntUser.adm = false;
                        }

                        else
                        {
                            EntUser.adm = true;
                        }

                }
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro! ..." + e);
                return false;
            }

            finally
            {
                conn.Close();
            }
        }

        public static bool Login(string Email)
        {
            try
            {
                conn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                string sql = "Select * from usuario where email = '" + Email + "'";

                command = new SqlCommand(sql, conn);

                dataReader = command.ExecuteReader();

                if (!dataReader.Read())
                {
                    dataReader.Close();
                    command.Dispose();
                    conn.Close();
                    return false;
                }

                dataReader.Close();
                command.Dispose();
                conn.Close();


                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    EntUser.id = dataReader.GetValue(0).ToString();
                    EntUser.nome = dataReader.GetValue(1).ToString();
                    EntUser.email = dataReader.GetValue(2).ToString();
                    EntUser.senha = dataReader.GetValue(3).ToString();
                }

                conn.Close();
                return true;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro! ..." + e);
                conn.Close();
                return false;
                
            }
        }
        
        public static bool SendEmail(string Assunto, string Corpo, string Destinatario, string NomeDestinatario)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("joaogabrieloliveira81@gmail.com", "adorojogar");

            MailMessage mail = new MailMessage();

            mail.Sender = new System.Net.Mail.MailAddress("joaogabrieloliveira81@gmail.com", "adorojogar");

            mail.From = new MailAddress("joaogabrieloliveira81@gmail.com", "System Locadora");

            mail.To.Add(new MailAddress(Destinatario, NomeDestinatario));
            mail.Subject = Assunto;
            mail.Body = Corpo;
            mail.IsBodyHtml = true; 
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
                return true;
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro + "");
                return false;
            }
            finally
            {
                mail = null;
                conn.Close();
            }
        }

    }
}
