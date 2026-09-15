

public class Student

{
    public List<Course> Courses = new List<Course>();
    public string Name = "";
    
            public Student(string name)
    {
            this.Name = name;
    }

public void Enroll(Course course)
{
    if (Courses.Contains(course)) return;
    if (course.Students.Count >= course.Capacity) return;

    Courses.Add(course);
    course.AddStudent(this);



}
public void Unenroll(Course course) 
{
        if (Courses.Contains(course))
        {
                Courses.Remove(course);
                course.RemoveStudent(this);
        }
}
public void Schedule()
        {
                Console.WriteLine(Name + " is enrolled in:");

                foreach (Course course in Courses)

                {
                        Console.WriteLine(course.Name);
                }



        }


            
}   
    


