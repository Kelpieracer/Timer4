using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RCB.TypeScript.Models
{
    public class TimerDbContext : DbContext
    {
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<WorkItem> WorkItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TapioM\Documents\TimerDB.mdf;Integrated Security=True;Connect Timeout=30");
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TimerDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasIndex(b => b.Name);
            modelBuilder.Entity<Project>()
                .HasIndex(b => b.Name);
            modelBuilder.Entity<Topic>()
                .HasIndex(b => b.Name);
            modelBuilder.Entity<WorkItem>()
                .HasIndex(b => b.Started);
            modelBuilder.Entity<Rate>()
                .HasIndex(b => b.Name);
        }
    }
}
