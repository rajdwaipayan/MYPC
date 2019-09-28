using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }



        private void showButton2_Click(object sender, EventArgs e)
        {
            showCustomers();
        }

        private void updateButton3_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton4_Click(object sender, EventArgs e)
        {

        }

        private void searchButton5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addCustomer(customerNameTextBox.Text,customeraddressTextBox.Text,CustomerContactTextBox.Text);
        }

        private void addCustomer(string name,string address,string contact)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"INSERT INTO Customers (Name,Address,Contact) VALUES ('" +customerNameTextBox.Text + "','"+customeraddressTextBox.Text+"','"+CustomerContactTextBox.Text+"') ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void showCustomers()
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            customersDataGridView.DataSource = dataTable;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateCustomers(Convert.ToInt32(customerIdTextBox.Text),customerNameTextBox.Text, customeraddressTextBox.Text, CustomerContactTextBox.Text);
            MessageBox.Show("Customer Has Been Updated !)");
        }
      private void  updateCustomers(int id,string name, string address, string contact)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"UPDATE Customers SET Name = '" + name + "', Address = '" + address + "',Contact='"+contact+"' WHERE ID="+id+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteCustomer(Convert.ToInt32(customerIdTextBox.Text));
            MessageBox.Show("ID Deleted Successfully..!!!!");
        }
        private void deleteCustomer(int id)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"DELETE FROM Customers WHERE id = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Pleas Enter ...!");
                return;
            }
            DataTable result = searchCustomers(customerNameTextBox.Text);

            if(result.Rows.Count > 0)
            {
                customersDataGridView.DataSource = result;
            }
            else
            {
                MessageBox.Show("No Data Found...!");
                return;
            }
            
        }
       private DataTable searchCustomers(string name)

        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Customers WHERE Name = '" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        private void searchid(int id)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Customers WHERE ID = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            customersDataGridView.DataSource = dataTable;
        }
    }
}
