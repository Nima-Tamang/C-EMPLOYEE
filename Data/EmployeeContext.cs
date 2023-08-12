using Microsoft.EntityFrameworkCore;

public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<ems.Models.Employee> Employee { get; set; } = default!;
    }
