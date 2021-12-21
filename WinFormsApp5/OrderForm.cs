using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home f=new Home();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm f =new AddOrderForm();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditOrderForm f =new EditOrderForm();
            f.Show();
            Hide();

        }
    }
}
