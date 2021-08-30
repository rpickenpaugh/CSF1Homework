using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            long powerTwoFifty = 2;
            for (int i = 1; i <= 50; i++)
            {
                powerTwoFifty= powerTwoFifty * 2;
                Console.WriteLine(powerTwoFifty);
            }

        }
    }
}
