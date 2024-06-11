using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkPortal_ASP.Net.Models;

namespace WorkPortal_ASP.Net.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Whenever I want to add something to my database I add this DBSET
        //Model names are singular
        //DBsets are PLURAL!
        public DbSet<Employee> Employees { get; set; }

        public DbSet <Attendance> Attendances { get; set; }

        public DbSet <Department> Departments { get; set; }



    }
}
