namespace OCP.Quiz;


public class TextQuestion : Question
{
    string CorrectAnswer;

    public TextQuestion(string prompt, string correctAnswer) : base(prompt)
    {
        CorrectAnswer = correctAnswer;
    }

    override public void Show()
    {
        base.Show();
        Console.WriteLine("Type your answer:");
    }

    override public bool CheckAnswer(string answer)
    {
        return answer.Equals(
            CorrectAnswer,
            StringComparison.OrdinalIgnoreCase);
    }
}