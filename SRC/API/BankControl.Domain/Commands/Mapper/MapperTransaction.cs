using BankControl.Domain.Commands.Mapper.Contracts;
using BankControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Commands.Mapper
{
    public class MapperTransaction : IMapperTransaction
    {
        public List<Transaction> ListTransactionsMapper(List<CreateTransactionCommand> transactionsCommand)
        {
            var transactions = new List<Transaction>();
            foreach (var item in transactionsCommand)
            {
                transactions.Add(new Transaction(item.Type, item.DatePosted, item.TransactionMont, item.Memo));
            }

            return transactions;
        }
    }

   
}
