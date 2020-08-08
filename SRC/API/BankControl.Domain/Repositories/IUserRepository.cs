using BankControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankControl.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        User Read(Guid id);
        void Update(User user);
        void Delete(Guid id);
    }
}
