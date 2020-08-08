using BankControl.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Commands
{
    public class CreateStatusExtractCommand : ICommand
    {
        public CreateStatusExtractCommand() { }
        public CreateStatusExtractCommand(int code, string severity)
        {
            Code = code;
            Severity = severity;
        }

        public int Code { get;  set; }
        public string Severity { get;  set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
