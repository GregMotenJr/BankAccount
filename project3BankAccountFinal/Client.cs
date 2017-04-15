using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3BankAccountFinal
{
    class Client : Account
    {

        ///fields 3
        // add all client info
        private string clientName = "James Bond";
        private string clientPhoneNumber = "007-007-1007";
        private string clientEmail = "007@MI6.uk";
        private string clientAgentIdNumber = "007";



        ///Properties 3
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

        ///Constructors 1
        public Client()
        {
            
        }



        ///Methods 1
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
        }

    }
}
