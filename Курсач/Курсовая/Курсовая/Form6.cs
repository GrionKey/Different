using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form6 : Form
    {
        
        public Form6()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Сотрудники);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Фамилия = textBox7.Text;
            this.сотрудникиTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Сотрудники, Фамилия);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string
                Фамилия = textBox2.Text,
                Имя = textBox3.Text,
                Отчество = textBox4.Text,
                Адрес = textBox5.Text;
            DateTime date = dateTimePicker1.Value;
            this.сотрудникиTableAdapter.InsertQuery(Фамилия, Имя, Отчество, Адрес, date);
            this.сотрудникиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Сотрудники);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string
                Фамилия = textBox2.Text,
                Имя = textBox3.Text,
                Отчество = textBox4.Text,
                Адрес = textBox5.Text;
            DateTime date = dateTimePicker1.Value;
            int code = Convert.ToInt32(textBox1.Text);
            this.сотрудникиTableAdapter.UpdateQuery(Фамилия, Имя, Отчество, Адрес, date,code);
            this.сотрудникиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Сотрудники);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            this.сотрудникиTableAdapter.DeleteQuery(code);
            this.сотрудникиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Сотрудники);
        }

        private void закрытьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void закрытьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
