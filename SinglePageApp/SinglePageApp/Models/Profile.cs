using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePageApp.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Provience { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string Education { get; set; }
    }
}