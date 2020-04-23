using System;
using System.Collections.Generic;
using System.Threading;
namespace ProblematicProblem
{

    public class Program
    {
        Random rng = new Random(); // TODO
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling",
            "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            

            Console.Write("Hello, welcome to the random activity generator! " +
                "\nWould you like to generate a random activity? yes/no: ");
            bool cont = bool.Parse(Console.ReadLine());
            var contResponse = Console.ReadLine().ToLower();
            if(Console.ReadLine().ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }
            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age?");
            var userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? " +
                "Sure/No thanks: ");
            bool seeList = bool.Parse(Console.ReadLine().ToLower() = "sure") ? true : false;

            if (seeList)
            {
                foreach(string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we " +
                    "generate one? yes/no: ");
                bool addToList = bool.Parse(Console.ReadLine());
                Console.WriteLine();

                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = bool.Parse(Console.ReadLine());
                    // I'm not sure what to do with this
                    //addToList has been initialized. We need to change value
                    //Once declared, you can't change its type
                }
            }

            while (cont)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                int randomNumber = this.rng.Next(activities.Count);
                // Does "this" serve a purpose in declaring a variable?

                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                   // int randomNumber = this.rng.Next(activities.Count);

                   // string randomActivity = activities[randomNumber];
                }

                Console.Write($"Ah, got it! {userName}, your random activity is: {randomActivity}! " +
                $"Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                _ = bool.Parse(Console.ReadLine());
            }
        }
    }
}

