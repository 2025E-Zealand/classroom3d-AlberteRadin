public class ClassRoom
{
    string ClassName { get; set; }
    List<Student> students;
    DateTime SemesterStart;

    public ClassRoom(string className , DateTime semesterStart)
    {
        ClassName = className;
        students = new List<Student>();
        SemesterStart = semesterStart;
            
    }
}