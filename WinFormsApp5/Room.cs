using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    public class Room
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int totalChair { get; set; }
        public bool availabilty { get; set; }
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<order> Orders { get; set; } 
        public virtual IEnumerable<Booking> Bookings { get; set; }
        public int ChairPrice { get; internal set; }
    }
}
