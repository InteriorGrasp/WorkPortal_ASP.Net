using Microsoft.AspNet.Identity.EntityFramework;
using WorkPortal_ASP.Net.Models;

namespace WorkPortal_ASP.Net.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Payroll> Payrolls {  get; set; }

        public DbSet<EmployeeLogin> EmployeeLogins { get; set; }

        public DbSet <AdminLogin> AdminLogins { get; set; }


    }
}
