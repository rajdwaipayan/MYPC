using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePractice
{
    public partial class Dwaipayan : Form
    {
        public Dwaipayan()
        {
            InitializeComponent();
        }

        private void Dwaipayan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Anonymous ! " + nametextBox1.Text);
            showlabel1.Text = nametextBox1.Text;
        }
    }
}
