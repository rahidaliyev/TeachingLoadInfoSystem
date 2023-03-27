using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.AppDbContext
{
    public class TLDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            optionBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
        public DbSet<PersonInfo> PersonInfos { get; set; }
    }
}
