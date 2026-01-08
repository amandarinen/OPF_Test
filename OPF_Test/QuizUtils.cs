namespace OPF_Test;

public class QuizUtils
{
    private static List<Question> _questions = new();
    //private int _count = 0;
    //private int _total = 0;

    public static bool IsCompleted()
    {
        throw new NotImplementedException();
    }

    public static void CheckAnswer(int answer)
    {
        throw new NotImplementedException();
    }

    public static void DisplayQuestion()
    {
        throw new NotImplementedException();
    }

    public static int GetAnswer()
    {
        throw new NotImplementedException();
    }

    public static void SeedQuestions()
    {
        Choice[] choices = 
            {
            new Choice("Q1.1","two legs"),
            new Choice("Q1.2", "three legs"),
            new Choice("Q1.3", "four legs")
            };
        _questions.Add(new Question("How many legs does a dog have?", choices, "Q1.3"));

        Choice[] choices2 =
            {
            new Choice("Q1.1","four legs"),
            new Choice("Q1.2", "ten legs"),
            new Choice("Q1.3", "eight legs")
            };
        _questions.Add(new Question("How many legs does a spider have?", choices2, "Q1.3"));
    }

    public static void WriteStatus()
    {
        throw new NotImplementedException();
    }
}