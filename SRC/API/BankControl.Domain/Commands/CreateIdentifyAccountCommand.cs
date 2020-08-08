using BankControl.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Commands
{
    public class CreateIdentifyAccountCommand : ICommand
    {
        public CreateIdentifyAccountCommand() { }
        public CreateIdentifyAccountCommand(int idBank, int accountNumber, string accountType)
        {
            IdBank = idBank;
            AccountNumber = accountNumber;
            AccountType = accountType;
        }

        public int IdBank { get;  set; }
        public int AccountNumber { get;  set; }
        public string AccountType { get;  set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
