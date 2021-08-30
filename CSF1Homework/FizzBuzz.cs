using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            //Capture user input
            Console.WriteLine("Enter a whole number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userInput; i++)
            {
                //Display
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }//end main
    }
}
