using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace hw4
{
    public class AppDbContext : DbContext 
    {
        private const string ConnectionString = @"Data Source=HW3.db";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlite(ConnectionString); 
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Organization> Organizationes { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
    }
}