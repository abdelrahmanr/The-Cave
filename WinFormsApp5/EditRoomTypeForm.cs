using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class EditRoomTypeForm : Form
    {
        public EditRoomTypeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomTypeFrom f = new RoomTypeFrom();
            f.Show();
            Hide();
        }
    }
}
