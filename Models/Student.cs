using System.ComponentModel.DataAnnotations;

namespace ClassManagement.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    
    [Range(7, 65)]
    public int Age { get; set; }
    
    [StringLength(25)]
    public string? Name { get; set; }
    
    [StringLength(25)]
    public string? Surname { get; set; }

    public decimal Gpa { get; set; }
    public string? FathersName { get; set; }
    public string? Address { get; set; }

    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}