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
            dataGridView1 = new DataGridView();
            btn_consultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.BackColor = Color.Transparent;
            lbl_user.Location = new Point(261, 61);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(47, 15);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Location = new Point(261, 123);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(261, 185);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Senha";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(263, 79);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(250, 23);
            txt_user.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(263, 141);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(250, 23);
            txt_senha.TabIndex = 4;
            // 
            // txt_confsenha
            // 
            txt_confsenha.Location = new Point(263, 203);
            txt_confsenha.Name = "txt_confsenha";
            txt_confsenha.Size = new Size(250, 23);
            txt_confsenha.TabIndex = 5;
            // 
            // btn_criar
            // 
            btn_criar.Location = new Point(322, 277);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(113, 23);
            btn_criar.TabIndex = 6;
            btn_criar.Text = "Criar Usuário";
            btn_criar.UseVisualStyleBackColor = true;
            btn_criar.Click += btn_criar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(713, 415);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 23);
            btn_voltar.TabIndex = 7;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(322, 28);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(136, 15);
            lbl_title.TabIndex = 8;
            lbl_title.Text = "CADASTRO DE USUÁRIO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(274, 161);
            dataGridView1.TabIndex = 9;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(12, 241);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(137, 30);
            btn_consultar.TabIndex = 10;
            btn_consultar.Text = "Consultar Usuários";
            btn_consultar.UseVisualStyleBackColor = true;
            // 
            // form_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_consultar);
            Controls.Add(dataGridView1);
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
            Load += form_cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btn_consultar;
    }
}