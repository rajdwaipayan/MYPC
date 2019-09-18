using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Home : Form
    {
        List<string> names = new List<string> { };
        List<string> contacts = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> items = new List<string> { };
        List<int> quantities = new List<int> { };
        List<int> prices = new List<int> { };
        List<int> totalPrices = new List<int> { };

        


        public Home()
        {
            InitializeComponent();
        }

        private void AddCustomer(string name, string contact, string address, int quantity, string item)
        {

            int price = 0;
            if (item == "Black")
            {
                price = 120;
            }
            else if (item == "Cold")
            {
                price = 100;
            }
            else if (item == "Hot")
            {
                price = 90;
            }
            else if (item == "Regular")
            {
                price = 80;
            }
            names.Add(name);
            contacts.Add(contact);
            addresses.Add(address);
            items.Add(item);
            prices.Add(price);
            quantities.Add(quantity);
            totalPrices.Add(quantity * price);
        }

        //{
        //    string message = " ";
        //    foreach(string name in names)
        //    {
        //        message += "Name is : " + name + "\n\n";

        //    }

        //}
        private void ShowCustomer(int first,int last)
        {
            for(int i=first;i<last;i++)
                {
                    richTextBox1.Text += "Customer " + (i + 1) + "\n\n";
                    richTextBox1.Text += "Name: " + names[i] + "\n";
                    richTextBox1.Text += "Contact Number: " + contacts[i] + "\n\n";
                    richTextBox1.Text += "Address is :" + addresses + "\n\n";
                    richTextBox1.Text += "Total Price is: " + totalPrices[i]+"\n\n";
                    richTextBox1.Text += ":)";
                }
        }
        private void showButton2_Click(object sender, EventArgs e)
        {
            ShowCustomer(0,names.Count);
        }
            private void Reset()
            {
                NameTextBox1.Text = " ";
                ContactTextBox2.Text = " ";
                AddressTextBox3.Text = " ";
                QuantityTextBox5.Text = null;
                OrderComboBox1.Text="select One";
                richTextBox1.Text = " ";
            }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void addButton1_Click(object sender, EventArgs e)
        {
            if (!contacts.Contains(ContactTextBox2.Text) && OrderComboBox1.Text != " Select one" && !String.IsNullOrEmpty(QuantityTextBox5.Text))
            {


                AddCustomer(NameTextBox1.Text, ContactTextBox2.Text, AddressTextBox3.Text, Convert.ToInt32(QuantityTextBox5.Text), OrderComboBox1.Text);

            }
            else
            {

                if (contacts.Contains(ContactTextBox2.Text))
                {
                    MessageBox.Show("This number is already added !");
                }
                else if (OrderComboBox1.Text == " Select an item")
                {
                    MessageBox.Show(" Nothing selected");
                }
                else if (String.IsNullOrEmpty(QuantityTextBox5.Text))
                {
                    MessageBox.Show("Enter Quanitity");

                }
                return;
            }
            Reset();
            ShowCustomer(names.Count-1,names.Count);
            

        }

        private void contactTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void QuantityTextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void QuantityTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch)&& ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
            
        }
    }
}
