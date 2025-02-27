using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class User2
    {
        public string Login { get; set; } = string.Empty;

        protected readonly string password;

        public User2(string login, string password)
        {
            Login = login;
            this.password = password;
        }

        public User2()
        {
                       
        }
    }
}
