using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class AddRoomTypeForm : Form
    {
        public AddRoomTypeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomTypeFrom t = new RoomTypeFrom();
            t.Show();
            Hide();
        }
    }
}
