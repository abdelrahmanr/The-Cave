using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h=new Home();
            h.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBookingForm a=new AddBookingForm();
            a.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditBookingForm a=new EditBookingForm();
            a.Show();
            Hide();
        }
    }
}
