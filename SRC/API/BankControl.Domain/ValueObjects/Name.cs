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
                "Fisrt Name is Not Empty")
                .IsNullOrEmpty(LastName, "Name.LastName",
                "Last Name is Not Empty")
                .HasMinLen(FirstName, 5, "Name.FirstName", "The First Name must be at least 5 characters")
                .HasMinLen(LastName, 3, "Name.LastName", "The Last Name must be at least 3 characters")
                .HasMaxLen(FirstName,40,"Name.FirstName", "The First Name can only be up to 40 characters")
                .HasMaxLen(LastName, 40, "Name.LastName", "The Last Name can only be up to 40 characters")
                );
            
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
