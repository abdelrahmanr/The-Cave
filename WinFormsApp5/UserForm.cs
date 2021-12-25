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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            Repo rw = new Repo();
            rw.Database.EnsureCreated();

            dataGridViewUser.DataSource = rw.users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home r = new Home();    
            r.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddUserForm f=new AddUserForm();
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {

                Repo rr = new Repo();
                rr.Database.EnsureCreated();


                int id = int.Parse(dataGridViewUser.SelectedRows[0].Cells[0].Value.ToString());

                var users = from r in rr.users.ToList()
                            where r.ID == id
                            select r;

                User user = users.FirstOrDefault();

                EditUserForm d = new EditUserForm(user);
                d.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(" you must select row to delete ");
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {

                Repo rq = new Repo();
                rq.Database.EnsureCreated();


                int id = int.Parse(dataGridViewUser.SelectedRows[0].Cells[0].Value.ToString());

                var users = from r in rq.users.ToList()
                            where r.ID == id
                            select r;

                User user = users.FirstOrDefault();

                if (user != null)
                {
                    rq.Remove(user);
                    rq.SaveChanges();
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
