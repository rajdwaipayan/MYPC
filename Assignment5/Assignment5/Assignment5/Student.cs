using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{


    public partial class Student : Form
    {
        List<string> ids = new List<string> { };
        List<string> names = new List<string> { };
        List<string> mobiles = new List<string> { };
        List<int> ages = new List<int> { };
        List<string> addresses = new List<string> { };
        List<double> points = new List<double> { };
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(idTextBox.Text) && !ids.Contains(idTextBox.Text) && idTextBox.TextLength == 4 && !String.IsNullOrEmpty(nameTextBox1.Text) && nameTextBox1.TextLength < 16 && !String.IsNullOrEmpty(mobileTextBox.Text) && !mobiles.Contains(mobileTextBox.Text) && mobileTextBox.TextLength == 11 && !String.IsNullOrEmpty(ageTextBox.Text) && !String.IsNullOrEmpty(gpaTextBox.Text) && double.Parse(gpaTextBox.Text) <= 4.00)
                {
                    AddStudent(idTextBox.Text, nameTextBox1.Text, mobileTextBox.Text, Convert.ToInt32(ageTextBox.Text), addressTextBox.Text, double.Parse(gpaTextBox.Text));
                    Reset();

                    ShowStudent(names.Count - 1, names.Count);
                    MessageBox.Show("Student Added Successfully");

                }
                else
                {
                    if (String.IsNullOrEmpty(idTextBox.Text) || idTextBox.TextLength != 4)
                        MessageBox.Show("Id must be entered with 4 digits ");
                    else if (ids.Contains(idTextBox.Text))
                        MessageBox.Show("Id already added !");
                    else if (mobiles.Contains(mobileTextBox.Text))
                    {
                        MessageBox.Show("Mobile Number already added !");
                    }
                    else if (String.IsNullOrEmpty(mobileTextBox.Text) || mobileTextBox.TextLength != 11)
                    {
                        MessageBox.Show("Please enter a valid mobile No!");
                    }
                    else if (string.IsNullOrEmpty(gpaTextBox.Text) || double.Parse(gpaTextBox.Text) > 4)
                    {
                        MessageBox.Show("Enter Gpa out of 4 ");
                    }
                    else if (String.IsNullOrEmpty(nameTextBox1.Text) || nameTextBox1.TextLength > 16)
                    {
                        MessageBox.Show("Enter a name up to 15 characters !!");
                    }
                    return;


                }

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

            private void Reset()
            {
                idTextBox.Text = " ";
                nameTextBox1.Text = "";
                mobileTextBox.Text = "";
                addressTextBox.Text = "";
                gpaTextBox.Text = "";
                richTextBox.Text = "";
                maxTextBox.Text = "";
                nameTextBox3.Text = "";
                nameTextBox2.Text = "";
                minTextBox1.Text = "";
                ageTextBox.Text = "";
                totalTextBox.Text = "";


            }

            private void AddStudent(string id, string name, string mobile, int age, string address, double gpa)
            {
                ids.Add(id);
                names.Add(name);
                mobiles.Add(mobile);
                ages.Add(age);
                addresses.Add(address);
                points.Add(gpa);


            }

            private void ShowStudent(int firstIndex, int lastIndex)
            {
                string message = "";
                for (int index = firstIndex; index < lastIndex; index++)
                {
                    message += "ID No: " + ids[index] + "\t" + "Name : " + names[index] + "\t" + "Mobile Number is: " + mobiles[index] + "\t" + "Age is: " + ages[index] + "\t" + "Address is: " + addresses[index] + "\t" + "GPA is: " + points[index]+"\n";
                }
                richTextBox.Text = message;
            }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double maxGpa = points[0], minGpa = points[0], totalGpa = 0;
            int MaxGpaIndex = 0;int MinGpaIndex = 0;
            try
            {
                for (int index = 0; index < ids.Count; index++)
                {
                    if (points[index] > maxGpa)
                    {
                        maxGpa = points[index];
                        MaxGpaIndex = index;
                    }
                    if (points[index] < minGpa)
                    {
                        minGpa = points[index];
                        MinGpaIndex = index;
                    }
                    totalGpa = totalGpa + points[index];
                }
                Reset();
                ShowStudent(0, names.Count);
                maxTextBox.Text = String.Format("{0:0.00}", points[MaxGpaIndex]);
                nameTextBox2.Text = names[MaxGpaIndex];
                minTextBox1.Text = String.Format("{0:0.00}",points[MinGpaIndex]);
                nameTextBox3.Text = names[MinGpaIndex];

                avgTextBox.Text = String.Format("{0:0.00}", totalGpa / ids.Count);
                totalTextBox.Text = String.Format("{0:0:00}", totalGpa);

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    } }
