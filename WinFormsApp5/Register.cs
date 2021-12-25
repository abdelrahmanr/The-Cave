using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheCave
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="")
            {
                MessageBox.Show("Please Enter your UserName", "The Cave", MessageBoxButtons.OK);
            }
            else if (txtpass.Text=="")
            {
                MessageBox.Show("Please Enter your Password", "The Cave", MessageBoxButtons.OK);

            }
            else if (txtpass.Text!=txtcpass.Text)
            {
                MessageBox.Show("Please Enter your Correct Password", "The Cave", MessageBoxButtons.OK);

            }
           else if(txtnumber.Text=="")
            {
                MessageBox.Show("Please Enter your Number ", "The Cave", MessageBoxButtons.OK);

            }
            else if ((txtnumber.Text).Length!=11)
            {
                MessageBox.Show("Please Enter your Correct Phone Number", "The Cave", MessageBoxButtons.OK);

            }
        }
    }
}
