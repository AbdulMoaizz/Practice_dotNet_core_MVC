using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mary",
                    Department = EnumDep.IT,
                    Email = "mary@gmail.com"
                }
                );
        }*/
    }
}
