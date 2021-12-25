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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm f = new ProductForm();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.buyPrice = int.Parse(textBox3.Text);
            p.sellPrice = int.Parse(textBox4.Text);
            p.productName = textBox2.Text;
            Repo rp = new Repo();
            rp.Database.EnsureCreated();
            rp.products.Add(p);
            rp.SaveChanges();
            MessageBox.Show("Done");
        }
    }
}
