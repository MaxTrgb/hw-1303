using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _0403wfCLass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numOne = Int32.Parse(textBox1.Text);
            double numTwo = Int32.Parse(textBox2.Text);
            double result = CalculatorModel.add(numOne, numTwo);
            label3.Text = result.ToString();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numOne = Int32.Parse(textBox1.Text);
            double numTwo = Int32.Parse(textBox2.Text);
            double result = CalculatorModel.substract(numOne, numTwo);
            label3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double numOne = Int32.Parse(textBox1.Text);
            double numTwo = Int32.Parse(textBox2.Text);
            double result = CalculatorModel.multiply(numOne, numTwo);
            label3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numOne = Int32.Parse(textBox1.Text);
            double numTwo = Int32.Parse(textBox2.Text);
            double result = CalculatorModel.divide(numOne, numTwo);
            label3.Text = result.ToString();
        }
    }
}
