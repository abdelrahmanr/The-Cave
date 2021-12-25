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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            load();

        }
        void load()
        {
            Repo rd = new Repo();
            rd.Database.EnsureCreated();

            dataGridViewOrder.DataSource = rd.roomTypes.ToList();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm f = new AddOrderForm();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {

                Repo rd = new Repo();
                rd.Database.EnsureCreated();


                int id = int.Parse(dataGridViewOrder.SelectedRows[0].Cells[0].Value.ToString());

                var orders = from r in rd.orders.ToList()
                             where r.Id == id
                             select r;

                order order = orders.FirstOrDefault();

                EditOrderForm f = new EditOrderForm(orders);
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(" you must select row to delete ");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {

                Repo rd = new Repo();
                rd.Database.EnsureCreated();


                int id = int.Parse(dataGridViewOrder.SelectedRows[0].Cells[0].Value.ToString());

                var orders = from r in rd.orders.ToList()
                             where r.Id == id
                             select r;

                order order = orders.FirstOrDefault();

                if (order != null)
                {
                    rd.Remove(order);
                    rd.SaveChanges();
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

