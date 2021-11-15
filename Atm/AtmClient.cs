using System;
using System.Collections.Generic;
using System.Text;
using Atm.interfaces;

namespace Atm
{
    public class AtmClient: Bank, IBankable, IDepositable
    {
        private Dictionary<string, string> _CustomersStanNumbers = new Dictionary<string, string>();
        private readonly Random _random = new Random();

        private string _GenerateCode()
        {
            StringBuilder bankCode = new StringBuilder(8);
            bankCode.Append("TOY");

            for (int i = 0; i < 5; i++)
            {
                bankCode.Append(Convert.ToString(_random.Next(0, 9)));
            }

            return bankCode.ToString();
        }

        public string WithdrawCash(string Pan, string cardPin)
        {
            throw new NotImplementedException();
        }

        public string ChangePin(string Pan, string cardPin)
        {
            throw new NotImplementedException();
        }

        public string CheckBalance(string Pan, string cardPin)
        {
            throw new NotImplementedException();
        }

        public string DepositCash(string Pan, string cardPin, decimal amount)
        {
            throw new NotImplementedException();
        }

        public string TransferFund(string Pan, string cardPin, string recipientAccount, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}