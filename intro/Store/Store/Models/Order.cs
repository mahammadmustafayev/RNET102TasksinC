using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public Book[] Books { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
