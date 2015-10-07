using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCTokenSystem.Models
{
    public class Campus
    {
        [Key]
        public int CampusId { get; set; }
        public string CampusName { get; set; }
        public string ContactNo { get; set; }
    }
}
