using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            //Declaring fruits array
            string[] fruits = new string[6];
            fruits[0] = "apple";
            fruits[1] = "orange";
            fruits[2] = "banana";
            fruits[3] = "pomegranate";
            fruits[4] = "papaya";
            fruits[5] = "pear";

            //Looping the fruits array
            for (int fruitPosition = 0; fruitPosition < fruits.Length; fruitPosition++)
            {
                Console.WriteLine(fruits[fruitPosition]);
            }
        }
    }
}
