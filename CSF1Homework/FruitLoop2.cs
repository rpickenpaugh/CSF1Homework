using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[6];
            fruits[0] = "apple";
            fruits[1] = "orange";
            fruits[2] = "banana";
            fruits[3] = "pomegranate";
            fruits[4] = "papaya";
            fruits[5] = "pear";

            string period = ".";
            int periodCtr = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{fruits[i]}");
                periodCtr++;
                Console.WriteLine(period);
                //unfinished

            }//end for
        }//end main
    }//end class
}//end namespace
