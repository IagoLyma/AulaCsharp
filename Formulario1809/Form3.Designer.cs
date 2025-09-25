namespace Formulario1809
{
    partial class form_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cadastro));
            lbl_user = new Label();
            lbl_senha = new Label();
            label3 = new Label();
            txt_user = new TextBox();
            txt_senha = new TextBox();
            txt_confsenha = new TextBox();
            btn_criar = new Button();
            btn_voltar = new Button();
            lbl_title = new Label();
            grid_users = new DataGridView();
            btn_consultar = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_users).BeginInit();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.BackColor = Color.Transparent;
            lbl_user.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_user.Location = new Point(423, 93);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(78, 25);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_senha.Location = new Point(423, 173);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(65, 25);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(423, 251);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Senha";
            // 
            // txt_user
            // 
            txt_user.Cursor = Cursors.IBeam;
            txt_user.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            txt_user.Location = new Point(425, 119);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(281, 29);
            txt_user.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Cursor = Cursors.IBeam;
            txt_senha.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            txt_senha.Location = new Point(425, 198);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(281, 29);
            txt_senha.TabIndex = 4;
            // 
            // txt_confsenha
            // 
            txt_confsenha.Cursor = Cursors.IBeam;
            txt_confsenha.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            txt_confsenha.Location = new Point(425, 277);
            txt_confsenha.Name = "txt_confsenha";
            txt_confsenha.Size = new Size(281, 29);
            txt_confsenha.TabIndex = 5;
            // 
            // btn_criar
            // 
            btn_criar.BackColor = Color.LightCyan;
            btn_criar.Cursor = Cursors.Hand;
            btn_criar.FlatStyle = FlatStyle.Flat;
            btn_criar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criar.ForeColor = SystemColors.ActiveCaptionText;
            btn_criar.Location = new Point(490, 328);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(140, 31);
            btn_criar.TabIndex = 6;
            btn_criar.Text = "Criar Usuário";
            btn_criar.UseVisualStyleBackColor = false;
            btn_criar.Click += btn_criar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Font = new Font("Segoe UI", 12F);
            btn_voltar.Location = new Point(704, 408);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(84, 30);
            btn_voltar.TabIndex = 7;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.Black;
            lbl_title.Location = new Point(155, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(429, 47);
            lbl_title.TabIndex = 8;
            lbl_title.Text = "CADASTRO DE USUÁRIO";
            // 
            // grid_users
            // 
            grid_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_users.Location = new Point(12, 202);
            grid_users.Name = "grid_users";
            grid_users.Size = new Size(316, 236);
            grid_users.TabIndex = 9;
            // 
            // btn_consultar
            // 
            btn_consultar.Cursor = Cursors.Hand;
            btn_consultar.Location = new Point(12, 152);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(137, 30);
            btn_consultar.TabIndex = 10;
            btn_consultar.Text = "Consultar Usuários";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // form_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_consultar);
            Controls.Add(grid_users);
            Controls.Add(lbl_title);
            Controls.Add(btn_voltar);
            Controls.Add(btn_criar);
            Controls.Add(txt_confsenha);
            Controls.Add(txt_senha);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_user);
            Name = "form_cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosing += form_cadastro_FormClosing;
            Load += form_cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)grid_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private Label lbl_senha;
        private Label label3;
        private TextBox txt_user;
        private TextBox txt_senha;
        private TextBox txt_confsenha;
        private Button btn_criar;
        private Button btn_voltar;
        private Label lbl_title;
        private DataGridView grid_users;
        private Button btn_consultar;
    }
}