using System;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Клиенты
            if (checkBox1.Checked == true)
            {
                Form2 form = new Form2();
                form.Show();
            }
            // Оказаны услуги
            if (checkBox2.Checked == true)
            {
                Form3 form = new Form3();
                form.Show();
            }
            // Список использованных деталей
            if (checkBox3.Checked == true)
            {
                Form4 form = new Form4();
                form.Show();
            }
            // Техника клиентов
            if (checkBox4.Checked == true)
            {
                Form5 form = new Form5();
                form.Show();
            }
            // Сотрудники
            if (checkBox5.Checked == true)
            {
                Form6 form = new Form6();
                form.Show();
            }          
            // Услуги
            if (checkBox6.Checked == true)
            {
                Form7 form = new Form7();
                form.Show();
            }         
            // Детали на складе
            if (checkBox7.Checked == true)
            {
                Form8 form = new Form8();
                form.Show();
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход
        }

        // Кнопка просмотра данных
        private void bView_Click(object sender, EventArgs e)
        {
            data.mode = 3;
            data.kod = ((Ремонт_Компьютерных_СистемDataSet.ЗаказыRow)((System.Data.DataRowView)заказыBindingSource.Current).Row).Номер_заказа;
            Form10 fr = new Form10();
            fr.ShowDialog();
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);
        }

        // Кнопка изменения данных
        private void bFill_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Form10 fr = new Form10();
            fr.ShowDialog();
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);
        }

        // Кнопка добавления данных
        private void bEdit_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            data.kod = ((Ремонт_Компьютерных_СистемDataSet.ЗаказыRow)((System.Data.DataRowView)заказыBindingSource.Current).Row).Номер_заказа;
            Form10 fr = new Form10();
            fr.ShowDialog();
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);
        }

        // Запрос на поиск заказов сделанных до заданной даты
        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            this.заказыTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Заказы, date);

        }

        // Запрос на поиск по статусу заказа
        private void button3_Click(object sender, EventArgs e)
        {
            string Item = comboBox1.Text;
            this.заказыTableAdapter.FillBy1(this.ремонт_Компьютерных_СистемDataSet.Заказы, Item);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}