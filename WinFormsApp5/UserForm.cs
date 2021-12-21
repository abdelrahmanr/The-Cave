using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home r = new Home();    
            r.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddUserForm f=new AddUserForm();
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditUserForm f=new EditUserForm();
            f.Show();
            Hide();
        }
    }
}
