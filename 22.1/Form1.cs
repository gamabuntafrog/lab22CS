using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        private operation Operation;
        private List<double> array;
        public Form1()
        {
            InitializeComponent();
            array = new List<double>();
            Operation = new operation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount= 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(textBox2.Text, out value))
            {
                array.Add(value);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Введіть коректне число.");
            }

            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = Operation.SumBeforeFirstNegativeElement(array);

            label1.Text = "Сума елементів до першого від'ємного елемента: " + sum;
        }
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < array.Count; i++)
            {
                dataGridView1.Rows.Add(i, array[i]);
            }
        }
    }
}
