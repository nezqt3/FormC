namespace Форма
{
    partial class Form2
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label количество_гостейLabel;
            System.Windows.Forms.Label дата_въездаLabel;
            System.Windows.Forms.Label дата_выездаLabel;
            System.Windows.Forms.Label класс_номераLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.бд_надоDataSet = new Форма.Бд_надоDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new Форма.Бд_надоDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new Форма.Бд_надоDataSetTableAdapters.TableAdapterManager();
            this.клиентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.клиентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.количество_гостейTextBox = new System.Windows.Forms.TextBox();
            this.дата_въездаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_выездаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.класс_номераTextBox = new System.Windows.Forms.TextBox();
            фИОLabel = new System.Windows.Forms.Label();
            количество_гостейLabel = new System.Windows.Forms.Label();
            дата_въездаLabel = new System.Windows.Forms.Label();
            дата_выездаLabel = new System.Windows.Forms.Label();
            класс_номераLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бд_надоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).BeginInit();
            this.клиентBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(339, 192);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // количество_гостейLabel
            // 
            количество_гостейLabel.AutoSize = true;
            количество_гостейLabel.Location = new System.Drawing.Point(270, 228);
            количество_гостейLabel.Name = "количество_гостейLabel";
            количество_гостейLabel.Size = new System.Drawing.Size(106, 13);
            количество_гостейLabel.TabIndex = 4;
            количество_гостейLabel.Text = "Количество гостей:";
            // 
            // дата_въездаLabel
            // 
            дата_въездаLabel.AutoSize = true;
            дата_въездаLabel.Location = new System.Drawing.Point(200, 265);
            дата_въездаLabel.Name = "дата_въездаLabel";
            дата_въездаLabel.Size = new System.Drawing.Size(76, 13);
            дата_въездаLabel.TabIndex = 6;
            дата_въездаLabel.Text = "Дата въезда:";
            // 
            // дата_выездаLabel
            // 
            дата_выездаLabel.AutoSize = true;
            дата_выездаLabel.Location = new System.Drawing.Point(199, 308);
            дата_выездаLabel.Name = "дата_выездаLabel";
            дата_выездаLabel.Size = new System.Drawing.Size(77, 13);
            дата_выездаLabel.TabIndex = 8;
            дата_выездаLabel.Text = "Дата выезда:";
            // 
            // класс_номераLabel
            // 
            класс_номераLabel.AutoSize = true;
            класс_номераLabel.Location = new System.Drawing.Point(294, 353);
            класс_номераLabel.Name = "класс_номераLabel";
            класс_номераLabel.Size = new System.Drawing.Size(82, 13);
            класс_номераLabel.TabIndex = 10;
            класс_номераLabel.Text = "Класс номера:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(304, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица «Клиент»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // бд_надоDataSet
            // 
            this.бд_надоDataSet.DataSetName = "Бд_надоDataSet";
            this.бд_надоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.бд_надоDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Форма.Бд_надоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Гостиничный_комплексTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Территория_комлпексаTableAdapter = null;
            // 
            // клиентBindingNavigator
            // 
            this.клиентBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиентBindingNavigator.BindingSource = this.клиентBindingSource;
            this.клиентBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиентBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.клиентBindingNavigatorSaveItem});
            this.клиентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клиентBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клиентBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиентBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиентBindingNavigator.Name = "клиентBindingNavigator";
            this.клиентBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиентBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.клиентBindingNavigator.TabIndex = 1;
            this.клиентBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // клиентBindingNavigatorSaveItem
            // 
            this.клиентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентBindingNavigatorSaveItem.Image")));
            this.клиентBindingNavigatorSaveItem.Name = "клиентBindingNavigatorSaveItem";
            this.клиентBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клиентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентBindingNavigatorSaveItem_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(382, 189);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 3;
            // 
            // количество_гостейTextBox
            // 
            this.количество_гостейTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Количество гостей", true));
            this.количество_гостейTextBox.Location = new System.Drawing.Point(382, 225);
            this.количество_гостейTextBox.Name = "количество_гостейTextBox";
            this.количество_гостейTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_гостейTextBox.TabIndex = 5;
            // 
            // дата_въездаDateTimePicker
            // 
            this.дата_въездаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентBindingSource, "Дата въезда", true));
            this.дата_въездаDateTimePicker.Location = new System.Drawing.Point(282, 261);
            this.дата_въездаDateTimePicker.Name = "дата_въездаDateTimePicker";
            this.дата_въездаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_въездаDateTimePicker.TabIndex = 7;
            // 
            // дата_выездаDateTimePicker
            // 
            this.дата_выездаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентBindingSource, "Дата выезда", true));
            this.дата_выездаDateTimePicker.Location = new System.Drawing.Point(282, 304);
            this.дата_выездаDateTimePicker.Name = "дата_выездаDateTimePicker";
            this.дата_выездаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_выездаDateTimePicker.TabIndex = 9;
            // 
            // класс_номераTextBox
            // 
            this.класс_номераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Класс номера", true));
            this.класс_номераTextBox.Location = new System.Drawing.Point(382, 350);
            this.класс_номераTextBox.Name = "класс_номераTextBox";
            this.класс_номераTextBox.Size = new System.Drawing.Size(100, 20);
            this.класс_номераTextBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(класс_номераLabel);
            this.Controls.Add(this.класс_номераTextBox);
            this.Controls.Add(дата_выездаLabel);
            this.Controls.Add(this.дата_выездаDateTimePicker);
            this.Controls.Add(дата_въездаLabel);
            this.Controls.Add(this.дата_въездаDateTimePicker);
            this.Controls.Add(количество_гостейLabel);
            this.Controls.Add(this.количество_гостейTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.клиентBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бд_надоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).EndInit();
            this.клиентBindingNavigator.ResumeLayout(false);
            this.клиентBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Бд_надоDataSet бд_надоDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private Бд_надоDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private Бд_надоDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton клиентBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox количество_гостейTextBox;
        private System.Windows.Forms.DateTimePicker дата_въездаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_выездаDateTimePicker;
        private System.Windows.Forms.TextBox класс_номераTextBox;
    }
}