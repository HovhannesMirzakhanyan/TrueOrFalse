using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

       
            string[] questions = { "Bla bla", "bli bli" };
            bool[] answers = { true, false };
            bool[] responses = new bool[2];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("The is Length error!");
            }
            int askingIndex = 0;
            foreach (string item in questions)
            {
                Console.WriteLine(item);
                Console.WriteLine("True or false?");
                string input = Console.ReadLine();
                bool isBool;
                bool inputBool;
                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false' ");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                   
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            foreach (bool ans in responses)
            {
                Console.WriteLine(ans);
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool ans in answers)
            {
                bool resp = responses[scoringIndex];
                Console.WriteLine($"1. Input: {resp} | Answer: {ans}");
                if (resp == ans)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of 2 correct!");
            Console.ReadLine();

        }
    }
}
