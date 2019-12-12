namespace Atividade_Locadora
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.lklTrocar = new System.Windows.Forms.LinkLabel();
            this.txtcadconfSenha = new System.Windows.Forms.TextBox();
            this.txtcadEmail = new System.Windows.Forms.TextBox();
            this.txtcadSenha = new System.Windows.Forms.TextBox();
            this.txtcadNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtadmUsename = new System.Windows.Forms.TextBox();
            this.txtadmSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnconf_email = new System.Windows.Forms.Button();
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(181, 338);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 39);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Logar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.entrarUser);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DimGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(94, 174);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.DimGray;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(94, 257);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '֎';
            this.txtSenha.Size = new System.Drawing.Size(253, 29);
            this.txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(190, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl1.Location = new System.Drawing.Point(194, 144);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 22);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(851, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(89, 52);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(265, 28);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "Entrar no LocalFilmes";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lklTrocar
            // 
            this.lklTrocar.ActiveLinkColor = System.Drawing.Color.LightBlue;
            this.lklTrocar.AutoSize = true;
            this.lklTrocar.BackColor = System.Drawing.Color.Transparent;
            this.lklTrocar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklTrocar.LinkColor = System.Drawing.Color.Red;
            this.lklTrocar.Location = new System.Drawing.Point(12, 424);
            this.lklTrocar.Name = "lklTrocar";
            this.lklTrocar.Size = new System.Drawing.Size(102, 22);
            this.lklTrocar.TabIndex = 8;
            this.lklTrocar.TabStop = true;
            this.lklTrocar.Text = "Cadastrar";
            this.lklTrocar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtcadconfSenha
            // 
            this.txtcadconfSenha.BackColor = System.Drawing.Color.DimGray;
            this.txtcadconfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadconfSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadconfSenha.Location = new System.Drawing.Point(221, 297);
            this.txtcadconfSenha.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtcadconfSenha.Name = "txtcadconfSenha";
            this.txtcadconfSenha.PasswordChar = '֎';
            this.txtcadconfSenha.Size = new System.Drawing.Size(253, 29);
            this.txtcadconfSenha.TabIndex = 10;
            this.txtcadconfSenha.Visible = false;
            // 
            // txtcadEmail
            // 
            this.txtcadEmail.BackColor = System.Drawing.Color.DimGray;
            this.txtcadEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadEmail.Location = new System.Drawing.Point(132, 214);
            this.txtcadEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtcadEmail.Name = "txtcadEmail";
            this.txtcadEmail.Size = new System.Drawing.Size(251, 29);
            this.txtcadEmail.TabIndex = 9;
            this.txtcadEmail.Visible = false;
            // 
            // txtcadSenha
            // 
            this.txtcadSenha.BackColor = System.Drawing.Color.DimGray;
            this.txtcadSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadSenha.Location = new System.Drawing.Point(132, 257);
            this.txtcadSenha.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtcadSenha.Name = "txtcadSenha";
            this.txtcadSenha.PasswordChar = '֎';
            this.txtcadSenha.Size = new System.Drawing.Size(342, 29);
            this.txtcadSenha.TabIndex = 12;
            this.txtcadSenha.Visible = false;
            // 
            // txtcadNome
            // 
            this.txtcadNome.BackColor = System.Drawing.Color.DimGray;
            this.txtcadNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadNome.Location = new System.Drawing.Point(132, 174);
            this.txtcadNome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtcadNome.Name = "txtcadNome";
            this.txtcadNome.Size = new System.Drawing.Size(342, 29);
            this.txtcadNome.TabIndex = 11;
            this.txtcadNome.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(62, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(62, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(62, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Senha";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(62, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Confirmar senha";
            this.label7.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(198, 338);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 39);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.cadastrar);
            // 
            // txtadmUsename
            // 
            this.txtadmUsename.BackColor = System.Drawing.Color.DimGray;
            this.txtadmUsename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadmUsename.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmUsename.Location = new System.Drawing.Point(56, 182);
            this.txtadmUsename.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtadmUsename.Name = "txtadmUsename";
            this.txtadmUsename.Size = new System.Drawing.Size(251, 29);
            this.txtadmUsename.TabIndex = 18;
            this.txtadmUsename.Visible = false;
            // 
            // txtadmSenha
            // 
            this.txtadmSenha.BackColor = System.Drawing.Color.DimGray;
            this.txtadmSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadmSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmSenha.Location = new System.Drawing.Point(164, 257);
            this.txtadmSenha.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtadmSenha.Name = "txtadmSenha";
            this.txtadmSenha.Size = new System.Drawing.Size(251, 29);
            this.txtadmSenha.TabIndex = 19;
            this.txtadmSenha.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(137, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usename";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(148, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Senha";
            this.label3.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(194, 301);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(88, 29);
            this.btnEntrar.TabIndex = 22;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Visible = false;
            this.btnEntrar.Click += new System.EventHandler(this.entrarAdm);
            // 
            // btnconf_email
            // 
            this.btnconf_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconf_email.Location = new System.Drawing.Point(390, 214);
            this.btnconf_email.Name = "btnconf_email";
            this.btnconf_email.Size = new System.Drawing.Size(84, 30);
            this.btnconf_email.TabIndex = 23;
            this.btnconf_email.Text = "confirmar";
            this.btnconf_email.UseVisualStyleBackColor = true;
            this.btnconf_email.Visible = false;
            this.btnconf_email.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblEsqueciSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(93, 299);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(164, 20);
            this.lblEsqueciSenha.TabIndex = 24;
            this.lblEsqueciSenha.Text = "Esqueceu sua Senha?";
            this.lblEsqueciSenha.Click += new System.EventHandler(this.LblEsqueciSenha_Click);
            this.lblEsqueciSenha.MouseEnter += new System.EventHandler(this.Hover);
            this.lblEsqueciSenha.MouseLeave += new System.EventHandler(this.DDLeave);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 455);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.btnconf_email);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadmSenha);
            this.Controls.Add(this.txtadmUsename);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcadSenha);
            this.Controls.Add(this.txtcadNome);
            this.Controls.Add(this.txtcadconfSenha);
            this.Controls.Add(this.txtcadEmail);
            this.Controls.Add(this.lklTrocar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.LinkLabel lklTrocar;
        private System.Windows.Forms.TextBox txtcadconfSenha;
        private System.Windows.Forms.TextBox txtcadEmail;
        private System.Windows.Forms.TextBox txtcadSenha;
        private System.Windows.Forms.TextBox txtcadNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtadmUsename;
        private System.Windows.Forms.TextBox txtadmSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnconf_email;
        private System.Windows.Forms.Label lblEsqueciSenha;
    }
}