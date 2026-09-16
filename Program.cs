Course programmering = new Course("Programmering", 2); //Lägger till "ny kurs" Programering med 2 platser
Course matte = new Course("Matematik", 3); //Lägg till "ny kurs" Matematik med 3 platser.

Student martin = new Student("Martin"); //Skapar en ny student, Martin
Student sara = new Student("Sara"); // Skapar en ny Student Sara
Student erik = new Student("Erik"); // skapa en ny student Erik

Console.WriteLine("=== Anmalan via Join ===");
martin.Join(programmering); // Martin gå med i programmering, då det läggs till I Martins kurslistan samtidigt som Kurslistan uppdatera Martin som student är med
programmering.RollCall(); // visar studeterna i kursen
martin.Schedule(); // visar kurserna i studenten martin går

Console.WriteLine("=== Anmalan via Enroll ===");
matte.Enroll(sara); // Mattekursen anmäler Sara, samtidigt sara läggs i kursens studentliga och matte läggs i saras kurslista.
matte.RollCall(); // Skriver ut vilka som går i matte då Sara är med.
sara.Schedule(); //Visa Saras schema då hon har matte i sin kurslista

Console.WriteLine("=== Dubblettest ===");
martin.Join(programmering);     //Martin försöker gå med igen men får en return då han redan är med
programmering.RollCall();          // Martin syns bara en gång

Console.WriteLine("=== Kapacitetstest ===");
sara.Join(programmering);          // 2/2, Sara går med kursen har nu 2 av 2 platser och är full
erik.Join(programmering);          // Erik testa första då han inte ha kursen gå genom men andra ivllkoret då kursen är full 2/2 och nekas
Console.WriteLine(programmering);  // Programmering (2/2 platser)
programmering.RollCall();          // Martin och Sara, ingen Erik, call på vilka studenter som går i Kurslistasn programmering
sara.Schedule();                   // kolla vilka kurser sara ha då det är matematik och programmering
erik.Schedule();                   // tom

Console.WriteLine("=== Ta bort nagon som inte ar anmald ===");
programmering.Remove(erik);        // inget händer, då erik kunde inte lägga till programmering i sin kurslista efter som det va full i kapaciteten i maxseats.
programmering.RollCall(); // Oförändrad då martin och sara är kvar

Console.WriteLine("=== Vanlig borttagning ===");
martin.Leave(programmering);    //Martin lämna kursen och tas bort från båda listorna.
programmering.RollCall();          // skriver ut studenterna då sara är den enda kvar
martin.Schedule();                 // tom lista då han lämnade programmering.

