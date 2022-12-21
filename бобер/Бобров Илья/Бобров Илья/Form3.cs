using System;
using System.Windows.Forms;

namespace Бобров_Илья
{
    public partial class Form3 : Form
    {

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void покупателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.реализацияГПDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.реализацияГПDataSet.Покупатели);
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Покупатель = textBox2.Text,
                   Город = textBox4.Text;
            int Номер = Convert.ToInt32(textBox3.Text);

            this.покупателиTableAdapter.InsertQuery(Покупатель, Номер, Город);
            this.покупателиTableAdapter.Fill(this.реализацияГПDataSet.Покупатели);

            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int КодП = Convert.ToInt32(textBox1.Text),
                Номер = Convert.ToInt32(textBox3.Text);
            string Покупатель = textBox2.Text,
                   Город = textBox4.Text;

            this.покупателиTableAdapter.UpdateQuery(Покупатель, Номер, Город, КодП);
            this.покупателиTableAdapter.Fill(this.реализацияГПDataSet.Покупатели);

            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int КодП = Convert.ToInt32(textBox1.Text);
            this.покупателиTableAdapter.DeleteQuery(КодП);
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Данные = textBox5.Text;
            this.покупателиTableAdapter.FillBy(this.реализацияГПDataSet.Покупатели, Данные);
            Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Данные = textBox6.Text;
            this.покупателиTableAdapter.FillBy1(this.реализацияГПDataSet.Покупатели, Данные);
            this.покупателиTableAdapter.Fill(this.реализацияГПDataSet.Покупатели);

            Clear();
        }
    }
}
