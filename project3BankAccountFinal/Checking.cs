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
        private decimal checkingBalence;


        ///Properties
        public decimal CheckingBalence
        {
            get { return this.checkingBalence; }
        }


        ///Constructors 1
        public Checking()
        {

        }


        ///Methods
        public override void ViewAccountBalance()
        {

        }




    }
}
