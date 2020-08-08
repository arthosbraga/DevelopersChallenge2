using BankControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Commands.Mapper.Contracts
{
    public interface IMapperTransaction
    {
         List<Transaction> ListTransactionsMapper(List<CreateTransactionCommand> transactionsCommand)
    }
}
