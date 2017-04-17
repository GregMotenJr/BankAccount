using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    class Savings : Account
    {

        ///fields
        private decimal minBalance = 5000000.00m;
        private decimal savingsBalance = 100000000.00m;
        private int accountNumberSavings = 100007;



        ///Properties 

        public decimal MinBalance
        {
            get { return this.minBalance; }
        }

        public decimal SavingsBalance
        {
            get { return this.savingsBalance; }
            set { savingsBalance = value; }
        }


        ///Constructors 
        public Savings()
        {

        }


        ///Methods
        public override void ViewAccountBalance()
        {
            Console.WriteLine("Current savings balence is: {0:c}", savingsAccountBalance);

        }

        public override void DepositFunds(decimal deposit)
        {
            savingsBalance += deposit;
        }

        /* Re-written several times and tried diffrent ways, still not 100% and I cant figure out why not
         cant find help online, im sure its something very simple I dont see right now because in my head this makes sense
         logicly unless nesting an IF doesnt work the way I think it does which is like(IF <this> is true AND IF <this 
         other thing> is true, then RESULT... that is why I have things written in its current state. Want to get project in 
         on time so I'm going to submit*/

        public override void WithdrawFunds(decimal withdraw)
        {
            if (savingsBalance >= withdraw)
            {
                if ((savingsBalance - withdraw) > minBalance)
                {
                    savingsBalance -= withdraw;
                }

                else
                {
                    Console.WriteLine("Terriably sorry sir, but that transaction would cause your account to fall below the minimum balance of {0:c} for your savings, Sorry about that Sir", minBalance);
                }
            }

            else
            {
                Console.WriteLine("Sorry 007 but you dont have enough money in your account");
            }
        }

    }
}
