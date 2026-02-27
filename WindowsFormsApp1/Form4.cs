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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Administrator Administrator = new Administrator();
            Administrator.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Запрос4". При необходимости она может быть перемещена или удалена.
            this.запрос4TableAdapter.Fill(this._2_DataSet.Запрос4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Запрос3". При необходимости она может быть перемещена или удалена.
            this.запрос3TableAdapter.Fill(this._2_DataSet.Запрос3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Запрос2". При необходимости она может быть перемещена или удалена.
            this.запрос2TableAdapter.Fill(this._2_DataSet.Запрос2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_2_DataSet.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this._2_DataSet.Запрос1);

        }
    }
}
