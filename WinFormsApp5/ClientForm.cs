using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClintFormcs a = new AddClintFormcs();
            a.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditClintFrom h =  new EditClintFrom();
            h.Show();
            Hide();
        }
    }
}
