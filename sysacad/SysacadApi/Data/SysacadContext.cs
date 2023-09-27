using Microsoft.EntityFrameworkCore;
using SysacadApi.Models;

namespace SysacadApi.Data
{
    public class SysacadContext : DbContext
    {
        public SysacadContext(DbContextOptions<SysacadContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Course>().ToTable("Course");
        }

    }
}
