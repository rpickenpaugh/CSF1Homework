using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            //Capture input
            Console.WriteLine("Enter a number to be Fibonacci'd:");
            int userInput = Convert.ToInt32( Console.ReadLine());

            int fiboVar = 1;
            int fiboVar2=1;
            //Executable
            while (fiboVar <= userInput)
            {
                Console.WriteLine(fiboVar);
                fiboVar = (fiboVar + fiboVar2);
                fiboVar2 = (fiboVar - fiboVar2);
            }
        }//end main
    }
}
