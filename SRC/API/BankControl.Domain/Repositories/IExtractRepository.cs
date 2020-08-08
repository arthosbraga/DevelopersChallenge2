using BankControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Repositories
{
    public interface IExtractRepository
    {
        void Create(Extract extract);
        Extract Read(Guid id);
        void Update(Extract extract);
        void Delete(Guid id);
    }
}
