using System;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form9 : Form
    {

        private void aaa()
        {
            if (textBox1.Text == "0000")
            {
                Form1 form = new Form1();
                form.Show();
                textBox1.Clear();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Error");
                textBox1.Clear();
            }
        }

        public Form9()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ремонт_Компьютерных_СистемDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_Компьютерных_СистемDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.ремонт_Компьютерных_СистемDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Param;
            switch (номер_сотрудникаComboBox.SelectedIndex)
            {
                case 0:
                    Param = 1;
                    aaa();
                    break;
                case 1:
                    Param = 2;
                    aaa();
                    break;
                case 2:
                    Param = 3;
                    aaa();
                    break;
                case 3:
                    Param = 4;
                    aaa();
                    break;
                case 4:
                    Param = 5;
                    aaa();
                    break;
                case 5:
                    Param = 6;
                    aaa();
                    break;
                case 6:
                    Param = 7;
                    aaa();
                    break;
                case 7:
                    Param = 8;
                    aaa();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
