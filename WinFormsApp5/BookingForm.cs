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
    public partial class BookingForm : Form
    {
        private object bookings;

        public BookingForm()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            Repo re = new Repo();
            re.Database.EnsureCreated();

            dataGridViewBooking.DataSource = re.roomTypes.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h=new Home();
            h.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBookingForm a=new AddBookingForm();
            a.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooking.SelectedRows.Count > 0)
            {

                Repo rm = new Repo();
                rm.Database.EnsureCreated();


                int id = int.Parse(dataGridViewBooking.SelectedRows[0].Cells[0].Value.ToString());

                var booking = from r in rm.bookings.ToList()
                            where r.Id == id
                            select r;

                Booking bo = booking.FirstOrDefault();

                EditBookingForm b = new EditBookingForm(bo);
                b.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(" you must select row to delete ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooking.SelectedRows.Count > 0)
            {

                Repo re = new Repo();
                re.Database.EnsureCreated();


                int id = int.Parse(dataGridViewBooking.SelectedRows[0].Cells[0].Value.ToString());

                var rooms = from r in re.roomTypes.ToList()
                            where r.ID == id
                            select r;

                RoomType room = rooms.FirstOrDefault();

                if (room != null)
                {
                    re.Remove(room);
                    re.SaveChanges();
                    load();
                }

            }
            else
            {
                MessageBox.Show(" you must select row to delete ");
            }
        }
    }
}
