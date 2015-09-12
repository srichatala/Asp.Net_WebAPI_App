using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Mobilr.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}