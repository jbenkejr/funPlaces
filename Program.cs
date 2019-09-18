using System;

namespace FunPlacesToGo
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chilling");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");
            int weekendPlans = int.Parse(Console.ReadLine());

            if (weekendPlans >= 5)
            {
                Console.WriteLine("Invalid option!");
                return;
            }


            Console.WriteLine("How many people are you bringing: ");
            int numberOfpeople = int.Parse(Console.ReadLine());

            if (weekendPlans == 1)
            {
                if (numberOfpeople == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go stock car racing and travel by foot!");
                }
                else if (numberOfpeople <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go stock car racing and travel in a sedan!");
                }
                else if (numberOfpeople <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go stock car racing and travel in a Volkswagen bus");
                }
                else
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go stock car racing and travel in an airplane");
                }
            }

            else if (weekendPlans == 2)
            {
                if (numberOfpeople == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel by foot!");
                }
                else if (numberOfpeople <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in a sedan!");
                }
                else if (numberOfpeople <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in a Volkswagen bus");
                }
                else
                {
                    Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in an airplane");
                }
            }

            else if (weekendPlans == 3)
            {
                if (numberOfpeople == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel by foot!");
                }
                else if (numberOfpeople <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a sedan!");
                }
                else if (numberOfpeople <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a Volkswagen bus");
                }
                else
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in an airplane");
                }

            }

            else if (weekendPlans == 4)
            {
                if (numberOfpeople == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel by foot!");
                }
                else if (numberOfpeople <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a sedan!");
                }
                else if (numberOfpeople <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a Volkswagen bus");
                }
                else
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in an airplane");
                }
            }

            else
            {

            }

            Console.WriteLine("Goodbye!");

        }
    }
}