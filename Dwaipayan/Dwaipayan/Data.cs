using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dwaipayan
{
    public partial class Data : Form
    {
        double NumberOne, NumberTwo, Result;
        public Data()
        {
            InitializeComponent();
        }

        private void enterbutton1_Click(object sender, EventArgs e)
        {
            string name = nametextBox1.Text;
            int firstNumber = Convert.ToInt32(firstNumbertextBox2.Text);
            int secondNumber = Convert.ToInt32(secondNumbertextBox3.Text);
            double result = firstNumber + secondNumber;
            MessageBox.Show("Name:  " +name + "Result = " +result.ToString());
        }

        private void addbutton1_Click(object sender, EventArgs e)
        {
            int first =Convert.ToInt32(numberOnetextBox1.Text);
            int second = Convert.ToInt32(numberTwotextBox2.Text);
            int add = first + second;

            NumberOne = Convert.ToDouble(numberOnetextBox1.Text);
            NumberTwo = Convert.ToDouble(numberTwotextBox2.Text);
            Result = NumberOne + NumberTwo;
            resulttextBox1.Text = Result.ToString();
            MessageBox.Show("Addingn Result : " + add.ToString());








        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(numberOnetextBox1.Text);
            int second = Convert.ToInt32(numberTwotextBox2.Text);
            int subtract = first - second;
            MessageBox.Show("Subtract Result : " + subtract.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int first = Convert.ToInt32(numberOnetextBox1.Text);
            int second = Convert.ToInt32(numberTwotextBox2.Text);
            int multiply = first * second;

            MessageBox.Show("Multiplication Result  " + multiply.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(numberOnetextBox1.Text);
            int second = Convert.ToInt32(numberTwotextBox2.Text);
            double division = first / second;
            MessageBox.Show("Division value " + division.ToString());
        }

        private void calculatorrichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void Data_Load(object sender, EventArgs e)
        {
            
        }

        private void numberOnetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resulttextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resultlabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
