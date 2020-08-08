using BankControl.Domain.Commands.Contracts;
using BankControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace BankControl.Domain.Commands
{
    public class CreateTransactionCommand : ICommand
    {
        public CreateTransactionCommand() { }
        public CreateTransactionCommand(Guid extractId, string type, DateTime datePosted, float transactionMont, string memo)
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

        public void Validate()
        {
            throw new NotImplementedException();
        }
       
    }
}
