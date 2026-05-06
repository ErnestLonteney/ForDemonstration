using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DtoModels
{
    public class ContactEntityDto
    {
        public Guid Id { get; set; }

        public string FullName { get; set; } = string.Empty;
    }
}
