using System.ComponentModel.DataAnnotations;

namespace ClassManagement.Models;

public class Subject
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}