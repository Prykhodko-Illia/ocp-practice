namespace OCP.Quiz;

public class MultipleChoiceQuestion : Question
{
    string[] Options;
    string CorrectAnswer;

    public MultipleChoiceQuestion(string prompt, string[] options, string correctAnswer) : base(prompt)
    {
        Options = options;
        CorrectAnswer = correctAnswer;
    }

    override public void Show()
    {
        base.Show();
        for (int i = 0; i < Options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }
        Console.WriteLine("Enter the options number:");
    }

    override public bool CheckAnswer(string answer)
    {
        return answer == CorrectAnswer;
    }
}
