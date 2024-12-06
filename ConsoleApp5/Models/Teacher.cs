using ConsoleApp5.Enums;

namespace ConsoleApp5.Model;

public class Teacher
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public string Speciality { get; set; }
    public DateOnly Birthday { get; set; }
    public Teacher()
    {
        
    }
    public Teacher(Guid id, string name, string surname, Gender gender, string speciality, DateOnly birthday)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Gender = gender;
        Speciality = speciality;
        Birthday = birthday;
    }

    public override string ToString()
    {
        return $"Id: {Id}\n" +
           $"Name: {Name}\n" +
           $"Surname: {Surname}\n" +
           $"Gender: {Gender}\n" +
           $"Speciality: {Speciality}\n" +
           $"Birthday: {Birthday}";
    }


}
