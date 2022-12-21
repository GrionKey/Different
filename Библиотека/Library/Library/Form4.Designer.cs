namespace Library
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
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label срокАрендыLabel;
            System.Windows.Forms.Label датаВыдачиLabel;
            System.Windows.Forms.Label датаСдачиLabel;
            System.Windows.Forms.Label кодКLabel;
            System.Windows.Forms.Label читательскийБилетLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.читательскийБилетComboBox = new System.Windows.Forms.ComboBox();
            this.выдачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаDataSet = new Library.БиблиотекаDataSet();
            this.читателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодКComboBox = new System.Windows.Forms.ComboBox();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаСдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаВыдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.срокАрендыTextBox = new System.Windows.Forms.TextBox();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.выдачиTableAdapter = new Library.БиблиотекаDataSetTableAdapters.ВыдачиTableAdapter();
            this.tableAdapterManager = new Library.БиблиотекаDataSetTableAdapters.TableAdapterManager();
            this.книгиTableAdapter = new Library.БиблиотекаDataSetTableAdapters.КнигиTableAdapter();
            this.читателиTableAdapter = new Library.БиблиотекаDataSetTableAdapters.ЧитателиTableAdapter();
            кодLabel = new System.Windows.Forms.Label();
            срокАрендыLabel = new System.Windows.Forms.Label();
            датаВыдачиLabel = new System.Windows.Forms.Label();
            датаСдачиLabel = new System.Windows.Forms.Label();
            кодКLabel = new System.Windows.Forms.Label();
            читательскийБилетLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(97, 6);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 0;
            кодLabel.Text = "Код:";
            // 
            // срокАрендыLabel
            // 
            срокАрендыLabel.AutoSize = true;
            срокАрендыLabel.Location = new System.Drawing.Point(49, 32);
            срокАрендыLabel.Name = "срокАрендыLabel";
            срокАрендыLabel.Size = new System.Drawing.Size(77, 13);
            срокАрендыLabel.TabIndex = 2;
            срокАрендыLabel.Text = "Срок Аренды:";
            // 
            // датаВыдачиLabel
            // 
            датаВыдачиLabel.AutoSize = true;
            датаВыдачиLabel.Location = new System.Drawing.Point(49, 59);
            датаВыдачиLabel.Name = "датаВыдачиLabel";
            датаВыдачиLabel.Size = new System.Drawing.Size(77, 13);
            датаВыдачиLabel.TabIndex = 4;
            датаВыдачиLabel.Text = "Дата Выдачи:";
            // 
            // датаСдачиLabel
            // 
            датаСдачиLabel.AutoSize = true;
            датаСдачиLabel.Location = new System.Drawing.Point(57, 85);
            датаСдачиLabel.Name = "датаСдачиLabel";
            датаСдачиLabel.Size = new System.Drawing.Size(69, 13);
            датаСдачиLabel.TabIndex = 6;
            датаСдачиLabel.Text = "Дата Сдачи:";
            // 
            // кодКLabel
            // 
            кодКLabel.AutoSize = true;
            кодКLabel.Location = new System.Drawing.Point(87, 111);
            кодКLabel.Name = "кодКLabel";
            кодКLabel.Size = new System.Drawing.Size(39, 13);
            кодКLabel.TabIndex = 8;
            кодКLabel.Text = "Код К:";
            // 
            // читательскийБилетLabel
            // 
            читательскийБилетLabel.AutoSize = true;
            читательскийБилетLabel.Location = new System.Drawing.Point(11, 138);
            читательскийБилетLabel.Name = "читательскийБилетLabel";
            читательскийБилетLabel.Size = new System.Drawing.Size(115, 13);
            читательскийБилетLabel.TabIndex = 10;
            читательскийБилетLabel.Text = "Читательский Билет:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(читательскийБилетLabel);
            this.panel1.Controls.Add(this.читательскийБилетComboBox);
            this.panel1.Controls.Add(кодКLabel);
            this.panel1.Controls.Add(this.кодКComboBox);
            this.panel1.Controls.Add(датаСдачиLabel);
            this.panel1.Controls.Add(this.датаСдачиDateTimePicker);
            this.panel1.Controls.Add(датаВыдачиLabel);
            this.panel1.Controls.Add(this.датаВыдачиDateTimePicker);
            this.panel1.Controls.Add(срокАрендыLabel);
            this.panel1.Controls.Add(this.срокАрендыTextBox);
            this.panel1.Controls.Add(кодLabel);
            this.panel1.Controls.Add(this.кодTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 189);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // читательскийБилетComboBox
            // 
            this.читательскийБилетComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.выдачиBindingSource, "ЧитательскийБилет", true));
            this.читательскийБилетComboBox.DataSource = this.читателиBindingSource;
            this.читательскийБилетComboBox.DisplayMember = "Фамилия";
            this.читательскийБилетComboBox.FormattingEnabled = true;
            this.читательскийБилетComboBox.Location = new System.Drawing.Point(132, 135);
            this.читательскийБилетComboBox.Name = "читательскийБилетComboBox";
            this.читательскийБилетComboBox.Size = new System.Drawing.Size(121, 21);
            this.читательскийБилетComboBox.TabIndex = 11;
            this.читательскийБилетComboBox.ValueMember = "ЧитательскийБилет";
            // 
            // выдачиBindingSource
            // 
            this.выдачиBindingSource.DataMember = "Выдачи";
            this.выдачиBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // читателиBindingSource
            // 
            this.читателиBindingSource.DataMember = "Читатели";
            this.читателиBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // кодКComboBox
            // 
            this.кодКComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.выдачиBindingSource, "КодК", true));
            this.кодКComboBox.DataSource = this.книгиBindingSource;
            this.кодКComboBox.DisplayMember = "Книга";
            this.кодКComboBox.FormattingEnabled = true;
            this.кодКComboBox.Location = new System.Drawing.Point(132, 108);
            this.кодКComboBox.Name = "кодКComboBox";
            this.кодКComboBox.Size = new System.Drawing.Size(121, 21);
            this.кодКComboBox.TabIndex = 9;
            this.кодКComboBox.ValueMember = "КодК";
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // датаСдачиDateTimePicker
            // 
            this.датаСдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выдачиBindingSource, "ДатаСдачи", true));
            this.датаСдачиDateTimePicker.Location = new System.Drawing.Point(132, 81);
            this.датаСдачиDateTimePicker.Name = "датаСдачиDateTimePicker";
            this.датаСдачиDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.датаСдачиDateTimePicker.TabIndex = 7;
            // 
            // датаВыдачиDateTimePicker
            // 
            this.датаВыдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выдачиBindingSource, "ДатаВыдачи", true));
            this.датаВыдачиDateTimePicker.Location = new System.Drawing.Point(132, 55);
            this.датаВыдачиDateTimePicker.Name = "датаВыдачиDateTimePicker";
            this.датаВыдачиDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.датаВыдачиDateTimePicker.TabIndex = 5;
            // 
            // срокАрендыTextBox
            // 
            this.срокАрендыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачиBindingSource, "СрокАренды", true));
            this.срокАрендыTextBox.Location = new System.Drawing.Point(132, 29);
            this.срокАрендыTextBox.Name = "срокАрендыTextBox";
            this.срокАрендыTextBox.Size = new System.Drawing.Size(121, 20);
            this.срокАрендыTextBox.TabIndex = 3;
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачиBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(132, 3);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(121, 20);
            this.кодTextBox.TabIndex = 1;
            // 
            // выдачиTableAdapter
            // 
            this.выдачиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Library.БиблиотекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыдачиTableAdapter = this.выдачиTableAdapter;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // читателиTableAdapter
            // 
            this.читателиTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(259, 189);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.BindingSource выдачиBindingSource;
        private БиблиотекаDataSetTableAdapters.ВыдачиTableAdapter выдачиTableAdapter;
        private БиблиотекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox читательскийБилетComboBox;
        private System.Windows.Forms.ComboBox кодКComboBox;
        private System.Windows.Forms.DateTimePicker датаСдачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаВыдачиDateTimePicker;
        private System.Windows.Forms.TextBox срокАрендыTextBox;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private БиблиотекаDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.BindingSource читателиBindingSource;
        private БиблиотекаDataSetTableAdapters.ЧитателиTableAdapter читателиTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}