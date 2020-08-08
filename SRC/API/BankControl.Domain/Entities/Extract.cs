using BankControl.Domain.Validations;
using System;
using System.Collections.Generic;


namespace BankControl.Domain.Entities
{
    public class Extract : Entity
    {
        public Extract(User user, Guid userId, IdentifyAccount identifyAccount, Guid identifyAccountId, string currency, string message, StatusExtract statusExtract, Guid statusExtractId, int messageId, string language, List<Transaction> transactions, float mountBalance, DateTime dateBalance)
        {
            User = user;
            UserId = userId;
            IdentifyAccount = identifyAccount;
            IdentifyAccountId = identifyAccountId;
            Currency = currency;
            Message = message;
            StatusExtract = statusExtract;
            StatusExtractId = statusExtractId;
            MessageId = messageId;
            Language = language;
            Transactions = transactions;
            MountBalance = mountBalance;
            DateBalance = dateBalance;

            Validation(this);

        }

        public Extract(Guid userId, IdentifyAccount identifyAccount, string currency, string message, StatusExtract statusExtract, int messageId, string language, List<Transaction> transactions, float mountBalance, DateTime dateBalance)
        {
            UserId = userId;
            IdentifyAccount = identifyAccount;
            Currency = currency;
            Message = message;
            StatusExtract = statusExtract;
            MessageId = messageId;
            Language = language;
            Transactions = transactions;
            MountBalance = mountBalance;
            DateBalance = dateBalance;

            Validation(this);
        }

        public User User { get; private set; }
        public Guid UserId { get; private set; }
        public IdentifyAccount IdentifyAccount { get; private set; }
        public Guid IdentifyAccountId { get; private set; }
        public string Currency { get; private set; }
        public string Message { get; private set; }
        public StatusExtract StatusExtract { get; private set; }
        public Guid StatusExtractId { get; private set; }
        public int MessageId { get; private set; }
        public string Language { get; private set; }
        public List<Transaction> Transactions { get; private set; }
        public float MountBalance { get; private set; }
        public DateTime DateBalance { get; private set; }


        void  Validation (Extract extract)
        {
            DateTime DateTimeValidFrom = new DateTime(1900, 01, 01);
            DateTime DateTimeValidto = new DateTime(2100, 01, 01);
            AddNotifications(new Contract()                
                .IsBetween(extract.DateBalance,DateTimeValidFrom,DateTimeValidto,"DateBalance","Date is Invalid")
                .IsNullOrEmpty(extract.Currency,"Extract.Currency","is Currency Is Empty")
                .IsListNotNullOrEmpty(extract.Transactions,"Transactions", "Transactions Is Empty")
                );

        }

    }
}
