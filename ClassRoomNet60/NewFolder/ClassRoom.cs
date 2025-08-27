public class ClassRoom
{
     public string ClassName { get; set; }
    public List<Student> students { get; }
   public DateTime SemesterStart { get; set; } 

    public ClassRoom(string className , DateTime semesterStart)
    {
        ClassName = className;
        students = new List<Student>();
        SemesterStart = semesterStart;
            
    }
}