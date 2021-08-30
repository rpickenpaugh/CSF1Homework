using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            //Declare
            string noun, adjective, verb, location;
            //Request input
            Console.WriteLine("Mad-Lib\nGimme a noun:");
            noun = Console.ReadLine();
            Console.WriteLine("Gimme an adjective:");
            adjective = Console.ReadLine();
            Console.WriteLine("Gimme a past tense verb:");
            verb = Console.ReadLine();
            Console.WriteLine("Gimme a common noun location:");
            location = Console.ReadLine();
            Console.WriteLine($"The {adjective} {noun} {verb} to the {location}.");
        }
    }
}
