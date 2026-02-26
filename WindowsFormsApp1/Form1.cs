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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this._1_БиблеотекаDataSet1.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_книг);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
