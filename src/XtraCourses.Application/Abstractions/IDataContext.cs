using Microsoft.EntityFrameworkCore;
using XtraCourses.Application.Entities;

namespace XtraCourses.Application.Abstractions
{
    public interface IDataContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
