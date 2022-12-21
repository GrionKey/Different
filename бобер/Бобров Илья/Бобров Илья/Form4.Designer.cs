namespace Бобров_Илья
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
            System.Windows.Forms.Label номер_сделкиLabel;
            System.Windows.Forms.Label дата_сделкиLabel;
            System.Windows.Forms.Label кол_воLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label товарLabel;
            System.Windows.Forms.Label покупательLabel;
            this.реализацияГПDataSet = new Бобров_Илья.РеализацияГПDataSet();
            this.сделкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделкиTableAdapter = new Бобров_Илья.РеализацияГПDataSetTableAdapters.СделкиTableAdapter();
            this.tableAdapterManager = new Бобров_Илья.РеализацияГПDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.номер_сделкиTextBox = new System.Windows.Forms.TextBox();
            this.дата_сделкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кол_воTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.товарComboBox = new System.Windows.Forms.ComboBox();
            this.покупательComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new Бобров_Илья.РеализацияГПDataSetTableAdapters.ТоварыTableAdapter();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new Бобров_Илья.РеализацияГПDataSetTableAdapters.ПокупателиTableAdapter();
            номер_сделкиLabel = new System.Windows.Forms.Label();
            дата_сделкиLabel = new System.Windows.Forms.Label();
            кол_воLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            товарLabel = new System.Windows.Forms.Label();
            покупательLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияГПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // реализацияГПDataSet
            // 
            this.реализацияГПDataSet.DataSetName = "РеализацияГПDataSet";
            this.реализацияГПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сделкиBindingSource
            // 
            this.сделкиBindingSource.DataMember = "Сделки";
            this.сделкиBindingSource.DataSource = this.реализацияГПDataSet;
            // 
            // сделкиTableAdapter
            // 
            this.сделкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Бобров_Илья.РеализацияГПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ПокупателиTableAdapter = this.покупателиTableAdapter;
            this.tableAdapterManager.СделкиTableAdapter = this.сделкиTableAdapter;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(покупательLabel);
            this.panel1.Controls.Add(this.покупательComboBox);
            this.panel1.Controls.Add(товарLabel);
            this.panel1.Controls.Add(this.товарComboBox);
            this.panel1.Controls.Add(стоимостьLabel);
            this.panel1.Controls.Add(this.стоимостьTextBox);
            this.panel1.Controls.Add(кол_воLabel);
            this.panel1.Controls.Add(this.кол_воTextBox);
            this.panel1.Controls.Add(дата_сделкиLabel);
            this.panel1.Controls.Add(this.дата_сделкиDateTimePicker);
            this.panel1.Controls.Add(номер_сделкиLabel);
            this.panel1.Controls.Add(this.номер_сделкиTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 185);
            this.panel1.TabIndex = 1;
            // 
            // номер_сделкиLabel
            // 
            номер_сделкиLabel.AutoSize = true;
            номер_сделкиLabel.Location = new System.Drawing.Point(4, 6);
            номер_сделкиLabel.Name = "номер_сделкиLabel";
            номер_сделкиLabel.Size = new System.Drawing.Size(83, 13);
            номер_сделкиLabel.TabIndex = 0;
            номер_сделкиLabel.Text = "Номер сделки:";
            // 
            // номер_сделкиTextBox
            // 
            this.номер_сделкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сделкиBindingSource, "Номер_сделки", true));
            this.номер_сделкиTextBox.Location = new System.Drawing.Point(93, 3);
            this.номер_сделкиTextBox.Name = "номер_сделкиTextBox";
            this.номер_сделкиTextBox.Size = new System.Drawing.Size(121, 20);
            this.номер_сделкиTextBox.TabIndex = 1;
            // 
            // дата_сделкиLabel
            // 
            дата_сделкиLabel.AutoSize = true;
            дата_сделкиLabel.Location = new System.Drawing.Point(12, 33);
            дата_сделкиLabel.Name = "дата_сделкиLabel";
            дата_сделкиLabel.Size = new System.Drawing.Size(75, 13);
            дата_сделкиLabel.TabIndex = 2;
            дата_сделкиLabel.Text = "Дата сделки:";
            // 
            // дата_сделкиDateTimePicker
            // 
            this.дата_сделкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сделкиBindingSource, "Дата_сделки", true));
            this.дата_сделкиDateTimePicker.Location = new System.Drawing.Point(93, 29);
            this.дата_сделкиDateTimePicker.Name = "дата_сделкиDateTimePicker";
            this.дата_сделкиDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.дата_сделкиDateTimePicker.TabIndex = 3;
            // 
            // кол_воLabel
            // 
            кол_воLabel.AutoSize = true;
            кол_воLabel.Location = new System.Drawing.Point(43, 58);
            кол_воLabel.Name = "кол_воLabel";
            кол_воLabel.Size = new System.Drawing.Size(44, 13);
            кол_воLabel.TabIndex = 4;
            кол_воLabel.Text = "Кол-во:";
            // 
            // кол_воTextBox
            // 
            this.кол_воTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сделкиBindingSource, "Кол-во", true));
            this.кол_воTextBox.Location = new System.Drawing.Point(93, 55);
            this.кол_воTextBox.Name = "кол_воTextBox";
            this.кол_воTextBox.Size = new System.Drawing.Size(121, 20);
            this.кол_воTextBox.TabIndex = 5;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(22, 84);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 6;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сделкиBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(93, 81);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(121, 20);
            this.стоимостьTextBox.TabIndex = 7;
            // 
            // товарLabel
            // 
            товарLabel.AutoSize = true;
            товарLabel.Location = new System.Drawing.Point(46, 110);
            товарLabel.Name = "товарLabel";
            товарLabel.Size = new System.Drawing.Size(41, 13);
            товарLabel.TabIndex = 8;
            товарLabel.Text = "Товар:";
            // 
            // товарComboBox
            // 
            this.товарComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сделкиBindingSource, "Товар", true));
            this.товарComboBox.DataSource = this.товарыBindingSource;
            this.товарComboBox.DisplayMember = "Наименование";
            this.товарComboBox.FormattingEnabled = true;
            this.товарComboBox.Location = new System.Drawing.Point(93, 107);
            this.товарComboBox.Name = "товарComboBox";
            this.товарComboBox.Size = new System.Drawing.Size(121, 21);
            this.товарComboBox.TabIndex = 9;
            this.товарComboBox.ValueMember = "КодТ";
            // 
            // покупательLabel
            // 
            покупательLabel.AutoSize = true;
            покупательLabel.Location = new System.Drawing.Point(17, 137);
            покупательLabel.Name = "покупательLabel";
            покупательLabel.Size = new System.Drawing.Size(70, 13);
            покупательLabel.TabIndex = 10;
            покупательLabel.Text = "Покупатель:";
            // 
            // покупательComboBox
            // 
            this.покупательComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сделкиBindingSource, "Покупатель", true));
            this.покупательComboBox.DataSource = this.покупателиBindingSource;
            this.покупательComboBox.DisplayMember = "Покупатель";
            this.покупательComboBox.FormattingEnabled = true;
            this.покупательComboBox.Location = new System.Drawing.Point(93, 134);
            this.покупательComboBox.Name = "покупательComboBox";
            this.покупательComboBox.Size = new System.Drawing.Size(121, 21);
            this.покупательComboBox.TabIndex = 11;
            this.покупательComboBox.ValueMember = "КодП";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.реализацияГПDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.реализацияГПDataSet;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 185);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.реализацияГПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private РеализацияГПDataSet реализацияГПDataSet;
        private System.Windows.Forms.BindingSource сделкиBindingSource;
        private РеализацияГПDataSetTableAdapters.СделкиTableAdapter сделкиTableAdapter;
        private РеализацияГПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private РеализацияГПDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox покупательComboBox;
        private System.Windows.Forms.ComboBox товарComboBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox кол_воTextBox;
        private System.Windows.Forms.DateTimePicker дата_сделкиDateTimePicker;
        private System.Windows.Forms.TextBox номер_сделкиTextBox;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private РеализацияГПDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
    }
}