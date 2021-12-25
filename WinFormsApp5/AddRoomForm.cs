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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomForm r = new RoomForm();
            r.ShowDialog();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            Repo ra = new Repo();
            ra.Database.EnsureCreated();
            r.name = textBox3.Text;
            r.totalChair = int.Parse(textBox2.Text);

            r.RoomTypeId = ra.roomTypes.
                ToList().Where(c=>c.Name  == comboBox1.Text).
                FirstOrDefault().ID;
           
         
            ra.rooms.Add(r);
            ra.SaveChanges();
            MessageBox.Show("Done");

        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            Repo r = new Repo();

            comboBox1.DataSource =
                r.roomTypes.ToList().
                Select(c=>c.Name).ToList();
        }
    }
}
