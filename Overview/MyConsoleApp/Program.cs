using System;

class HowManyDaysApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to the 'How Many Days?' Console Application!");

        while (true)
        {
            Console.Write("\nEnter a date (yyyy-MM-dd) or type 'exit' to quit: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Try to parse the input date
            if (DateTime.TryParse(input, out DateTime userDate))
            {
                DateTime today = DateTime.Today;
                int dayDifference = (userDate - today).Days;

                if (dayDifference == 0)
                {
                    Console.WriteLine("That date is today!");
                }
                else if (dayDifference > 0)
                {
                    Console.WriteLine($"That date is in the future. {dayDifference} day(s) remain.");
                }
                else
                {
                    Console.WriteLine($"That date is in the past. {Math.Abs(dayDifference)} day(s) have passed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use 'yyyy-MM-dd' (e.g., 2025-07-09).");
            }
        }
    }
}
