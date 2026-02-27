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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this._2_DataSet.Оплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Телефоны". При необходимости она может быть перемещена или удалена.
            this.телефоныTableAdapter.Fill(this._2_DataSet.Телефоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Абоненты". При необходимости она может быть перемещена или удалена.
            this.абонентыTableAdapter.Fill(this._2_DataSet.Абоненты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookDataSet.Учет_выдачи". При необходимости она может быть перемещена или удалена.
           

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
