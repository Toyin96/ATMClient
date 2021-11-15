using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Atm.interfaces;

namespace Atm
{
    public class AtmClient: Bank, IBankable, IDepositable, IAccountOpenable
    {
        private Dictionary<string, string> _CustomersStanDetails = new Dictionary<string, string>();
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

        private bool _AccountChecker(string pan)
        {
            foreach (var account in Accounts)
            {
                if (account.Key == pan)
                {
                    return true;
                }
            }
            return false;
        }

        public string WithdrawCash(string Pan, string cardPin, decimal amount)
        {
            foreach (var account in Accounts)
            {
                if (account.Key == Pan && account.Value > amount)
                {
                    var balance = account.Value - amount;
                    var stan = _GenerateCode();
                    _CustomersStanDetails.Add(stan, $"user initiated a withdrawal of {amount}");
                    
                    return $"{amount} has been successfully withdrawn from account\nYour balance is ${balance}";
                }
                else
                {
                    return "Amount to be withdrawn is lesser than bank balance";
                }
            }

            return "Pan does not match any account in our database";
        }

        public string ChangePin(string Pan, string cardPin)
        {
            foreach (var account in Accounts)
            {
                if (Pan == account.Key)
                {
                    
                }
            }
        }

        public string CheckBalance(string Pan, string cardPin)
        {
            if (_AccountChecker(Pan))
            {
                var balance = Accounts[Pan];
                var stan = _GenerateCode();
                _CustomersStanDetails.Add(stan, $"user changed cardpin to {cardPin}");
                
                return $"Your balance is {balance}";
            }

            return "No account found";
        }

        public string DepositCash(string pan, string cardPin, decimal amount)
        {
            if (_AccountChecker(pan))
            {
                Accounts[pan] += amount;
                var stan = _GenerateCode();
                _CustomersStanDetails.Add(stan, $"user initiated a deposit of {amount}");
                return $"{amount} has been deposited successfully to your account\nNew balance is {Accounts[pan]}";
            }

            return "No account found";
        }

        public string TransferFund(string Pan, string cardPin, string recipientAccount, decimal amount)
        {
            if (_AccountChecker(recipientAccount))
            {
                Accounts[recipientAccount] += amount;
                var stan = _GenerateCode();
                _CustomersStanDetails.Add(stan, $"user initiated a transfer of {amount}");
                return $"Deposit of ${amount} has been sent to {recipientAccount}.\nNew balance is {Accounts[recipientAccount]}";
            }

            return $"Thia account: {recipientAccount} does not exist in our database";
        }

        public string OpenAccount(string accountName, decimal deposit)
        {
            Accounts.Add(accountName, deposit);
            var stan = _GenerateCode();
            _CustomersStanDetails.Add(stan, $"user opened an account with name: {accountName}");
            return $"Success! your account has been created. You can now bank with us henceforth";
        }
    }
}