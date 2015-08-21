using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebAPI.Models
{
    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Qualification { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }
}