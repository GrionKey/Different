using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.библиотекаDataSet.DataTable1);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b;
            b = Convert.ToString(textBox1.Text);
            this.dataTable1TableAdapter.FillBy(this.библиотекаDataSet.DataTable1,b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.библиотекаDataSet.DataTable1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string b;
            b = Convert.ToString(textBox2.Text);
            this.dataTable1TableAdapter.FillBy1(this.библиотекаDataSet.DataTable1, b);
        }
    }
}
