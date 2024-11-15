using _02_WEB_API.Model;

namespace _02_WEB_API.Context;

public class StudentsDB
{

    public static List<Student> students = new List<Student>()
    {
        new Student()
        {
            name = "Tarık",
            surname = "Hamarat",
            birthdate = Convert.ToDateTime("1990/01/01"),
            school_number = "605"
        },
        new Student()
        {
            name = "Muhammet Ali",
            surname = "Çetinkaya",
            birthdate = Convert.ToDateTime("1995/01/01"),
            school_number = "790"
        },
        new Student()
        {
            name = "Aleyna",
            surname = "Uzan",
            birthdate = Convert.ToDateTime("1991/10/11"),
            school_number = "800"
        },
        new Student()
        {
            name = "Nursena",
            surname = "Namlı",
            birthdate = Convert.ToDateTime("1997/05/02"),
            school_number = "995"
        },
        new Student()
        {
            name = "Mehmet",
            surname = "Çiftçi",
            birthdate = Convert.ToDateTime("1982/05/02"),
            school_number = "1023"
        },
        
    };


}