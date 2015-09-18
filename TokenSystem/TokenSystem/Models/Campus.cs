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
    public class Campus
    {
        [Key]
        public int Campusid { get; set; }
        public string Campusname { get; set; }
        public string Contactno { get; set; }
    }
}
