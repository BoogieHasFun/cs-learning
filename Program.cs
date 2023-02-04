// by boogie
using System.Diagnostics;
using System;
using System.Reflection;

namespace cs_learning;

class Program }
class cslearning
{
    static void Main(string[] args)
    {
       int num1;
       int num2;
       string thing;
        Console.WriteLine("henlo! click any button to coutine.");
             Console.WriteLine("reminder: entering letters (string values) as the numbers will crash the program.");
                Console.WriteLine("by boogie!");
            Console.ReadKey(true);
// num1 value
    Console.WriteLine();
        Console.WriteLine("Enter Num 1");
           num1 = (Convert.ToInt32(Console.ReadLine()));
            Debug.WriteLine(Convert.ToString(num1),"num1 value");
// num2 value  
    Console.WriteLine();            
        Console.WriteLine("Enter Num 2");
           num2 = (Convert.ToInt32(Console.ReadLine()));
// thing value   
    Console.WriteLine();      
            Debug.WriteLine(Convert.ToString(num2),"num2 value");
        Console.WriteLine("enter if you are going to divde (/), multiply (*), add (+), or subtract (-)");
            thing = Console.ReadLine();
                Debug.WriteLine(thing,"operation value");

// math!
        var solution = DoMath(num1, thing, num2);
        Console.Write("and the answer to ");
            Console.Write("{0} {1} {2}", num1, thing, num2);
        Console.Write(" is ");
        Console.Write(solution);
            Debug.Write(solution);  
          // prevent console from closing when finsished 
            Console.WriteLine();
               Console.WriteLine("multiplying big numbers can sometimes give you negative numbers, sorry about that.");
                var info = Console.ReadKey(true);
            Console.WriteLine();
                Console.WriteLine("right now you have to maunally restart the program, i couldn't find a simple solution to restart the program so you will have to deal with it.");
                       
                       do {
                     Process.Start("explorer", "https://rroll.to/iHgSMg");
                    break;  
      } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

      // math

        static double DoMath(int num1, string thing, int num2)
       	{
    		switch(thing)
 		    {
    			case "+": return num1 + num2;
    			case "-": return num1 - num2;
    			case "*": return num1 * num2;
    			case "/": return num1 / (double)num2; // convert to double so we don't do integer division.
			    default: throw new ArgumentException("Unknown mathpiece: " + thing);
		    }
	    }
    }
}
// it's unreadable
// sorry.

