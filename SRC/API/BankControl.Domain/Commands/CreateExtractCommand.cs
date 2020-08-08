using BankControl.Domain.Commands.Contracts;
using BankControl.Domain.Notifications;
using BankControl.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Commands
{
    public class CreateExtractCommand : Notifiable, ICommand
    {
        public Guid Userid { get; set; }
        public CreateIdentifyAccountCommand IdentifyAccount { get;  set; }        
        public string Currency { get;  set; }
        public string Message { get;  set; }
        public int MessageId { get; set; }
        public CreateStatusExtractCommand StatusExtract { get;  set; }  
        public string Language { get;  set; }
        public List<CreateTransactionCommand> Transactions { get;  set; }
        public float MountBalance { get;  set; }
        public DateTime DateBalance { get;  set; }

        public void Validate()
        {
            DateTime DateTimeValidFrom = new DateTime(1900, 01, 01);
            DateTime DateTimeValidto = new DateTime(2100, 01, 01);
            AddNotifications(
                new Contract().Requires()
                .IsNotNull(this,"Extract","Extract Is Empty")
                .IsNotNullOrWhiteSpace(Currency,"Currency", "Is Currency Empty")
                .IsNotNullOrWhiteSpace(Language, "Language", "Is Language Empty")
                .IsBetween(DateBalance, DateTimeValidFrom, DateTimeValidto, "DateBalance", "Date is Invalid")
                );
        }
    }
}
