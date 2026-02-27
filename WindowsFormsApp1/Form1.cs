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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tELEDataSet.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter2.Fill(this.tELEDataSet.Запрос1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tELEDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter4.Fill(this.tELEDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tELEDataSet.Переговоры". При необходимости она может быть перемещена или удалена.
            this.переговорыTableAdapter.Fill(this.tELEDataSet.Переговоры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tELEDataSet.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.tELEDataSet.Города);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tELEDataSet.Абоненты". При необходимости она может быть перемещена или удалена.
            this.абонентыTableAdapter1.Fill(this.tELEDataSet.Абоненты);




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
            
            this.пользователиTableAdapter4.Update(this.tELEDataSet.Пользователи);
            this.переговорыTableAdapter.Update(this.tELEDataSet.Переговоры);
            this.городаTableAdapter.Update(this.tELEDataSet.Города);
            this.абонентыTableAdapter1.Update(this.tELEDataSet.Абоненты);

            MessageBox.Show("Все изменения обновлены", "Успех");
        }

        
        
    }
}
