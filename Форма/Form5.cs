﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бд_надоDataSet.Территория_комлпекса". При необходимости она может быть перемещена или удалена.
            this.территория_комлпексаTableAdapter.Fill(this.бд_надоDataSet.Территория_комлпекса);

        }

        private void территория_комлпексаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.территория_комлпексаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бд_надоDataSet);

        }
    }
}
