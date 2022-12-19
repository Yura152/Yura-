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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = "Admin";
            var Password = "12345";
            if ((textBox1.Text == Login) && (textBox2.Text == Password)) 
            {
                Form2 newform = new Form2();
                newform.Show();
            }
            else
            {
                button1.AutoSize = true;
                button1.Text = "Пользователь не существует!";

            }
        }
    }
}
