using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Юрий
{
    public partial class Form6 : Form
    {
        int i, j, n, m;

        private void button1_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells[0].Value = rowNumber;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[rowNumber].Cells[3].Value = textBox3.Text;
            dataGridView1.Rows[rowNumber].Cells[4].Value = textBox4.Text;
            dataGridView1.Rows[rowNumber].Cells[5].Value = textBox5.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = dataGridView1.RowCount;
            m = dataGridView1.ColumnCount;
            StreamWriter sw = File.CreateText("data4.txt");
            sw.WriteLine(Convert.ToString(n));
            sw.WriteLine(Convert.ToString(m));
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    sw.WriteLine(Convert.ToString(dataGridView1[j, i].Value));

                }

            }
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("data4.txt");

            n = Convert.ToInt32(f.ReadLine());
            m = Convert.ToInt32(f.ReadLine());

            for (i = 0; i < n - 1; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells[0].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[2].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[3].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[4].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[5].Value = f.ReadLine();
              
            }

            f.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 kek = new Form2();
            kek.Show();
            this.Hide();
        }

        

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Код клиента");
            dataGridView1.Columns.Add("1", "ФИО клиента");
            dataGridView1.Columns.Add("34", "Номер заказа");
            dataGridView1.Columns.Add("55", "Номер услуги");
            dataGridView1.Columns.Add("11", "Оплата");
            dataGridView1.Columns.Add("223", "Оценка приложения");

        }
    }
}
