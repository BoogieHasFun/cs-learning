// this version is made by chatgpt and will made the default for now. if you want to build the old version then remove this file and rename "main.cs_disabled" to "program.cs". 

using System.Diagnostics;
using System;
using System.Reflection;

namespace cs_learning
{
    class cslearning
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operation;

            Console.WriteLine("Hello! Enter Num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /): ");
            operation = Console.ReadLine();

            double solution = DoMath(num1, operation, num2);
            Console.WriteLine("The result of " + num1 + " " + operation + " " + num2 + " is: " + solution);

                       
                 Console.WriteLine(";)");
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.R)
            {
                var url = "spotify:";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            
            }
        }

        static double DoMath(int num1, string operation, int num2)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return (double)num1 / num2; // convert to double so we don't do integer division.
                default:
                    throw new ArgumentException("Unknown operation: " + operation);
            }
        }
    }
}
