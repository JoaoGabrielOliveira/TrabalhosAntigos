namespace Atividade_Locadora
{
    partial class ListaCompleta
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
            this.DataView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_lista = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_addFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.PIC_poster = new System.Windows.Forms.PictureBox();
            this.LBL_titulo = new System.Windows.Forms.Label();
            this.BTN_detalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GRP_filtros = new System.Windows.Forms.GroupBox();
            this.RADIO_genero = new System.Windows.Forms.RadioButton();
            this.RADIO_titulo = new System.Windows.Forms.RadioButton();
            this.RADIO_id = new System.Windows.Forms.RadioButton();
            this.TXT_pesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_deletar = new System.Windows.Forms.Button();
            this.BTN_alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_poster)).BeginInit();
            this.GRP_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(385, 279);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersVisible = false;
            this.DataView.RowHeadersWidth = 62;
            this.DataView.ShowEditingIcon = false;
            this.DataView.Size = new System.Drawing.Size(325, 241);
            this.DataView.TabIndex = 1;
            this.DataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick_1);
            this.DataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_lista,
            this.MENU_addFilme});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // MENU_lista
            // 
            this.MENU_lista.Name = "MENU_lista";
            this.MENU_lista.Size = new System.Drawing.Size(164, 22);
            this.MENU_lista.Text = "Voltar para Menu";
            this.MENU_lista.Click += new System.EventHandler(this.MENU_lista_Click);
            // 
            // MENU_addFilme
            // 
            this.MENU_addFilme.Name = "MENU_addFilme";
            this.MENU_addFilme.Size = new System.Drawing.Size(164, 22);
            this.MENU_addFilme.Text = "Adicionar Filmes";
            this.MENU_addFilme.Click += new System.EventHandler(this.MENU_addFilme_Click);
            // 
            // PIC_poster
            // 
            this.PIC_poster.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PIC_poster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(128)))), ((int)(((byte)(92)))));
            this.PIC_poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIC_poster.Location = new System.Drawing.Point(39, 35);
            this.PIC_poster.Margin = new System.Windows.Forms.Padding(2);
            this.PIC_poster.Name = "PIC_poster";
            this.PIC_poster.Size = new System.Drawing.Size(200, 282);
            this.PIC_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_poster.TabIndex = 11;
            this.PIC_poster.TabStop = false;
            // 
            // LBL_titulo
            // 
            this.LBL_titulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_titulo.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LBL_titulo.Location = new System.Drawing.Point(39, 328);
            this.LBL_titulo.Name = "LBL_titulo";
            this.LBL_titulo.Size = new System.Drawing.Size(200, 47);
            this.LBL_titulo.TabIndex = 12;
            this.LBL_titulo.Text = "Titulo do Filme";
            this.LBL_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_detalhes
            // 
            this.BTN_detalhes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_detalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_detalhes.Location = new System.Drawing.Point(59, 387);
            this.BTN_detalhes.Name = "BTN_detalhes";
            this.BTN_detalhes.Size = new System.Drawing.Size(161, 33);
            this.BTN_detalhes.TabIndex = 14;
            this.BTN_detalhes.Text = "Ver Detalhes";
            this.BTN_detalhes.UseVisualStyleBackColor = false;
            this.BTN_detalhes.Visible = false;
            this.BTN_detalhes.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(484, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GRP_filtros
            // 
            this.GRP_filtros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GRP_filtros.Controls.Add(this.RADIO_genero);
            this.GRP_filtros.Controls.Add(this.RADIO_titulo);
            this.GRP_filtros.Controls.Add(this.RADIO_id);
            this.GRP_filtros.Location = new System.Drawing.Point(387, 194);
            this.GRP_filtros.Name = "GRP_filtros";
            this.GRP_filtros.Size = new System.Drawing.Size(323, 67);
            this.GRP_filtros.TabIndex = 16;
            this.GRP_filtros.TabStop = false;
            this.GRP_filtros.Text = "Filtros";
            // 
            // RADIO_genero
            // 
            this.RADIO_genero.AutoSize = true;
            this.RADIO_genero.BackColor = System.Drawing.Color.Transparent;
            this.RADIO_genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RADIO_genero.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RADIO_genero.Location = new System.Drawing.Point(203, 25);
            this.RADIO_genero.Margin = new System.Windows.Forms.Padding(2);
            this.RADIO_genero.Name = "RADIO_genero";
            this.RADIO_genero.Size = new System.Drawing.Size(82, 25);
            this.RADIO_genero.TabIndex = 2;
            this.RADIO_genero.TabStop = true;
            this.RADIO_genero.Text = "Gênero";
            this.RADIO_genero.UseVisualStyleBackColor = false;
            // 
            // RADIO_titulo
            // 
            this.RADIO_titulo.AutoSize = true;
            this.RADIO_titulo.BackColor = System.Drawing.Color.Transparent;
            this.RADIO_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RADIO_titulo.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RADIO_titulo.Location = new System.Drawing.Point(107, 25);
            this.RADIO_titulo.Margin = new System.Windows.Forms.Padding(2);
            this.RADIO_titulo.Name = "RADIO_titulo";
            this.RADIO_titulo.Size = new System.Drawing.Size(68, 25);
            this.RADIO_titulo.TabIndex = 1;
            this.RADIO_titulo.TabStop = true;
            this.RADIO_titulo.Text = "Titulo";
            this.RADIO_titulo.UseVisualStyleBackColor = false;
            // 
            // RADIO_id
            // 
            this.RADIO_id.AutoSize = true;
            this.RADIO_id.BackColor = System.Drawing.Color.Transparent;
            this.RADIO_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RADIO_id.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RADIO_id.Location = new System.Drawing.Point(19, 25);
            this.RADIO_id.Margin = new System.Windows.Forms.Padding(2);
            this.RADIO_id.Name = "RADIO_id";
            this.RADIO_id.Size = new System.Drawing.Size(43, 25);
            this.RADIO_id.TabIndex = 0;
            this.RADIO_id.TabStop = true;
            this.RADIO_id.Text = "ID";
            this.RADIO_id.UseVisualStyleBackColor = false;
            // 
            // TXT_pesquisar
            // 
            this.TXT_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TXT_pesquisar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TXT_pesquisar.Location = new System.Drawing.Point(417, 98);
            this.TXT_pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_pesquisar.Name = "TXT_pesquisar";
            this.TXT_pesquisar.Size = new System.Drawing.Size(276, 31);
            this.TXT_pesquisar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_deletar
            // 
            this.BTN_deletar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_deletar.Location = new System.Drawing.Point(59, 487);
            this.BTN_deletar.Name = "BTN_deletar";
            this.BTN_deletar.Size = new System.Drawing.Size(161, 33);
            this.BTN_deletar.TabIndex = 22;
            this.BTN_deletar.Text = "Deletar";
            this.BTN_deletar.UseVisualStyleBackColor = false;
            this.BTN_deletar.Visible = false;
            this.BTN_deletar.Click += new System.EventHandler(this.BTN_deletar_Click);
            // 
            // BTN_alterar
            // 
            this.BTN_alterar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_alterar.Location = new System.Drawing.Point(59, 448);
            this.BTN_alterar.Name = "BTN_alterar";
            this.BTN_alterar.Size = new System.Drawing.Size(161, 33);
            this.BTN_alterar.TabIndex = 21;
            this.BTN_alterar.Text = "Alterar";
            this.BTN_alterar.UseVisualStyleBackColor = false;
            this.BTN_alterar.Visible = false;
            this.BTN_alterar.Click += new System.EventHandler(this.BTN_alterar_Click);
            // 
            // ListaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(741, 530);
            this.Controls.Add(this.BTN_deletar);
            this.Controls.Add(this.BTN_alterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_pesquisar);
            this.Controls.Add(this.GRP_filtros);
            this.Controls.Add(this.BTN_detalhes);
            this.Controls.Add(this.LBL_titulo);
            this.Controls.Add(this.PIC_poster);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DataView);
            this.Name = "ListaCompleta";
            this.Text = "ListaCompleta";
            this.Load += new System.EventHandler(this.ListaCompleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_poster)).EndInit();
            this.GRP_filtros.ResumeLayout(false);
            this.GRP_filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MENU_lista;
        private System.Windows.Forms.ToolStripMenuItem MENU_addFilme;
        private System.Windows.Forms.PictureBox PIC_poster;
        private System.Windows.Forms.Label LBL_titulo;
        private System.Windows.Forms.Button BTN_detalhes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GRP_filtros;
        private System.Windows.Forms.RadioButton RADIO_genero;
        private System.Windows.Forms.RadioButton RADIO_titulo;
        private System.Windows.Forms.RadioButton RADIO_id;
        private System.Windows.Forms.TextBox TXT_pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_deletar;
        private System.Windows.Forms.Button BTN_alterar;
    }
}