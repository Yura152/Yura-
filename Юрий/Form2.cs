using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Юрий
{

    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Key1 = new Form1();
            Key1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 Key1 = new Form3();
            Key1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Key1 = new Form4();
            Key1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form5 Key1 = new Form5();
            Key1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Key2 = new Form6();
            Key2.Show();
            this.Hide();
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            Form8 Key2 = new Form8();
            Key2.Show();
            this.Hide();
        }

       
        private void button7_Click_1(object sender, EventArgs e)
        {
            Form9 Key2 = new Form9();
            Key2.Show();
            this.Hide();
        }
    }
}
