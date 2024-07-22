using System;
using System.Collections.Generic;
using System.Linq;

public class FilterDestinations
{
    public static void ShowFilteredDestinations(List<Category> categories)
    {
        // Flatten the list of destinations from all categories into a single list.
        var destinations = categories.SelectMany(c => c.Destinations);

        // Filter destinations to get only those with duration less than 100 minutes.
        var filteredDestinations = destinations.Where(d => d.GetDurationInMinutes() < 100).ToList();

        // Output the filtered destinations to the console.
        Console.WriteLine("Destinations with duration less than 100 minutes:");
        foreach (var destination in filteredDestinations)
        {
            // Display the name of each filtered destination.
            Console.WriteLine(destination.Name);
        }
    }
}
