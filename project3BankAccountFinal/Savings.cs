﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    class Savings : Account
    {

        ///fields
        private decimal minBalance = 100000000.00m;
        private decimal savingsBalance = 100000000.00m;



        ///Properties 1
        public decimal MinBalance
        {
            get { return this.minBalance; }
        }

        public decimal SavingsBalance
        {
            get { return this.savingsBalance; }
            set { savingsBalance = value; }
        }


        ///Constructors 1
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

        public override void WithdrawFunds(decimal withdraw)
        {
            if (savingsBalance >= withdraw)
            {
                if (savingsBalance >= minBalance)
                {
                    savingsBalance -= withdraw;
                }

                else
                {
                    Console.WriteLine("Terriably sorry sir, but that transaction would cause your account to fall below minimum balance of {0:c} from your savings, Sorry about that Sir", minBalance);
                }
            }

            else
            {
                Console.WriteLine("Sorry 007 but you dont have enough money in your account");
            }
        }

    }
}
