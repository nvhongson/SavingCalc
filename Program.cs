using System;

namespace SavingGoalsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║   Saving Goals Calculator   ║");
            Console.WriteLine("╚════════════════════════════╝\n");

            Console.Write("Enter Monthly Expenses: ");
            double monthlyExpenses = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Savings Goal: ");
            double savingsGoal = Convert.ToDouble(Console.ReadLine());

            if (income <= 0 || monthlyExpenses <= 0 || savingsGoal <= 0)
            {
                Console.WriteLine("\nIncome, Monthly Expenses, and Savings Goal must be greater than zero.");
                return;
            }

            double netIncome = income - monthlyExpenses;
            double monthsToReachGoal = savingsGoal / netIncome;

            Console.WriteLine("\n╔══════════════════════════════════════╗");
            if (monthsToReachGoal <= 0)
            {
                Console.WriteLine("║ You are already saving more than your  ║");
                Console.WriteLine("║ goal each month!                       ║");
            }
            else
            {
                Console.WriteLine($"║ It will take approximately {Math.Round(monthsToReachGoal, 2)} months to reach your goal. ║");
            }
            Console.WriteLine("╚══════════════════════════════════════╝");
        }
    }
}
