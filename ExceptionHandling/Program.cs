using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueLoop = true;
            do
            {
                try
                {
                    Console.Write("Enter a numerator: ");
                    var numerator = int.Parse(Console.ReadLine());
                    Console.Write("Enter a denominator: ");
                    var denominator = int.Parse(Console.ReadLine());
                    var result = numerator / denominator;
                    Console.WriteLine($"\nResult : {result}");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\n{formatException.Message}");
                    Console.WriteLine("You must enter two integers. Please try again.\n");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine($"\n{divideByZeroException.Message}");
                    Console.WriteLine("Zero is an invalid denominator. Please try again.\n");
                }
            }
            while (continueLoop == true);
        }
    }
}
