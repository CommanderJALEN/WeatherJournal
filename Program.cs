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
                Console.WriteLine("0) Exit program");

                Console.Write("Please input your choice (1-2), Enter 0 if you want to exit: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter weather information:");

                        string? date;
                        while (true)
                        {
                            Console.Write("Date(DD-MM-YYYY):");
                            date = Console.ReadLine();

                            if (DateTime.TryParseExact(date, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format. Please enter a valid date (DD-MM-YYYY).");
                            }
                        }

                        double temperature;
                        while (true)
                        {
                            Console.Write("temperature (in degrees Celsius):");
                            if (double.TryParse(Console.ReadLine(), out temperature))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Invalid temperature. Please enter a valid number:");
                            }
                        }
                        Console.Write("Weather condition: ");
                        string? condition = Console.ReadLine();

                        dates[count] = date;
                        temperatures[count] = temperature;
                        conditions[count] = condition; count++;

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
    }
}