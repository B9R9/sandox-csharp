using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[2]
      {
                "Le ciel est jaune ?",
                "La mer est bleu ?"
      };
            bool[] solutions = new bool[2]
            {
                false,
                true
            };
            string[] answers = new string[2];
            int score = 0;

            bool replyAsBool;
            bool isBool;


            if (questions.Length != solutions.Length)
                Console.WriteLine("There is a problem. Questions and solutions are not equal!");

            int askingIndex = 0;
            while (askingIndex < questions.Length)
            {
                do
                {
                    Console.WriteLine(questions[askingIndex]);
                    Console.Write("True or False: ");
                    answers[askingIndex] = Console.ReadLine().ToLower();
                    isBool = Boolean.TryParse(answers[askingIndex], out replyAsBool);
                    if (isBool)
                    {
                        if (replyAsBool == solutions[askingIndex])
                            score++;
                        Console.WriteLine($"You got {score} out of {questions.Length} correct!");
                    }
                    else
                        Console.WriteLine("Please answer with 'True' or 'False'.");
                } while (isBool == false);
                askingIndex++;
            }
        }
    }
}