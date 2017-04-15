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
        private decimal minBalence =5.00m;
        private decimal savingsBalence;



        ///Properties 1
        public decimal minBalence
        {
            get { return this.minBalence; }
        }

        public decimal SavingsBalence
        {
            get { return this.savingsBalence; }
        }


        ///Constructors 1
        public Savings()
        {

        }


        ///Methods
        public override void ViewAccountBalance()
        {
            ////Thread.CurrentThread.CurrentCulture = new CultureInfo;
            ////Console.WriteLine(minBalence.ToString("{0:c}",5.00));
        }



    }
}
