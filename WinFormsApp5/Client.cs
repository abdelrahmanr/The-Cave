using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public virtual IEnumerable<Room>Rooms { get; set; }
        public virtual IEnumerable<User> Users { get; set; }    
        public virtual IEnumerable<Product> Products { get; set; }  
        public virtual IEnumerable<order> Orders { get; set; }
        public virtual IEnumerable<Booking> Bookings   { get; set; }




    }
}
