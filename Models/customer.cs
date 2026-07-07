using System;
using System.Collections.Generic;
using System.Text;

namespace ClientSchedule.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}