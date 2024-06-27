using LINQ_Practice3.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQ_Practice3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblDepartment> tblDepartment { get; set; }
        public DbSet<tblEmployee> tblEmployee { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDepartment>()
                .HasMany(d => d.tblEmployee)
                .WithOne(e => e.tblDepartment)
                .HasForeignKey(d => d.DepartmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
