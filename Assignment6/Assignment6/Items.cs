using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class itemForm : Form
    {
        public itemForm()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddItem(itemNameTextBox.Text, Convert.ToInt32(itemPriceTextBox.Text));
            MessageBox.Show("Successfully Added...!");
        }

        private void showButton2_Click(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        private void updateButton3_Click(object sender, EventArgs e)
        {
            UpdateItem(Convert.ToInt32(itemIdTextBox.Text), itemNameTextBox.Text, Convert.ToInt32(itemPriceTextBox.Text));
            MessageBox.Show("Operation Successful..!");
        }

        private void deleteButton4_Click(object sender, EventArgs e)
        {
            DeleteItem(Convert.ToInt32(itemIdTextBox.Text));
            MessageBox.Show("Delete Operation Successful..!");
        }

        private void searchButton5_Click(object sender, EventArgs e)
        {
            SearchByName(itemNameTextBox.Text);
        }

        private void AddItem(string name, int price)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"INSERT INTO Items (name, price) VALUES ('" + itemNameTextBox.Text + "'," + itemPriceTextBox.Text + ") ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        private void ShowAllItems()
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            itemDataGridView1.DataSource = dataTable;
        }
        
        private void SearchByName(string name)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Items WHERE name = '"+name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            itemDataGridView1.DataSource = dataTable;
        }



        private void DeleteItem(int id)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"DELETE FROM Items WHERE id = " + id + "" ;
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void UpdateItem(int id, string name, int price)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"UPDATE Items SET name = '"+name+"', price = "+price+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
