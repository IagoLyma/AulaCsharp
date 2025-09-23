using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1809
{
    public partial class form_login : Form
    {
        string dbPath = @"C:\Users\iago.lfarias\Downloads\Banco\Contato.db";

        string connectionString;
        public form_login()
        {
            InitializeComponent();

            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            conexao();
        }

        private void conexao()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("RODO!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"BURRO NÃO RODO {ex.Message}");
            }
        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_user.Text))
            {
                MessageBox.Show("O campo Usuário é obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_user.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_user.Focus();
                return;
            }
            else
            {
                validar();
            }

        }

        private void validar()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Usuarios WHERE NomeUsuario = @NomeUsuario AND Senha = @Senha";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@NomeUsuario", txt_user.Text);

                        cmd.Parameters.AddWithValue("@Senha", txt_senha.Text);

                        cmd.ExecuteNonQuery();

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Form1 form = new Form1();
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou Senha incorretos!");
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao efetuar Login: {ex.Message}");
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            form_cadastro form = new form_cadastro();
            form.Show();
            this.Hide();
        }
    }
}
