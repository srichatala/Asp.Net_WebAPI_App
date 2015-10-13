using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTokenSystem.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Advisor_Fname { get; set; }
        public string Advisor_Lname { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int Extension { get; set; }

        [ForeignKey("Campuses")]
        public int CampusId { get; set; }
        //  [JsonIgnore]
        public virtual Campus Campuses { get; set; }
    }
}
