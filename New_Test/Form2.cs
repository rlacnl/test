using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(num1.Text);
            int b = int.Parse(num2.Text);

            int result = a + b;

            Result.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(num1.Text);
            int b = int.Parse(num2.Text);

            int result = a - b;

            Result.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(num1.Text);
            int b = int.Parse(num2.Text);

            int result = a * b;

            Result.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(num1.Text);
            int b = int.Parse(num2.Text);

            int result = a / b;

            Result.Text = result.ToString();
        }
    }
}
