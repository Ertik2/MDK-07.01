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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter.Fill(this._1_БиблеотекаDataSet.Учет_книг);

        }
    }
}
