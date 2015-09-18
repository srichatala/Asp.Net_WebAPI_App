using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TokenSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phoneno { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
    }
}
