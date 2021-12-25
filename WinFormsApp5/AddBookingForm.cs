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
    public partial class AddBookingForm : Form
    {
        public AddBookingForm()
        {
            InitializeComponent();
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingForm v=new BookingForm();
            v.Show();
            Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking a = new Booking ();
            a.time = int.Parse(textBox2.Text);
            a.NumberOfChairs = int.Parse(textBox5.Text);
            a.TotalPrice= int.Parse(textBox6.Text);
            a.NumberOfHours= int.Parse(textBox7.Text);
            Repo rm = new Repo();
            rm.Database.EnsureCreated();
            rm.bookings.Add(a);
            rm.SaveChanges();
            MessageBox.Show("Done");

        }
    }
}
