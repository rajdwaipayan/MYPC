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
    public partial class ConditionUi : Form
    {
        public ConditionUi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConditionUi_Load(object sender, EventArgs e)
        {

        }

        private void showButton1_Click(object sender, EventArgs e)
        {
            if (itemcomboBox1.Text == "")
            {
                MessageBox.Show("Please Select An Item ");
            }
            else
            {
                MessageBox.Show(itemcomboBox1.Text + "  \t is Selected");
            }
        }
    }
}
