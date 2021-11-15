namespace Atm.interfaces
{
    public interface IDepositable
    {
        public string DepositCash(string Pan, string cardPin, decimal amount);
        public string TransferFund(string Pan, string cardPin, string recipientAccount, decimal amount);
    }
}