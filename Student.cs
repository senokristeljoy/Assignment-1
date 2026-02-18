using System;

public class Student
{
    public string StudentID { get; }
    public string Name { get; }
    public string Course { get; }

    public Student(string studentID, string name, string course)
    {
        StudentID = studentID;
        Name = name;
        Course = course;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Course: {Course}");
        Console.WriteLine();
    }
}
