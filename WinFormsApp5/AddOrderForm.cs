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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm f=new OrderForm();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order d = new order();
            d.totalPrice = int.Parse(textBox1.Text);
            d.quantity = int.Parse(textBox2.Text);
            d.time = int.Parse(textBox7.Text);
            Repo rd = new Repo();
            rd.Database.EnsureCreated();
            rd.orders.Add(d);
            rd.SaveChanges();
            MessageBox.Show("Done");


        }
    }
}
