Course programmering = new Course("Programmering", 2);
Course matte = new Course("Matematik", 3);

Student martin = new Student("Martin");
Student sara = new Student("Sara");
Student erik = new Student("Erik");

Console.WriteLine("=== Anmalan via Join ===");
martin.Join(programmering);
programmering.RollCall();
martin.Schedule();

Console.WriteLine("=== Anmalan via Enroll ===");
matte.Enroll(sara);
matte.RollCall();
sara.Schedule();

Console.WriteLine("=== Dubblettest ===");
martin.Join(programmering);
programmering.RollCall();          // Martin syns bara en gång

Console.WriteLine("=== Kapacitetstest ===");
sara.Join(programmering);          // 2/2, nu full
erik.Join(programmering);          // nekas
Console.WriteLine(programmering);  // Programmering (2/2 platser)
programmering.RollCall();          // Martin och Sara, ingen Erik
sara.Schedule();                   // Matematik och Programmering
erik.Schedule();                   // tom

Console.WriteLine("=== Ta bort nagon som inte ar anmald ===");
programmering.Remove(erik);        // inget händer
programmering.RollCall();

Console.WriteLine("=== Vanlig borttagning ===");
martin.Leave(programmering);
programmering.RollCall();          // bara Sara kvar
martin.Schedule();                 // tom lista