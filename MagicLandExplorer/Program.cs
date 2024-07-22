using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        string filepath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
        string json = File.ReadAllText(filepath);
        List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);


        // Define an array of actions (delegates) corresponding to different tasks.
        Action<List<Category>>[] actions =
        {
            FilterDestinations.ShowFilteredDestinations,
            LongestDuration.ShowLongestDuration,
            SortByName.ShowSortedDestinations,
            Top3Duration.ShowTop3Destinations,
            SharedLocation.ShowSharedLocationCategories
        };

        // Start an infinite loop to interactively handle user inputs.
        while (true)
        {
            // Display the menu options to the user.
            Console.WriteLine("\nMagic Land Explorer:");
            Console.WriteLine("1 - Show filtered destinations");
            Console.WriteLine("2 - Show longest duration");
            Console.WriteLine("3 - Sort destinations by name");
            Console.WriteLine("4 - Show top 3 longest durations");
            Console.WriteLine("5 - Show categories with 'Fantasyland' as a shared location");
            Console.WriteLine("0 - Exit");

            var input = Console.ReadLine();

            // Try to parse the user input as an integer.
            if (int.TryParse(input, out int choice))
            {
                // If the user chooses to exit, break the loop.
                if (choice == 0) break;

                // If the choice is valid, invoke the corresponding action.
                if (choice > 0 && choice <= actions.Length)
                {
                    actions[choice - 1](categories);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 5.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
