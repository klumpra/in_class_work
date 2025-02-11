﻿/* illustrates using dictionaries.
 * reads a file of gradeable items and corresponding scores
 */
using static System.Console;
namespace PureElationWithDictionaries20250205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> grades = new Dictionary<string, double>();
            Write("Enter the path to the file: ");
            string path = ReadLine();
            string line;
            string[] parts;
            string itemName;
            double score;
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine().Trim();
                            if (line.Length == 0)
                            {
                                continue;
                            }
                            parts = line.Split("\t");
                            itemName = parts[0];
                            score = double.Parse(parts[1]);
                            if (grades.ContainsKey(itemName))
                            {
                                grades[itemName] = grades[itemName] + score;
                            }
                            else
                            {
                                grades.Add(itemName, score);
                            }
                        }
                    }
                    WriteLine("Here are the grades: ");
                    foreach (var grade in grades)
                    {
                        WriteLine($"{grade.Key,-20}{grade.Value,10:F2}");
                    }
                    Write("Enter an item to print the score for (or quit) ");
                    itemName = ReadLine().Trim();
                    while (itemName != "quit")
                    {
                        if (grades.ContainsKey(itemName))
                        {
                            WriteLine($"The score on {itemName} was {grades[itemName]}.");
                        } else
                        {
                            WriteLine("The item does not exist.");
                        }
                        Write("Enter the name of another item or quit: ");
                        itemName = ReadLine().Trim();
                    }
                } else
                {
                    WriteLine("That file doesn't exist.");
                }
                WriteLine("Thank you for using the program.");
            }
            catch (Exception ex)
            {
                WriteLine("Couldn't read the file. Exiting.");
                return;
            }
        }
    }
}
