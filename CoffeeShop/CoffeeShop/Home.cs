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
    public partial class Home : Form
    {

        const int size = 10;

        string[] name = new string[size];
        string[] contact = new string[size];
        string[] address = new string[size];
        string[] item = new string[size];

        int[] quantity = new int[size];
        int[] price = new int[size];
        int[] totalCost = new int[size];


        int index = 0;

        public Home()
        {
            InitializeComponent();
        }
        /* private void savebutton1_Click(object sender, EventArgs e)
        {


            int price = 0;



            if (size > index)
            {
                name[index] = customerNametextBox2.Text;
                contact[index] = contactNotextBox1.Text;
                address[index] = addresstextBox3.Text;
                quantity[index] = Convert.ToInt32(quantitytextBox4.Text);
                order[index] = ordercomboBox1.Text;
            }

            if (order[index] == "Black")
            {
                price = quantity[index] * 120;
            }
            else if (order[index] == "Cold")
            {
                price = quantity[index] * 100;
            }
            else if (order[index] == "Hot")
            {
                price = quantity[index] * 90;
            }
            else if (order[index] == "Regular")
            {
                price = quantity[index] * 80;
            }
            else
            {
                MessageBox.Show("No Item is Selected");
            }





            richTextBox1.AppendText("Customer Name: " + name[index] + "\n\nContact No: " + contact[index] + "\n\nAddress: " + address[index] + "\n\nTotal Item :" + quantity[index] + "\n\nTotal Amount: " + price + "  Taka\n\n");

*/
            

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (index<size)
            {
                if (orderComboBox.Text != " ")
                {
                    name[index] = customernameTextBox.Text;
                    contact[index] = contactNoTextBox.Text;
                    address[index] = addressTextBox.Text;
                    item[index] = orderComboBox.Text;

                    if (item[index] == "Black")
                        price[index] = 120;
                    else if (item[index] == "Cold")
                        price[index] = 100;
                    else if (item[index] == "Hot")
                        price[index] = 90;
                    else if (item[index] == "Regular")
                        price[index] = 80;

                    quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                    totalCost[index] = price[index] * quantity[index];


                    richTextBox.Text += "Customer Name " + (index+1)+"\n\n";
                    richTextBox.Text += "Name :  " + name[index] + "\n";
                    richTextBox.Text += "Contact : " + contact[index] + "\n";
                    richTextBox.Text += "Address : " + address[index] + "\n\n";
                    richTextBox.Text += "Ordered Item : " + item[index] + "\n";
                    richTextBox.Text += "Price is: " + price[index] + "\n";
                    richTextBox.Text += "Quantity : " + quantity[index] + "\n";
                    richTextBox.Text += "Total Bill : " + totalCost[index] + "\n";
                    richTextBox.Text += "----------------------------------";

                    index++;

                }
                else
                {
                    MessageBox.Show("Item not selected !");
                }
            }
            else
            {
                MessageBox.Show("Max has been added");
            }


        }
    }
}
 