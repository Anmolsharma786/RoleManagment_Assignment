using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace rolemanagment.Models
{
    public class SalaryContext : DbContext
    {
        public SalaryContext(DbContextOptions<SalaryContext> options) : base(options) { }
        public DbSet<Salary> Salarys { get; set; }
    }
}
