using HighSchoolLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace HighSchoolLesson.DataAccess
{
    public class HighContext : DbContext
    {
        public HighContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubjectsStudents> SubjectsStudents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=A-305-05;Database=HighSchoolv1;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
