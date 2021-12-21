using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    public class Booking
    {
        public int ID { get; set; }
        public int date { get; set; }
        public int time { get; set; }
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public int NumberOfChairs { get; set; }
        public int TotalPrice { get; set; }
        public int NumberOfHours { get; set; }

    }
}
