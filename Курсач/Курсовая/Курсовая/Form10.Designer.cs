namespace Курсовая
{
    partial class Form10
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
            System.Windows.Forms.Label номер_заказаLabel;
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label дата_закрытиеLabel;
            this.ремонт_Компьютерных_СистемDataSet = new Курсовая.Ремонт_Компьютерных_СистемDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager();
            this.клиентыTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.КлиентыTableAdapter();
            this.оказаны_услугиTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.Оказаны_услугиTableAdapter();
            this.список_использованных_деталейTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.Список_использованных_деталейTableAdapter();
            this.техника_клиентовTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.Техника_клиентовTableAdapter();
            this.номер_заказаTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.дата_закрытиеDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статусComboBox = new System.Windows.Forms.ComboBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.оказаны_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_использованных_деталейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.техника_клиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыЗаказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_клиентаComboBox = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            номер_заказаLabel = new System.Windows.Forms.Label();
            код_клиентаLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            дата_закрытиеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_Компьютерных_СистемDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаны_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_использованных_деталейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.техника_клиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыЗаказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_заказаLabel
            // 
            номер_заказаLabel.AutoSize = true;
            номер_заказаLabel.Location = new System.Drawing.Point(8, 15);
            номер_заказаLabel.Name = "номер_заказаLabel";
            номер_заказаLabel.Size = new System.Drawing.Size(83, 13);
            номер_заказаLabel.TabIndex = 1;
            номер_заказаLabel.Text = "Номер заказа:";
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Location = new System.Drawing.Point(18, 41);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(73, 13);
            код_клиентаLabel.TabIndex = 2;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.Location = new System.Drawing.Point(16, 69);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заказаLabel.TabIndex = 4;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(31, 94);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 6;
            описаниеLabel.Text = "Описание:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(47, 120);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 8;
            статусLabel.Text = "Статус:";
            // 
            // дата_закрытиеLabel
            // 
            дата_закрытиеLabel.AutoSize = true;
            дата_закрытиеLabel.Location = new System.Drawing.Point(3, 148);
            дата_закрытиеLabel.Name = "дата_закрытиеLabel";
            дата_закрытиеLabel.Size = new System.Drawing.Size(88, 13);
            дата_закрытиеLabel.TabIndex = 10;
            дата_закрытиеLabel.Text = "Дата закрытие:";
            // 
            // ремонт_Компьютерных_СистемDataSet
            // 
            this.ремонт_Компьютерных_СистемDataSet.DataSetName = "Ремонт_Компьютерных_СистемDataSet";
            this.ремонт_Компьютерных_СистемDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детали_на_складеTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.Оказаны_услугиTableAdapter = this.оказаны_услугиTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Список_использованных_деталейTableAdapter = this.список_использованных_деталейTableAdapter;
            this.tableAdapterManager.Техника_клиентовTableAdapter = this.техника_клиентовTableAdapter;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // оказаны_услугиTableAdapter
            // 
            this.оказаны_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // список_использованных_деталейTableAdapter
            // 
            this.список_использованных_деталейTableAdapter.ClearBeforeFill = true;
            // 
            // техника_клиентовTableAdapter
            // 
            this.техника_клиентовTableAdapter.ClearBeforeFill = true;
            // 
            // номер_заказаTextBox
            // 
            this.номер_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Номер_заказа", true));
            this.номер_заказаTextBox.Location = new System.Drawing.Point(97, 12);
            this.номер_заказаTextBox.Name = "номер_заказаTextBox";
            this.номер_заказаTextBox.Size = new System.Drawing.Size(121, 20);
            this.номер_заказаTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.код_клиентаComboBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(дата_закрытиеLabel);
            this.panel1.Controls.Add(this.дата_закрытиеDateTimePicker);
            this.panel1.Controls.Add(статусLabel);
            this.panel1.Controls.Add(this.статусComboBox);
            this.panel1.Controls.Add(описаниеLabel);
            this.panel1.Controls.Add(this.описаниеTextBox);
            this.panel1.Controls.Add(дата_заказаLabel);
            this.panel1.Controls.Add(this.дата_заказаDateTimePicker);
            this.panel1.Controls.Add(код_клиентаLabel);
            this.panel1.Controls.Add(this.номер_заказаTextBox);
            this.panel1.Controls.Add(номер_заказаLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 207);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // дата_закрытиеDateTimePicker
            // 
            this.дата_закрытиеDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата_закрытие", true));
            this.дата_закрытиеDateTimePicker.Location = new System.Drawing.Point(97, 144);
            this.дата_закрытиеDateTimePicker.Name = "дата_закрытиеDateTimePicker";
            this.дата_закрытиеDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.дата_закрытиеDateTimePicker.TabIndex = 11;
            // 
            // статусComboBox
            // 
            this.статусComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Статус", true));
            this.статусComboBox.FormattingEnabled = true;
            this.статусComboBox.Items.AddRange(new object[] {
            "Ожидает оплаты",
            "Оплачен",
            "В работе",
            "Выполнен"});
            this.статусComboBox.Location = new System.Drawing.Point(97, 117);
            this.статусComboBox.Name = "статусComboBox";
            this.статусComboBox.Size = new System.Drawing.Size(121, 21);
            this.статусComboBox.TabIndex = 9;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(97, 91);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(121, 20);
            this.описаниеTextBox.TabIndex = 7;
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата_заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(97, 65);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.дата_заказаDateTimePicker.TabIndex = 5;
            // 
            // клиентыBindingSource1
            // 
            this.клиентыBindingSource1.DataMember = "Клиенты";
            this.клиентыBindingSource1.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // оказаны_услугиBindingSource
            // 
            this.оказаны_услугиBindingSource.DataMember = "ЗаказыОказаны_услуги";
            this.оказаны_услугиBindingSource.DataSource = this.заказыBindingSource;
            // 
            // список_использованных_деталейBindingSource
            // 
            this.список_использованных_деталейBindingSource.DataMember = "ЗаказыСписок_использованных_деталей";
            this.список_использованных_деталейBindingSource.DataSource = this.заказыBindingSource;
            // 
            // техника_клиентовBindingSource
            // 
            this.техника_клиентовBindingSource.DataMember = "ЗаказыТехника_клиентов";
            this.техника_клиентовBindingSource.DataSource = this.заказыBindingSource;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // клиентыЗаказыBindingSource
            // 
            this.клиентыЗаказыBindingSource.DataMember = "КлиентыЗаказы";
            this.клиентыЗаказыBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // код_клиентаComboBox
            // 
            this.код_клиентаComboBox.DataSource = this.заказыBindingSource;
            this.код_клиентаComboBox.DisplayMember = "Код_клиента";
            this.код_клиентаComboBox.FormattingEnabled = true;
            this.код_клиентаComboBox.Location = new System.Drawing.Point(97, 38);
            this.код_клиентаComboBox.Name = "код_клиентаComboBox";
            this.код_клиентаComboBox.Size = new System.Drawing.Size(121, 21);
            this.код_клиентаComboBox.TabIndex = 13;
            this.код_клиентаComboBox.ValueMember = "Код_клиента";
            // 
            // клиентыBindingSource2
            // 
            this.клиентыBindingSource2.DataMember = "Клиенты";
            this.клиентыBindingSource2.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 207);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form10";
            this.Text = "Данные";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_Компьютерных_СистемDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаны_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_использованных_деталейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.техника_клиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыЗаказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ремонт_Компьютерных_СистемDataSet ремонт_Компьютерных_СистемDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_заказаTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker дата_закрытиеDateTimePicker;
        private System.Windows.Forms.ComboBox статусComboBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.Button button1;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.Оказаны_услугиTableAdapter оказаны_услугиTableAdapter;
        private System.Windows.Forms.BindingSource оказаны_услугиBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.Список_использованных_деталейTableAdapter список_использованных_деталейTableAdapter;
        private System.Windows.Forms.BindingSource список_использованных_деталейBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.Техника_клиентовTableAdapter техника_клиентовTableAdapter;
        private System.Windows.Forms.BindingSource техника_клиентовBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private System.Windows.Forms.BindingSource клиентыЗаказыBindingSource;
        private System.Windows.Forms.BindingSource клиентыBindingSource1;
        private System.Windows.Forms.ComboBox код_клиентаComboBox;
        private System.Windows.Forms.BindingSource клиентыBindingSource2;
    }
}