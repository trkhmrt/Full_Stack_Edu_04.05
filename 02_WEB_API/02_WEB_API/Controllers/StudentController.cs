using _02_WEB_API.Context;
using _02_WEB_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace _02_WEB_API.Controllers;

[ApiController]
// localhost:8080/Student
[Route("[controller]")]
public class StudentController: ControllerBase
{
    private List<Student> _students;
    
    
    public StudentController()
    {
        _students = StudentsDB.students;
    }
    
    
    [HttpGet]
    public List<Student> GetAllStudents()
    {
        var context = HttpContext.Request.Body;
        return _students;
    }
    
    
    [HttpGet("{number}")]
    public Student GetStudent(string number)
    {
        var founded_student = _students.FirstOrDefault(s => s.school_number == number);

        if (founded_student != null)
        {
            return founded_student;
        }
        
        
        return null;
    }


    [HttpPost]
    //Ön yüzden gönderilen body içindeki field isimlerinin nesne prop isimleriyle aynı olması gerekir.
    //Bu gönderilen verilerin backendde nesne ile maplenmesi için gereklidir.
    public string AddStudent(Student student)
    {
        
        if(!ModelState.IsValid)
        {
            var error = ModelState.Values.SelectMany(v => v.Errors);
            return error.ToString();
        }
        if (student != null)
        {
            
            _students.Add(student);
            
            return "Öğrenci başarıyla kaydedildi.";
        }

        return "Öğrenci kaydında hata";
        
    }
    
    
    [HttpDelete("{number}")]
    public string AddStudent(string number)
    {
        
        var founded_student = _students.FirstOrDefault(s => s.school_number == number);

        if (founded_student != null)
        {
            _students.Remove(founded_student);

            return "Öğrenci başarıyla silinmiştir.";
        }
                                
                
        return "Öğrenci Bulunamadı.";
        
    }
    
    [HttpPut("{number}")]
    public Student UpdateStudent(string number)
    {
        
        var founded_student = _students.FirstOrDefault(s => s.school_number == number);

        if (founded_student != null)
        {
            
            founded_student.name = "Berke";

            return founded_student;
        }
        
        return null;
    }
    
    
    
    
    
    
    
    
}