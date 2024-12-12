using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Форма
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.MoveFirst();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.MoveNext();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.сотрудникBindingSource.AddNew();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //double ant, bnt;
            //ant = Convert.ToDouble(textBox1.Text);
            //bnt = (118 * ant) / 100;
            //textBox1.Text = bnt.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void сотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бд_надоDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бд_надоDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.бд_надоDataSet.Сотрудник);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бд_надоDataSet);
        }

        private void адрес_проживанияLabel_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void должностьTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
