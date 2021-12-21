using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoomForm f = new AddRoomForm();
          
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditRoomform p = new EditRoomform();
            p.Show();
            Hide();
        }
    }
}
