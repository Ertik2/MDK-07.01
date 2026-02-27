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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter3.Fill(this._2_DataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Телефоны". При необходимости она может быть перемещена или удалена.
            this.телефоныTableAdapter.Fill(this._2_DataSet.Телефоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this._2_DataSet.Оплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Абоненты". При необходимости она может быть перемещена или удалена.
            this.абонентыTableAdapter.Fill(this._2_DataSet.Абоненты);



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
            this.пользователиTableAdapter3.Update(this._2_DataSet.Пользователи);
            this.телефоныTableAdapter.Update(this._2_DataSet.Телефоны);
            this.оплатаTableAdapter.Update(this._2_DataSet.Оплата);
            this.абонентыTableAdapter.Update(this._2_DataSet.Абоненты);

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
