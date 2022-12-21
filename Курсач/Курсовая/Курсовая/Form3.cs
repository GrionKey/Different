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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void оказаны_услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оказаны_услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Оказаны_услуги". При необходимости она может быть перемещена или удалена.
            this.оказаны_услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Оказаны_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);


        }


        private void button5_Click(object sender, EventArgs e)
        {
            int КолВо = Convert.ToInt32(textBox3.Text);
            DateTime dateTime = dateTimePicker1.Value;
            int заказ = Convert.ToInt32(номер_заказаComboBox.Text);
            int Сотрудники = Convert.ToInt32(номер_сотрудникаComboBox.SelectedIndex + 1);
            int Услуга = Convert.ToInt32(услугаComboBox.SelectedIndex + 1);
            string прим = textBox4.Text;
            this.оказаны_услугиTableAdapter.InsertQuery(заказ, Сотрудники, dateTime, Услуга, КолВо, прим);
            this.оказаны_услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Оказаны_услуги);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int номерПП = Convert.ToInt32(textBox1.Text);
            int КолВо = Convert.ToInt32(textBox3.Text);
            DateTime dateTime = dateTimePicker1.Value;
            int заказ = Convert.ToInt32(номер_заказаComboBox.Text);
            int Сотрудники = номер_сотрудникаComboBox.SelectedIndex + 1;
            int Услуга = Convert.ToInt32(услугаComboBox.SelectedIndex + 1);
            string прим = textBox4.Text;
            this.оказаны_услугиTableAdapter.UpdateQuery(заказ, Сотрудники, dateTime, Услуга, КолВо, прим, номерПП);
            this.оказаны_услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Оказаны_услуги);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int номерПП = Convert.ToInt32(textBox1.Text);
            this.оказаны_услугиTableAdapter.DeleteQuery(номерПП);
            this.оказаны_услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Оказаны_услуги);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int dsfs = Convert.ToInt32(comboBox1.SelectedIndex + 1);
            this.оказаны_услугиTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Оказаны_услуги, dsfs);

        }
    }
}
