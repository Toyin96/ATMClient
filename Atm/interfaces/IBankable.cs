namespace Atm.interfaces
{
    public interface IBankable
    {
        public string WithdrawCash(string Pan, string cardPin, decimal amount);
        public string ChangePin(string Pan, string cardPin);
        public string CheckBalance(string Pan, string cardPin);
        
        
    }
}