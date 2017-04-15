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
        public virtual void DepositFunds()
        {

        }
        //Withdraw Funds
        public virtual void WithdrawFunds()
        {

        }


    }
}
