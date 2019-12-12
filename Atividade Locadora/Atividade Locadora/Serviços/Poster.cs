using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Serviços
{
    class Poster
    {


        public Poster()
        {

        }


        public void CopiarPoster(string Poster, string NomeArquivo, string Destino)
        {
            //string fileName = "test.txt";
            //string sourcePath = @"C:\Users\Public\TestFolder";

            string sourceFile = System.IO.Path.Combine(Poster, NomeArquivo);
            string destFile = System.IO.Path.Combine(Destino, NomeArquivo);

            System.IO.Directory.CreateDirectory(Destino);
            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(Poster))
            {
                string[] files = System.IO.Directory.GetFiles(Poster);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    NomeArquivo = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(Destino, NomeArquivo);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                MessageBox.Show("Item não encontrado", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }

        }

    }
}
