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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void список_использованных_деталейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.список_использованных_деталейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей". При необходимости она может быть перемещена или удалена.
            this.список_использованных_деталейTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Code = Convert.ToInt32(код_деталиComboBox.SelectedIndex + 1);
            this.список_использованных_деталейTableAdapter.FillBy(this.ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей, Code);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int orderNumber = Convert.ToInt32(textBox3.Text),
                detailNumber = Convert.ToInt32(код_деталиComboBox1.SelectedIndex + 1),
                quantity = Convert.ToInt32(textBox2.Text);

            this.список_использованных_деталейTableAdapter.InsertQuery(orderNumber, detailNumber, quantity);
            this.список_использованных_деталейTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей);

            //Form4_Load(sender,e);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int orderNumber = Convert.ToInt32(textBox3.Text),
                detailNumber = Convert.ToInt32(код_деталиComboBox1.SelectedIndex + 1),
                quantity = Convert.ToInt32(textBox2.Text),
                code = Convert.ToInt32(textBox1.Text);

            this.список_использованных_деталейTableAdapter.UpdateQuery(orderNumber, detailNumber, quantity, code);
            this.список_использованных_деталейTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей);
        }

        private void Delete(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            this.список_использованных_деталейTableAdapter.DeleteQuery(code);
            this.список_использованных_деталейTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей);
        }

        private void закрытьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
