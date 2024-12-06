namespace ConsoleApp5.Model;

public class Group
{

    public Guid Id { get; set; }
    public string GroupName { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
    public Group()
    {
        
    }
    public Group(Guid id, string groupName, Teacher teacher, List<Student> students)
    {
        Id = id;
        GroupName = groupName;
        Teacher = teacher;
        Students = students;
    }


}
