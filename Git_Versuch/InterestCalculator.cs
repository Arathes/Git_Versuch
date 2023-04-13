using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class InterestCalculator
{
    static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the annual interest rate (%): ");
        double interestRate = double.Parse(Console.ReadLine());

        Console.Write("Enter the number of years: ");
        int years = int.Parse(Console.ReadLine());

        double interest = CalculateInterest(principal, interestRate, years);
        double totalAmount = principal + interest;

        Console.WriteLine("Interest: " + interest);
        Console.WriteLine("Total amount: " + totalAmount);
    }

    static double CalculateInterest(double principal, double interestRate, int years)
    {
        double rate = interestRate / 100;
        double interest = principal * rate * years;
        return interest;
    }
}

