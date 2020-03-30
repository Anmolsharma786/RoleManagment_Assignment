using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace rolemanagment.Models
{
    public class Project
    {
        [Required]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public String ProjectName { get; set; }
        [Key]
        [Required]
        public int projectID { get; set; }
    }
}
