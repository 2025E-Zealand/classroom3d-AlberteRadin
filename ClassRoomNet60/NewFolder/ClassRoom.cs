public class ClassRoom
{
    string ClassName { get; set; }
    List<Student> students;
    DateTime SemesterStart { get; set; } 

    public ClassRoom(string className , DateTime semesterStart)
    {
        ClassName = className;
        students = new List<Student>();
        SemesterStart = semesterStart;
            
    }
}