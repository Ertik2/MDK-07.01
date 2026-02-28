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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter5.Fill(this.cookDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Состав". При необходимости она может быть перемещена или удалена.
            this.составTableAdapter.Fill(this.cookDataSet.Состав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.cookDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.cookDataSet.Блюда);
        

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Autorization Autorization = new Autorization();
            Autorization.Show();
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

        private void Update_Click(object sender, EventArgs e)
        {
            // Сохраняем все наборы данных, которые могут быть изменены
            
            this.пользователиTableAdapter5.Update(this.cookDataSet.Пользователи);
            this.составTableAdapter.Update(this.cookDataSet.Состав);
            this.продуктыTableAdapter.Update(this.cookDataSet.Продукты);
            this.блюдаTableAdapter.Update(this.cookDataSet.Блюда);

            MessageBox.Show("Все изменения обновлены", "Успех");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            Hide();
        }
    }
}
