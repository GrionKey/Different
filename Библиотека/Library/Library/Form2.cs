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
    public partial class Form2 : Form
    {

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Param = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Param = "Хаменгуэй";
                    break;
                case 1:
                    Param = "Толкин";
                    break;
                case 2:
                    Param = "Лондон";
                    break;
                case 3:
                    Param = "Лермонтов";
                    break;
                case 4:
                    Param = "Оруэлл";
                    break;
                case 5:
                    Param = "Брэдберри";
                    break;
                case 6:
                    Param = "Акунин";
                    break;
                case 7:
                    Param = "Мураками";
                    break;
            }
            this.книгиTableAdapter.FillBy(this.библиотекаDataSet.Книги, Param);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Автор = textBox2.Text,
                Книга = textBox3.Text;
            int Год = Convert.ToInt32(textBox4.Text),
                КолВо = Convert.ToInt32(textBox5.Text);

            this.книгиTableAdapter.InsertQuery(Автор, Книга, Год, КолВо);
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Автор = textBox2.Text,
    Книга = textBox3.Text;
            int Год = Convert.ToInt32(textBox4.Text),
                КолВо = Convert.ToInt32(textBox5.Text),
                Код = Convert.ToInt32(textBox1.Text);

            this.книгиTableAdapter.UpdateQuery(Автор, Книга, Год, КолВо, Код);
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);

            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Код = Convert.ToInt32(textBox1.Text);
            this.книгиTableAdapter.DeleteQuery( Код);
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);

            Clear();
        }
    }
}
