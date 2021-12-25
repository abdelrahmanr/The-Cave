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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            load();
        }
        
        
        
            void load()
            {
                Repo re = new Repo();
                re.Database.EnsureCreated();

                dataGridViewRoom.DataSource = re.rooms.ToList();
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
            if (dataGridViewRoom.SelectedRows.Count > 0)
            {

                Repo re = new Repo();
                re.Database.EnsureCreated();


                int id = int.Parse(dataGridViewRoom.SelectedRows[0].Cells[0].Value.ToString());

                var rooms = from r in re.rooms.ToList()
                            where r.Id == id
                            select r;

                Room room = rooms.FirstOrDefault();

                EditRoomform f = new EditRoomform(room);
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(" you must select row to delete ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count > 0)
            {

                Repo ro = new Repo();
                ro.Database.EnsureCreated();


                int ID = int.Parse(dataGridViewRoom.SelectedRows[0].Cells[0].Value.ToString());

                var rooms = from r in ro.rooms.ToList()
                            where r.Id == ID
                            select r;

                Room room = rooms.FirstOrDefault();

                if (room != null)
                {
                    ro.Remove(room);
                    ro.SaveChanges();
                    load();
                }

            }
            else
            {
                MessageBox.Show(" you must select row to delete ");
            }

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }
    }
    }


  
   

