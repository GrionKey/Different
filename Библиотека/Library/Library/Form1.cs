using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выдачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выдачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Выдачи". При необходимости она может быть перемещена или удалена.
            this.выдачиTableAdapter.Fill(this.библиотекаDataSet.Выдачи);

        }

        private void bBook_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void bReader_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void bView_Click(object sender, EventArgs e)
        {
            data.mode = 3;
            data.kod = ((БиблиотекаDataSet.ВыдачиRow)((System.Data.DataRowView)выдачиBindingSource.Current).Row).Код;
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
            this.выдачиTableAdapter.Fill(this.библиотекаDataSet.Выдачи);
        }

        private void bFill_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
            this.выдачиTableAdapter.Fill(this.библиотекаDataSet.Выдачи);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            data.kod = ((БиблиотекаDataSet.ВыдачиRow)((System.Data.DataRowView)выдачиBindingSource.Current).Row).Код;
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
            this.выдачиTableAdapter.Fill(this.библиотекаDataSet.Выдачи);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
