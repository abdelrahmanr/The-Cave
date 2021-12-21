using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class RoomTypeFrom : Form
    {
        public RoomTypeFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AddRoomTypeForm g = new AddRoomTypeForm();
            g.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Home a = new Home ();
            a.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditRoomTypeForm f=new EditRoomTypeForm();
            f.Show();
            Hide();
        }
    }
}
