using BankControl.Domain.ValueObjects;

namespace BankControl.Domain.Entities
{
    public class User : Entity
    {
        public User(Name name, Email email, Password password)
        {
            Name = name;
            Email = email;
            Password = password;

            AddNotifications(name, email, password);

        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get ; private set; }

    }
}
