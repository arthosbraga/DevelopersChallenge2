namespace BankControl.Domain.Entities
{
    public class StatusExtract : Entity
    {
        public StatusExtract(int code, string severity)
        {
            Code = code;
            Severity = severity;
        }

        public int Code { get; private set; }
        public string Severity { get; private set; }

    }
}
