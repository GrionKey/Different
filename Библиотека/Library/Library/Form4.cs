using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Выдачи". При необходимости она может быть перемещена или удалена.
            this.выдачиTableAdapter.Fill(this.библиотекаDataSet.Выдачи);

            if (data.mode == 1) выдачиBindingSource.AddNew();
            if (data.mode == 2)
            {
                int pos = выдачиBindingSource.Find("Код", data.kod);
                выдачиBindingSource.Position = pos;
            }
            if (data.mode == 3)
            {
                int pos = выдачиBindingSource.Find("Код", data.kod);
                выдачиBindingSource.Position = pos;
                panel1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выдачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);
            this.Close();
        }
    }
}
