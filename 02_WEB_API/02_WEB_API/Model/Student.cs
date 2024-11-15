using System.ComponentModel.DataAnnotations;

namespace _02_WEB_API.Model;

public class Student
{
    [Required]
    [StringLength(50, MinimumLength = 5)]
    public string name { get; set; }

    public string surname { get; set; }

    public string school_number { get; set; }

    public DateTime birthdate { get; set; }
    
    
}