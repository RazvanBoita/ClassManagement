using System.ComponentModel.DataAnnotations;

namespace ClassManagement.Models;

public class Teacher
{
    [Key]
    public int Id { get; set; }
    
    [Range(23, 65)]
    public int Age { get; set; }
    
    [StringLength(25)]
    public string? Name { get; set; }
    
    [StringLength(25)]
    public string? Surname { get; set; }
    
    public Subject? Subject { get; set; }
    public int SubjectId { get; set; }
    
    public string? EmailAddress { get; set; }
    public int Experience { get; set; }
}