namespace BankControl.Domain.ValueObjects
{
    public class Password : ValueObject
    {
        public Password(string validPassword)
        {
            ValidPassword = validPassword;

            if (string.IsNullOrEmpty(ValidPassword))
            {
                AddNotification("Password", "Invalid Password");
            }

            if(validPassword.Length < 6)
            {
                AddNotification("Password", "Length Is Invalid");
            }
        }

        public string ValidPassword { get; set; }
    }
}
