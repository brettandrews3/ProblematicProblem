using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
// ProblematicProblem

public class Program
    {
        Random randomNumber;        
        static bool cont = true;
    static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling",
            "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
        Console.Write("Hello, welcome to the random activity generator! " +
            "\nWould you like to generate a random activity? yes/no: ");
            bool cont = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age?");
            var userAge = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList = bool.Parse(Console.ReadLine());

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
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
                    string addToList = bool.Parse(Console.ReadLine());
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

                int randomNumber = this.randomNumber.Next(activities.Count);
                // Does "this" serve a purpose in declaring a variable?

                string randomActivity = activities[randomNumber]

                if(var userAge > 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    string randomNumber = this.randomNumber.Next(activities.Count);

                    string randomActivity = activities[randomNumber];
                }

                Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! " +
                $"Is this ok or do you want to grab another activity? Keep/Redo: ");
                ConsoleWriteLine();
                bool cont = bool.Parse(Console.ReadLine());
            }
        }
    }


