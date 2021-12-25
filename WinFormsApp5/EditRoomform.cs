using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheCave;

namespace WinFormsApp5
{
    public partial class EditRoomform : Form
    {
        private Room room1;

        public EditRoomform(IEnumerable<Room> rooms)
        {
            InitializeComponent();
        }

        public EditRoomform(Room room1)
        {
            this.room1 = room1;
            InitializeComponent();

            Repo re = new Repo();
            re.Database.EnsureCreated();
            

            textBox1.Text = room1.Id.ToString();
            textBox2.Text = room1.ChairPrice.ToString();

            var list = re.roomTypes.
                ToList().Select(c => c.Name).ToList();

            comboBox1.DataSource = list;

         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repo re = new Repo();
            re.Database.EnsureCreated();

            Room room = room1;
            //room.name = textBox1.Text;
            room.ChairPrice = int.Parse(textBox2.Text);

            room.RoomTypeId = re.roomTypes.
                ToList().Where(c => c.Name == comboBox1.Text).
                FirstOrDefault().ID;

            re.rooms.Update(room);
            re.SaveChanges();
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           RoomForm q = new RoomForm();
            q.Show();
            Hide();
        }
    }
}
