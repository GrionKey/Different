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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }


        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Техника_клиентов". При необходимости она может быть перемещена или удалена.
            this.техника_клиентовTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Техника_клиентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей". При необходимости она может быть перемещена или удалена.
            this.список_использованных_деталейTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Список_использованных_деталей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Оказаны_услуги". При необходимости она может быть перемещена или удалена.
            this.оказаны_услугиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Оказаны_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Заказы);

            if (data.mode == 1) заказыBindingSource.AddNew();
            if (data.mode == 2)
            {
                int pos = заказыBindingSource.Find("Номер_заказа", data.kod);
                заказыBindingSource.Position = pos;
            }
            if (data.mode == 3)
            {
                int pos = заказыBindingSource.Find("Номер_заказа", data.kod);
                заказыBindingSource.Position = pos;
                panel1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);
            this.Close();
        }
    }
}
