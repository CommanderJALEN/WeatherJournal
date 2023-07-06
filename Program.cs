using System;
using System.Collections.Generic;

namespace WeatherJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<WeatherEntry?> weatherEntries = new List<WeatherEntry?>();

            while (true)
            {
                Console.WriteLine("WEATHER JOURNAL MAIN MENU:");
                Console.WriteLine("1) Input journal entry");
                Console.WriteLine("2) Check entries");
                Console.WriteLine("0) Exit program");

                Console.Write("Please input your choice (1-2), Enter 0 if you want to exit: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter weather information:");
                    
                        string? date = GetValidDate();
                        double temperature = GetValidTemperature();
                    
                        Console.Write("Weather condition: ");
                        string? condition = Console.ReadLine();
                    
                        WeatherEntry entry = new WeatherEntry
                        {
                            Date = date,
                            Temperature = temperature,
                            Condition = condition
                        };
                    
                        weatherEntries.Add(entry);
                    
                        Console.WriteLine("Weather information recorded.");
                        Console.WriteLine();
                        break;

                    case "2":
                        DisplayWeatherEntries(weatherEntries);
                        break;

                    case "0":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option (1-2), Enter 0 to exit.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static string? GetValidDate()
        {
            while (true)
            {
                Console.Write("Date (DD-MM-YYYY): ");
                string? date = Console.ReadLine();

                if (DateTime.TryParseExact(date, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date (DD-MM-YYYY).");
                }
            }
        }

        static double GetValidTemperature()
        {
            while (true)
            {
                Console.Write("Temperature (in degrees Celsius): ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    return temperature;
                }
                else
                {
                    Console.Write("Invalid temperature. Please enter a valid number: ");
                }
            }
        }

        static void DisplayWeatherEntries(List<WeatherEntry?> weatherEntries)
        {
            Console.WriteLine("Weather journal entries:");
            foreach (WeatherEntry? entry in weatherEntries)
            {
            Console.WriteLine($"Date: {entry.Date}, Temperature: {entry.Temperature}C, Condition: {entry.Condition}");
            }
            Console.WriteLine();
        }
    }
}