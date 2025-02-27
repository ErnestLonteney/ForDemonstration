using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Serialization
{

    class User(string login, string password) : IEqualityComparer<User>
    {
       [JsonPropertyName("login")]
        public string Login { get; } = login;

       [JsonIgnore]
        public string SecretQuestion { get; init; } = string.Empty;

        protected readonly string password = password;

        public bool Equals(User? expexcted, User? current) =>
            expexcted?.Login == current?.Login && expexcted?.password == current?.password;

        public int GetHashCode([DisallowNull] User obj) => obj.Login.GetHashCode() ^ obj.password.GetHashCode();

        [JsonConstructor]
        private User(string login)
            : this(login, string.Empty)
        {
        }
    }
}
