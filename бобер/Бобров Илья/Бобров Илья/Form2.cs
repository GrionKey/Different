using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Бобров_Илья
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.реализацияГПDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Category = "";
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Category = "Овощи";
                    break;
                case 1:
                    Category = "Фрукты";
                    break;
                case 2:
                    Category = "Ягоды";
                    break;
            }
            this.товарыTableAdapter.FillBy(this.реализацияГПDataSet.Товары, Category);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);
        }

        private void button3_Click(object sender, EventArgs e)  // Добавить
        {
            string
                Наименование = textBox2.Text,
                Категория = textBox3.Text;

            int 
                КолВо = Convert.ToInt32(textBox4.Text),  
                Цена = Convert.ToInt32(textBox5.Text);

            this.товарыTableAdapter.InsertQuery(Наименование, Категория, КолВо, Цена);
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);

            Clear();
        }

        private void button4_Click(object sender, EventArgs e) // Изменить
        {
            string
                Наименование = textBox2.Text,
                Категория = textBox3.Text;

            int
                Код = Convert.ToInt32(textBox1.Text),
                КолВо = Convert.ToInt32(textBox4.Text),
                Цена = Convert.ToInt32(textBox5.Text);

            this.товарыTableAdapter.UpdateQuery(Наименование, Категория, КолВо, Цена, Код);
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);

            Clear();
        }

        private void button5_Click(object sender, EventArgs e) // Удалить
        {
            int Код = Convert.ToInt32(textBox1.Text);
            this.товарыTableAdapter.DeleteQuery(Код);
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);

            Clear();
        }
    }
}
