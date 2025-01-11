using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    public class PubsDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Title> Titles { get; set; }

        private string connectionString = string.Empty;
        public PubsDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API を記述
        }
    }
}
