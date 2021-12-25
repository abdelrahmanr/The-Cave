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
    public partial class EditRoomTypeForm : Form
    {
        RoomType RoomType;
        private IEnumerable<Product> products;

        public EditRoomTypeForm(RoomType r)
        {
            InitializeComponent();
            RoomType = r;
            textBox3.Text = r.Name;
            textBox2.Text = r.ChairPrice.ToString();
        }

        public EditRoomTypeForm(IEnumerable<Product> products)
        {
            this.products = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomTypeFrom f = new RoomTypeFrom();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo re = new Repo();
            re.Database.EnsureCreated();

            RoomType.Name = textBox3.Text;
            RoomType.ChairPrice =int.Parse(textBox2.Text);

            re.roomTypes.Update(RoomType);
            re.SaveChanges();
            MessageBox.Show("Done");
        }

      
    }
}
