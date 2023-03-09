// TODO: Instantiate your objects and test your exercise solutions with print statements here.
using Classes;

Student whateverTheNewNameIs = new Student("Dion", 111, 1, 4.0);

Console.WriteLine(whateverTheNewNameIs.Name);
whateverTheNewNameIs.Name = "D";
Console.WriteLine(whateverTheNewNameIs.Name);

Student rosco = new Student("Rosco", 323);

//foreach (Student stu in whateverTheNewNameIs)

Console.WriteLine(rosco.Name);
Console.WriteLine(rosco.StudentId);
Console.WriteLine(rosco.NumberOfCredits);
Console.WriteLine(rosco.Gpa);

Student joe = new Student ("Joe");
Student john = new Student("John");
Student devon = new Student("Devon");
Student dee = new Student("Dee");

Console.WriteLine(joe.StudentId);
Console.WriteLine(dee.StudentId);
Console.WriteLine(john.StudentId);
Console.WriteLine(devon.StudentId);