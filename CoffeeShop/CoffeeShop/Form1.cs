using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
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

        private void savebutton1_Click(object sender, EventArgs e)
        {
            string name = customerNametextBox2.Text;
            int contact =Convert.ToInt32(contactNotextBox1.Text);
            string address = addresstextBox3.Text;
            int quantity =Convert.ToInt32(quantitytextBox4.Text);
            string order = ordercomboBox1.Text;
            int price = 0;

            if (ordercomboBox1.Text == "Black")
            {
                price = 120;
            }
            else if(ordercomboBox1.Text =="Cold")
            {
                price = 100;
            }
            else if(ordercomboBox1.Text=="Hot")
            {
                price = 90;
            }
            else if(ordercomboBox1.Text=="Regular")
            {
                price = 80;
            }
            else
            {
                MessageBox.Show("Nothing is Selected");
            }
            int Cost = price * quantity;


            richTextBox1.AppendText($"Customer Name:  {name}\n\nContact Number is :  {contact}\n\nAddress :  {address}\n\nTotal quantity of Coffee:   {quantity}\n\nTotal Amount :  {Cost}  Taka");

        }

        private void ordercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contactNotextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        private void quantityKeyPressed(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void DropDownList(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
