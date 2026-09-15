public class Student                                                                     //Ritning för student, samt att den är publik

{
    public List<Course> Courses = new List<Course>();                                    //List typ "Course, Skapa ny lista som heter Courses
    public string Name = "";                                                             // Text variabel för stundeternas namn
    
            public Student(string name)                                                  // Konstruktor -> körs när en ny student skapas och tar emot namnet
    {
            this.Name = name;                                                           //Namnet skickas ner hit och konstruktorn sparar det i fältet "public string Name"
    }
public void Join(Course course)                                                         //Studenten går med i en kurs
{
    if (Courses.Contains(course)) return;                                               //Går redan kursen -> avbryter
    if (course.Students.Count >= course.MaxSeats) return;                               // kursen är full -> avbryt

    Courses.Add(course);                                                                // lägg till kursen i studentens lista
    course.Students.Add(this);                                                          //Kursen lägger till studenten i sin studentlista
}
public void Leave(Course course)                                                        //Studenten lämnar en kurs
{
        if (Courses.Contains(course))                                                   // bara om studenten går kursen
        {
                Courses.Remove(course);                                                 // studenten tar bort kursen ur sin kurslista
                course.Students.Remove(this);                                           // Kursen tar bort studenten ur sin studentlista
        }
}
public void Schedule()                                                                  //Skriver ut alla kurser studenten gå
        {
                Console.WriteLine(Name + " is enrolled in:");                            // rubrik med studentens namn

                foreach (Course course in Courses)                                      // gå igenom kurslistan, en kurs i taget

                {
                        Console.WriteLine(course.Name);                                 // Skriver ut kursens namn
                }

        



        }
public override string ToString ()                                                      // Ersätter den inbyggda ToString, så att en student skrivs ut med sitt namn

{
        return Name;                                                                    // Skickar tillbaka studentens namn som text
}

            
}   
    


