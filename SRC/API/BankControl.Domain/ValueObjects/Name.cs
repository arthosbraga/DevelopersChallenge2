using BankControl.Domain.Validations;

namespace BankControl.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract().Requires().IsNullOrEmpty(FirstName,"Name.FirstName",
                "Fisrt Name is Not Empty"));
            AddNotifications(new Contract().Requires().IsNullOrEmpty(LastName,"Name.LastName",
                "Last Name is Not Empty"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
