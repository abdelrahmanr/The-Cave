using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    public class Product
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public int sellPrice { get; set; }
        public int buyPrice { get; set; }
        public int productId { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }




    }
}
