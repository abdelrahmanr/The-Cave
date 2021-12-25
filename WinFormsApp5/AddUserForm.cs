using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheCave;

namespace WinFormsApp5
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.UserName = textBox3.Text;
            u.PhoneNumber = int.Parse(textBox1.Text);
            u.Password = textBox2.Text;
            Repo rq = new Repo();
            rq.Database.EnsureCreated();
            rq.users.Add(u);
            rq.SaveChanges();
            MessageBox.Show("Done");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm f=new UserForm();
            f.Show();
            Hide();
        }
    }
}
