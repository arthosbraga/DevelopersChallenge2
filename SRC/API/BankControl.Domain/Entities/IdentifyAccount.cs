namespace BankControl.Domain.Entities
{
    public class IdentifyAccount :Entity
    {
        public IdentifyAccount(int idBank, int accountNumber, string accountType)
        {
            IdBank = idBank;
            AccountNumber = accountNumber;
            AccountType = accountType;
        }

        public int IdBank { get; private set; }
        public int AccountNumber { get; private set; }
        public string AccountType { get; private set; }
    }
}
