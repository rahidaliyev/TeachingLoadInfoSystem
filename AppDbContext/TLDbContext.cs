using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.AppDbContext
{
    public class TLDbContext : DbContext
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConStr"].ConnectionString.ToString();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<PersonInfo> PersonInfos { get; set; }
    }
}
