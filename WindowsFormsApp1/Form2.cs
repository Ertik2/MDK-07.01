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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter.Fill(this._1_БиблеотекаDataSet2.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet1.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this._1_БиблеотекаDataSet1.Запрос1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1_БиблеотекаDataSet2.История_выдачи". При необходимости она может быть перемещена или удалена.
            this.история_выдачиTableAdapter.Fill(this._1_БиблеотекаDataSet2.История_выдачи);

        }
    }
}
