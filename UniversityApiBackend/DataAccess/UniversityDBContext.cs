using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) 
        { 
        
        }

        //TODO add bdset(tables of our data)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; } 
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; } 
    }
}
