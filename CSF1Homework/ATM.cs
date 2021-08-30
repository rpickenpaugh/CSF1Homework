using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {

            Console.Title = "ATM";

            //Declaring and initalizing variables
            int accNum = 1212;
            int accPin = 3434;
            int userAccNum, userPin;
            decimal userMoney = 0;
            string userMenu;
            //Optional int for fail counter
            int accFailCounter = 0, pinFailCounter = 0;

            do
            {
                //Enter account number
                Console.WriteLine("Enter an account number:");
                //Parse string for int
                userAccNum = Int32.Parse(Console.ReadLine());

                if (userAccNum != accNum)
                {
                    accFailCounter++;
                }//end if
            } while (userAccNum != accNum && accFailCounter != 4);

            //Login fail if
            if (accFailCounter == 4)
            {
                Console.WriteLine("\nToo many failed account number attempts, closing program.");
            }
            else
            {
                Console.WriteLine("Account number recognized!\n");
                do
                {
                    //Enter PIN
                    Console.WriteLine("Enter PIN");
                    userPin = Int32.Parse(Console.ReadLine());

                    if (userPin != accPin)
                    {
                        pinFailCounter++;
                    }//end if
                } while (userPin != accPin && pinFailCounter != 4);

                //PIN fail if
                if (pinFailCounter == 4)
                {
                    Console.WriteLine("\nToo many failed PIN attempts, closing program.");
                }//end if
                else
                {
                    Console.WriteLine("Login successful!\n");
                    bool menuRepeat = true;
                    do
                    {

                        Console.WriteLine("Please select from the following:\n" +
                            "1) Deposit\n2) Withdraw\n3) Balance\n4) Exit");
                        userMenu = Console.ReadLine().ToUpper();
                        switch (userMenu)
                        {
                            case "1":
                            case "DEPOSIT":
                            case "D":
                                //Deposit script
                                Console.WriteLine("How much would you like to deposit?\n");
                                decimal depositMoney = Decimal.Parse(Console.ReadLine());
                                userMoney = depositMoney += userMoney;
                                Console.WriteLine($"{depositMoney:c} has been deposited into account number 1212.\n" +
                                    $"\n{userMoney:c} total.\n");
                                break;//end Deposit switch
                            case "2":
                            case "WITHDRAW":
                            case "WITHDRAWAL":
                            case "W":
                                //Withdraw script
                                Console.WriteLine("How much would you like to withdraw?\n");
                                decimal withdrawMoney = decimal.Parse(Console.ReadLine());
                                userMoney = userMoney -= withdrawMoney;
                                Console.WriteLine($"{withdrawMoney:c} has been withdrawn from account number 1212.\n" +
                                    $"\n{userMoney:c} total.\n");
                                break;//end Withdraw switch
                            case "3":
                            case "BALANCE":
                            case "TOTAL":
                            case "B":
                                //Balance script
                                Console.WriteLine($"Your total balance is: {userMoney:c}\n");
                                break;
                            case "4":
                            case "EXIT":
                            case "E":
                                //Exit script
                                Console.WriteLine("Thank you for your business!");
                                menuRepeat = false;
                                break;//end Exit switch
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid Response");
                                break;
                        }//end switch
                    } while (menuRepeat);
                }//end else



            }//end else

        }//end main
    }//end class
}//end namespace
