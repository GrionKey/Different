using System;
using System.Windows.Forms;

namespace QualifingExam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void createArray()
        {

            // создание и заполнение массива

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            int N = Convert.ToInt32(tbColumn.Text);     // количество строк вводимые пользователем
            int maxZn = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();

            dataGridView1.ColumnCount = N;
            dataGridView1.RowCount = N;

            if (maxZn <= 0)
            {
                MessageBox.Show("введите число больше 0");
            }


            int sumpob = 0;
            int sumGlav = 0;
            int max = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i, j].Value = rnd.Next(0, maxZn + 1);        // заполнение массива слeчайными значениями

                    if (i == N - j - 1)                                         // нахождение суммы элементов 
                    {
                        sumpob += Convert.ToInt32(dataGridView1[i, j].Value);
                    }

                    if (i == j)
                    {
                        sumGlav += Convert.ToInt32(dataGridView1[i, j].Value);
                    }
                    if (Convert.ToInt32(dataGridView1[i, j].Value) > max)//если это число больше максимального то оно становится новым максимальным
                    {
                        max = Convert.ToInt32(dataGridView1[i, j].Value);//если это число больше максимального то оно становится новым максимальным
                    }

                }
            }
            textBox3.Text = Convert.ToString(max);
            textBox7.Text = Convert.ToString(max);
            textBox5.Text = Convert.ToString(sumGlav);
            textBox6.Text = Convert.ToString(sumpob);

            // поиск индекса
            Random rand = new Random();

            textBox4.Text = Convert.ToString(rand.Next(1, N));
            textBox8.Text = Convert.ToString(rand.Next(1, N));
            textBox2.Text = Convert.ToString(rand.Next(1, N));
            textBox9.Text = Convert.ToString(rand.Next(1, N));
        }




        private void button1_Click(object sender, EventArgs e)
        {
            createArray();
        }
    }
}
