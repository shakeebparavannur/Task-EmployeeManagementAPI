using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Work> Works { get; set; }

    }
}
