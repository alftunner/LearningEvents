namespace LearningEvents;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public void Exam(object sender, ExamEventArgs e)
    {
        Console.WriteLine($"Student {LastName} solved the {e.Task}");
    }
}