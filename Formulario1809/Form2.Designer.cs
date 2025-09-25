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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = Color.Transparent;
            lbl_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = Color.White;
            lbl_email.Location = new Point(82, 97);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(76, 25);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_senha.ForeColor = SystemColors.Control;
            lbl_senha.Location = new Point(82, 228);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(62, 25);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // txt_user
            // 
            txt_user.Cursor = Cursors.IBeam;
            txt_user.Font = new Font("Segoe UI", 12F);
            txt_user.Location = new Point(82, 125);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(290, 29);
            txt_user.TabIndex = 2;
            // 
            // txt_senha
            // 
            txt_senha.Cursor = Cursors.IBeam;
            txt_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_senha.Location = new Point(82, 256);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(290, 29);
            txt_senha.TabIndex = 3;
            txt_senha.UseWaitCursor = true;
            // 
            // btn_button
            // 
            btn_button.BackColor = Color.PaleTurquoise;
            btn_button.Cursor = Cursors.Hand;
            btn_button.FlatStyle = FlatStyle.Flat;
            btn_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_button.Location = new Point(148, 323);
            btn_button.Name = "btn_button";
            btn_button.Size = new Size(144, 33);
            btn_button.TabIndex = 4;
            btn_button.Text = "Entrar";
            btn_button.UseVisualStyleBackColor = false;
            btn_button.Click += btn_button_Click;
            // 
            // btn_cadastro
            // 
            btn_cadastro.BackColor = Color.LightBlue;
            btn_cadastro.Cursor = Cursors.Hand;
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastro.Location = new Point(148, 391);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(144, 36);
            btn_cadastro.TabIndex = 5;
            btn_cadastro.Text = "Cadastrar";
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 47);
            label1.TabIndex = 6;
            label1.Text = "Seja Bem Vindo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(207, 366);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "OU";
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
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
            FormClosing += form_login_FormClosing;
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
        private Label label1;
        private Label label2;
    }
}