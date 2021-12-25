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

        private void button1_Click(object sender, EventArgs e)
        {
            RoomType r=new RoomType();
            r.Name = textBox3.Text;
            r.ChairPrice = int.Parse(textBox2.Text);
            Repo re=new Repo();
            re.Database.EnsureCreated();
            re.roomTypes.Add(r);
            re.SaveChanges();
            MessageBox.Show("Done");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
