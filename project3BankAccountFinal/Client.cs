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
        private string clientPhoneNumber = "007-007-0007";
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

        ///Constructors 1
        public Client()
        {
            
        }



        ///Methods 1
        public override void ViewAccountBalance()
        {
            
        }

        public void ViewClientInformation()
        {
            Console.WriteLine(clientName);
            Console.WriteLine(clientAgentIdNumber);
            Console.WriteLine(clientEmail);
            Console.WriteLine(ClientPhoneNumber);
        }

    }
}
