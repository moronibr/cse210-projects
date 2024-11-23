using System;
using System.Collections.Generic;
using System.IO;


public class Program
{

    public static void Main(string[] args)
    {
    
        List<(string question, string answer)> answersList = new List<(string, string)>();

        string answer = " ";
        while (answer != "5")
        {
            Console.WriteLine("Please select one of the following choices: \n");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

              switch (answer)
            {
                case "1":
                    Write(answersList);
                    break;

                case "2":
                    Display(answersList);
                    break;

                case "3":
                    Load(answersList);
                    break;

                case "4":
                    Save(answersList);
                    break;

                case "5":
                    Console.WriteLine("Quitting...");
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

    }

    static void Write(List<(string question, string answer)> answersList)
    {
        

        List<string> questions = new List<string>();
        questions.Add("If I had one thing I could have done today, what would it be?");
        questions.Add("What kind of skill would I like to have?");
        questions.Add("What am I anxious about today?");
        questions.Add("What can I do to feel closer from The Lord?");
        questions.Add("What kind of spiritual work do I have to do to have more spiritual experiences?");

        Random rand = new Random();
        int index = rand.Next(0, questions.Count);
        string question = questions[index];
        Console.WriteLine(question);
        Console.Write("> ");
        string answer = Console.ReadLine();
        Console.WriteLine("You answered: " + answer);

        answersList.Add((question, answer));

      
    }

    static void Display(List<(string question, string answer)> answersList)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        foreach (var tuple in answersList)
        {
            Console.WriteLine($"Date: {dateText} Question: {tuple.question}");
            Console.WriteLine($"Answer: {tuple.answer}");
            Console.WriteLine();
        }
    }
    
    static void Load(List<(string question, string answer)> answersList)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        Console.WriteLine("Loading from file...");

        using (StreamReader inputFile = new StreamReader(filename))
        {
            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
    }

    static void Save(List<(string question, string answer)> answersList)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {   

            Console.WriteLine("Saving to file...");

            foreach (var tuple in answersList)
            {
                outputFile.WriteLine($"Date: {dateText} Question: {tuple.question}");
                outputFile.WriteLine($"Answer: {tuple.answer}");
                outputFile.WriteLine();
            }

            Console.WriteLine("Done!");
        }

    }
}

 
