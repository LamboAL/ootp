using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ootp.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        
        public string Person { get; set; }
        
        public string Address { get; set; }
        
        public int BookId { get; set; }
 
        public DateTime Date { get; set; }
    }
}