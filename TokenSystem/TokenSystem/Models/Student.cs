using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenSystem.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phoneno { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
    }
}
