using System.Xml.Serialization;

namespace OPF_Test;

public class Question
{
    public Question(string text, Choice[] choices, string correctAnswerCode)
    {
        Text = text.Trim();
        Choices = choices.ToList();
        CorrectAnswerCode = correctAnswerCode;
        EnsureValid();
    }

    public string Text { get; }
    public List<Choice> Choices { get; }
    public string CorrectAnswerCode { get; }

    private void EnsureValid()
    {
        if (Choices is null)
        {
            throw new Exception("Choices must not be null");
        }

        if (!Choices.Any())
        {
            throw new Exception("Choices must not be empty");
        }

        if (string.IsNullOrWhiteSpace(CorrectAnswerCode))
        {
            throw new Exception("Choices must not be null or whitespace");
        }

        if (string.IsNullOrWhiteSpace(Text))
        {
            throw new Exception("Text must not be null or whitespace");
        }
    }
}