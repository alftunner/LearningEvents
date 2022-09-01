using LearningEvents;

List<Student> group = new List<Student>
{
    new Student
    {
        FirstName = "Alexis",
        LastName = "Sherstnyev",
        BirthDate = new DateTime(1992, 8, 6)
    },
    new Student
    {
        FirstName = "Andrey",
        LastName = "Zadorozhniy",
        BirthDate = new DateTime(1992, 8, 6)
    },
};

Teacher teacher = new Teacher();
foreach (Student item in group)
{
    teacher.examEvent += item.Exam;
}

ExamEventArgs eventArgs = new ExamEventArgs { Task = "Задание" };

teacher.Exam(eventArgs);