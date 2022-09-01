namespace LearningEvents;

public class Teacher
{
    public EventHandler<ExamEventArgs> examEvent;

    public void Exam(ExamEventArgs task)
    {
        if (examEvent != null)
        {
            examEvent(this, task);
        }
    }
}