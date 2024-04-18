using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_cv_.EFCore
{
    internal class VyukaContext : DbContext
    {
        public DbSet<Student> Students {  get; set; }
        public DbSet<Predmet> Predmets { get; set; }
        public DbSet<StudentPredmet> StudentPredmets { get; set; }
        public DbSet<Hodnoceni> Hodnocenis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\bpc-oop\bpc-oop\11_cv_\vyuka.mdf;Integrated Security=True;Connect Timeout=30"); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentPredmet>().HasKey(e => new { e.IdStudent, e.ZkratkaPredmet });
            modelBuilder.Entity<Hodnoceni>().HasKey(e => new { e.IdStudent, e.ZkratkaPredmet });
        }
    }
}
