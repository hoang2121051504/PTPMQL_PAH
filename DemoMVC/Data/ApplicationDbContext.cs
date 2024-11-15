using Microsoft.EntityFrameworkCore;
using DemoMVC.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<Models.ApplicationUser>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<ApplicationUser> Users { get; set; } = default!;
    }
}
