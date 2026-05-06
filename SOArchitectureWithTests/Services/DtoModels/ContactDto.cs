using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Services.DtoModels
{
    public class ContactDto : ContactEntityDto
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public AccountDto? Account { get; set; }

    }
}
