using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }
    }
}
