using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FakultetDbContext : DbContext
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Kontakt> kontakti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5GED28G\\SQLEXPRESS;Database=Fakultet;Integrated Security=True;",
                        options => options.EnableRetryOnFailure());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Student>()
           .HasOne(s => s.Kontakt)
           .WithOne(c => c.Student)
            .HasForeignKey<Kontakt>(c => c.StudentId);
        }


    }

}
