namespace Форма
{
    partial class Form5
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
            System.Windows.Forms.Label отельLabel;
            System.Windows.Forms.Label спа_СалонLabel;
            System.Windows.Forms.Label банный_комлпексLabel;
            System.Windows.Forms.Label теннисный_кортLabel;
            System.Windows.Forms.Label бассейнLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.бд_надоDataSet = new Форма.Бд_надоDataSet();
            this.территория_комлпексаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.территория_комлпексаTableAdapter = new Форма.Бд_надоDataSetTableAdapters.Территория_комлпексаTableAdapter();
            this.tableAdapterManager = new Форма.Бд_надоDataSetTableAdapters.TableAdapterManager();
            this.территория_комлпексаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.территория_комлпексаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.отельCheckBox = new System.Windows.Forms.CheckBox();
            this.спа_СалонCheckBox = new System.Windows.Forms.CheckBox();
            this.банный_комлпексCheckBox = new System.Windows.Forms.CheckBox();
            this.теннисный_кортCheckBox = new System.Windows.Forms.CheckBox();
            this.бассейнCheckBox = new System.Windows.Forms.CheckBox();
            отельLabel = new System.Windows.Forms.Label();
            спа_СалонLabel = new System.Windows.Forms.Label();
            банный_комлпексLabel = new System.Windows.Forms.Label();
            теннисный_кортLabel = new System.Windows.Forms.Label();
            бассейнLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бд_надоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.территория_комлпексаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.территория_комлпексаBindingNavigator)).BeginInit();
            this.территория_комлпексаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // отельLabel
            // 
            отельLabel.AutoSize = true;
            отельLabel.Location = new System.Drawing.Point(185, 84);
            отельLabel.Name = "отельLabel";
            отельLabel.Size = new System.Drawing.Size(41, 13);
            отельLabel.TabIndex = 2;
            отельLabel.Text = "Отель:";
            // 
            // спа_СалонLabel
            // 
            спа_СалонLabel.AutoSize = true;
            спа_СалонLabel.Location = new System.Drawing.Point(163, 114);
            спа_СалонLabel.Name = "спа_СалонLabel";
            спа_СалонLabel.Size = new System.Drawing.Size(63, 13);
            спа_СалонLabel.TabIndex = 4;
            спа_СалонLabel.Text = "Спа Салон:";
            // 
            // банный_комлпексLabel
            // 
            банный_комлпексLabel.AutoSize = true;
            банный_комлпексLabel.Location = new System.Drawing.Point(124, 144);
            банный_комлпексLabel.Name = "банный_комлпексLabel";
            банный_комлпексLabel.Size = new System.Drawing.Size(102, 13);
            банный_комлпексLabel.TabIndex = 6;
            банный_комлпексLabel.Text = "Банный комлпекс:";
            // 
            // теннисный_кортLabel
            // 
            теннисный_кортLabel.AutoSize = true;
            теннисный_кортLabel.Location = new System.Drawing.Point(133, 174);
            теннисный_кортLabel.Name = "теннисный_кортLabel";
            теннисный_кортLabel.Size = new System.Drawing.Size(93, 13);
            теннисный_кортLabel.TabIndex = 8;
            теннисный_кортLabel.Text = "Теннисный корт:";
            // 
            // бассейнLabel
            // 
            бассейнLabel.AutoSize = true;
            бассейнLabel.Location = new System.Drawing.Point(173, 204);
            бассейнLabel.Name = "бассейнLabel";
            бассейнLabel.Size = new System.Drawing.Size(53, 13);
            бассейнLabel.TabIndex = 10;
            бассейнLabel.Text = "Бассейн:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Территория комплекса";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // бд_надоDataSet
            // 
            this.бд_надоDataSet.DataSetName = "Бд_надоDataSet";
            this.бд_надоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // территория_комлпексаBindingSource
            // 
            this.территория_комлпексаBindingSource.DataMember = "Территория комлпекса";
            this.территория_комлпексаBindingSource.DataSource = this.бд_надоDataSet;
            // 
            // территория_комлпексаTableAdapter
            // 
            this.территория_комлпексаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Форма.Бд_надоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Гостиничный_комплексTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Территория_комлпексаTableAdapter = this.территория_комлпексаTableAdapter;
            // 
            // территория_комлпексаBindingNavigator
            // 
            this.территория_комлпексаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.территория_комлпексаBindingNavigator.BindingSource = this.территория_комлпексаBindingSource;
            this.территория_комлпексаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.территория_комлпексаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.территория_комлпексаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.территория_комлпексаBindingNavigatorSaveItem});
            this.территория_комлпексаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.территория_комлпексаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.территория_комлпексаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.территория_комлпексаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.территория_комлпексаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.территория_комлпексаBindingNavigator.Name = "территория_комлпексаBindingNavigator";
            this.территория_комлпексаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.территория_комлпексаBindingNavigator.Size = new System.Drawing.Size(555, 25);
            this.территория_комлпексаBindingNavigator.TabIndex = 1;
            this.территория_комлпексаBindingNavigator.Text = "bindingNavigator1";
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
            // территория_комлпексаBindingNavigatorSaveItem
            // 
            this.территория_комлпексаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.территория_комлпексаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("территория_комлпексаBindingNavigatorSaveItem.Image")));
            this.территория_комлпексаBindingNavigatorSaveItem.Name = "территория_комлпексаBindingNavigatorSaveItem";
            this.территория_комлпексаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.территория_комлпексаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.территория_комлпексаBindingNavigatorSaveItem.Click += new System.EventHandler(this.территория_комлпексаBindingNavigatorSaveItem_Click);
            // 
            // отельCheckBox
            // 
            this.отельCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.территория_комлпексаBindingSource, "Отель", true));
            this.отельCheckBox.Location = new System.Drawing.Point(232, 79);
            this.отельCheckBox.Name = "отельCheckBox";
            this.отельCheckBox.Size = new System.Drawing.Size(104, 24);
            this.отельCheckBox.TabIndex = 3;
            this.отельCheckBox.Text = "checkBox1";
            this.отельCheckBox.UseVisualStyleBackColor = true;
            // 
            // спа_СалонCheckBox
            // 
            this.спа_СалонCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.территория_комлпексаBindingSource, "Спа Салон", true));
            this.спа_СалонCheckBox.Location = new System.Drawing.Point(232, 109);
            this.спа_СалонCheckBox.Name = "спа_СалонCheckBox";
            this.спа_СалонCheckBox.Size = new System.Drawing.Size(104, 24);
            this.спа_СалонCheckBox.TabIndex = 5;
            this.спа_СалонCheckBox.Text = "checkBox1";
            this.спа_СалонCheckBox.UseVisualStyleBackColor = true;
            // 
            // банный_комлпексCheckBox
            // 
            this.банный_комлпексCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.территория_комлпексаBindingSource, "Банный комлпекс", true));
            this.банный_комлпексCheckBox.Location = new System.Drawing.Point(232, 139);
            this.банный_комлпексCheckBox.Name = "банный_комлпексCheckBox";
            this.банный_комлпексCheckBox.Size = new System.Drawing.Size(104, 24);
            this.банный_комлпексCheckBox.TabIndex = 7;
            this.банный_комлпексCheckBox.Text = "checkBox1";
            this.банный_комлпексCheckBox.UseVisualStyleBackColor = true;
            // 
            // теннисный_кортCheckBox
            // 
            this.теннисный_кортCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.территория_комлпексаBindingSource, "Теннисный корт", true));
            this.теннисный_кортCheckBox.Location = new System.Drawing.Point(232, 169);
            this.теннисный_кортCheckBox.Name = "теннисный_кортCheckBox";
            this.теннисный_кортCheckBox.Size = new System.Drawing.Size(104, 24);
            this.теннисный_кортCheckBox.TabIndex = 9;
            this.теннисный_кортCheckBox.Text = "checkBox1";
            this.теннисный_кортCheckBox.UseVisualStyleBackColor = true;
            // 
            // бассейнCheckBox
            // 
            this.бассейнCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.территория_комлпексаBindingSource, "Бассейн", true));
            this.бассейнCheckBox.Location = new System.Drawing.Point(232, 199);
            this.бассейнCheckBox.Name = "бассейнCheckBox";
            this.бассейнCheckBox.Size = new System.Drawing.Size(104, 24);
            this.бассейнCheckBox.TabIndex = 11;
            this.бассейнCheckBox.Text = "checkBox1";
            this.бассейнCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 351);
            this.Controls.Add(бассейнLabel);
            this.Controls.Add(this.бассейнCheckBox);
            this.Controls.Add(теннисный_кортLabel);
            this.Controls.Add(this.теннисный_кортCheckBox);
            this.Controls.Add(банный_комлпексLabel);
            this.Controls.Add(this.банный_комлпексCheckBox);
            this.Controls.Add(спа_СалонLabel);
            this.Controls.Add(this.спа_СалонCheckBox);
            this.Controls.Add(отельLabel);
            this.Controls.Add(this.отельCheckBox);
            this.Controls.Add(this.территория_комлпексаBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "ТерКомпл";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бд_надоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.территория_комлпексаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.территория_комлпексаBindingNavigator)).EndInit();
            this.территория_комлпексаBindingNavigator.ResumeLayout(false);
            this.территория_комлпексаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Бд_надоDataSet бд_надоDataSet;
        private System.Windows.Forms.BindingSource территория_комлпексаBindingSource;
        private Бд_надоDataSetTableAdapters.Территория_комлпексаTableAdapter территория_комлпексаTableAdapter;
        private Бд_надоDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator территория_комлпексаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton территория_комлпексаBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox отельCheckBox;
        private System.Windows.Forms.CheckBox спа_СалонCheckBox;
        private System.Windows.Forms.CheckBox банный_комлпексCheckBox;
        private System.Windows.Forms.CheckBox теннисный_кортCheckBox;
        private System.Windows.Forms.CheckBox бассейнCheckBox;
    }
}