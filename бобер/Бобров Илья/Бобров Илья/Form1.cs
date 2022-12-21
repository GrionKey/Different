using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бобров_Илья
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сделкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сделкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.реализацияГПDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.реализацияГПDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Сделки". При необходимости она может быть перемещена или удалена.
            this.сделкиTableAdapter.Fill(this.реализацияГПDataSet.Сделки);

        }

        // Открытие Form2 с таблицей "Товары"
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        // Открытие Form2 с таблицей "Товары"
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        // Кнопка просмотр данных в таблице
        private void button3_Click(object sender, EventArgs e)
        {
            data.mode = 3;
            data.kod = ((РеализацияГПDataSet.СделкиRow)((System.Data.DataRowView)сделкиBindingSource.Current).Row).Номер_сделки;
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
            this.сделкиTableAdapter.Fill(this.реализацияГПDataSet.Сделки);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
            this.сделкиTableAdapter.Fill(this.реализацияГПDataSet.Сделки);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            data.kod = ((РеализацияГПDataSet.СделкиRow)((System.Data.DataRowView)сделкиBindingSource.Current).Row).Номер_сделки;
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
            this.сделкиTableAdapter.Fill(this.реализацияГПDataSet.Сделки);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
