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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.реализацияГПDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.реализацияГПDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Сделки". При необходимости она может быть перемещена или удалена.
            this.сделкиTableAdapter.Fill(this.реализацияГПDataSet.Сделки);

            if (data.mode == 1) сделкиBindingSource.AddNew();
            if (data.mode == 2)
            {
                int pos = сделкиBindingSource.Find("Номер_сделки", data.kod);
                сделкиBindingSource.Position = pos;
            }
            if (data.mode == 3)
            {
                int pos = сделкиBindingSource.Find("Номер_сделки", data.kod);
                сделкиBindingSource.Position = pos;
                panel1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сделкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.реализацияГПDataSet);
            this.Close();
        }
    }
}
