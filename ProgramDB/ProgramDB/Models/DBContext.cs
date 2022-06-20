using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace ProgramDB.Models
{
    public class DBContext : DbContext
    {
       
        public DbSet<DBClass> tablica { get; set; } = null!;
        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }*/
        public void DBContext1()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=DESKTOP-PC\\SQLEXPRESS;Database=load_CSV;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
