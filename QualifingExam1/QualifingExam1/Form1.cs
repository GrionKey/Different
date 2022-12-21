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
            int M = Convert.ToInt32(tbRow.Text);        // количество столбцов воодимых пользователем
            int maxZn = Convert.ToInt32(textBox1.Text);
            int n,m = 0;
            Random rnd = new Random();

            dataGridView1.ColumnCount = N;
            dataGridView1.RowCount = M;

            if (maxZn <= 0) 
            {
                MessageBox.Show("введите число больше 0");
            }

            try
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        n = rnd.Next(0, maxZn+1);
                        dataGridView1[i, j].Value = n;        // заполнение массива слeчайными значениями
                        if (n < m)
                            m = n;
                    }
                 textBox5.Text = m.ToString();  // Минимальное значение
                }   
            }
            catch { };




        }



        private void button1_Click(object sender, EventArgs e)
        {
            createArray();
        }
    }
}
