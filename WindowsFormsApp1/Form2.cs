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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
           

        }

        private void Client_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Состав". При необходимости она может быть перемещена или удалена.
            this.составTableAdapter.Fill(this.cookDataSet.Состав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.cookDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cookDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.cookDataSet.Блюда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tELEDataSet.Переговоры". При необходимости она может быть перемещена или удалена.
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены в выходе?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization Autorization = new Autorization();
            Autorization.Show();
            Hide();
        }

       
    }
}
