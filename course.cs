public class Course

{
    public List<Student> Students = new List<Student>();

    public string Name = "";
    public int MaxSeats;

    
        public Course(string name, int capacity)

        {
            this.Name = name;
            this.MaxSeats = capacity;
        }


public void AddStudent(Student student)

    {
        if (Students.Contains(student)) return;
        if (Students.Count >= MaxSeats) return;

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
public void RollCall()

    {
        Console.WriteLine("Roll call for " + Name + ":");

        foreach (Student student in Students)

        {
            Console.WriteLine(student.Name);
        }
    }

public override string ToString()

    {
        return Name + " (" + Students.Count + "/" + MaxSeats + " platser)";
    }


}