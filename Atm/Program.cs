using System;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cardPin = "1234";
            var pan = "0976326589052378";
            var amount = 20234m;
            var recipientAcct = "0286195294793853";
            var moneyToBeSent = 12678m;
            
            AtmClient toyinAtm = new AtmClient();
            toyinAtm.CreateNewAccount(pan, amount);
            toyinAtm.CreateNewAccount(recipientAcct, 1000m);
            toyinAtm.InitiateAtmProcesses(pan, cardPin, amount);
            toyinAtm.TransferDelegate(pan, cardPin, recipientAcct, moneyToBeSent);
            toyinAtm.OtherAtmProcesses(pan, cardPin);
            
        }
    }
}