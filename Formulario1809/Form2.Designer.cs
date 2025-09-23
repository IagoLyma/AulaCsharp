namespace Formulario1809
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            lbl_email = new Label();
            lbl_senha = new Label();
            txt_user = new TextBox();
            txt_senha = new TextBox();
            btn_button = new Button();
            btn_cadastro = new Button();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = SystemColors.Control;
            lbl_email.Location = new Point(262, 65);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(47, 15);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(262, 184);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(262, 95);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(290, 23);
            txt_user.TabIndex = 2;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(262, 217);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(290, 23);
            txt_senha.TabIndex = 3;
            txt_senha.UseWaitCursor = true;
            // 
            // btn_button
            // 
            btn_button.Location = new Point(361, 303);
            btn_button.Name = "btn_button";
            btn_button.Size = new Size(75, 23);
            btn_button.TabIndex = 4;
            btn_button.Text = "Entrar";
            btn_button.UseVisualStyleBackColor = true;
            btn_button.Click += btn_button_Click;
            // 
            // btn_cadastro
            // 
            btn_cadastro.Location = new Point(361, 354);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(75, 23);
            btn_cadastro.TabIndex = 5;
            btn_cadastro.Text = "Cadastrar";
            btn_cadastro.UseVisualStyleBackColor = true;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cadastro);
            Controls.Add(btn_button);
            Controls.Add(txt_senha);
            Controls.Add(txt_user);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_email);
            MaximizeBox = false;
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += form_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_email;
        private Label lbl_senha;
        private TextBox txt_user;
        private TextBox txt_senha;
        private Button btn_button;
        private Button btn_cadastro;
    }
}