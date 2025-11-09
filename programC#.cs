using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitDictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary where fruit names are keys and colors are values (as a list)
            Dictionary<string, List<string>> fruitColors = new Dictionary<string, List<string>>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Fruit Dictionary Menu ---");
                Console.WriteLine("a. Populate Dictionary");
                Console.WriteLine("b. Display Contents");
                Console.WriteLine("c. Remove Key");
                Console.WriteLine("d. Add New Key-Value");
                Console.WriteLine("e. Append Value to Existing Key");
                Console.WriteLine("f. Sort Keys");
                Console.WriteLine("q. Quit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine().Trim().ToLower();

                switch (choice)
                {
                    case "a":
                        // Populate dictionary with sample fruits and colors
                        fruitColors["Apple"] = new List<string> { "Red", "Green" };
                        fruitColors["Banana"] = new List<string> { "Yellow" };
                        fruitColors["Orange"] = new List<string> { "Orange" };
                        fruitColors["Grapes"] = new List<string> { "Purple", "Green" };
                        fruitColors["Strawberry"] = new List<string> { "Red" };
                        Console.WriteLine("Dictionary populated with sample fruits.");
                        break;

                    case "b":
                        // Display dictionary contents
                        if (fruitColors.Count == 0)
                        {
                            Console.WriteLine("Dictionary is empty. Please populate it first.");
                        }
                        else
                        {
                            Console.WriteLine("\nCurrent Fruit Dictionary:");
                            foreach (KeyValuePair<string, List<string>> kvp in fruitColors)
                            {
                                Console.WriteLine($"- {kvp.Key} ({kvp.Value.Count} colors): {string.Join(", ", kvp.Value)}");
                            }
                        }
                        break;

                    case "c":
                        // Remove a specific fruit by key
                        Console.Write("Enter the fruit name to remove: ");
                        string removeKey = Console.ReadLine().Trim();
                        if (fruitColors.Remove(removeKey))
                            Console.WriteLine($"'{removeKey}' removed successfully.");
                        else
                            Console.WriteLine($"'{removeKey}' not found in the dictionary.");
                        break;

                    case "d":
                        // Add a new fruit and its colors
                        Console.Write("Enter new fruit name: ");
                        string newKey = Console.ReadLine().Trim();

                        Console.Write("Enter colors (comma-separated): ");
                        string newValInput = Console.ReadLine();
                        List<string> newVal = newValInput.Split(',')
                                                         .Select(s => s.Trim())
                                                         .Where(s => !string.IsNullOrEmpty(s))
                                                         .ToList();

                        fruitColors[newKey] = newVal;
                        Console.WriteLine($"Added '{newKey}' with colors: {string.Join(", ", newVal)}");
                        break;

                    case "e":
                        // Append a new color to an existing fruit
                        Console.Write("Enter existing fruit name: ");
                        string existKey = Console.ReadLine().Trim();

                        if (fruitColors.ContainsKey(existKey))
                        {
                            Console.Write("Enter new color to add: ");
                            string appendVal = Console.ReadLine().Trim();

                            if (!fruitColors[existKey].Contains(appendVal, StringComparer.OrdinalIgnoreCase))
                            {
                                fruitColors[existKey].Add(appendVal);
                                Console.WriteLine($"Added color '{appendVal}' to '{existKey}'.");
                            }
                            else
                            {
                                Console.WriteLine($"'{existKey}' already has color '{appendVal}'.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"'{existKey}' not found in the dictionary.");
                        }
                        break;

                    case "f":
                        // Sort keys alphabetically and display
                        if (fruitColors.Count == 0)
                        {
                            Console.WriteLine("Nothing to sort — dictionary is empty.");
                        }
                        else
                        {
                            var sortedKeys = fruitColors.Keys.OrderBy(k => k).ToList();
                            Console.WriteLine("\nSorted Fruit Keys:");
                            foreach (string key in sortedKeys)
                            {
                                Console.WriteLine($"- {key}");
                            }
                        }
                        break;

                    case "q":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (a–f or q).");
                        break;
                }
            }
        }
    }
}