namespace Курсовая
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_сотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ремонт_Компьютерных_СистемDataSet = new Курсовая.Ремонт_Компьютерных_СистемDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager();
            this.номер_сотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            номер_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_Компьютерных_СистемDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_сотрудникаLabel
            // 
            resources.ApplyResources(номер_сотрудникаLabel, "номер_сотрудникаLabel");
            номер_сотрудникаLabel.Name = "номер_сотрудникаLabel";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // ремонт_Компьютерных_СистемDataSet
            // 
            this.ремонт_Компьютерных_СистемDataSet.DataSetName = "Ремонт_Компьютерных_СистемDataSet";
            this.ремонт_Компьютерных_СистемDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детали_на_складеTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Оказаны_услугиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.Список_использованных_деталейTableAdapter = null;
            this.tableAdapterManager.Техника_клиентовTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // номер_сотрудникаComboBox
            // 
            this.номер_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сотрудникиBindingSource, "Номер_сотрудника", true));
            this.номер_сотрудникаComboBox.DataSource = this.сотрудникиBindingSource1;
            this.номер_сотрудникаComboBox.DisplayMember = "Фамилия";
            this.номер_сотрудникаComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.номер_сотрудникаComboBox, "номер_сотрудникаComboBox");
            this.номер_сотрудникаComboBox.Name = "номер_сотрудникаComboBox";
            this.номер_сотрудникаComboBox.ValueMember = "Номер_сотрудника";
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(номер_сотрудникаLabel);
            this.Controls.Add(this.номер_сотрудникаComboBox);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_Компьютерных_СистемDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Ремонт_Компьютерных_СистемDataSet ремонт_Компьютерных_СистемDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox номер_сотрудникаComboBox;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}