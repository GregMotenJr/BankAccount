using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Bank Account Project by Greg Moten Jr

            ///Greeting
            Console.WriteLine("Establishing secure connection");
            Console.WriteLine("Validating credentials");
            Console.WriteLine("Access granted");
            Console.WriteLine("Secure connection established");
            Console.WriteLine("Welcome 007");
            Console.WriteLine("Access to your funds is online");
            Console.WriteLine("All other functions remain offline at this time including weapon requests");
            Console.WriteLine("Godspeed James -- Q\n\n\n");

            //instantiate accounts
            Client bond = new Client();
            Savings savings1 = new Savings();
            Checking checking1 = new Checking();

            ///Menu System

            int selectedOption;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");


                selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    case 1://view
                        bond.ViewClientInformation();
                        break;

                    case 2://view balance
                        Console.WriteLine("Checking account balance is: {0:c}", checking1.CheckingBalence);
                        Console.WriteLine("Savings account balance is: {0:c}", savings1.SavingsBalance);
                        break;

                    case 3://deposit funds
                        Console.WriteLine("Which account would you like to deposit to Sir?");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Savings Account");
                        selectedOption = int.Parse(Console.ReadLine());
                        Console.WriteLine("And how Much would you like to Deposit Sir?");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());

                        if (selectedOption == 1)
                        {
                            Console.WriteLine("{0:c} into checking, understood Sir", deposit);
                            checking1.CheckingBalence += deposit;
                            Console.WriteLine("New balance: {0:c} ", checking1.CheckingBalence);
                        }

                        else
                        {
                            Console.WriteLine("{0:c} into saving, understood Sir", deposit);
                            savings1.SavingsBalance += deposit;
                            Console.WriteLine("New balance: {0:c} ", savings1.SavingsBalance);
                        }

                        break;

                    case 4://withdraw funds
                        Console.WriteLine("Which account would you like to withdraw from to Sir?");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Savings Account");
                        selectedOption = int.Parse(Console.ReadLine());
                        Console.WriteLine("And how much will you be needing Sir?");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());

                        if (selectedOption == 1)
                        {
                            Console.WriteLine("{0:c} from checking, understood Sir", withdraw);
                            checking1.CheckingBalence -= withdraw;
                            Console.WriteLine("New balance: {0:c} ", checking1.CheckingBalence);
                        }

                        else
                        { //having trouble with min balance logic, commented out orginal solution and trying to work the method

                            savings1.WithdrawFunds(withdraw);

                        }

                        break;

                    case 5://Exit
                        Console.WriteLine("Affirmative sir, good luck out there 007");
                        break;

                    default://Wrong key press
                        Console.WriteLine(" Invalid selection");
                        break;
                }

            } while (selectedOption != 5);


        }
    }
}
