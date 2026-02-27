using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены в выходе?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2 .accdb";

            using (var connection = new OleDbConnection(connStr))
            {
                connection.Open();

                string query = @"SELECT [Права], [Заблокированные] FROM [Пользователи] WHERE [Логин] = ? AND [Пароль] = ?";

                using (var cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Логин", LoginTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("Пароль", PasswordTextBox.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isBanned = false;
                            object bannedObj = reader["Заблокированные"];
                            if (bannedObj != DBNull.Value)
                                isBanned = Convert.ToBoolean(bannedObj);

                            if (isBanned)
                            {
                                MessageBox.Show("Учётная запись заблокирована.", "Доступ запрещён");
                                return;
                            }

                            bool isAdmin = false;
                            object adminObj = reader["Права"];
                            if (adminObj != DBNull.Value)
                                isAdmin = Convert.ToBoolean(adminObj);

                            loginAttempts = 0;

                            if (isAdmin)
                            {
                                MessageBox.Show("Добро пожаловать, администратор!");
                                var frm = new Administrator();
                                frm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Добро пожаловать!");
                                var frm = new Client();
                                frm.Show();
                            }

                            this.Hide();
                            return;
                        }
                        loginAttempts++;
                        int left = MAX_ATTEMPTS - loginAttempts;

                        if (left > 0)
                        {
                            MessageBox.Show($"Неверный логин или пароль.\nОсталось попыток: {left}", "Ошибка авторизации");
                        }
                        else
                        {
                            BanUser(LoginTextBox.Text.Trim());
                            MessageBox.Show("Превышено количество попыток. Учётная запись заблокирована.", "Доступ запрещён");
                        }
                    }
                }
            }
        }




        private void Regist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2 .accdb";
            string query = "INSERT INTO [Пользователи] ([Логин], [Пароль], [Права], [Заблокированные]) VALUES (?, ?, ?, ?)";

            try
            {
                using (var connection = new OleDbConnection(conn))
                {
                    connection.Open();
                    using (var cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("Логин", LoginTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("Пароль", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("Права", false);
                        cmd.Parameters.AddWithValue("Заблокированные", false);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Вы успешно зарегистрировались!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            }


        }
        private int loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;
    
private void BanUser(string login)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2 .accdb";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE [Пользователи] SET [Заблокированные] = ? WHERE [Логин] = ?";

                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Заблокированные", true);
                    cmd.Parameters.AddWithValue("Логин", login);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    } 
}
