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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string наим = textBox2.Text;
            int цена = Convert.ToInt32(textBox3.Text);
            this.услугиTableAdapter.InsertQuery(наим, цена);
            this.услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Услуги);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string наим = textBox2.Text;
            int цена = Convert.ToInt32(textBox3.Text),
                code = Convert.ToInt32(textBox1.Text);
            this.услугиTableAdapter.UpdateQuery(наим, цена, code);
            this.услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Услуги);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            this.услугиTableAdapter.DeleteQuery(code);
            this.услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Услуги);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dfhgdf = textBox4.Text;
            this.услугиTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Услуги, dfhgdf);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string param = "";
            int price = Convert.ToInt32(textBox5.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    param = "<";
                    this.услугиTableAdapter.FillBy1(this.ремонт_Компьютерных_СистемDataSet.Услуги,price );
                    break;
                case 1:
                    param = ">";
                    this.услугиTableAdapter.FillBy2(this.ремонт_Компьютерных_СистемDataSet.Услуги, price);
                    break;
                case 2:
                    param = "=";
                    this.услугиTableAdapter.FillBy3(this.ремонт_Компьютерных_СистемDataSet.Услуги, price);
                    break;
            }


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
