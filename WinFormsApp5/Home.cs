using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomForm r=new RoomForm();
            r.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomTypeFrom r = new RoomTypeFrom();
            r.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm r= new UserForm();
            r.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientForm c =new ClientForm();
            c.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();  
            p.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderForm q = new OrderForm();  
            q.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookingForm b=new BookingForm();
            b.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();    
            f.Show();
            Hide();
        }
    }
}
