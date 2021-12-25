using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public class RoomType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Room> rooms { get; set; }
        public int ChairPrice { get; set; }

    }
}
