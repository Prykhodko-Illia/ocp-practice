namespace OCP.Questions;

public abstract class Question
{
    string Prompt;

    protected Question(string prompt)
    {
        Prompt = prompt;
    }

    public virtual void Show()
    {
        Console.WriteLine(Prompt);
    }

    public abstract bool CheckAnswer(string answer);
}

