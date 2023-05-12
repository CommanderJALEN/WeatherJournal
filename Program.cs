using System;

namespace WeatherJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            string?[] dates = new string[10];
            double[] temperatures = new double[10];
            string?[] conditions = new string[10];
            int count = 0;

            while (true)
            {
                Console.WriteLine("WEATHER JOURNAL MAIN MENU:");
                Console.WriteLine("1) Input journal entry");
                Console.WriteLine("2) Check entries");
                Console.WriteLine("3) Exit program");

                Console.Write("Please input your choice (1-3): ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter weather information:");

                        Console.Write("Date (DD-MM-YYYY): ");
                        string? date = Console.ReadLine();

                        Console.Write("Temperature (in degrees Celsius): ");
                        double temperature;
                        while (!double.TryParse(Console.ReadLine(), out temperature))
                        {
                            Console.Write("Invalid temperature. Please enter a valid number: ");
                        }

                        Console.Write("Weather condition: ");
                        string? condition = Console.ReadLine();

                        dates[count] = date;
                        temperatures[count] = temperature;
                        conditions[count] = condition;
                        count++;

                        Console.WriteLine("Weather information recorded.");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Weather journal entries:");
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"Date: {dates[i]}, Temperature: {temperatures[i]}C, Condition: {conditions[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option (1-3).");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
