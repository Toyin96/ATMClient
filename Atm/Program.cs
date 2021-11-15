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
            
            AtmClient toyinAtm = new AtmClient();
            toyinAtm.CreateNewAccount(pan, amount);
            toyinAtm.InitiateAtmProcesses(pan, cardPin, amount);
        }
    }
}