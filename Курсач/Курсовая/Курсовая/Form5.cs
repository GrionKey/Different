using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Курсовая
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void техника_клиентовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.техника_клиентовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Техника_клиентов". При необходимости она может быть перемещена или удалена.
            this.техника_клиентовTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Техника_клиентов);

        }

        private void закрытьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codeOrder = Convert.ToInt32(номер_заказаComboBox.ValueMember),
                kol = Convert.ToInt32(textBox4.Text);
            string name = textBox3.Text;

            this.техника_клиентовTableAdapter.InsertQuery(codeOrder, name, kol);
            this.техника_клиентовTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Техника_клиентов);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codeOrder = Convert.ToInt32(номер_заказаComboBox.ValueMember),
                kol = Convert.ToInt32(textBox4.Text),
                Code = Convert.ToInt32(textBox1);
            string name = textBox3.Text;

            this.техника_клиентовTableAdapter.UpdateQuery(codeOrder, name, kol,Code);
            this.техника_клиентовTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Техника_клиентов);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Code = Convert.ToInt32(textBox1);

            this.техника_клиентовTableAdapter.DeleteQuery( Code);
            this.техника_клиентовTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Техника_клиентов);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = textBox3.Text;
            this.техника_клиентовTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Техника_клиентов,Name);

        }
    }
}
