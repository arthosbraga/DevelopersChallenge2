using BankControl.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Handlers.Contracts
{
    interface IHandler<T> where T: ICommand
    {
        ICommandResult Handle(T command);
    }
}
