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
            Console.WriteLine("Establishing connection");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nValidating credentials");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("  ___   ___ ______ ");
            Console.WriteLine(" / _ \\ / _ \\____  |");
            Console.WriteLine("| | | | | | |  / / ");
            Console.WriteLine("| | | | | | | / /  ");
            Console.WriteLine("| |_| | |_| |/ /   ");
            Console.WriteLine(" \\___/ \\___//_/    \n\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\n\nAccess granted");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nSecure connection established");
            System.Threading.Thread.Sleep(1500);

            Program.TypeLine("\n\nWelcome to the remote requsitions system 007");
            Program.TypeLine("access to funds is online");
            Program.TypeLine("all other functions remain offline at this time including weapon requests until contact with the target is established");
            Program.TypeLine("please try not to break this device 007");
            Program.TypeLine("Godspeed James -- Q\n\n\n");
            System.Threading.Thread.Sleep(2000);
            //instantiate accounts
            Client bond = new Client();
            Savings savings1 = new Savings();
            Checking checking1 = new Checking();

            ///Menu System

            int selectedOption;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. View Agent Information");
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
                        { //having trouble with min balance and making it work correctly, see method in savings

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
            Console.ReadKey();


        }
        
        // using this to make text appear like its being typed out in real time in certain places
        static void TypeLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(100); // Sleep for 150 milliseconds
            }
            Console.WriteLine();
        }
    }
}
