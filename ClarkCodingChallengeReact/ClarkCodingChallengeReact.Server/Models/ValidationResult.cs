namespace ClarkCodingChallengeReact.Server.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; private set; } = true;
        public List<string> Messages { get; set; } = [];

        public void AddValidationError(string message)
        {
            IsValid = false;
            Messages.Add(message);
        }
    }
}
