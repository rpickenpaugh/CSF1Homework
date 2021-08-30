using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            //Vars
            decimal userBal, userIntRate, userYears;
            //Executable
            Console.WriteLine("INTEREST CALCULATOR\nEnter the beginning balance:");
            userBal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the interest rate percentage:");
            userIntRate = Convert.ToDecimal(Console.ReadLine()) / 100;
            Console.WriteLine("Enter the number of years:");
            userYears = Convert.ToDecimal(Console.ReadLine());
            //Years are the loop condition
            for (int i = 0; i < userYears; i++)
            {
                userBal = (userBal + (userBal * userIntRate));
            }
            Console.WriteLine($"The amount you will have in {userYears} years is {userBal:c}.");

        }//end main
    }
}
