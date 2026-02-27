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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_книг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_книг);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization Autorization = new Autorization();
            Autorization.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены в выходе?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
    }
}
