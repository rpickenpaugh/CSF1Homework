using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            string listOfScores="";
            string userInputString;
            int userInput;

            Console.WriteLine("Enter test scores:");
            do
            {
                userInputString = Console.ReadLine();
                listOfScores += userInputString + "\n ";
                userInput = Convert.ToInt32(userInputString);
            } while (userInput >= 0);

            Console.WriteLine("\nList of Scores:\n" + listOfScores);
            //Extra because why not.
            //Nevermind// string[] scores = new string[]
        }
    }
}
