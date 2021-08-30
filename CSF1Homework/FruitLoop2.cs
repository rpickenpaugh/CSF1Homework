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
            string[] fruits = {"apple", "orange", "banana", "pomegranate", "papaya", "pear"};

            for (int i = 0; i < fruits.Length; i++)
            {
                string period = new string('.', i + 1);
                Console.WriteLine($"{fruits[i]}\n{period}");
            }//end for
        }//end main
    }//end class
}//end namespace
