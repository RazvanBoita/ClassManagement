namespace ClassManagement.Models;

public class Grade
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }

    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }

    public int Value { get; set; }
    public DateTime DateAssigned { get; set; }

}