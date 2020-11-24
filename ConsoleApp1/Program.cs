using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a radius: ");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            radius = Math.Pow(radius, 2) * Math.PI;
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            Console.WriteLine("The area fo a circle of radius " + input + " is: " + radius + '\n' + 
                "The circumference is: " + circumference + '\n' + "The diameter is: " + diameter);
            Console.WriteLine("Enter miles per gallon: ");
            string miles = Console.ReadLine();
            double milesPerGallon = double.Parse(miles);
            milesPerGallon = circumference / milesPerGallon;
            Console.WriteLine("Used " + milesPerGallon + " gallons.");
        }

    }

}
