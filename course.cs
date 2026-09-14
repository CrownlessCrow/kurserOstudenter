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
    } 
