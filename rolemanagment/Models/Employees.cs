using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rolemanagment.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string fName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string lName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string gender { get; set; }
        [Column(TypeName = "varchar(2)")]
        public int jobId { get; set; }
    }
}
