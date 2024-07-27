using ClassManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassManagement.Data;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {}

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Grade> Grades { get; set; }


    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // One-to-many relationship between Subject and Teacher
        modelBuilder.Entity<Subject>()
            .HasMany(s => s.Teachers)
            .WithOne(t => t.Subject)
            .HasForeignKey(t => t.SubjectId);

        // One-to-many relationship between Subject and Grade
        modelBuilder.Entity<Subject>()
            .HasMany(s => s.Grades)
            .WithOne(g => g.Subject)
            .HasForeignKey(g => g.SubjectId);

        // One-to-many relationship between Student and Grade
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Grades)
            .WithOne(g => g.Student)
            .HasForeignKey(g => g.StudentId);
    }
}