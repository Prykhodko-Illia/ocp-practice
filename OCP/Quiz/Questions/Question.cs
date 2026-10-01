namespace OCP.Quiz;

public abstract class Question
{
    string Prompt;

    public Question(string prompt)
    {
        Prompt = prompt;
    }

    public virtual void Show()
    {
        Console.WriteLine(Prompt);
    }

    public abstract bool CheckAnswer(string answer);
}

