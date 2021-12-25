using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    public class Booking
    {
       

        public int Id { get; set; }
        public int date { get; set; }
        public int time { get; set; }
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public int RoomID { get; set; }
        public int NumberOfChairs { get; set; }
        public int TotalPrice { get; set; }
        public int NumberOfHours { get; set; }
        public virtual IEnumerable<User> Users { get; set; }    
        public virtual IEnumerable<Client> Clients { get; set; }


    }
}
