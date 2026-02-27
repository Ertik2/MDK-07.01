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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this._1_БиблеотекаDataSet2.Запрос1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_книг);

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
            this.учет_книгTableAdapter1.Update(this._1_БиблеотекаDataSet2.Учет_книг);
            this.учет_читателейTableAdapter1.Update(this._1_БиблеотекаDataSet2.Учет_читателей);
            this.учет_выдачиTableAdapter1.Update(this._1_БиблеотекаDataSet2.Учет_выдачи);
            this.пользователиTableAdapter1.Update(this._1_БиблеотекаDataSet2.Пользователи);

            MessageBox.Show("Все изменения обновлены", "Успех");
        }
    }
}
