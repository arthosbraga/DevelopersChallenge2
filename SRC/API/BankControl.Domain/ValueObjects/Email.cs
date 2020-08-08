

using BankControl.Domain.Validations;

namespace BankControl.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string addressEmail)
        {
            AddressEmail = addressEmail;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(AddressEmail, "Email.Addres", "Invalid E-Mail"));
        }

        public string AddressEmail { get; private set; }
    }
}
