namespace Atm.interfaces
{
    public interface IAccountOpenable
    {
        public string OpenAccount(string accountName, decimal deposit);
    }
}