using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls; 

namespace Library
{
    public partial class Form7 : MaterialForm
    {
        public Form7()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        MaterialSkinManager tManager = MaterialSkinManager.Instance;


        private void выдачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выдачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Выдачи". При необходимости она может быть перемещена или удалена.
            this.выдачиTableAdapter.Fill(this.библиотекаDataSet.Выдачи);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
