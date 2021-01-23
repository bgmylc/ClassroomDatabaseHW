using ClassroomHW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomHW.Migrations
{
    public class ClassroomDbContext : DbContext
    {
        public ClassroomDbContext()
        {


        }

        public ClassroomDbContext(DbContextOptions<ClassroomDbContext> options) : base(options)
        {

        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>()
                        .HasMany(s => s.Students)
                        .WithOne(c => c.classroom)
                        .HasForeignKey(f => f.ClassroomID);
            
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB; Database=ClassroomV1; Integrated Security = yes");
            }




        }
    }
}
