# Magic Land Explorer

## Overview

Welcome to the Magic Land Explorer! This console application simulates exploring various destinations within Magic Land. Users can interactively explore different categories of attractions, such as rides, shows, and dining options, and view details using LINQ queries and delegates. The application reads data from an external JSON file, making it easy to update and manage the available destinations.

## Project Components

**Program.cs**

- Main entry point of the application.
- Initializes the interactive menu for user interactions.
- Reads and parses the JSON data file.
- Provides options to execute different LINQ query tasks.

**Destination.cs**

- Represents individual destinations within Magic Land.
- Properties include `Name`, `Type`, `Location`, `Duration` (as a string), and `Description`.
- Includes a method to parse the duration into minutes.

**Category.cs**

- Represents a category of destinations, such as rides, shows, or dining options.
- Contains `CategoryName` and a list of `Destination` objects.

**Tasks/FilterDestinations.cs**

- Contains logic to display destinations with a duration of less than 100 minutes.

**Tasks/LongestDuration.cs**

- Contains logic to find and display the destination with the longest duration.

**Tasks/SortByName.cs**

- Contains logic to sort and display destinations alphabetically by name.

**Tasks/Top3Duration.cs**

- Contains logic to find and display the top three destinations with the longest durations.

**Tasks/SharedLocation.cs**

- Contains logic to find and display all categories that have "Fantasyland" as a shared location.

## Features

- **Destination Filtering**: Show destinations with a duration of less than 100 minutes.
- **Longest Duration**: Find and display the destination with the longest duration.
- **Sorting by Name**: Display destinations sorted alphabetically.
- **Top 3 Longest Durations**: Show the top three destinations with the longest durations.
- **Shared Location**: Find and display categories that have "Fantasyland" as a shared location.

## Usage

1. Run the application.
2. Follow the on-screen prompts to:
   - Filter destinations based on duration.
   - Find the destination with the longest duration.
   - Sort destinations by name.
   - Display the top three destinations with the longest durations.
   - Find and display categories with "Fantasyland" as a shared location.
3. Enter the corresponding number to execute the desired task.

## Conclusion

Magic Land Explorer provides an engaging way to explore various attractions in Magic Land using a console interface. By utilizing LINQ queries and delegates, the application allows users to interact with and analyze destination data efficiently. Enjoy your exploration of Magic Land with this dynamic and interactive tool!
