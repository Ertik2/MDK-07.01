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
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=1 Библеотека.accdb;";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();

                string query = "SELECT Права FROM Пользователи WHERE Логин=? AND Пароль=?";
                using (var cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", LoginTextBox.Text);
                    cmd.Parameters.AddWithValue("?", PasswordTextBox.Text);
                    OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);

                    object adminValue = cmd.ExecuteScalar();
                    if (dt.Rows.Count > 0)
                    {
                        if (adminValue != null && Convert.ToInt32(adminValue) == 1)
                        {
                            MessageBox.Show("Вход выполнен! Вы — администратор");
                            Administrator Administrator = new Administrator();
                            Administrator.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Вход выполнен! Обычный пользователь");
                            Client Client = new Client();
                            Client.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }

        private void Regist_Click(object sender, EventArgs e)
        {
            int adminValue = AdminCheckBox.Checked ? 1 : 0;
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=1 Библеотека.accdb;";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            string query = "INSERT INTO [Пользователи] ([Логин], [Пароль], [Права]) VALUES (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            cmd.Parameters.Add("Логин", OleDbType.VarChar).Value = LoginTextBox.Text;
            cmd.Parameters.Add("Пароль", OleDbType.VarChar).Value = PasswordTextBox.Text;
            cmd.Parameters.Add("Права", OleDbType.VarChar).Value = adminValue;

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Регистрация успешна!");
        }

       
    }
}
