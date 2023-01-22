using Microsoft.EntityFrameworkCore;
using XtraCourses.Application.Abstractions;
using XtraCourses.Application.Entities;

namespace XtraCourses.Infrastructure.Persistence
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
