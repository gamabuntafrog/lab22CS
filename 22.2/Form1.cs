using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        private Matrix matriX;
        public Form1()
        {
            InitializeComponent();
            matriX = new Matrix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int n = int.Parse(textBox1.Text);

            int[,] matrix = matriX.GenerateMatrix(n);

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                dataGridView1.Columns.Add($"Column{j + 1}", $"Column{j + 1}");
            }

            dataGridView1.Rows.Add(rows);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }


        }
    }
}