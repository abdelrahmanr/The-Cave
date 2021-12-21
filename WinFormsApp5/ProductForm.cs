using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm f = new AddProductForm();
            f.Show();
            Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProduct r = new EditProduct();  
            r.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Hide();
            
        }
    }
}
