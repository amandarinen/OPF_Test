using OPF_Test;

QuizUtils.SeedQuestions();

Console.WriteLine("Welcome to QuizzBattle!");

Console.WriteLine("Quiz Battle rules: ");
Console.WriteLine("Answer questions correct to earn points");

while(!QuizUtils.IsCompleted())
{
    QuizUtils.DisplayQuestion();
    int answer = QuizUtils.GetAnswer();

    QuizUtils.CheckAnswer(answer);

    QuizUtils.WriteStatus();
}

Console.WriteLine("Thanks for playing!");
