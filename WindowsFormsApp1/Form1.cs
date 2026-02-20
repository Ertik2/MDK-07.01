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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_книг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter1.Fill(this._1_БиблеотекаDataSet2.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Новые_читатели". При необходимости она может быть перемещена или удалена.
            this.новые_читателиTableAdapter.Fill(this._1_БиблеотекаDataSet2.Новые_читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.История_выдачи". При необходимости она может быть перемещена или удалена.
            this.история_выдачиTableAdapter.Fill(this._1_БиблеотекаDataSet2.История_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter.Fill(this._1_БиблеотекаDataSet2.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet1.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter.Fill(this._1_БиблеотекаDataSet1.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet1.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter.Fill(this._1_БиблеотекаDataSet1.Учет_книг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet1.Пример". При необходимости она может быть перемещена или удалена.
            this.примерTableAdapter.Fill(this._1_БиблеотекаDataSet1.Пример);

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
