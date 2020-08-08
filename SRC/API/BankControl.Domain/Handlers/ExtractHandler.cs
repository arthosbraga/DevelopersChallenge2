using BankControl.Domain.Commands;
using BankControl.Domain.Commands.Contracts;
using BankControl.Domain.Entities;
using BankControl.Domain.Handlers.Contracts;
using BankControl.Domain.Notifications;
using BankControl.Domain.Repositories;
using BankControl.Domain.Commands.Mapper;
using System;
using System.Collections.Generic;
using BankControl.Domain.Commands.Mapper.Contracts;

namespace BankControl.Domain.Handlers
{
    public class ExtractHandler : Notifiable,
        IHandler<CreateExtractCommand>
    {

        private readonly IExtractRepository _extractRepository;
        private readonly IMapperTransaction _IMapperTransaction;

        public ExtractHandler(IExtractRepository extractRepository, IMapperTransaction mapperTransaction)
        {
            _extractRepository = extractRepository;
            _IMapperTransaction = mapperTransaction;
        }
        public ICommandResult Handle(CreateExtractCommand command)
        {
            // Fail fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,"Ops, Is Extract not valid.",command.Notifications);

            var extract = new Extract(
                command.Userid,
                new IdentifyAccount(
                    command.IdentifyAccount.IdBank,
                    command.IdentifyAccount.AccountNumber,
                    command.IdentifyAccount.AccountType),
                command.Currency,
                command.Message,
                new StatusExtract(
                    command.StatusExtract.Code,
                    command.StatusExtract.Severity),
                command.MessageId,
                command.Language,
                _IMapperTransaction.ListTransactionsMapper(command.Transactions),
                command.MountBalance,
                command.DateBalance
                );

            _extractRepository.Create(extract);
            return new GenericCommandResult(true, "Success", extract);
        }
        
    }
}
