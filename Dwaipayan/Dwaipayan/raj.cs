using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dwaipayan
{
    public partial class raj : Form
    {
        public raj()
        {
            InitializeComponent();
        }

        private void showbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Anonymous ! " + nametextBox1.Text);
            showlabel2.Text = nametextBox1.Text;
            namelabel2.Text = showlabel2.Text;

        }

        private void raj_Load(object sender, EventArgs e)
        {

        }
    }
}
