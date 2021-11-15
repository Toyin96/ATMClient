using System.Collections.Generic;

namespace Atm
{
    public abstract class Bank
    {
        internal Dictionary<string, decimal> Accounts = new Dictionary<string, decimal>();
    }
}