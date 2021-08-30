using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            //Declare vars
            decimal celUserInput, fahUserInput, celConsOutput, fahConsOutput;
            string menuUserInput;
            bool repeat = true;

            do
            {
                Console.WriteLine("Would you like to convert from Celsius or Fahrenheit?:\n1) Celsius\n2) Fahrenheit");
                menuUserInput = Console.ReadLine().ToUpper();

                switch (menuUserInput)
                {
                    case "1":
                    case "C":
                    case "CELSIUS":
                        Console.WriteLine("Enter a Celsius temperature to convert to Fahrenheit:");
                        celUserInput = Convert.ToDecimal(Console.ReadLine());
                        celConsOutput = ((celUserInput * 9) / 5) + 32;
                        Console.WriteLine($"\n{celUserInput:n2}°C is\n\n{celConsOutput:n2}°F\n");

                        break;
                    case "2":
                    case "F":
                    case "FAHRENHEIT":
                        Console.WriteLine("Enter a Fahrenheit temperature to convert to Celsius:\n");
                        fahUserInput = Convert.ToDecimal(Console.ReadLine());
                        fahConsOutput = (fahUserInput - 32) * 5 / 9;
                        Console.WriteLine($"\n{fahUserInput:n2}°F is\n\n{fahConsOutput:n2}°C\n");

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Response\n");
                        break;
                }//end switch
                Console.WriteLine("Do you have another conversion request?\nY) Yes\nN) No\n");
                string resetMenu = Console.ReadLine().ToUpper();
                switch (resetMenu)
                {
                    case "Y":
                    case "YES":
                        Console.Clear();
                        Console.WriteLine($"You typed {resetMenu}\n");
                        break;
                    case "N":
                    case "NO":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Response.");
                        repeat = false;
                        break;
                }
            } while (repeat);
            Console.WriteLine("\nEnding program.");

            ////Celsius to Fahrenheit script
            //Console.WriteLine("Enter a Celsius temperature to convert to Fahrenheit:\n");
            //celUserInput = Convert.ToDecimal(Console.ReadLine());
            //celConsOutput = ((celUserInput * 9) / 5) + 32;
            //Console.WriteLine($"{celConsOutput:n2}");

            ////Fahrenheit to Celsius script
            //Console.WriteLine("Enter a Fahrenheit temperature to convert to Celsius:\n");
            //fahUserInput = Convert.ToDecimal(Console.ReadLine());
            //fahConsOutput = (fahUserInput - 32) * 5 / 9;
            //Console.WriteLine($"{fahConsOutput:n2}");

        }//end main
    }//end class
}//end namespace
