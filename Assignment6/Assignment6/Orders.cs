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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }


        private void addButton1_Click(object sender, EventArgs e)
        {
            DataTable customerSearchResult = searchCustomers(customerNameTextBox.Text);
            DataTable itemSearchResult = SearchItem(orderItemTextBox.Text);


            if (customerSearchResult.Rows.Count > 0)
            {
                string name = customerNameTextBox.Text;
                string address = customerSearchResult.Rows[0]["Address"].ToString();
                string contact = customerSearchResult.Rows[0]["Contact"].ToString();
                string item = itemSearchResult.Rows[0]["name"].ToString();
                int price = Convert.ToInt32(itemSearchResult.Rows[0]["price"]);
                int quantity = Convert.ToInt32(orderQuantityTextBox.Text);
                int totalPrice = price * quantity;

                addOrder(name, address, contact, item, price, quantity, totalPrice);
                MessageBox.Show("Successfully Added!");
            }
        }
        private void addOrder(string name, string address, string contact, string item, int price, int quantity, int totalBill)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"INSERT INTO Orders (Name, Address, Contact, Item, Price, Quantity, Total_Price) VALUES('" + name+ "','" + address + "','" + contact+ "', '"+item+"', "+price+", "+quantity+", "+totalBill+") ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        private void UpdateOrder(int id, string name, string contact, string address, string item, int price, int quantity, int totalBill)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string sqlString = @"UPDATE Orders SET Name = '" + name + "', Contact = '" + contact + "', Address = '" + address + "', Item = '" + item + "', Price = " + price + ", Quantity = " + quantity + ", TotalBill = " + totalBill + " WHERE ID = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

            //Open Connectio
            sqlConnection.Open();

            //Execute Qeury
            sqlCommand.ExecuteNonQuery();

            //Close Connection
            sqlConnection.Close();
        }


        private void showButton2_Click(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowOrders()
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Orders";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

           orderDataGridView1.DataSource = dataTable;
        }
        private DataTable SearchOrderByCustomerName(string name)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string sqlString = @"SELECT * FROM Orders WHERE Name = '" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

            //Connection Open
            sqlConnection.Open();

            //Execute Crud Operation
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //Connection Close
            sqlConnection.Close();

            return dataTable;
        }
        private DataTable SearchOrderById(int id)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string sqlString = @"SELECT * FROM Orders WHERE ID = '" + id + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

            //Connection Open
            sqlConnection.Open();

            //Execute Crud Operation
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //Connection Close
            sqlConnection.Close();

            return dataTable;
        }

        private void updateButton4_Click(object sender, EventArgs e)
        {
{
            try
            {
                if (String.IsNullOrEmpty(idTextBox.Text))
                {
                    MessageBox.Show("Please Enter ID to Update Order Information!");
                    return;
                }

                DataTable orderSearchResult = SearchOrderById(Convert.ToInt32(idTextBox.Text));

                if (orderSearchResult.Rows.Count == 0)
                {
                    MessageBox.Show("No Order Information is found with this ID..!");
                    return;
                }

                if (String.IsNullOrEmpty(customerNameTextBox.Text))
                {
                    MessageBox.Show("Please Enter Customer Name to Update Order Information!");
                    return;
                }
                if (String.IsNullOrEmpty(itemNameTextBox.Text))
                {
                    MessageBox.Show("Please Enter Item Name to Update Order Information!");
                    return;
                }

                DataTable customerSearchResult = SearchCustomerByName(customerNameTextBox.Text);
                DataTable itemSearchResult = SearchItemByName(itemNameTextBox.Text);

                if (customerSearchResult.Rows.Count > 0 && itemSearchResult.Rows.Count > 0)
                {
                    string name = customerNameTextBox.Text;
                    string contact = customerSearchResult.Rows[0]["Contact"].ToString();
                    string address = customerSearchResult.Rows[0]["Address"].ToString();
                    string item = itemSearchResult.Rows[0]["Name"].ToString();
                    int price = Convert.ToInt32(itemSearchResult.Rows[0]["Price"]);
                    int quantity = Convert.ToInt32(quantityTextBox.Text);
                    int totalBill = price * quantity;

                    UpdateOrder(Convert.ToInt32(idTextBox.Text), name, contact, address, item, price, quantity, totalBill);
                    MessageBox.Show("Update Order Information Successfully..!");
                }
                else
                {
                    if (customerSearchResult.Rows.Count == 0)
                        MessageBox.Show("No Customer Found with this Name..!");
                    else if (itemSearchResult.Rows.Count == 0)
                        MessageBox.Show("No Item Found With this Name..!");

                    return;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
      
        }

        private void updateCustomers(int id, string name, int price)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"UPDATE Item SET Name = '" + name + "',Price="+price+" WHERE ID=" + id + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

        //private void updateOrder(string name, string address, string contact, string item, int price, int quantity, int totalBill)
        //{
        //    //Connection
        //    string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    //Command

        //    sqlConnection.Open();

        //    sqlCommand.ExecuteNonQuery();

        //    sqlConnection.Close();
        //}

        private void deleteButton5_Click(object sender, EventArgs e)
        {

        }

        private void searchButton6_Click(object sender, EventArgs e)
        {

        }

        private void orderDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private DataTable SearchItem(string name)
        {
            //Connection
            string connectionString = @"Server=DWAIPAYAN-PC\SQLEXPRESS; Database =CoffeeShop;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Items WHERE name = '" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

    }
}
