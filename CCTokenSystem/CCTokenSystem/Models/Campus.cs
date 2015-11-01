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
        public string CampusAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
    }
}
