using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.AppDbContext
{
    public class TLDbContext : DbContext
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConStr"].ConnectionString.ToString();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<TeacherInfo> TeacherInfos { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ScientificDegree> ScientificDegrees { get; set; }
        public DbSet<ScientificName> ScientificNames { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PreviousJob> PreviousJobs { get; set; }
        public DbSet<LayoutInfo> LayoutInfos { get; set; }
        public DbSet<TeacherLanguage> TeacherLanguages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TLExcluded> TLExcludeds { get; set; }
        public DbSet<TLIncluded> TLIncludeds { get; set; }
        public DbSet<PreferedSubject> PreferedSubjects { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<TeachingLoad> TeachingLoads { get; set; }
        public DbSet<TeachingLoadSubject> TeachingLoadSubjects { get; set; }    
    }
}
