using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebAPI.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Course { get; set; }
    }
}