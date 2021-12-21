using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class EditBookingForm : Form
    {
        public EditBookingForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingForm s=new BookingForm();
            s.Show();
            Hide();

        }
    }
}
