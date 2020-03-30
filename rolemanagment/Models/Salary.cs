using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rolemanagment.Models
{
    public class Salary
    {
        [Required]
        public int EmployeeId { get; set; }
        [Column(TypeName = "int")]
        public int Salarys { get; set; }
        [Key]
        [Required]
        public int salaryId { get; set; }

    }
}
