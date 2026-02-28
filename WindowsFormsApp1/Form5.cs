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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=4.accdb";
            OleDbConnection conn = new OleDbConnection(connection);
            conn.Open();

            string query = "UPDATE [Пользователи] SET [Пароль] = ? WHERE [Логин] = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("Пароль", PasswordTextBox.Text);
            cmd.Parameters.AddWithValue("Логин", LoginTextBox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Вы сменили пароль");
            Close();
        }
    }
}
