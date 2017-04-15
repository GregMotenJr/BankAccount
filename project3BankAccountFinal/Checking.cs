using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    class Checking : Account
    {

        ///fields
        private decimal checkingBalence=100000.00m;


        ///Properties
        public decimal CheckingBalence
        {
            get { return this.checkingBalence; }
            set { checkingBalence = value; }
        }


        ///Constructors 1
        public Checking()
        {

        }


        ///Methods
        public override void ViewAccountBalance()
        {
            Console.WriteLine("Current checking balence is: {0:c}", checkingAccountBalance);

        }

        public override void WithdrawFunds(decimal withdraw)
        {
            if (checkingBalence >= withdraw)
            {
                checkingBalence -= withdraw;
            }

            else
            {
                Console.WriteLine("You can't withdraw money that you don't have!");
            }
        }



    }
}
