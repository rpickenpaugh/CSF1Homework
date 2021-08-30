using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            //Declaring vars
            string consoleUsername = "OWEN", consolePassword = "3434",
                userUsername, userPassword;
            byte userUserAttempt = 0, maxUserAttempt = 3,
                userPassAttempt = 0, maxPassAttempt = 3;

            //Begin executable
            //Request username
            Console.WriteLine("User, what is your username?");
            do
            {
                userUsername = Console.ReadLine().ToUpper();
                if (userUsername != consoleUsername)
                {
                    //Count failed username attempts
                    userUserAttempt++;
                    Console.WriteLine($"Incorrect username, {maxUserAttempt - userUserAttempt}" +
                    $" attempts remaining.");
                }
            } while (userUsername != consoleUsername && userUserAttempt != 3);

            if (userUserAttempt == 3)
            {
                Console.WriteLine("\n3 failed attempts, access denied.");
            }//end if (login fail)
            else
            {
                //Request password
                Console.WriteLine("What is your password?");
                do
                {
                    userPassword = Console.ReadLine().ToUpper();
                    if (userPassword != consolePassword)
                    {
                        //Count failed password attempts
                        userPassAttempt++;
                        Console.WriteLine($"Incorrect password, {maxPassAttempt - userPassAttempt}" +
                            $" attempts remaining.");
                    }//end if 
                } while (userPassword != consolePassword && userPassAttempt != 3);
                if (userPassAttempt == 3)
                {
                    Console.WriteLine("\n3 failed attempts, access denied.");
                }
                else
                {
                    Console.Clear();
                    string hunter2 = new string('*', userPassword.Length);
                    Console.WriteLine($"LOGIN SUCCESSFUL!\nWelcome, {userUsername}!\n" +
                        $"Your password is {hunter2}!");
                    if (userPassword.Length < 8)
                    {
                        int passMinSum = (8 - userPassword.Length);
                        Console.WriteLine("Your password is {0} character{1} less than the minimum" +
                            " recommended length!", passMinSum, passMinSum == 1 ? "" : "s");
                    }//end nonsense if
                }//end else (login success)
            }//end else (password)
        }//end main
    }//end class
}//end namespace
