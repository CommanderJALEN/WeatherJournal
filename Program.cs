using System;
using System.Collections.Generic;

namespace WeatherJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string?> dates = new List<string?>();
            List<double> temperatures = new List<double>();
            List<string?> conditions = new List<string?>();

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

                        dates.Add(date);
                        temperatures.Add(temperature);
                        conditions.Add(condition);

                        Console.WriteLine("Weather information recorded.");
                        Console.WriteLine();
                        break;

                    case "2":
                        DisplayWeatherEntries(dates, temperatures, conditions);
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

        static void DisplayWeatherEntries(List<string?> dates, List<double> temperatures, List<string?> conditions)
        {
            Console.WriteLine("Weather journal entries:");
            for (int i = 0; i < dates.Count; i++)
            {
                Console.WriteLine($"Date: {dates[i]}, Temperature: {temperatures[i]}C, Condition: {conditions[i]}");
            }
            Console.WriteLine();
        }
    }
}