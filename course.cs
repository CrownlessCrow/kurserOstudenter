public class Course                                                     //Ritning för "Kursen" samt att den är publikt så andra filer som student.cs kan använda den

{
    public List<Student> Students = new List<Student>(); // Listan ska innehålla Studenter, o den toma listan som blir skapad heter Students.

    public string Name = "";                            //Textvariabel för kursens namn
    public int MaxSeats;                                //  heltal variabel då jag har döpt den till MaxSeats       

    
        public Course(string name, int capacity)        //Konstruktorn -> kör när kursen är skapad då den ta emot 1. namn 2 platser.

        {
            this.Name = name;                           //  spara namnet i fältet       
            this.MaxSeats = capacity;                   // spara antal platser i fältet
        }


public void Enroll(Student student)                     //Kursen anmäler studenter i kursen

    {
        if (Students.Contains(student)) return; // Villkor, finns studenten redan i listan -> avbryt, annars gå vidare
        if (Students.Count >= MaxSeats) return; // nästa villkor: är antalet studenter lika med eller över maxSeats -> kursen är full, avbryt

        Students.Add(student); //Annars lägger den till Studenten i kurslsitasn
        student.Courses.Add(this);  //Lägger till kursen i Studentens StudentKurs då sedan kommer synas i hens schedule()
    }
public void Remove(Student student) //Ta bort studenten ur kursen
    {
        if (Students.Contains(student)) // Kollar om studenten finns i kursens studentlista, annars hoppas blocket över
        {
            Students.Remove(student); // Tar bort studenten ur kursens studentlista
           student.Courses.Remove(this); //Tar bort kursen ur studentens kurslista
        }
    }
public void RollCall() //Upprop då den skriver ut alla studenter i kursen

    {
        Console.WriteLine("Roll call for " + Name + ":"); //rubrik med kursens namn som "Roll call for " Kursensnman

        foreach (Student student in Students) // kursens studentlista

        {
            Console.WriteLine(student.Name); //studentens namn
        }
    }

public override string ToString() // Istället för "Course" skrivs t.ex. "Programmering (2/2 platser)" ut

    {
        return Name + " (" + Students.Count + "/" + MaxSeats + " platser)"; //Detta stycket då som jag har lagt till, bygger själva Programmerings 2/2 platser
}
    }


