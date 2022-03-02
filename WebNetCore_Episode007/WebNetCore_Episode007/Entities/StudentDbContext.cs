using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNetCore_Episode007.Entities
{
    public class StudentDbContext: DbContext    {
        public StudentDbContext() : base() { }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<PersonInfo> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Gender>().HasNoKey();
        }
    }
}
