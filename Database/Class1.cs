namespace Database;
using ConsoleApp5.Model;
using ConsoleApp5.Models;

public class StepAcademyDb
{
    public static List<Student> Students { get; set; }
    public static List<Teacher> Teachers { get; set; }
    public static List<Group> Groups { get; set; }
    public static List<Faculty> Faculty { get; set; }

    static StepAcademyDb()
    {
        Student students = new Student();
        Teacher teachers = new Teacher();
        Group groups = new Group();
        Faculty faculties = new Faculty();

    }


    public void ShowAllStudents()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine(student);
        }
    }
    public void ShowAllTeachers()
    {
        throw new NotImplementedException();
    }
    public void ShowAllGroups()
    {
        throw new NotImplementedException();
    }
    public void ShowAllFaculties()
    {
        throw new NotImplementedException();
    }
    public void GetStudentById(Guid id)
    {
        throw new NotImplementedException();
    }
    public void GetTeacherById(Guid id)
    {
        throw new NotImplementedException();
    }
    public void GetGroupById(Guid id)
    {
        throw new NotImplementedException();
    }

    public void StudentAdd(Student student)//ACademye add
    {
        throw new NotImplementedException();

    }

    public void StudentGroupAdd(Student student, Guid groupId)//ACademye add
    {
        throw new NotImplementedException();

    }

    public void TeacherAdd(Teacher student)//ACademye add
    {
        throw new NotImplementedException();

    }

    public void TeacherGroupAdd(Teacher student, Guid groupId)//ACademye add
    {
        throw new NotImplementedException();

    }

    //Add de oldugu kimi Deleted olan variantda yazilsin 2 side





}

