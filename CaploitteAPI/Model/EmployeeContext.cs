using Microsoft.EntityFrameworkCore;

namespace CaploitteAPI.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSalaryDetails> EmployeesSalaryDetail { get; set; }
    }
}
