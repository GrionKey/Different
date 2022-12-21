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
    public partial class Form3 : Form
    {

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void читателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Фамилия = textBox2.Text,
                Имя = textBox3.Text;
            int Билет = Convert.ToInt32(textBox1.Text),
                Телефон = Convert.ToInt32(textBox4.Text);

            this.читателиTableAdapter.InsertQuery(Билет, Имя, Фамилия, Телефон);
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);

            Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Фамилия = textBox2.Text,
                   Имя = textBox3.Text;
            int Билет = Convert.ToInt32(textBox1.Text),
                Телефон = Convert.ToInt32(textBox4.Text);

            this.читателиTableAdapter.UpdateQuery(Билет,Имя, Фамилия, Телефон, Билет);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Билет = Convert.ToInt32(textBox1.Text);

            this.читателиTableAdapter.DeleteQuery(Билет);
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);

            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string фамилия = textBox5.Text;
            this.читателиTableAdapter.FillBy(this.библиотекаDataSet.Читатели, фамилия);

        }
    }
}
