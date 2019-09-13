using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DataaUi : Form
    {
        public DataaUi()
        {
            InitializeComponent();
        }

        private void showbutton1_Click(object sender, EventArgs e)
        {
            //int age = 0;
            //double salary = 5000.50;
            //String 
            string name = nametextBox1.Text;
            int firstNumber = Convert.ToInt32(firstNumbertextBox2.Text);
            int secondNumber = Convert.ToInt32(secondNumbertextBox3.Text);
            int result = firstNumber + secondNumber;
            MessageBox.Show("Name:  " + name + "\n\t"+ "Result= \t" + result.ToString());

            //int firstNumber =Convert.ToInt32(firstNumbertextBox2);
            //int secondNumber = Convert.ToInt32(secondNumbertextBox3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
