using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    class Client : Account
    {

        ///fields 
        // add all client info
        private string clientName = "James Bond";
        private string clientPhoneNumber = "007-007-1007";
        private string clientEmail = "007@MI6.uk";
        private string clientAgentIdNumber = "007";
        private string checkingAccNum = "Account Number - Checking = 0000007";
        private string savingsAccNum = "Account Number - Savings = 100007";



        ///Properties 
        public string ClientName
        {
            get { return this.clientName; }
        }

        public string ClientPhoneNumber
        {
            get { return this.clientPhoneNumber; }
        }

        public string ClientAgentIdNumber
        {
            get { return this.clientAgentIdNumber; }
        }

        public string ClientEmail
        {
            get { return this.clientEmail; }
        }

        ///Constructors 
        public Client()
        {

        }



        ///Methods 
        //this method will never be called but cannont be commented out
        public override void ViewAccountBalance()
        {
            //***Nothing to see here.... move along citizen***
        }

        public void ViewClientInformation()
        {
            Console.WriteLine("Personal Information:");
            Console.WriteLine(clientAgentIdNumber);
            Console.WriteLine(clientName);
            Console.WriteLine(clientEmail);
            Console.WriteLine(ClientPhoneNumber);
            Console.WriteLine(checkingAccNum);
            Console.WriteLine(savingsAccNum);
        }

    }
}
