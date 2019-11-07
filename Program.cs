using System;

namespace LabEight
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {
                "Joey", //names {0}
                "Michael", //names {1}
                "Andrew" // names {2}
            };
            string[] food = {
                "chicken", //food {0}
                "pizza", //food {1}
                "steak" //food {2}
            };
            string[] homeTown = {
                "Temperance", //homeTown {0} 
                "Toledo", //homeTown {1}
                "Detroit" //homeTown {2}
            };

            string hometown = "hometown";
            string favFood = "food";
             

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (0, 1, 2)");

            while (true)
            {
                Console.Write("Enter student number: ");
                Console.WriteLine();
                try
                {
                    string userInput = Console.ReadLine();
                    int input = int.Parse(userInput);
                    Console.WriteLine($"You selected, {names[input]}. What would you like to know more about them? (hometown, food.)");

                    string decision = Console.ReadLine();

                    if (decision == hometown)
                    {
                        Console.WriteLine($"Their hometown is {homeTown[int.Parse(userInput)]}");
                    }
                    else if (decision == favFood)
                    {
                        Console.WriteLine($"Their favorite food is {food[int.Parse(userInput)]}");
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist. Please try again. (0, 1, 2)");
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("You've entered a letter. Please try again. (0, 1, 2.)");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered an overflow. Please try again. (0, 1, 2.)");
                    Console.WriteLine();
                }
                catch (ArgumentNullException)
                { 
                    Console.WriteLine("Can not enter a null answer, Please try again. (0, 1, 2.");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                    Console.WriteLine();
                }
            }
        }
    }
}
