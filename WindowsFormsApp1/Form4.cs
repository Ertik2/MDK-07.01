using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Запрос4". При необходимости она может быть перемещена или удалена.
            this.запрос4TableAdapter.Fill(this.cookDataSet.Запрос4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Запрос3". При необходимости она может быть перемещена или удалена.
            this.запрос3TableAdapter.Fill(this.cookDataSet.Запрос3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Запрос2". При необходимости она может быть перемещена или удалена.
            this.запрос2TableAdapter.Fill(this.cookDataSet.Запрос2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this.cookDataSet.Запрос1);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            administrator.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены в выходе?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
