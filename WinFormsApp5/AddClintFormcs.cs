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
    public partial class AddClintFormcs : Form
    {
        public AddClintFormcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientForm c =new ClientForm();
            c.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Client c = new Client();
            c.Name = textBox2.Text;
            c.PhoneNumber = int.Parse(textBox3.Text);
            Repo rc = new Repo();
            rc.Database.EnsureCreated();
            rc.clients.Add(c);
            rc.SaveChanges();
            MessageBox.Show("Done");
        }
    }
}
