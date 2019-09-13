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
    public partial class MyHome : Form
    {
        public MyHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showlabel1_Click(object sender, EventArgs e)
        {

        }

        private void showbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Anonymous !  "+nametextBox1.Text);
            showlabel2.Text = nametextBox1.Text;

        }
    }
}
