using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class EditClintFrom : Form
    {
        public EditClintFrom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientForm f =new ClientForm();
            f.Show();
            Hide();
        }
    }
}
