using System;
using System.Linq;  // Add this line

class Program
{
    static void Main()
    {
        string[] salespeopleNames = { "Danielle", "Edward", "Francis" };
        char[] salespeopleInitials = { 'D', 'E', 'F' };
        decimal[] sales = new decimal[3];

        while (true)
        {
            Console.WriteLine("Enter salesperson initial (D, E, F) or Z to exit:");
            char initial = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Z')
            {
                break;
            }

            int index = Array.IndexOf(salespeopleInitials, initial);
            if (index == -1)
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again");
                continue;
            }

            Console.WriteLine($"Enter sale amount for {salespeopleNames[index]}:");
            decimal sale = decimal.Parse(Console.ReadLine());
            sales[index] += sale;
        }

        decimal grandTotal = 0;
        foreach (var sale in sales)
        {
            grandTotal += sale;
        }
        Console.WriteLine($"Grand Total: ${grandTotal:0,0.00}");

        int highestSalespersonIndex = Array.IndexOf(sales, sales.Max());  // Use the Max method from Linq
        Console.WriteLine($"Highest Sale: {salespeopleInitials[highestSalespersonIndex]}");
    }
}
