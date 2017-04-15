using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    abstract class Account
    {

        ///fields
        protected int accountNumber;
        protected decimal checkingAccountBalance;
        protected decimal savingsAccountBalance;
        protected string accountType;
        protected decimal deposit;
        protected decimal withdraw;
        


        ///Properties
        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }

        public decimal CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
        }

        public decimal SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
        }


        ///Constructors
        public Account()
        {

        }


        ///Methods
        

        //View Account Balance
        public abstract void ViewAccountBalance();
        

        //Deposit Funds
        public virtual void DepositFunds(decimal deposit)
        {
            Console.WriteLine("Transaction recorded, somone will be by to collect the dead drop 007");
        }
        //Withdraw Funds
        public virtual void WithdrawFunds(decimal withdraw)
        {
            Console.WriteLine("Transaction recorded, I hope this isnt about that woman in the red dress from last night 007");
        }


    }
}
