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
    public partial class Form5 : Form
    {
        int i, j, m, n;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Номер оборудования");
            dataGridView1.Columns.Add("Ingr", "Наименование оборудования");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells[0].Value = rowNumber;
        
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox2.Text;
          
            textBox2.Text = "";
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 gh = new Form2();
            gh.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            StreamWriter sw = File.CreateText("data+.txt");
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
            StreamReader f = new StreamReader("data+.txt");

            n = Convert.ToInt32(f.ReadLine());
            m = Convert.ToInt32(f.ReadLine());

            for (i = 0; i < n - 1; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells[0].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
                
               
            }

            f.Close();
        }
    }
}
