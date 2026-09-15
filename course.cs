public class Course

{
    public List<Student> Students = new List<Student>();

    public string Name = "";
    public int Capacity;

    
        public Course(string name, int capacity)

        {
            this.Name = name;
            this.Capacity = capacity;
        }


public void AddStudent(Student student)

    {
        if (Students.Contains(student)) return;
        if (Students.Count >= Capacity) return;

        Students.Add(student);
        student.Enroll(this);
    }
public void RemoveStudent(Student student)
    { 
        if (Students.Contains(student))
        {
            Students.Remove(student);
            student.Unenroll(this);
        }
    } 
}