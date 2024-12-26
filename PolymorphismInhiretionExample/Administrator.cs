namespace PolymorphismInhiretionExample
{
    public class Administrator : User
    {
        public Administrator(int id, string login, string password)
            : base(id, login, password)
        {
        }
        public override void ChangePassword(string newPassword, out string error)
        {
            password = newPassword;
            error = string.Empty;
        }

        public override string GetPersonalData() => $"Login - {Login} Name - {FirstName}";

        public void FixIssue()
        {
            // Some fixing
        }
    }
}
