using System;
using System.Collections.Generic;
using System.Linq;

public class LongestDuration
{
    public static void ShowLongestDuration(List<Category> categories)
    {
        // Flatten the list of destinations from all categories into a single list.
        var destinations = categories.SelectMany(c => c.Destinations);

        // Order the destinations by duration in descending order and get the first one (i.e., the longest).
        var longestDuration = destinations.OrderByDescending(d => d.GetDurationInMinutes()).FirstOrDefault();

        // Output the destination with the longest duration to the console.
        Console.WriteLine("Destination with the longest duration:");
        if (longestDuration != null)
        {
            // Display the name and duration of the destination with the longest duration.
            Console.WriteLine($"{longestDuration.Name} ({longestDuration.GetDurationInMinutes()} minutes)");
        }
    }
}
