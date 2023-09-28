using Microsoft.EntityFrameworkCore;
using SysacadApi.Core.Entities;

namespace SysacadApi.Infrastructure.Persistence
{
    public class SysacadContext : DbContext
    {
        public SysacadContext(DbContextOptions<SysacadContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
        }

    }
}
