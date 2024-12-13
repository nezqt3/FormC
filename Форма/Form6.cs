using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; j < клиентDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < клиентDataGridView.RowCount - 1; j++)
                {
                    клиентDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    клиентDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; j < клиентDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < клиентDataGridView.RowCount - 1; j++)
                {
                    var value = клиентDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            клиентDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            клиентDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бд_надоDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бд_надоDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.бд_надоDataSet.Клиент);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            клиентBindingSource.Filter = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //клиентBindingSource.Filter = "Клиент=" + comboxBox1.Text + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
            {
                клиентDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            } else
            {
               клиентDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
