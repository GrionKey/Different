namespace Курсовая
{
    partial class Form4
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
            System.Windows.Forms.Label ___ппLabel;
            System.Windows.Forms.Label номер_заказаLabel;
            System.Windows.Forms.Label код_деталиLabel;
            System.Windows.Forms.Label количествоLabel;
            this.список_использованных_деталейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонт_Компьютерных_СистемDataSet = new Курсовая.Ремонт_Компьютерных_СистемDataSet();
            this.список_использованных_деталейDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.деталинаскладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.код_деталиComboBox = new System.Windows.Forms.ComboBox();
            this.деталинаскладеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.код_деталиComboBox1 = new System.Windows.Forms.ComboBox();
            this.список_использованных_деталейTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.Список_использованных_деталейTableAdapter();
            this.tableAdapterManager = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager();
            this.заказыTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.ЗаказыTableAdapter();
            this.детали_на_складеTableAdapter = new Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.Детали_на_складеTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ___ппLabel = new System.Windows.Forms.Label();
            номер_заказаLabel = new System.Windows.Forms.Label();
            код_деталиLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.список_использованных_деталейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_Компьютерных_СистемDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_использованных_деталейDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталинаскладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деталинаскладеBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ___ппLabel
            // 
            ___ппLabel.AutoSize = true;
            ___ппLabel.Location = new System.Drawing.Point(7, 20);
            ___ппLabel.Name = "___ппLabel";
            ___ппLabel.Size = new System.Drawing.Size(36, 13);
            ___ппLabel.TabIndex = 0;
            ___ппLabel.Text = "№ пп:";
            // 
            // номер_заказаLabel
            // 
            номер_заказаLabel.AutoSize = true;
            номер_заказаLabel.Location = new System.Drawing.Point(3, 59);
            номер_заказаLabel.Name = "номер_заказаLabel";
            номер_заказаLabel.Size = new System.Drawing.Size(83, 13);
            номер_заказаLabel.TabIndex = 2;
            номер_заказаLabel.Text = "Номер заказа:";
            // 
            // код_деталиLabel
            // 
            код_деталиLabel.AutoSize = true;
            код_деталиLabel.Location = new System.Drawing.Point(3, 98);
            код_деталиLabel.Name = "код_деталиLabel";
            код_деталиLabel.Size = new System.Drawing.Size(67, 13);
            код_деталиLabel.TabIndex = 4;
            код_деталиLabel.Text = "Код детали:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(7, 138);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 6;
            количествоLabel.Text = "Количество:";
            // 
            // список_использованных_деталейBindingSource
            // 
            this.список_использованных_деталейBindingSource.DataMember = "Список_использованных_деталей";
            this.список_использованных_деталейBindingSource.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // ремонт_Компьютерных_СистемDataSet
            // 
            this.ремонт_Компьютерных_СистемDataSet.DataSetName = "Ремонт_Компьютерных_СистемDataSet";
            this.ремонт_Компьютерных_СистемDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_использованных_деталейDataGridView
            // 
            this.список_использованных_деталейDataGridView.AutoGenerateColumns = false;
            this.список_использованных_деталейDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.список_использованных_деталейDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.список_использованных_деталейDataGridView.DataSource = this.список_использованных_деталейBindingSource;
            this.список_использованных_деталейDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.список_использованных_деталейDataGridView.Location = new System.Drawing.Point(0, 24);
            this.список_использованных_деталейDataGridView.Name = "список_использованных_деталейDataGridView";
            this.список_использованных_деталейDataGridView.Size = new System.Drawing.Size(444, 426);
            this.список_использованных_деталейDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№_пп";
            this.dataGridViewTextBoxColumn1.HeaderText = "№_пп";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_заказа";
            this.dataGridViewTextBoxColumn2.DataSource = this.заказыBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Номер_заказа";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_заказа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Номер_заказа";
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_детали";
            this.dataGridViewTextBoxColumn3.DataSource = this.деталинаскладеBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код_детали";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код";
            // 
            // деталинаскладеBindingSource
            // 
            this.деталинаскладеBindingSource.DataMember = "Детали_на_складе";
            this.деталинаскладеBindingSource.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.код_деталиComboBox);
            this.groupBox1.Location = new System.Drawing.Point(450, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Код детали";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // код_деталиComboBox
            // 
            this.код_деталиComboBox.DataSource = this.деталинаскладеBindingSource1;
            this.код_деталиComboBox.DisplayMember = "Наименование";
            this.код_деталиComboBox.FormattingEnabled = true;
            this.код_деталиComboBox.Location = new System.Drawing.Point(6, 19);
            this.код_деталиComboBox.Name = "код_деталиComboBox";
            this.код_деталиComboBox.Size = new System.Drawing.Size(121, 21);
            this.код_деталиComboBox.TabIndex = 1;
            this.код_деталиComboBox.ValueMember = "Код";
            // 
            // деталинаскладеBindingSource1
            // 
            this.деталинаскладеBindingSource1.DataMember = "Детали_на_складе";
            this.деталинаскладеBindingSource1.DataSource = this.ремонт_Компьютерных_СистемDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(количествоLabel);
            this.groupBox2.Controls.Add(код_деталиLabel);
            this.groupBox2.Controls.Add(this.код_деталиComboBox1);
            this.groupBox2.Controls.Add(номер_заказаLabel);
            this.groupBox2.Controls.Add(___ппLabel);
            this.groupBox2.Location = new System.Drawing.Point(450, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 189);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 34);
            this.button6.TabIndex = 10;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(141, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(141, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // код_деталиComboBox1
            // 
            this.код_деталиComboBox1.DataSource = this.деталинаскладеBindingSource;
            this.код_деталиComboBox1.DisplayMember = "Наименование";
            this.код_деталиComboBox1.FormattingEnabled = true;
            this.код_деталиComboBox1.Location = new System.Drawing.Point(6, 114);
            this.код_деталиComboBox1.Name = "код_деталиComboBox1";
            this.код_деталиComboBox1.Size = new System.Drawing.Size(121, 21);
            this.код_деталиComboBox1.TabIndex = 5;
            this.код_деталиComboBox1.ValueMember = "Код";
            // 
            // список_использованных_деталейTableAdapter
            // 
            this.список_использованных_деталейTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Курсовая.Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детали_на_складеTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Оказаны_услугиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Список_использованных_деталейTableAdapter = this.список_использованных_деталейTableAdapter;
            this.tableAdapterManager.Техника_клиентовTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // детали_на_складеTableAdapter
            // 
            this.детали_на_складеTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.закрытьФормуToolStripMenuItem,
            this.закрытьВсеToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.список_использованных_деталейBindingNavigatorSaveItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.Form4_Load);
            // 
            // закрытьФормуToolStripMenuItem
            // 
            this.закрытьФормуToolStripMenuItem.Name = "закрытьФормуToolStripMenuItem";
            this.закрытьФормуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьФормуToolStripMenuItem.Text = "Закрыть форму";
            this.закрытьФормуToolStripMenuItem.Click += new System.EventHandler(this.закрытьФормуToolStripMenuItem_Click);
            // 
            // закрытьВсеToolStripMenuItem
            // 
            this.закрытьВсеToolStripMenuItem.Name = "закрытьВсеToolStripMenuItem";
            this.закрытьВсеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьВсеToolStripMenuItem.Text = "Закрыть все";
            this.закрытьВсеToolStripMenuItem.Click += new System.EventHandler(this.закрытьВсеToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.список_использованных_деталейDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Список использованных деталей";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.список_использованных_деталейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_Компьютерных_СистемDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_использованных_деталейDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталинаскладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.деталинаскладеBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ремонт_Компьютерных_СистемDataSet ремонт_Компьютерных_СистемDataSet;
        private System.Windows.Forms.BindingSource список_использованных_деталейBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.Список_использованных_деталейTableAdapter список_использованных_деталейTableAdapter;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView список_использованных_деталейDataGridView;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource деталинаскладеBindingSource;
        private Ремонт_Компьютерных_СистемDataSetTableAdapters.Детали_на_складеTableAdapter детали_на_складеTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox код_деталиComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox код_деталиComboBox1;
        private System.Windows.Forms.BindingSource деталинаскладеBindingSource1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьФормуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
    }
}