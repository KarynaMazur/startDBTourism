using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace startPage.Models
{
    public class TextContent: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BuyTicket> BuyTickets { get; set; }
       public DbSet<About> Abouts { get; set; }
    }
}