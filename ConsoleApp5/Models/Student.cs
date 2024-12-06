using ConsoleApp5.Enums;
using ConsoleApp5.Models;


namespace ConsoleApp5.Model;

public class Student
{
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public Faculty Faculty { get; set; }
    public DateOnly Birthday { get; set; }
    public Student()
    {
        
    }
    public Student(Guid id, string name, string surname, Gender gender, Faculty faculty, DateOnly birthday)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Gender = gender;
        Faculty = faculty;
        Birthday = birthday;
    }

    public override string ToString()
    {
        return $"Id: {Id}\n" +
       $"Name: {Name}\n" +
       $"Surname: {Surname}\n" +
       $"Gender: {Gender}\n" +
       $"Faculty: {Faculty}\n" +
       $"Birthday: {Birthday}";
    }

}
