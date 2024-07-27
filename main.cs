using System;

class Program
{
    const double CentimetersPerInch = 2.54;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a measurement in inches:");

        string input = Console.ReadLine();
        double inches = Convert.ToDouble(input);


        double centimeters = inches * CentimetersPerInch;

        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");

    }
}