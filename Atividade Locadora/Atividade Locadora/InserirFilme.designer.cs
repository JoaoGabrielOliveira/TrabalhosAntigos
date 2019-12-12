namespace Atividade_Locadora
{
    partial class InserirFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_duracao = new System.Windows.Forms.MaskedTextBox();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.SLC_genero = new System.Windows.Forms.ComboBox();
            this.PIC_poster = new System.Windows.Forms.PictureBox();
            this.DLG_img = new System.Windows.Forms.SaveFileDialog();
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.LBL_img = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_trailer = new System.Windows.Forms.TextBox();
            this.TXT_sinopse = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_img = new System.Windows.Forms.TextBox();
            this.BTN_voltar = new System.Windows.Forms.Button();
            this.BTN_alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_duracao
            // 
            this.TXT_duracao.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TXT_duracao.Location = new System.Drawing.Point(286, 187);
            this.TXT_duracao.Mask = "00:00:00";
            this.TXT_duracao.Name = "TXT_duracao";
            this.TXT_duracao.Size = new System.Drawing.Size(112, 26);
            this.TXT_duracao.TabIndex = 0;
            this.TXT_duracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_nome
            // 
            this.TXT_nome.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TXT_nome.Location = new System.Drawing.Point(286, 44);
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(164, 26);
            this.TXT_nome.TabIndex = 1;
            // 
            // SLC_genero
            // 
            this.SLC_genero.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SLC_genero.FormattingEnabled = true;
            this.SLC_genero.Items.AddRange(new object[] {
            "Ação e Aventura",
            "Drama",
            "Animação",
            "Cómedia",
            "Romance",
            "Musical e Dança",
            "Documentario",
            "Ficção Científica",
            "Ficção Fantasiosa",
            "Terror"});
            this.SLC_genero.Location = new System.Drawing.Point(286, 114);
            this.SLC_genero.Name = "SLC_genero";
            this.SLC_genero.Size = new System.Drawing.Size(164, 28);
            this.SLC_genero.TabIndex = 2;
            // 
            // PIC_poster
            // 
            this.PIC_poster.BackColor = System.Drawing.Color.Transparent;
            this.PIC_poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIC_poster.Location = new System.Drawing.Point(30, 60);
            this.PIC_poster.Margin = new System.Windows.Forms.Padding(2);
            this.PIC_poster.Name = "PIC_poster";
            this.PIC_poster.Size = new System.Drawing.Size(200, 282);
            this.PIC_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_poster.TabIndex = 4;
            this.PIC_poster.TabStop = false;
            this.PIC_poster.Click += new System.EventHandler(this.Add_Poster);
            this.PIC_poster.DoubleClick += new System.EventHandler(this.Add_Poster);
            // 
            // DLG_img
            // 
            this.DLG_img.Filter = "Arquivos de Imagem (*.png,*.jpg)|*.png;*.jpg|Todos os arquivos (*.*)|*.*";
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.BTN_salvar.FlatAppearance.BorderSize = 0;
            this.BTN_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_salvar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BTN_salvar.Location = new System.Drawing.Point(213, 478);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(149, 29);
            this.BTN_salvar.TabIndex = 6;
            this.BTN_salvar.Text = "Salvar Filme";
            this.BTN_salvar.UseVisualStyleBackColor = false;
            this.BTN_salvar.Click += new System.EventHandler(this.BTN_salvar_Click);
            // 
            // LBL_img
            // 
            this.LBL_img.AutoSize = true;
            this.LBL_img.BackColor = System.Drawing.Color.Transparent;
            this.LBL_img.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LBL_img.Location = new System.Drawing.Point(55, 187);
            this.LBL_img.Name = "LBL_img";
            this.LBL_img.Size = new System.Drawing.Size(150, 21);
            this.LBL_img.TabIndex = 7;
            this.LBL_img.Text = "Selecione sua foto.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duração do Filme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sinopse:";
            // 
            // TXT_trailer
            // 
            this.TXT_trailer.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TXT_trailer.Location = new System.Drawing.Point(30, 414);
            this.TXT_trailer.Name = "TXT_trailer";
            this.TXT_trailer.Size = new System.Drawing.Size(401, 26);
            this.TXT_trailer.TabIndex = 12;
            // 
            // TXT_sinopse
            // 
            this.TXT_sinopse.BackColor = System.Drawing.Color.White;
            this.TXT_sinopse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_sinopse.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TXT_sinopse.Location = new System.Drawing.Point(286, 256);
            this.TXT_sinopse.Name = "TXT_sinopse";
            this.TXT_sinopse.Size = new System.Drawing.Size(236, 115);
            this.TXT_sinopse.TabIndex = 13;
            this.TXT_sinopse.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trailer:";
            // 
            // TXT_img
            // 
            this.TXT_img.Location = new System.Drawing.Point(286, 391);
            this.TXT_img.Name = "TXT_img";
            this.TXT_img.ReadOnly = true;
            this.TXT_img.Size = new System.Drawing.Size(100, 20);
            this.TXT_img.TabIndex = 15;
            this.TXT_img.Visible = false;
            // 
            // BTN_voltar
            // 
            this.BTN_voltar.Location = new System.Drawing.Point(17, 8);
            this.BTN_voltar.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_voltar.Name = "BTN_voltar";
            this.BTN_voltar.Size = new System.Drawing.Size(144, 25);
            this.BTN_voltar.TabIndex = 16;
            this.BTN_voltar.Text = "Voltar";
            this.BTN_voltar.UseVisualStyleBackColor = true;
            this.BTN_voltar.Click += new System.EventHandler(this.BTN_voltar_Click);
            // 
            // BTN_alterar
            // 
            this.BTN_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.BTN_alterar.FlatAppearance.BorderSize = 0;
            this.BTN_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_alterar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BTN_alterar.Location = new System.Drawing.Point(261, 478);
            this.BTN_alterar.Name = "BTN_alterar";
            this.BTN_alterar.Size = new System.Drawing.Size(149, 29);
            this.BTN_alterar.TabIndex = 17;
            this.BTN_alterar.Text = "Editar Filme";
            this.BTN_alterar.UseVisualStyleBackColor = false;
            this.BTN_alterar.Click += new System.EventHandler(this.BTN_alterar_Click);
            // 
            // InserirFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(561, 524);
            this.Controls.Add(this.BTN_alterar);
            this.Controls.Add(this.BTN_voltar);
            this.Controls.Add(this.TXT_img);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_sinopse);
            this.Controls.Add(this.TXT_trailer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_img);
            this.Controls.Add(this.BTN_salvar);
            this.Controls.Add(this.PIC_poster);
            this.Controls.Add(this.SLC_genero);
            this.Controls.Add(this.TXT_nome);
            this.Controls.Add(this.TXT_duracao);
            this.Name = "InserirFilme";
            this.Text = "InserirFilme";
            this.Load += new System.EventHandler(this.InserirFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TXT_duracao;
        private System.Windows.Forms.TextBox TXT_nome;
        private System.Windows.Forms.PictureBox PIC_poster;
        private System.Windows.Forms.SaveFileDialog DLG_img;
        private System.Windows.Forms.Button BTN_salvar;
        private System.Windows.Forms.Label LBL_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_trailer;
        private System.Windows.Forms.RichTextBox TXT_sinopse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_img;
        private System.Windows.Forms.ComboBox SLC_genero;
        private System.Windows.Forms.Button BTN_voltar;
        private System.Windows.Forms.Button BTN_alterar;
    }
}