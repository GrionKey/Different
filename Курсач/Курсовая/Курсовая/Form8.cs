using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Курсовая
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void детали_на_складеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.детали_на_складеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Детали_на_складе". При необходимости она может быть перемещена или удалена.
            this.детали_на_складеTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int price = Convert.ToInt32(textBox3.Text),
                kol = Convert.ToInt32(textBox4.Text);
            this.детали_на_складеTableAdapter.InsertQuery(name, price, kol);
            this.детали_на_складеTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int price = Convert.ToInt32(textBox3.Text),
                kol = Convert.ToInt32(textBox4.Text),
                code = Convert.ToInt32(textBox1.Text);
            this.детали_на_складеTableAdapter.UpdateQuery(name, price, kol, code);
            this.детали_на_складеTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            this.детали_на_складеTableAdapter.DeleteQuery(code);
            this.детали_на_складеTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string param = "";
                int price = Convert.ToInt32(textBox6.Text);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        param = "<";
                        this.детали_на_складеTableAdapter.FillBy1(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе, price);
                        break;
                    case 1:
                        param = ">";
                        this.детали_на_складеTableAdapter.FillBy2(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе, price);
                        break;
                    case 2:
                        param = "=";
                        this.детали_на_складеTableAdapter.FillBy3(this.ремонт_Компьютерных_СистемDataSet.Детали_на_складе, price);
                        break;
                }
            }
            catch(Exception d)
            {
                MessageBox.Show(d.Message, "Error");
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
