using System;

class Program
{
    static void Main()
    {
        // Production capacities
        int L1Capacity = 100;
        int L2Capacity = 200;
        int L3Capacity = 300;

        // Weekend capacity reduction
        double WeekendReduction = 0.5;

        // Input variables
        int orderQuantity;
        string productionLine;

        // Getting order quantity from user
        Console.Write("Enter the order quantity: ");
        orderQuantity = int.Parse(Console.ReadLine());

        // Getting production line from user
        Console.Write("Which band do you choose? (L1, L2, L3): ");
        productionLine = Console.ReadLine().ToUpper();

        // Variables to calculate the number of days required
        int days = 0;
        int totalCapacity = 0;
        int dailyCapacity = 0;

        // Set the daily capacity based on the selected production line
        switch (productionLine)
        {
            case "L1":
                dailyCapacity = L1Capacity;
                break;
            case "L2":
                dailyCapacity = L2Capacity;
                break;
            case "L3":
                dailyCapacity = L3Capacity;
                break;
            default:
                Console.WriteLine("Wrong choice..");
                return;
        }

        // Calculate the number of days required
        while (orderQuantity > 0)
        {
            days++;
            if (days % 7 == 5 || days % 7 == 6) // Weekend days (Saturday and Sunday)
            {
                totalCapacity += (int)(dailyCapacity * WeekendReduction);
            }
            else // Weekdays
            {
                totalCapacity += dailyCapacity;
            }

            orderQuantity -= totalCapacity;
            totalCapacity = 0;
        }

        // Output the result
        Console.WriteLine($"An order of {orderQuantity + totalCapacity} pcs can be produced on {productionLine} band in {days} days.");
    }
}

