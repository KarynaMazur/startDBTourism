using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace startPage.Models
{
    public class About
    {
        public About()
        {
            Id = 1;
        }

        public int Id { get; set; }
        public string AboutContent { get; set; }


    }
}