using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace ProgramDB.Models
{
    public class DBContext : IdentityDbContext<IdentityUser>
    {
       
        public DbSet<DBClass> tablica => Set<DBClass>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=importCSV2;Trusted_Connection=True;");
        }
    }
}
