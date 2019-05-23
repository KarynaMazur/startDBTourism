using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace startPage.Models
{
    public class BuyTicket
    {
        public int BuyTicketId { get; set; }
        public string Person { get; set; }
        public string City { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}