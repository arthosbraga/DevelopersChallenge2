using System;

namespace BankControl.Domain.Entities
{
    public class Transaction :Entity
    {
        public Transaction(Guid extractId, string type, DateTime datePosted, float transactionMont, string memo)
        {
            ExtractId = extractId;
            Type = type;
            DatePosted = datePosted;
            TransactionMont = transactionMont;
            Memo = memo;
        }

        public Guid ExtractId { get; private set; }
        public string Type { get; private set; }
        public DateTime DatePosted { get; private set; }
        public float TransactionMont { get; private set; }
        public string Memo { get; private set; }
    }
}
