using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public int ID { get; set; }
        public virtual IEnumerable<Room> Rooms { get; set; }    
        public virtual IEnumerable<Booking> Bookings { get; set; }  
        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<User> users { get; set; }
    }
}
