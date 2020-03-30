using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rolemanagment.Models
{
    public class ProjectRunningContext : DbContext
    {
        public ProjectRunningContext(DbContextOptions<ProjectRunningContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
    }
}
