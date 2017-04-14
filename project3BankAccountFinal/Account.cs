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
        //An account number
        //Checking account balance
        //Savings account balance
        //Account type (savings or checking)





        ///Properties



        ///Constructors



        ///Methods

        //View Client Information
        public void ViewClientInformation()
        {

        }

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
