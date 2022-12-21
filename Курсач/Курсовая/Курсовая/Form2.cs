using System;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Фамилия = textBox2.Text,
                Имя = textBox3.Text,
                Отчество = textBox4.Text;
            int Номер = Convert.ToInt32(textBox5.Text);
            this.клиентыTableAdapter.InsertQuery(Фамилия, Имя, Отчество, Номер);
            this.клиентыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Клиенты);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Фамилия = textBox2.Text,
                Имя = textBox3.Text,
                Отчество = textBox4.Text;
            int Номер = Convert.ToInt32(textBox5.Text),
                Код = Convert.ToInt32(textBox1.Text);
            this.клиентыTableAdapter.UpdateQuery(Фамилия, Имя, Отчество, Номер, Код);
            this.клиентыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Клиенты);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Код = Convert.ToInt32(textBox1.Text);
            this.клиентыTableAdapter.DeleteQuery(Код);
            this.клиентыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Клиенты);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Asd = textBox6.Text;
            this.клиентыTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Клиенты, Asd, Asd);

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
