namespace Форма
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
            System.Windows.Forms.Label спаLabel;
            System.Windows.Forms.Label питаниеLabel;
            System.Windows.Forms.Label специальные_услугиLabel;
            System.Windows.Forms.Label банный_комплексLabel;
            System.Windows.Forms.Label аренда_автомобиляLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.бд_надоDataSet = new Форма.Бд_надоDataSet();
            this.дополнительные_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дополнительные_услугиTableAdapter = new Форма.Бд_надоDataSetTableAdapters.Дополнительные_услугиTableAdapter();
            this.tableAdapterManager = new Форма.Бд_надоDataSetTableAdapters.TableAdapterManager();
            this.дополнительные_услугиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.дополнительные_услугиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.спаCheckBox = new System.Windows.Forms.CheckBox();
            this.питаниеCheckBox = new System.Windows.Forms.CheckBox();
            this.специальные_услугиCheckBox = new System.Windows.Forms.CheckBox();
            this.банный_комплексCheckBox = new System.Windows.Forms.CheckBox();
            this.аренда_автомобиляCheckBox = new System.Windows.Forms.CheckBox();
            спаLabel = new System.Windows.Forms.Label();
            питаниеLabel = new System.Windows.Forms.Label();
            специальные_услугиLabel = new System.Windows.Forms.Label();
            банный_комплексLabel = new System.Windows.Forms.Label();
            аренда_автомобиляLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бд_надоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingNavigator)).BeginInit();
            this.дополнительные_услугиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // спаLabel
            // 
            спаLabel.AutoSize = true;
            спаLabel.Location = new System.Drawing.Point(313, 211);
            спаLabel.Name = "спаLabel";
            спаLabel.Size = new System.Drawing.Size(29, 13);
            спаLabel.TabIndex = 6;
            спаLabel.Text = "Спа:";
            // 
            // питаниеLabel
            // 
            питаниеLabel.AutoSize = true;
            питаниеLabel.Location = new System.Drawing.Point(313, 241);
            питаниеLabel.Name = "питаниеLabel";
            питаниеLabel.Size = new System.Drawing.Size(53, 13);
            питаниеLabel.TabIndex = 7;
            питаниеLabel.Text = "Питание:";
            // 
            // специальные_услугиLabel
            // 
            специальные_услугиLabel.AutoSize = true;
            специальные_услугиLabel.Location = new System.Drawing.Point(251, 271);
            специальные_услугиLabel.Name = "специальные_услугиLabel";
            специальные_услугиLabel.Size = new System.Drawing.Size(115, 13);
            специальные_услугиLabel.TabIndex = 8;
            специальные_услугиLabel.Text = "Специальные услуги:";
            // 
            // банный_комплексLabel
            // 
            банный_комплексLabel.AutoSize = true;
            банный_комплексLabel.Location = new System.Drawing.Point(264, 301);
            банный_комплексLabel.Name = "банный_комплексLabel";
            банный_комплексLabel.Size = new System.Drawing.Size(102, 13);
            банный_комплексLabel.TabIndex = 9;
            банный_комплексLabel.Text = "Банный комплекс:";
            // 
            // аренда_автомобиляLabel
            // 
            аренда_автомобиляLabel.AutoSize = true;
            аренда_автомобиляLabel.Location = new System.Drawing.Point(255, 331);
            аренда_автомобиляLabel.Name = "аренда_автомобиляLabel";
            аренда_автомобиляLabel.Size = new System.Drawing.Size(111, 13);
            аренда_автомобиляLabel.TabIndex = 10;
            аренда_автомобиляLabel.Text = "Аренда автомобиля:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(292, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таблица «Доп.услуги»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // бд_надоDataSet
            // 
            this.бд_надоDataSet.DataSetName = "Бд_надоDataSet";
            this.бд_надоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дополнительные_услугиBindingSource
            // 
            this.дополнительные_услугиBindingSource.DataMember = "Дополнительные услуги";
            this.дополнительные_услугиBindingSource.DataSource = this.бд_надоDataSet;
            // 
            // дополнительные_услугиTableAdapter
            // 
            this.дополнительные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Форма.Бд_надоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Гостиничный_комплексTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = this.дополнительные_услугиTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Территория_комлпексаTableAdapter = null;
            // 
            // дополнительные_услугиBindingNavigator
            // 
            this.дополнительные_услугиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.дополнительные_услугиBindingNavigator.BindingSource = this.дополнительные_услугиBindingSource;
            this.дополнительные_услугиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.дополнительные_услугиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.дополнительные_услугиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.дополнительные_услугиBindingNavigatorSaveItem});
            this.дополнительные_услугиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.дополнительные_услугиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.дополнительные_услугиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.дополнительные_услугиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.дополнительные_услугиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.дополнительные_услугиBindingNavigator.Name = "дополнительные_услугиBindingNavigator";
            this.дополнительные_услугиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.дополнительные_услугиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.дополнительные_услугиBindingNavigator.TabIndex = 6;
            this.дополнительные_услугиBindingNavigator.Text = "bindingNavigator1";
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
            // дополнительные_услугиBindingNavigatorSaveItem
            // 
            this.дополнительные_услугиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.дополнительные_услугиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("дополнительные_услугиBindingNavigatorSaveItem.Image")));
            this.дополнительные_услугиBindingNavigatorSaveItem.Name = "дополнительные_услугиBindingNavigatorSaveItem";
            this.дополнительные_услугиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.дополнительные_услугиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.дополнительные_услугиBindingNavigatorSaveItem.Click += new System.EventHandler(this.дополнительные_услугиBindingNavigatorSaveItem_Click);
            // 
            // спаCheckBox
            // 
            this.спаCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.дополнительные_услугиBindingSource, "Спа", true));
            this.спаCheckBox.Location = new System.Drawing.Point(372, 206);
            this.спаCheckBox.Name = "спаCheckBox";
            this.спаCheckBox.Size = new System.Drawing.Size(104, 24);
            this.спаCheckBox.TabIndex = 7;
            this.спаCheckBox.Text = "checkBox1";
            this.спаCheckBox.UseVisualStyleBackColor = true;
            // 
            // питаниеCheckBox
            // 
            this.питаниеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.дополнительные_услугиBindingSource, "Питание", true));
            this.питаниеCheckBox.Location = new System.Drawing.Point(372, 236);
            this.питаниеCheckBox.Name = "питаниеCheckBox";
            this.питаниеCheckBox.Size = new System.Drawing.Size(104, 24);
            this.питаниеCheckBox.TabIndex = 8;
            this.питаниеCheckBox.Text = "checkBox1";
            this.питаниеCheckBox.UseVisualStyleBackColor = true;
            // 
            // специальные_услугиCheckBox
            // 
            this.специальные_услугиCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.дополнительные_услугиBindingSource, "Специальные услуги", true));
            this.специальные_услугиCheckBox.Location = new System.Drawing.Point(372, 266);
            this.специальные_услугиCheckBox.Name = "специальные_услугиCheckBox";
            this.специальные_услугиCheckBox.Size = new System.Drawing.Size(104, 24);
            this.специальные_услугиCheckBox.TabIndex = 9;
            this.специальные_услугиCheckBox.Text = "checkBox1";
            this.специальные_услугиCheckBox.UseVisualStyleBackColor = true;
            // 
            // банный_комплексCheckBox
            // 
            this.банный_комплексCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.дополнительные_услугиBindingSource, "Банный комплекс", true));
            this.банный_комплексCheckBox.Location = new System.Drawing.Point(372, 296);
            this.банный_комплексCheckBox.Name = "банный_комплексCheckBox";
            this.банный_комплексCheckBox.Size = new System.Drawing.Size(104, 24);
            this.банный_комплексCheckBox.TabIndex = 10;
            this.банный_комплексCheckBox.Text = "checkBox1";
            this.банный_комплексCheckBox.UseVisualStyleBackColor = true;
            // 
            // аренда_автомобиляCheckBox
            // 
            this.аренда_автомобиляCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.дополнительные_услугиBindingSource, "Аренда автомобиля", true));
            this.аренда_автомобиляCheckBox.Location = new System.Drawing.Point(372, 326);
            this.аренда_автомобиляCheckBox.Name = "аренда_автомобиляCheckBox";
            this.аренда_автомобиляCheckBox.Size = new System.Drawing.Size(104, 24);
            this.аренда_автомобиляCheckBox.TabIndex = 11;
            this.аренда_автомобиляCheckBox.Text = "checkBox1";
            this.аренда_автомобиляCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(аренда_автомобиляLabel);
            this.Controls.Add(this.аренда_автомобиляCheckBox);
            this.Controls.Add(банный_комплексLabel);
            this.Controls.Add(this.банный_комплексCheckBox);
            this.Controls.Add(специальные_услугиLabel);
            this.Controls.Add(this.специальные_услугиCheckBox);
            this.Controls.Add(питаниеLabel);
            this.Controls.Add(this.питаниеCheckBox);
            this.Controls.Add(спаLabel);
            this.Controls.Add(this.спаCheckBox);
            this.Controls.Add(this.дополнительные_услугиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Доп.Услуги";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бд_надоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingNavigator)).EndInit();
            this.дополнительные_услугиBindingNavigator.ResumeLayout(false);
            this.дополнительные_услугиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Бд_надоDataSet бд_надоDataSet;
        private System.Windows.Forms.BindingSource дополнительные_услугиBindingSource;
        private Бд_надоDataSetTableAdapters.Дополнительные_услугиTableAdapter дополнительные_услугиTableAdapter;
        private Бд_надоDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator дополнительные_услугиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton дополнительные_услугиBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox спаCheckBox;
        private System.Windows.Forms.CheckBox питаниеCheckBox;
        private System.Windows.Forms.CheckBox специальные_услугиCheckBox;
        private System.Windows.Forms.CheckBox банный_комплексCheckBox;
        private System.Windows.Forms.CheckBox аренда_автомобиляCheckBox;
    }
}