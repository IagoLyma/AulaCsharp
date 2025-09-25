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
    public partial class form_cadastro : Form
    {
        string dbPath = @"C:\Users\Iago\Desktop\AulaCsharp\Banco\Contato.db";

        string connectionString;

        public form_cadastro()
        {
            InitializeComponent();

            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void form_cadastro_Load(object sender, EventArgs e)
        {
            testconexao();
        }

        private void testconexao()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conectado ao Banco");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não Rodou: {ex.Message}");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            form_login form = new form_login();
            form.Show();
            this.Close();
        }

        private void btn_criar_Click(object sender, EventArgs e)
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
                txt_senha.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_confsenha.Text))
            {
                MessageBox.Show("O campo Confirmar Senha é obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_confsenha.Focus();
                return;
            }

            if (txt_senha.Text != txt_confsenha.Text)
            {
                MessageBox.Show("As senhas não coincidem", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_confsenha.Focus();
                txt_senha.Focus();
                return;
            }

            else
            {
                criar();
            }
        }

        private void criar()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sqlinsert = @"INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@User, @Senha);";

                    using (var cmd = new SQLiteCommand(sqlinsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@User", txt_user.Text);

                        cmd.Parameters.AddWithValue("@Senha", txt_senha.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Conta criada com Sucesso!", "Sucesso", MessageBoxButtons.OK);
                form_login form = new form_login();
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                validation();
                MessageBox.Show($"Erro ao criar conta {ex.Message}");
            }
        }

        private void validation()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sqlselect = "SELECT * FROM Usuarios WHERE NomeUsuario = @User;";

                    using (var cmd = new SQLiteCommand(sqlselect, connection))
                    {
                        cmd.Parameters.AddWithValue("@User", txt_user.Text);

                        cmd.ExecuteNonQuery();

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Usuário já existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ConsultarUsuarios()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sqlconsulta = "SELECT * FROM Usuarios";

                    using (var grid = new SQLiteDataAdapter(sqlconsulta, connection))
                    {
                        DataTable dt = new DataTable(); //Cria o data table
                        grid.Fill(dt); //preenche o data table
                        grid_users.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar usuários!: {ex.Message}");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();
        }

        private void form_cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if ( result == DialogResult.No )
            {
               e.Cancel = true;
            }
        }
    }
}
