namespace ConsoleApp5.Models;

public class Faculty
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Faculty()
    {
        
    }

    public Faculty(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
        => $"Id:{Id}\nName:{Name}";
}
