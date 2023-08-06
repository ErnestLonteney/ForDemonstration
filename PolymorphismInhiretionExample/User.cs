using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInhiretionExample
{
    public class User : Emploee
    {
        public string Login { get; private set; }

        protected string password;

        public User(int id, string login, string password)
            : base(id)
        {
            Login = login;
            this.password = password;
        }

        public virtual void ChangePassword(string newPassword, out string error)
        {
            error = string.Empty;

            if (ValidatePassword(newPassword))
            {
                password = newPassword;
            }
            else
                error = "Password has not been validated";

        }

        public override string GetPersonalData()
        {
            return base.GetPersonalData() + '\n' + $"Password- {password}";
        }

        private static bool ValidatePassword(string newPawssord) =>
            newPawssord.Length > 6 && newPawssord.Any(char.IsDigit);
    }
}
