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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "реализацияГПDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.реализацияГПDataSet.DataTable1);

            tb1.Clear();
            tb2.Clear();
            tb3.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Покупатель = tb1.Text;
            this.dataTable1TableAdapter.FillBy(this.реализацияГПDataSet.DataTable1, Покупатель);

            tb1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Город = tb2.Text;
            this.dataTable1TableAdapter.FillBy1(this.реализацияГПDataSet.DataTable1, Город);

            tb2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string КолВо = tb3.Text;
            this.dataTable1TableAdapter.FillBy2(this.реализацияГПDataSet.DataTable1, КолВо);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string КолВо = tb3.Text;
            this.dataTable1TableAdapter.FillBy3(this.реализацияГПDataSet.DataTable1, КолВо);
        }
    }
}
