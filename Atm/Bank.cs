using System.Collections.Generic;

namespace Atm
{
    public abstract class Bank
    {
        private Dictionary<string, decimal> Accounts = new Dictionary<string, decimal>();
    }
}